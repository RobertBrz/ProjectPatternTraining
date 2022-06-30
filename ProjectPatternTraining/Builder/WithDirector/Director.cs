using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternTraining.Builder.WithDirector
{
    class Director : IDirector
    {
        IBuilder Builder { get; set; }

        public Director(IBuilder builder)
        {
            Builder = builder;
        }

        public Product BuildMinimalViableProduct(int id)
        {
            Builder.AddID(id);
            return Builder.GetProduct();
        }

        public Product BuildFullFeaturedProdut(int id, string name)
        {
            Builder.AddID(id);
            Builder.AddName(name);
            return Builder.GetProduct();
        }
    }
}
