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
                printBox.Text += "\n Index: "+ i + "    |   Element: " + list.Get(i).Data;
            }

            indexBox.Maximum = list.Count;
            indexBox.Value = list.Count;

            change1.Maximum = list.Count;
            change1.Value = list.Count;

            change2.Maximum = list.Count;
            change2.Value = list.Count;
        }

        private void remButton_Click(object sender, EventArgs e)
        {
            if (indexBox.Value != 0)
            {
                list.Remove(int.Parse(indexBox.Value + ""));
                printBox.Text = "Lista:";

                for (int i = 0; i < list.Count; i++)
                {
                    printBox.Text += "\n Index: " + i + "    |   Element: " + list.Get(i).Data;
                }

                indexBox.Maximum = list.Count;
                indexBox.Value = list.Count;

                change1.Maximum = list.Count;
                change1.Value = list.Count;

                change2.Maximum = list.Count;
                change2.Value = list.Count;
            }
        }

        private void addNextButton_Click(object sender, EventArgs e)
        {

            list.AddNext(enterValue.Text, findValue.Text);
            printBox.Text = "Lista:";

            for (int i = 0; i < list.Count; i++)
            {
                printBox.Text += "\n Index: " + i + "    |   Element: " + list.Get(i).Data;
            }

            indexBox.Maximum = list.Count;
            indexBox.Value = list.Count;

            change1.Maximum = list.Count;
            change1.Value = list.Count;

            change2.Maximum = list.Count;
            change2.Value = list.Count;
        }

        private void remAtButton_Click(object sender, EventArgs e)
        {
            List<int> pos = new List<int>();

            pos = list.IndexOf(findValue.Text);

            while (pos[0] != -1) {
                list.Remove(pos[0]);
                pos = list.IndexOf(findValue.Text);
            }

            printBox.Text = "Lista:";

            for (int i = 0; i < list.Count; i++)
            {
                printBox.Text += "\n Index: " + i + "    |   Element: " + list.Get(i).Data;
            }

            indexBox.Maximum = list.Count;
            indexBox.Value = list.Count;

            change1.Maximum = list.Count;
            change1.Value = list.Count;

            change2.Maximum = list.Count;
            change2.Value = list.Count;
        }

        private void value_Click(object sender, EventArgs e)
        {
            
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            list.Change(list.Get(int.Parse(change1.Value + "")), list.Get(int.Parse(change2.Value + "")));

            printBox.Text = "Lista:";

            for (int i = 0; i < list.Count; i++)
            {
                printBox.Text += "\n Index: " + i + "    |   Element: " + list.Get(i).Data;
            }
        }
    }
}
