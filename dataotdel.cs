using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indinok
{
    public class dataotdel
    {

            private Random _random = new Random();
            private int RandomInt
            {
                get => _random.Next(1, 10);
            }
            internal List<Data> Otdel { get; private set; }

            public void Initialize()
            {
            Otdel = new List<Data>
            {
                new Data(new Otdel("покраски"),RandomInt),
                new Data(new Otdel("завода "),RandomInt),
                new Data(new Otdel("еды"),RandomInt),
                new Data( new Otdel("книг"),RandomInt),
                new Data( new Otdel("корма "),RandomInt)

            };
            }

}
}





