using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beer.DataBase
{
    public class Agreement
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }

        public string Patronimic { get; set; }

        public string Status { get; set; }

        public string Date { get; set; }
    }
}
