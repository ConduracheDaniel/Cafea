
using Cafea.Enums;

namespace Cafea.Classes.Bases
{
    abstract class CoffeeBase
    {
        private CoffeeType name;
        public string Name { get { return name.ToString(); }  }
        public abstract CoffeeBase Recipe();
    }
}
