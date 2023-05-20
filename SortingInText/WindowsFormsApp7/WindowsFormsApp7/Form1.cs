using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //сортировка2
            
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //сортировка1
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();
            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDlg.FileName, Encoding.Default);
                richTextBox1.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            OpenDlg.Dispose();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog SaveDlg = new SaveFileDialog();



            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDlg.FileName);

                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    Writer.WriteLine((string)listBox2.Items[i]);
                }
                Writer.Close();
            }
            SaveDlg.Dispose();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) //exit
        {
            Application.Exit();
            MessageBox.Show("");
        }

        private void button10_Click(object sender, EventArgs e) //start
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            listBox1.BeginUpdate();

            string[] Strings = richTextBox1.Text.Split(new char[] { '\n', '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach(string s in Strings)
            {
                string Str = s.Trim();

                if (Str == String.Empty) continue;
                if (radioButton1.Checked) listBox1.Items.Add(Str);
                if (radioButton2.Checked)
                {
                    if (Regex.IsMatch(Str, @"\d")) listBox1.Items.Add(Str);
                }
                if (radioButton3.Checked)
                {
                    if (Regex.IsMatch(Str, @"\w+@\w+\.\w+")) listBox1.Items.Add(Str);
                }
            }
            listBox1.EndUpdate();
        }

        private void button7_Click(object sender, EventArgs e) //сброс
        {
            listBox3.Items.Clear();
        }

        private void button8_Click(object sender, EventArgs e) //exit
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) //clean1
        {
            listBox1.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e) // clean2
        {
            listBox2.Items.Clear();
        }

        private void button9_Click(object sender, EventArgs e) //find
        {
            string Find = textBox1.Text;

            if(checkBox1.Checked)
            {
                foreach(string String in listBox1.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);
                }
            }
            if (checkBox2.Checked)
            {
                foreach(string String in listBox2.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 AddRec = new Form2();
            AddRec.Owner = this;
            AddRec.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) // delete
        {
            for (int i = listBox1.Items.Count - 1; i >= 0; i--)
            {
                if (listBox1.GetSelected(i)) listBox1.Items.RemoveAt(i);
            }
            for (int i = listBox2.Items.Count - 1; i >= 0; i--)
            {
                if (listBox2.GetSelected(i)) listBox2.Items.RemoveAt(i);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            listBox2.BeginUpdate();

            foreach(object Item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(Item);
            }
            listBox2.EndUpdate();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();

            foreach (object Item in listBox2.SelectedItems)
            {
                listBox2.Items.Add(Item);
            }
            listBox1.EndUpdate();
        }
    }
}
