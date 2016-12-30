using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedListForm
{
    public partial class Form1 : Form
    {
        MyLinkedList list;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list = new MyLinkedList();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            list.AddAtStart(textBox1.Text);
            list.PrintAllNodes(textBox2);
         
        }

        private void btn_rmv_Click(object sender, EventArgs e)
        {
            list.RemoveFromStart();
            list.PrintAllNodes(textBox2);
            
        }
    }
}
