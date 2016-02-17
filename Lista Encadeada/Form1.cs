using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Encadeada
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();  
        }

        //Recipe rcp = new Recipe();

        LinkedList list = new LinkedList();

        private void addButton_Click(object sender, EventArgs e)
        {
            //tempIng = new Ingredient();
            //rcp.AddPosition();
            list.Add(int.Parse(indexBox.Value + ""), enterValue.Text);
            printBox.Text = "Lista:";

            for (int i = 0; i < list.Count; i++ ) {
                printBox.Text += "\n Index: "+ i + "    |   Element: " + list.Get(i);
            }

            indexBox.Maximum++;
            indexBox.Value++;
        }
    }
}
