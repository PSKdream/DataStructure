using Collections;
using Sets;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        //Collection data = new ArrayCollection(1);
        //Collection data = new LinkedCollection();
        //Collection data = new LinkedHeaderCollection();
        Set data = new ArraySet(2);
        //Set data = new LinkedSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            data.add(textBox1.Text);
            updata();
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool find = data.contains(textBox2.Text);
            if (find)
                MessageBox.Show("me");
            else
                MessageBox.Show("not me");
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (data.contains(textBox3.Text))
            {
                data.remove(textBox3.Text);
                updata();
            }
            else
                MessageBox.Show("not me");
            textBox3.Text = "";
        }

        private void updata()
        {
            label1.Text = "จำนวน "+data.size()+" คน";
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
