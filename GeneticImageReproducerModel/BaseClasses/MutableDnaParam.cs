using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticImageReproducerModel.BaseClasses
{
    public class MutableDnaParam
    {
        public String Name = "";
        public virtual void Mutate()
        {

        }
        public virtual void Mutate(double probability)
        {

        }


        //todo: should add some constraints via params 
        public virtual void SetRandomParams(Random rand)
        {

        }
    }
}
