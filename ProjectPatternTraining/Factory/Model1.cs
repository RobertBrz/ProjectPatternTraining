using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternTraining.Factory
{
    class Model1 : IModelInterface
    {
        public string GetModelInfo()
        {
            return "model1";
        }
    }
}
