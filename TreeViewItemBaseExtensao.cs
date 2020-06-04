using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioTreeView
{
    public static class TreeViewItemBaseExtensao
    {

        public static void TryAdicionarItem(this TreeView tree, Item item)
        {
            if (item is ItemContainerBase)
            {
                   var noPai = tree.Nodes.Add(item.Nome);
                foreach (var filhoItem in (item as ItemContainerBase).Items)
                {
                    TryAdicionarItem(noPai, filhoItem);
                }
            }
            else
            {
                tree.Nodes.Add(item.Nome);
            }
        }

        public static void TryAdicionarItem(this TreeNode node, Item item) 
        {
            if (item is ItemContainerBase)
            {
                var noPai = node.Nodes.Add(item.Nome);
                foreach (var filhoItem in (item as ItemContainerBase).Items)
                {
                    TryAdicionarItem(noPai, filhoItem);
                }
            }
            else 
            {
                node.Nodes.Add(item.Nome);
            }
        }


        public static void TryAdicionarItems(this TreeView tree, List<Item> items)
        {
            foreach (var item in items)
            {
                TryAdicionarItem(tree, item);
            }
        }

        public static void TryAdicionarItems(this TreeNode tree, List<Item> items)
        {
            foreach (var item in items) 
            {
                TryAdicionarItem(tree, item);
            }
        }
    }
}
