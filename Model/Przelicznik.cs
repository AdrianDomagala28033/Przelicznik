using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPrzelicznik.Model
{
    class Przelicznik
    {
        public int Id { get; set; }
        public double Mnoznik { get; set; }


        public int JednostkiZrodloweId{ get; set; }
        public Jednostki JednostkiZrodlowe { get; set; }
        public int JednostkiDocelowejId { get; set; }
        public Jednostki JednostkiDocelowej { get; set; }
 
     
    }
}
