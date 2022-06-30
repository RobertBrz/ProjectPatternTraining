using ProjectPatternTraining.Builder;
using ProjectPatternTraining.Builder.WithDirector;
using System;

namespace ProjectPatternTraining
{
    class Program
    {
        static void Main(string[] args)
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
