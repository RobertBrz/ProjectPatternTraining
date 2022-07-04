using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternTraining.ProductionMethod
{
    class CreatorClass : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new TestProduct();
        }
    }
}
