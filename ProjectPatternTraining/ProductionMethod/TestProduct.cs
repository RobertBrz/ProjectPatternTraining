using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternTraining.ProductionMethod
{
    class TestProduct : IProduct
    {
        public void Method()
        {
            Console.WriteLine("product1");
        }
    }
}
