using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indinok
{
    internal class Otdel
    {
        private string _name;

        public string Name
        {
            get => _name;
            private set => _name = value;
        }

        public Otdel(string name)
        {
            _name = name;
        }
      
       

    }
}
