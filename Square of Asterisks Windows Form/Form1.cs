using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Square_of_Asterisks_Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(sizeTextBox.Text);
            string square = "";

            if (size < 1)
            {
                size = 1;
            }

            if (size > 20)
            {
                size = 20;
            }

            for (int row = 1; row <= size; row++) 
            {
                for (int col = 1; col <= size; col++)
                {
                    if (row == 1 || row == size || col == 1 || col == size) 
                    {
                        square += "*";
                    }

                    else
                    {
                        square += " ";
                    }
                }

                square += "\n";
            }

            MessageBox.Show(square);
        }
    }
}
