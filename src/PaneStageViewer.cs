using LibGC;
using LibGC.Gma;
using LibGC.ModelRenderer;
using LibGC.StageLayout;
using LibGC.Tpl;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Potassium {
    public partial class PaneStageViewer : DockContent {

        struct TextureReference {
            /// <summary>The index of the texture in the TPL file.</summary>
            public int TextureIdx;
            /// <summary>Selected mipmap level in the texture, or -1 for the whole texture.</summary>
            public int TextureLevel;

            public TextureReference(int textureIdx, int textureLevel) {
                this.TextureIdx = textureIdx;
                this.TextureLevel = textureLevel;
            }
        };

        /// <summary> Reference to the MainWindow. </summary>
        private MainWindow mainWindow;

        /// <summary>true if a .TPL/.GMA has been loaded and the OpenGL references need to be updated.</summary>
        public bool ReloadOnNextRedraw { get; set; }
        /// <summary>Manager for the textures and display lists associated with the .GMA/.TPL files.</summary>
        OpenGlModelContext ctx = new OpenGlModelContext();

        /// <summary>
        /// A tree containing the objects defined in the currently loaded GMA file.
        /// The first level of tree children contains a node for each GCMF model in the GMA file,
        /// and the second level of tree children contains a node for each mesh in the GCMF model.
        /// </summary>
        Tree<OpenGlModelObjectInformation> modelObjects;

        /// <summary>true if the left mouse button is currently down on the model viewer.</summary>
        bool isMouseDownOnModelControl = false;
        /// <summary>Last observed coordinates of the mouse in the model viewer, to manage mouse events.</summary>
        int modelViewerLastMouseX = 0, modelViewerLastMouseY = 0;

        /// <summary>Angles in the X and Y axis for the model viewer.</summary>
        float angleX = 0.0f, angleY = 0.0f;
        /// <summary>Zoom factor for the model viewer.</summary>
        float zoomFactor = 1.0f;

        public PaneStageViewer(MainWindow win) {
            mainWindow = win;
            InitializeComponent();
            Name = TabText = Text = "Stage Viewer";
            HideOnClose = true;
            // For some reason this event can't be associated in the Visual Studio designer
            glControl.MouseWheel += glControl_MouseWheel;
        }

        public void InvalidateGL() {
            ReloadOnNextRedraw = true;
            glControl.Invalidate();
        }

        public void UnloadModel() {
            glControl.MakeCurrent();
            ctx.ClearTextures();
            ctx.ClearDisplayLists();
            modelObjects = null;
        }

        private void LoadModel() {
            // Make sure that the old model is unloaded correctly
            UnloadModel();

            // TODO ALPHA CHANNEL. Not as easy as just enabling source alpha
            // http://www.opengl.org/resources/faq/technical/transparency.htm
            // See last paragraph of 15.020

            // Load textures
            if (mainWindow.Tpl != null) {
                for (int i = 0; i < mainWindow.Tpl.Count; i++)
                    ctx.SetTexture(i, mainWindow.Tpl[i]);
            }

            // Generate OpenGL display lists
            if (mainWindow.Gma != null) {
                modelObjects = ctx.CreateDisplayList(mainWindow.Gma);
            }
        }

        private void glControl_Load(object sender, EventArgs e) {
            SetupViewport();

            GL.ShadeModel(ShadingModel.Smooth);
            GL.ClearColor(Color.Black);
            GL.ClearDepth(1.0);

            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Lequal);

            GL.Enable(EnableCap.Normalize);

            GL.Enable(EnableCap.Lighting);
            GL.Enable(EnableCap.Light0);

            GL.Enable(EnableCap.AlphaTest);

            if (toolStripButtonDrawTextures.Checked)
                GL.Enable(EnableCap.Texture2D);

            GL.Hint(HintTarget.PerspectiveCorrectionHint, HintMode.Nicest);
        }

        private void SetupViewport() {
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            Matrix4 perspectiveMatrix = Matrix4.CreatePerspectiveFieldOfView(
                MathHelper.PiOver4, (float)glControl.Width / glControl.Height, 0.001f, 10000.0f);
            GL.LoadMatrix(ref perspectiveMatrix);

            GL.Viewport(0, 0, glControl.Width, glControl.Height);
        }

        private void glControl_Paint(object sender, PaintEventArgs e) {
            // Reload the model if necessary
            if (ReloadOnNextRedraw) {
                LoadModel();
                ReloadOnNextRedraw = false;
            }

            // Set up OpenGL context
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.Translate(0.0f, 0.0f, -6.0f);
            GL.Rotate(angleY, 1.0f, 0.0f, 0.0f);
            GL.Rotate(angleX, 0.0f, 1.0f, 0.0f);
            GL.Scale(zoomFactor, zoomFactor, zoomFactor);

            // Draw the models/meshes
            foreach (TreeNode modelItem in mainWindow.paneModels.TreeModel.Nodes) {
                ModelMeshReference modelRef = (ModelMeshReference)modelItem.Tag;
                if (mainWindow.Gma[modelRef.ModelIdx] != null) {
                    if (mainWindow.paneModels.TreeModel.GetCheckState(modelItem) == CheckState.Checked) {
                        // Whole item is checked -> Call the display list corresponding to the entire model
                        ctx.CallDisplayList(modelObjects[modelRef.ModelIdx].Value);
                    }
                    else if (mainWindow.paneModels.TreeModel.GetCheckState(modelItem) == CheckState.Indeterminate) {
                        // Only some meshes of the item are checked -> Call the display list corresponding to each mesh
                        foreach (TreeNode meshItem in modelItem.Nodes) {
                            if (mainWindow.paneModels.TreeModel.GetCheckState(meshItem) == CheckState.Checked) {
                                ModelMeshReference meshRef = (ModelMeshReference)meshItem.Tag;
                                ctx.CallDisplayList(modelObjects[meshRef.ModelIdx][meshRef.MeshIdx].Value);
                            }
                        }
                    }
                }
            }

            if (mainWindow.Gma == null) DrawUnitCube(Vector3.Zero, new Vector3(0.75f, 0.75f, 0.75f), 1);

            if (mainWindow.StageLayout != null) {
                foreach (var b in mainWindow.StageLayout.Bananas) {
                    DrawUnitCube(b.Position, new Vector3(1, 1, 0), 1);
                }
                foreach (var g in mainWindow.StageLayout.Goals) {
                    switch (g.Color) {
                        case StageLayoutGoal.GoalColor.Blue:
                            DrawUnitCube(g.Position, new Vector3(0, 0, 1), 2);
                            break;
                        case StageLayoutGoal.GoalColor.Green:
                            DrawUnitCube(g.Position, new Vector3(0, 1, 0), 2);
                            break;
                        case StageLayoutGoal.GoalColor.Red:
                            DrawUnitCube(g.Position, new Vector3(1, 0, 0), 2);
                            break;
                    }
                }
            }

            glControl.SwapBuffers();
        }

        private void DrawUnitCube(Vector3 pos, Vector3 color, float scale) {
            float size = 0.5f * scale;

            GL.Disable(EnableCap.Texture2D);
            GL.FrontFace(FrontFaceDirection.Ccw);
            GL.Enable(EnableCap.ColorMaterial);

            GL.Begin(PrimitiveType.Quads);
            // top
            GL.Color3(color.X, color.Y, color.Z);
            GL.Normal3(0, 1, 0);
            GL.Vertex3(pos.X - size, pos.Y + size, pos.Z + size);
            GL.Vertex3(pos.X + size, pos.Y + size, pos.Z + size);
            GL.Vertex3(pos.X + size, pos.Y + size, pos.Z - size);
            GL.Vertex3(pos.X - size, pos.Y + size, pos.Z - size);

            GL.End();

            GL.Begin(PrimitiveType.Quads);
            // front
            GL.Color3(color.X, color.Y, color.Z);
            GL.Normal3(0, 0, 1);
            GL.Vertex3(pos.X + size, pos.Y - size, pos.Z + size);
            GL.Vertex3(pos.X + size, pos.Y + size, pos.Z + size);
            GL.Vertex3(pos.X - size, pos.Y + size, pos.Z + size);
            GL.Vertex3(pos.X - size, pos.Y - size, pos.Z + size);

            GL.End();

            GL.Begin(PrimitiveType.Quads);
            // right
            GL.Color3(color.X, color.Y, color.Z);
            GL.Normal3(1, 0, 0);
            GL.Vertex3(pos.X + size, pos.Y + size, pos.Z - size);
            GL.Vertex3(pos.X + size, pos.Y + size, pos.Z + size);
            GL.Vertex3(pos.X + size, pos.Y - size, pos.Z + size);
            GL.Vertex3(pos.X + size, pos.Y - size, pos.Z - size);

            GL.End();

            GL.Begin(PrimitiveType.Quads);
            // left
            GL.Color3(color.X, color.Y, color.Z);
            GL.Normal3(-1, 0, 0);
            GL.Vertex3(pos.X - size, pos.Y - size, pos.Z + size);
            GL.Vertex3(pos.X - size, pos.Y + size, pos.Z + size);
            GL.Vertex3(pos.X - size, pos.Y + size, pos.Z - size);
            GL.Vertex3(pos.X - size, pos.Y - size, pos.Z - size);

            GL.End();

            GL.Begin(PrimitiveType.Quads);
            // bottom
            GL.Color3(color.X, color.Y, color.Z);
            GL.Normal3(0, -1, 0);
            GL.Vertex3(pos.X + size, pos.Y - size, pos.Z + size);
            GL.Vertex3(pos.X - size, pos.Y - size, pos.Z + size);
            GL.Vertex3(pos.X - size, pos.Y - size, pos.Z - size);
            GL.Vertex3(pos.X + size, pos.Y - size, pos.Z - size);

            GL.End();

            GL.Begin(PrimitiveType.Quads);
            // back
            GL.Color3(color.X, color.Y, color.Z);
            GL.Normal3(0, 0, -1);
            GL.Vertex3(pos.X + size, pos.Y + size, pos.Z - size);
            GL.Vertex3(pos.X + size, pos.Y - size, pos.Z - size);
            GL.Vertex3(pos.X - size, pos.Y - size, pos.Z - size);
            GL.Vertex3(pos.X - size, pos.Y + size, pos.Z - size);

            GL.End();

            GL.Color3(1.0f, 1.0f, 1.0f);
            if (toolStripButtonDrawTextures.Checked) {
                GL.Enable(EnableCap.Texture2D);
            }
            GL.FrontFace(FrontFaceDirection.Cw);
            GL.Disable(EnableCap.ColorMaterial);
        }

        private void glControl_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                isMouseDownOnModelControl = true;
                modelViewerLastMouseX = e.X;
                modelViewerLastMouseY = e.Y;
            }
        }

        private void glControl_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left && isMouseDownOnModelControl == true) {
                int deltaX = e.X - modelViewerLastMouseX;
                int deltaY = e.Y - modelViewerLastMouseY;

                angleX += (float)deltaX;
                angleY += (float)deltaY;

                modelViewerLastMouseX = e.X;
                modelViewerLastMouseY = e.Y;

                glControl.Invalidate();
            }
        }

        private void glControl_MouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                isMouseDownOnModelControl = false;
                modelViewerLastMouseX = 0;
                modelViewerLastMouseY = 0;
            }
        }

        private void toolStripButtonResetView_Click(object sender, EventArgs e) {
            angleX = 0.0f;
            angleY = 0.0f;
            zoomFactor = 1.0f;
            glControl.Invalidate();
        }

        public void SetDrawTextures(bool drawTex) {
            toolStripButtonDrawTextures.Checked = drawTex;
            SetGlDrawTextures(drawTex);
        }

        private void toolStripButtonDrawTextures_Click(object sender, EventArgs e) {
            SetGlDrawTextures(toolStripButtonDrawTextures.Checked);
        }

        private void SetGlDrawTextures(bool drawTex) {
            glControl.MakeCurrent();

            if (drawTex)
                GL.Enable(EnableCap.Texture2D);
            else
                GL.Disable(EnableCap.Texture2D);

            glControl.Invalidate();
        }

        void glControl_MouseWheel(object sender, MouseEventArgs e) {
            zoomFactor *= (float)Math.Pow(1.5, e.Delta / 120.0);
            glControl.Invalidate();
        }

        private void glControl_Resize(object sender, EventArgs e) {
            SetupViewport();
        }
    }
}
