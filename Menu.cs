using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioTreeView
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //treeView1.Nodes.Clear();
            //treeView1.Nodes.Add("Item");
            //var node = treeView1.Nodes[0]; // é a referencia: o ponto de partida para a leitura das pastas e arquivos
            //loadDiretorios(@"C:\Users\Public\PedroNovaes\CodigosEmC#\Tree\TreeView", ref node);
            rodar();
        }


        private void rodar() 
        {
            //List<Item>  itemsBase = new List<Item>()
            //{
            //    new ItemContainerBase() { Nome = "1", Items = new List<Item>()
            //    {
            //        new ItemContainerBase() { Nome = "1.1" , Items = new List<Item>()
            //        {
            //            new Item() { Nome = "1.1.1" },
            //            new Item() { Nome = "1.1.2" },
            //            new Item() { Nome = "1.1.3" },
            //        } },
            //        new Item() { Nome = "1.2" },
            //        new Item() { Nome = "1.3" },
            //    } },
            //    new ItemContainerBase() { Nome = "2", Items = new List<Item>()
            //    {
            //        new Item() { Nome = "2.1" },
            //        new ItemContainerBase() { Nome = "2.2", Items = new List<Item>()
            //        {
            //            new Item() { Nome = "2.2.1" },
            //            new Item() { Nome = "2.2.2" },
            //            new Item() { Nome = "2.2.3" },
            //        } },
            //        new Item() { Nome = "2.3" },
            //    } },
            //    new ItemContainerBase() { Nome = "3", Items = new List<Item>()
            //    {
            //        new Item() { Nome = "3.1" },
            //        new Item() { Nome = "3.2" },
            //        new ItemContainerBase() { Nome = "3.3" , Items = new List<Item>()
            //        {
            //            new Item() { Nome = "3.3.1" },
            //            new Item() { Nome = "3.3.2" },
            //            new Item() { Nome = "3.3.3" },
            //        } },
            //    } },
            //};


            List<Item> itemBase = new List<Item>();
            itemBase.Add(new ItemContainerBase() { Nome = "Pasta1" });
            itemBase.Add(new ItemContainerBase() { Nome = "Pasta2" });

            var itemContainerBase1 = new ItemContainerBase() { Nome = "Arquivo1" };

            var itemContainerBase3 = new ItemContainerBase() { Nome = "Arquivo2" };

            itemContainerBase1.Items.Add(itemContainerBase3);

            itemContainerBase3.Items.Add(new Item() { Nome = "pasta3" });
            itemContainerBase3.Items.Add(new Item() { Nome = "pasta4" });
            itemBase.Add(itemContainerBase1);



            treeView1.Nodes.Clear();
            TreeViewItemBaseExtensao.TryAdicionarItems(treeView1, itemBase);
        }


        #region #TentativaAntiga
        private void Do()
        {
            List<Item> itemBase = new List<Item>();
            itemBase.Add(new ItemContainerBase() { Nome = "Pasta1" });
            itemBase.Add(new ItemContainerBase() { Nome = "Pasta2" });

            var itemContainerBase1 = new ItemContainerBase() { Nome = "Arquivo1" };

            var itemContainerBase3 = new ItemContainerBase() { Nome = "Arquivo2" };

            itemContainerBase1.Items.Add(itemContainerBase3);

            itemContainerBase3.Items.Add(new Item() { Nome = "pasta3" });
            itemContainerBase3.Items.Add(new Item() { Nome = "pasta4" });
            itemBase.Add(itemContainerBase1);



            treeView1.Nodes.Clear();



            #region #RecursividadeQueNãoDeuCerto
            foreach (Item item1 in itemBase)
            {
                treeView1.Nodes.Add(new TreeNode(item1.Nome));

                // Add a child treenode for each Order object in the current Customer object.
                foreach (ItemContainerBase item2 in itemContainerBase1.Items)
                {
                    treeView1.Nodes[itemBase.IndexOf(item1)].Nodes.Add(
                      new TreeNode(item1.Nome));
                    //foreach (Item item3 in itemContainerBase3.Items)
                    //{
                    //    treeView1.Nodes[itemBase.IndexOf(item1)].Nodes.Add(
                    //    new TreeNode(item1.Nome));
                    //}
                }
            }
            #endregion



            //TreeNode teste = treeView1.Nodes.Add("Estados");
            //teste.Name = "Arquivo";
            //teste.Nodes.Add("Pasta");
            //teste.Name = "teste";

            //TreeNode teste2 = treeView1.Nodes.Add("Cores");
            //teste.Name = "teste2";

            //TreeNode teste3 = treeView1.Nodes.Add("Minas gerais");
            //teste3.Name = "Minas Gerais";

            //TreeNode teste4 = treeView1.Nodes.Add("Rio de janeiro");
            //teste4.Name = "Rio de Janeiro";

            //TreeNode teste5 = treeView1.Nodes.Add("São Paulo");
            //teste5.Name = "São Paulo";

            #region #ChamandoTreeViewPegandoRepositorio
            //treeView1.Nodes.Clear();
            //treeView1.Nodes.Add("Items");
            //var node = treeView1.Nodes[0];
            //loadDiretorios(@"C:/caminhoDiretorio", ref node);
            #endregion

        }
        #endregion

        #region #UsandoTreeViewPegandoRepositório
        private void loadDiretorios(string diretorio, ref TreeNode node)
        {
           
            //string[] arquivos = Directory.GetFiles(diretorio);
            //foreach (string arquivo in arquivos)
            //{
            //    node.Nodes.Add(Path.GetFileName(arquivo));
            //}


            //string[] subDiretorios = Directory.GetDirectories(diretorio);
            //foreach (string subDiretorio in subDiretorios)
            //{
            //    TreeNode n = new TreeNode(Path.GetFileName(subDiretorio));
            //    loadDiretorios(subDiretorio, ref n);
            //    node.Nodes.Add(n);
            //}
        }
        #endregion
    }
}
