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
    public partial class FrmNew_User : Form
    {
        public FrmNew_User()
        {
            InitializeComponent();
           
        }

        private void create_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(TxtUsername.Text)) 
            {
                MessageBox.Show("El nombre de usuario no puede estar vacio!");
            }
            if (String.IsNullOrEmpty(TxtPassword.Text)) 
            {
                MessageBox.Show("Escriba un contraseña valida");
            }
        }
        
        
        
    }
}
