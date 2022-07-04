using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternTraining.Factory
{

    class Factory1 : IModelFactory
    {
        public IModelInterface CreateModel()
        {
            return new Model1();
        }
    }
}
