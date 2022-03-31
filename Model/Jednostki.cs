using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPrzelicznik.Model
{
    class Jednostki
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Symbol { get; set; }
        public int RodzajeJednostekId { get; set; }
        public Rodzaj RodzajeJednostek { get; set; }
    }
}
