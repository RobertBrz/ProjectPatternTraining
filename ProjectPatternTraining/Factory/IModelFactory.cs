using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternTraining.Factory
{
    public interface IModelFactory
    {
        IModelInterface CreateModel();
    }
}
