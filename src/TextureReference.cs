using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potassium {
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
}
