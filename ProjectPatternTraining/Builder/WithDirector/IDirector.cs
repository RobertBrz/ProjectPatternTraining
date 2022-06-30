using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternTraining.Builder.WithDirector
{
    public interface IDirector
    {
        Product BuildMinimalViableProduct(int id);
        Product BuildFullFeaturedProdut(int id , string name );
    }
}
