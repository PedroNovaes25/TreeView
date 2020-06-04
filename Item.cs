using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTreeView
{
    public class Item
    {
        public string Nome { get; set; }

        public override string ToString()
        {
            return "Nome" + Nome ;
        }
    }
}
