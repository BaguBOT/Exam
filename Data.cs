using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indinok
{
    internal class Data
    {
        private Otdel _otdel;
        private int _number;

        private Otdel Otdel
        {
            get => _otdel;
        }
        public int Number
        {
            get => _number;
        }

        public string OtdelName
        {
            get { return Otdel != null ? Otdel.Name : "Отдел"; }
        }
        public Data(Otdel Otdel, int Num)
        {
           
            _otdel = Otdel;
            _number = Num;
        }
    }
}

