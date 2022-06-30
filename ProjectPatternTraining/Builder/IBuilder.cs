using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternTraining.Builder
{
    public interface IBuilder
    {
        void AddName(string name);
        void AddID(int id );

        Product GetProduct();
    }
}
