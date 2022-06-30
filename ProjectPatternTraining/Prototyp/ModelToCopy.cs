using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternTraining.Prototyp
{
    class ModelToCopy
    {
        int IntProp { get; set; }
        string StringProp { get; set; } // string is referencetype but its immutable so  at modifying string new one is creating 
        DateTime DateTimeProp { get; set; } //  datetime is value type 

        public ModelToCopy(int intprop, string stringprop, DateTime dateTimeprop)
        {
            IntProp = intprop;
            StringProp = stringprop;
            DateTimeProp = dateTimeprop;
        }

        public ModelToCopy DeepCopy()
        {
            //value type dont have to be copied manually , reference type have to 
            ModelToCopy clone = (ModelToCopy)this.MemberwiseClone();
            clone.StringProp = StringProp; //string.copy()
            return clone;
        }

        public ModelToCopy ShallowCopy()
        {
            ModelToCopy clone = (ModelToCopy)this.MemberwiseClone();

            return clone;
        }
    }
}
