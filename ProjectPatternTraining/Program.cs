using ProjectPatternTraining.Builder;
using ProjectPatternTraining.Builder.WithDirector;
using ProjectPatternTraining.Prototyp;
using System;

namespace ProjectPatternTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            StartBuilder();
            StartPrototype();

        }

        private static void StartPrototype()
        {
            ModelToCopy modelToCopy1 = new ModelToCopy(1,"dwa", new DateTime());
            var deppcopiedmodel = modelToCopy1.DeepCopy();
            var shallowcopiedmodel = modelToCopy1.ShallowCopy();
        }

        private static void StartBuilder()
        {
            //builder 
            ObjectBuilder objectBuilder = new ObjectBuilder();
            objectBuilder.AddID(1);
            objectBuilder.AddName("testname");
            var model = objectBuilder.GetProduct();

            //builder with director
            ObjectBuilder objectBuilder2 = new ObjectBuilder();
            Director director = new Director(objectBuilder2);
            var model2 = director.BuildFullFeaturedProdut(1, "testname");
        }
    }
}
