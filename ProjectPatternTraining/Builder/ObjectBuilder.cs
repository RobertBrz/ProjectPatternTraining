using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternTraining.Builder
{
    class ObjectBuilder : IBuilder
    {

        Product Product { get; set; } = new Product();

        public ObjectBuilder()
        {
        }

        public void AddName(string name)
        {
            Product.Name = name;
        }

        public void AddID(int id)
        {
            Product.ProductID = id;
        }

        public Product GetProduct()
        {
            return Product;
        }
    }
}
