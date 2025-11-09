using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP4_MenusListes
{
    public partial class frmApropos : Form
    {
        public frmApropos()
        {
            InitializeComponent();
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
