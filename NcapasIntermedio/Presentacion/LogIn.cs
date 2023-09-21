using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }
        
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.White;
                txtContra.UseSystemPasswordChar = true;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "Contraseña";
                txtContra.ForeColor = Color.DimGray;
                txtContra.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "Usuario" || txtContra.Text != "Contraseña") 
            {
                UserModel user = new UserModel();
                var validLogin = user.LoginUser(txtUsuario.Text, txtContra.Text);
                if (validLogin == true)
                {
                    MenuLateral mainMenu = new MenuLateral();
                    mainMenu.Show();
                    this.Hide();
                }
                else
                {
                    msjError("Por favor verifique los datos ingresados");
                }
            } else {
                msjError("Por favor ingrese los datos");
            }

        }

        private void msjError(string msj) {
            lblErrorLogin.Text = "    " + msj;
            lblErrorLogin.Visible = true;
        }
    }
}
