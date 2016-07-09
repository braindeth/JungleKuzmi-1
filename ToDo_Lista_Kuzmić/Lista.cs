using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_Lista_Kuzmić
{
    public class Lista
    {
        public Lista ()
        {
        }
    

        public string Name { get; set; }
        public string Desc { get; set; }
        public DateTime Date { get; set; }
        public int State { get; set; }
        }
}
