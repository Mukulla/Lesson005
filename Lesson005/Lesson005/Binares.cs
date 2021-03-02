using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson005
{
    [Serializable]
    class Binares
    {
        public string BinareNumbers { get; }
        public Binares()
        {
            BinareNumbers = "12 687";
        }

        public Binares( string Bi001)
        {
            BinareNumbers = Bi001;
        }
    }
}
