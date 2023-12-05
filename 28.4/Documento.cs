using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._4
{
    internal class Documento
    {
        public string Titolo { get; set; }
        public int Anno { get; set; }
        public string Settore { get; set; }
        public string Stato { get; set; }
        public int Scaffale { get; set; }
        public List<Autore> Autori { get; set; }
    }
}
