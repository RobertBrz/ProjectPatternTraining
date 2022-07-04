using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternTraining.Factory
{
    class FactoryHandler
    {
        public void Method(IModelFactory modelFactory)
        {
            var model = modelFactory.CreateModel();
            var modelInfo = model.GetModelInfo();
        }
    }
}
