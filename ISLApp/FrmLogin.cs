using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace ISLApp
{
    public partial class FrmLogin : Form
    {
        
        private Conexion conexion;
        FrmPrincipal frm;
        public FrmLogin()
        {
            this.conexion = new Conexion(FrmPrincipal.getStringConexion()); // obtiene la conexion para la base de datos.
            
            InitializeComponent();

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            this.IngresarAlSistema();
        }

        private DataTable DevuelveTable()
        {
            this.conexion.Login(this.TxtUsername.Text);
            DataTable dataTable = new DataTable();
            dataTable = this.conexion.Login(this.TxtUsername.Text).Tables[0];
            return dataTable;
        }
        private void IngresarAlSistema()
        {
            try
            {
                string passwordSaved = "";
                string usernameSaved = "";
                string rol = "";

                if (ValidarTextoVacio() == true)
                {
                 
                    DataTable dataTable = new DataTable();
                    dataTable = DevuelveTable();

                    if (dataTable.Rows.Count == 0)//valida si la tabla viene vacía
                    {
                        MessageBox.Show("El usuario no existe", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        usernameSaved = dataTable.Rows[0]["nombreUsuario"].ToString();
                        passwordSaved = dataTable.Rows[0]["password"].ToString();
                        rol = dataTable.Rows[0]["rol"].ToString();
                        if (this.TxtPassword.Text.Equals(passwordSaved)) //valida si los password son iguales
                        {
                            frm = new FrmPrincipal();
                            if (rol.Equals("Usuario")){
                                frm.iconButtonUsuario.Visible = false;
                            }
                            frm.Show();
                            this.Hide();
                            var w = new Form() { Size = new Size(0, 0) };
                            Task.Delay(TimeSpan.FromSeconds(1))
                                .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());
                            MessageBox.Show(w, "Bienvenido " + usernameSaved + "", "Information");
                          
                        }
                        else
                        {
                            MessageBox.Show("Contraseña incorrecta ", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.TxtPassword.Text = "";
                        } 
                    }
                }
                else
                {
                    MessageBox.Show("El usuario o la contraseña no son conrrectos.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message) ;
            }
        }

        private  bool ValidarTextoVacio()
        {
            bool valid = false;
            if (string.IsNullOrEmpty(this.TxtUsername.Text) || string.IsNullOrEmpty(this.TxtPassword.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            { 
               valid = true;
            }
            return valid;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }//fin clase 
}// fin de namespace
