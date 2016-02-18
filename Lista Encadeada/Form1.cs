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

        LinkedList list = new LinkedList();

        private void addButton_Click(object sender, EventArgs e)
        {
            list.Add(int.Parse(indexBox.Value + ""), enterValue.Text);
            printBox.Text = "Lista:";

            for (int i = 0; i < list.Count; i++ ) {
                printBox.Text += "\n Index: "+ i + "    |   Element: " + list.Get(i);
            }

            indexBox.Maximum++;
            indexBox.Value = list.Count;
        }

        private void remButton_Click(object sender, EventArgs e)
        {
            if (indexBox.Value != 0)
            {
                list.Remove(int.Parse(indexBox.Value + ""));
                printBox.Text = "Lista:";

                for (int i = 0; i < list.Count; i++)
                {
                    printBox.Text += "\n Index: " + i + "    |   Element: " + list.Get(i);
                }

                indexBox.Maximum--;
                indexBox.Value = list.Count;
            }
        }
    }
}
