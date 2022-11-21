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
using System.ComponentModel.DataAnnotations;

namespace ISLApp
{
    public partial class FrmRegistrarUsuario : Form
    {
        private String username;
        private Conexion conexion;
        public FrmRegistrarUsuario()
        {
            this.conexion = new Conexion(FrmPrincipal.getStringConexion()); // obtiene la conexion para la base de datos.
            InitializeComponent();
        }
        public FrmRegistrarUsuario(string nombreUsuario)
        {
            this.conexion = new Conexion(FrmPrincipal.getStringConexion()); // obtiene la conexion para la base de datos.
            InitializeComponent();
            this.username = nombreUsuario;

        }


        public void validacionGeneral()
        {
            try
            {

                if (validarEmail(this.TxtCorreo.Text.Trim()) == false ||
                    validarEspacioBlanco(this.TxtContrasenia.Text.Trim()) == false ||
                    validarEspacioBlanco(this.CbRol.Text.Trim()) == false ||
                    validarEspacioBlanco(this.TxtNombreUsuario.Text.Trim()) == false)
                {

                    MessageBox.Show("Debe completar todos los campos", "Warning",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (this.BtnAgregar.Text == "Agregar")
                    {
                        this.conexion.registrarUsuario(llenarUsuario());
                        MessageBox.Show("Usuario registrado exitosamente", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos();

                    }
                    else
                    {
                        this.conexion.ActualizarUsuario(this.username, llenarUsuario());


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

        public Usuario llenarUsuario()
        {
            try
            {
                Usuario usuarioNuevo = new Usuario();
                usuarioNuevo.nombreUsuario = this.TxtNombreUsuario.Text.Trim();
                usuarioNuevo.email = this.TxtCorreo.Text.Trim();
                usuarioNuevo.password = this.TxtContrasenia.Text.Trim();
                usuarioNuevo.rol = this.CbRol.Text.Trim();

                return usuarioNuevo;
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
        public void limpiarCampos()
        {
            this.TxtNombreUsuario.Text = "";
            this.TxtCorreo.Text = "";
            this.TxtContrasenia.Text = "";
            this.CbRol.Items.Clear();
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
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            this.agregarUsuario();
        }

        private void TxtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
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

        public void validarSoloLetras(KeyPressEventArgs v)
        {
            try
            {
                if (Char.IsLetter(v.KeyChar))
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }//fin de la clase
}//fin del namespace
