using Lists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GUI_List
{
    public partial class Form1 : Form
    {
        //List data = new ArrayList(1);
        List data = new LinkedList();
        //List data = new SinglyLinkedList();

        public Form1()
        {
            InitializeComponent();
            EditName.Enabled = false;
        }

        private void InsertName_Click(object sender, EventArgs e)
        {
            data.add(textName.Text);
            textName.Text = "";
            updata();
        }

        private void FindName_Click(object sender, EventArgs e)
        {
            bool find = data.contains(textName.Text);
            if (find)
                MessageBox.Show("me");
            else
                MessageBox.Show("not me");
            textName.Text = "";

        }

        private void DelName_Click(object sender, EventArgs e)
        {
            data.remove((object)textName.Text);
            textName.Text = "";
            updata();

        }

        private void FindNameIndex_Click(object sender, EventArgs e)
        {
            textEdit.Text= (String) data.get((int)numericUpDown1.Value);
            numericUpDown1.Enabled = false;
            EditName.Enabled = true;
        }

        private void EditName_Click(object sender, EventArgs e)
        {
            data.set((int)numericUpDown1.Value, textEdit.Text);
            numericUpDown1.Enabled = true;
            textEdit.Text = "";
            updata();
            EditName.Enabled = false;
        }

        private void ShowListName_Click(object sender, EventArgs e)
        {
            string[] text = new string[data.size()];
            ListName1.Clear();
            for (int i = 0; i < text.Length; i++)
            {
                text[i] = i + " : " + data.get(i).ToString();
            }
            ListName1.Lines = text;
        }
        private void updata()
        {
            label1.Text = "จำนวน " + data.size() + " คน";
            ShowListName_Click(null, null);
        }
    }
}
