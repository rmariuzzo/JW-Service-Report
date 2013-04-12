using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Reybin.ServiceReport.Service;

namespace Reybin.ServiceReport
{
    public partial class FrmNewUser : Form
    {
        public FrmNewUser()
        {
            InitializeComponent();
           
        }

        private void BtnCreateUser_Click(object sender, EventArgs e)
        {
            // Validate input.

            if (String.IsNullOrEmpty(TxtUsername.Text)) 
            {
                MessageBox.Show("El nombre de usuario no puede estar vacio!");
            }
            if (String.IsNullOrEmpty(TxtPassword.Text)) 
            {
                MessageBox.Show("Escriba un contraseña valida");
            }

            // Crete user.
            var service = new UserService();
            service.Create(TxtUsername.Text, TxtPassword.Text);
        }
        
        
        
    }
}
