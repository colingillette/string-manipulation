using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_manipulation
{
    public partial class Form1 : Form
    {
        private void CleanForm()
        {
            textBox.Clear();
            textBox.Focus();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void largestWordButton_Click(object sender, EventArgs e)
        {
            string str;

            StringAid stringAid = new StringAid(textBox.Text);
            str = stringAid.LongestWord();

            MessageBox.Show(str);
            CleanForm();
        }

        private void luckyButton_Click(object sender, EventArgs e)
        {
            string str;
            bool isLucky;

            StringAid stringAid = new StringAid(textBox.Text);
            isLucky = stringAid.FeelingLucky();

            if (isLucky)
            {
                MessageBox.Show("You are feeling lucky.");
            }
            else
            {
                MessageBox.Show("You are not feeling lucky.");
            }
            CleanForm();
        }

        private void uniqueButton_Click(object sender, EventArgs e)
        {
            string unique;

            StringAid stringAid = new StringAid(textBox.Text);
            unique = stringAid.UniqueCharacters();

            MessageBox.Show(unique);
        }

        private void chatbotButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
