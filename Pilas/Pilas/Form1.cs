using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilas
{
    public partial class Form1 : Form
    {
        Pila p;
        public Form1()
        {
            InitializeComponent();
            p = new Pila();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nodo n = new Nodo(int.Parse(textBox1.Text));
            p.Push(n);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nodo n = p.Pop();
            MessageBox.Show(n.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(p.Count + "");
        }
    }
}
