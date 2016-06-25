using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potassium {
    struct ModelMaterialReference {
        /// <summary>The index of the model that contains the material</summary>
        public int ModelIdx;
        /// <summary>The index of the material within the model</summary>
        public int MaterialIdx;

        public ModelMaterialReference(int modelIdx, int materialIdx) {
            this.ModelIdx = modelIdx;
            this.MaterialIdx = materialIdx;
        }
    };
}
