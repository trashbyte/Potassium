using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potassium {
    struct ModelMeshReference {
        /// <summary>The index of the model, or the model that the triangle mesh belongs to.</summary>
        public int ModelIdx;
        /// <summary>The index of the mesh, or (size_t)-1 if it is a whole model</summary>
        public int MeshIdx;

        public ModelMeshReference(int modelIdx, int meshIdx) {
            this.ModelIdx = modelIdx;
            this.MeshIdx = meshIdx;
        }
    };
}
