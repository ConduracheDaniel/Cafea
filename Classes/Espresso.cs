using Cafea.Classes.Bases;
using System;

namespace Cafea.Classes
{
    internal class Espresso : CoffeeBase
    {
        
        public override CoffeeBase Recipe()
        {
           
            return this;
        }
    }
}
