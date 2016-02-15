using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternshipApplication
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_NewStudent_Click(object sender, EventArgs e)
        {
            NewStudent ns = new NewStudent();
            ns.Show();
            this.Hide();
        }

        private void ns_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
