using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTreeView
{
    public class ItemContainerBase : Item
    {
        public List<Item> Items { get; set; } = new List<Item>();
    }
}
