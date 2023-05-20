using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

       
        Random random = new Random();

        List<string> icons = new List<string>()
        {"!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"
};
        Label firstClicked = null;
        Label secondCliced = null;

        public void AssingIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNum = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNum];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNum);
                }
            }
            
        }
             
        public Form1()
        {
            InitializeComponent();

            AssingIconsToSquares();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;



                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }
                secondCliced = clickedLabel;
                secondCliced.ForeColor = Color.Black;

                CheckForWinner();

                if (firstClicked.Text == secondCliced.Text)
                {
                    firstClicked = null;
                    secondCliced = null;
                    return;
                }
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondCliced.ForeColor = secondCliced.BackColor;

            firstClicked = null;
            secondCliced = null;

            
        }
        private void CheckForWinner()
        {
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if(iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            MessageBox.Show("Вы нашли все пары!", "Congratulations");
            Close();
        }
    }
}
