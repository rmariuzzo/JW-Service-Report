using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reybin.ServiceReport
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(TxtUsername.Text))
            {
                MessageBox.Show("El nombre de usuario no puede estar vacio");
            }
             if(String.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Contraseña incorrexta o no valida");
            }
        }
    }
}
