using BLL;
using DAL;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace ISLApp
{
    public partial class FrmInfractor : Form
    {
        String url = "https://apis.gometa.org/cedulas/";
        private Conexion conexion;
        Boolean modificar = false;
        FrmInformeInfractor padre;
        int idModificacion = 0;
        public FrmInfractor(FrmInformeInfractor padre)
        {
            InitializeComponent();
            this.conexion = new Conexion(FrmPrincipal.getStringConexion());
            modificar = false;
            this.padre = padre;
        }

        public FrmInfractor(FrmInformeInfractor padre, Boolean modificar, String cedula, String nombre, String tipo, int idInfractor, int actividadIlegal)
        {
            InitializeComponent();
            this.conexion = new Conexion(FrmPrincipal.getStringConexion());
            //this.lblTitle.Text = "Modificar Informe"; ERRRROOORR
            this.btnCrear.Text = "Modificar";
            tbCedula.Text = cedula;
            tbNombreInfractor.Text = nombre;
            cbTipo.Text = tipo;
            cbActividades.SelectedItem = actividadIlegal;
            this.modificar = modificar;
            this.padre = padre;
            idModificacion = idInfractor;
        }

        private  void FrmInfractor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'islaSanLucasBDDataSet.ActividadIlegal' Puede moverla o quitarla según sea necesario.
            this.actividadIlegalTableAdapter.Fill(this.islaSanLucasBDDataSet.ActividadIlegal);
            // TODO: esta línea de código carga datos en la tabla 'islaSanLucasBDDataSet.ActividadIlegal' Puede moverla o quitarla según sea necesario.

        }

        // metodo asincronico que requiere del campo cedula(req) para realizar una busqueda a traves de la api.
        private async void btnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                String cedula = this.tbCedula.Text.Trim();
                if (cedula.Length > 0)
                {
                    if (cedula.Length > 8)
                    {
                        String urlStream = url + cedula;
                        String json = await GetHttp(urlStream);
                        Infractor infractor = JsonConvert.DeserializeObject<Infractor>(json);

                        if (int.Parse(infractor.resultcount) != 0)
                        {
                            this.tbNombreInfractor.Text = infractor.nombre;
                        }
                        else {
                            MessageBox.Show("La cédula digitada no pertenece a nadie", "Persona no registrada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            limpiarCampos();
                        }
                    }
                    else {
                        MessageBox.Show("Debe digitar la cédula completa", "Dato Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCampos();
                    }
                }
                else {
                    MessageBox.Show("El campo cédula debe contener algun valor", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limpiarCampos();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error" + ex);
                MessageBox.Show("Verifique su conexión con internet: ", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Metodo asincronico que permite obtener un objeto json desde una api, para consultar a una persona por numero de cedula
        public async Task<string> GetHttp (String apiUrl) {
            WebRequest oRequest = WebRequest.Create(apiUrl);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tbCedula.Text.Length > 0 && tbNombreInfractor.Text.Length > 0 && this.cbTipo.Text.Length > 0)
                {
                    InfractorBD infractorBd = new InfractorBD();

                    infractorBd.nombreResponsable = tbNombreInfractor.Text.Trim();
                    infractorBd.cedulaResponsable = tbCedula.Text.Trim();
                    infractorBd.tipoResponsable = this.cbTipo.Text.Trim();
                    infractorBd.estado = true;
                    infractorBd.actividadIlegal = int.Parse(cbActividades.SelectedValue.ToString());

                    try
                    {
                        if (this.conexion.realizarConexion())
                        {
                            if (modificar)
                            {
                                if (idModificacion != 0)
                                {
                                    this.conexion.modificar(infractorBd, idModificacion);
                                    MessageBox.Show("Realizaron los cambios de manera correcta", "Modificado con Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    limpiarCampos();
                                    padre.cargarTabla();
                                    this.Dispose();
                                }
                            }
                            else
                            {
                                if (conexion.buscarInfractorXcedula(infractorBd.cedulaResponsable) == 0)
                                {
                                    this.conexion.registrarInfractor(infractorBd);
                                    MessageBox.Show("La persona fue registrada de manera correcta", "Guardado con Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    limpiarCampos();
                                    padre.cargarTabla();
                                    padre.activarBotones();
                                    this.Dispose();
                                }
                                else
                                {
                                    MessageBox.Show("La cedula digitada ya se encuentra registrada en el sistema", "Cedula Registrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    limpiarCampos();
                                }
                            }
                        }
                        else {
                            MessageBox.Show("Revise la conexión con internet o su conexión con la base de datos", "No se encontro la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se encoentro un error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {
                    MessageBox.Show("Todos los campos son requeridos", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se encoentro un error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarCampos() {
            tbNombreInfractor.Text = "";
            tbCedula.Text = "";
            cbTipo.Text = "";
        }

        private void tbCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void cbActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }



        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
