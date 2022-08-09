using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;


namespace ISLApp
{
    public partial class FrmRegistrarUsuario : Form
    {

        Conexion connection;
        
        public FrmRegistrarUsuario()
        {
            InitializeComponent();
            
            this.connection = new Conexion(FrmPrincipal.ObtenerStringConexion());
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            this.agregarUsuario();
        }

        public Usuario llenarUsuario()
        {
            try
            {
                Usuario usuarioNuevo = new Usuario();
                usuarioNuevo.nombreUsuario = this.nombreUsuario.Text.Trim();
                usuarioNuevo.email = this.email.Text.Trim();
                usuarioNuevo.password = this.contrasena.Text.Trim();
                usuarioNuevo.rol = this.cbxRol.Text.Trim();

                return usuarioNuevo;
            }
            catch (Exception)
            {

                throw;
            } 
 
        }

        public void agregarUsuario()
        {
            try
            {
                validacionGeneral();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void editarUsuario()
        {
            try
            {
                validacionGeneral();
                this.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       

        public void validarSoloLetras(KeyPressEventArgs v)
        {
            try
            {
                if(Char.IsLetter(v.KeyChar))
                {
                    v.Handled = false;
                }
                else if (Char.IsSeparator(v.KeyChar))
                {
                    v.Handled = false;
                }
                else if (Char.IsControl(v.KeyChar))
                {
                    v.Handled = false;
                }
                else
                {
                    v.Handled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void nombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                validarSoloLetras(e);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool validarEmail(string email)
        {
            try
            {
                if (email == null)
                {
                    return false;
                }
                if (new EmailAddressAttribute().IsValid(email))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public bool validarEspacioBlanco(string validar)
        {
            try
            {
                if (validar == "")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void validacionGeneral()
        {
            try
            {

                if (validarEmail(this.email.Text.Trim()) == false ||
                    validarEspacioBlanco(this.contrasena.Text.Trim()) == false ||
                    validarEspacioBlanco(this.cbxRol.Text.Trim()) == false ||
                    validarEspacioBlanco(this.nombreUsuario.Text.Trim()) == false)
                {

                    MessageBox.Show("Debe completar todos los campos", "Warning",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (this.btnAgregar.Text == "Agregar")
                    {
                        this.connection.registrarUsuario(llenarUsuario());
                        MessageBox.Show("Usuario registrado exitosamente", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos();

                    }
                    else
                    {
                        this.connection.ActualizarUsuario(llenarUsuario());
                        MessageBox.Show("Usuario actualizado exitosamente", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos();
                    }
                    
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void limpiarCampos()
        {
            this.nombreUsuario.Text = "";
            this.email.Text = "";
            this.contrasena.Text = "";
            this.cbxRol.Items.Clear();
        }

    }//fin de la clase
}//fin del namespace
