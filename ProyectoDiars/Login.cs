using InversionesHermanos.Conexion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InversionesHermanos
{

    public partial class Login : Form
    {

        Conexion.Conexion conexion = new Conexion.Conexion();

        public int id_empleado;
        public string dni;
        public string cargo;
        public int id_usuario;

        public Login()
        {
            InitializeComponent();
            txtUsuario.Enter += txtUserID_Enter;
            txtUsuario.Leave += txtUserID_Leave;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string[] usuario;

            if (txtUsuario.Text == "admin" && txtPassword.Text == "admin10")
            {
                this.id_empleado = 0;
                this.cargo = "admin";
                Operaciones operaciones = new Operaciones(this);
                operaciones.Show();
                this.Close();
            }
            else
            {
                usuario = conexion.VerificarUsuario(txtUsuario.Text, txtPassword.Text);
                //MessageBox.Show("Usuario " + usuario[0] + usuario[1]);
                if (usuario != null)
                {
                    if (Convert.ToInt32(usuario[4]) == 1)
                    {
                        // Muestra un MessageBox con las opciones Sí y No
                        DialogResult result = MessageBox.Show("Se ha detectado que este usuario se encuentra activo. ¿Desea iniciar sesion qui?", "Sesion iniciada", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // Maneja la respuesta del usuario
                        if (result == DialogResult.Yes)
                        {
                            conexion.CambiarEstadoUsuario(Convert.ToInt32(usuario[3]), 2);
                            Thread.Sleep(7000);
                            // Código para cuando el usuario selecciona 'Sí'
                            conexion.CambiarEstadoUsuario(Convert.ToInt32(usuario[3]), 2);
                            this.id_empleado = Convert.ToInt32(usuario[0]);
                            this.dni = Convert.ToString(usuario[1]);
                            this.cargo = Convert.ToString(usuario[2]);
                            this.id_usuario = Convert.ToInt32(usuario[3]);
                            conexion.CambiarEstadoUsuario(Convert.ToInt32(usuario[3]), 1);
                            Operaciones operaciones = new Operaciones(this);
                            operaciones.Show();
                            this.Close();
                        }                      
                    }
                    else
                    {
                        this.id_empleado = Convert.ToInt32(usuario[0]);
                        this.dni = Convert.ToString(usuario[1]);
                        this.cargo = Convert.ToString(usuario[2]);
                        this.id_usuario = Convert.ToInt32(usuario[3]);
                        conexion.CambiarEstadoUsuario(Convert.ToInt32(usuario[3]), 1);
                        Operaciones operaciones = new Operaciones(this);
                        operaciones.Show();
                        this.Close();
                    }
                }

                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }
            }
        }

        private void txtUserID_Enter(object sender, EventArgs e)
        {
            txtUsuario.ForeColor = Color.White;

            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
            }
        }
        private void txtUserID_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtUsuario.Text == "Usuario")
            {
                txtUsuario.ForeColor = Color.White;
                txtUsuario.Text = "Usuario";
            }
            else
            {
                txtUsuario.ForeColor = Color.White;
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.ForeColor = Color.White;

            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "" || txtPassword.Text == "Contraseña")
            {
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Contraseña";
            }
            else
            {
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

