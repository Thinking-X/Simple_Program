using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }       
        public int Result = 0;
        private void Student_Click(object sender, EventArgs e)
        {
            Result = 1;
            this.Close();
            return;
        }
        private void Course_Click(object sender, EventArgs e)
        {
            Result = 2;
            this.Close();
            return;
        }
        private void SC_Click(object sender, EventArgs e)
        {
            Result = 3;
            this.Close();
            return;
        }
    }
}
