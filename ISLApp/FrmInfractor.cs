using BLL;
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
        public FrmInfractor()
        {
            InitializeComponent();
        }

        private  void FrmInfractor_Load(object sender, EventArgs e)
        {
            
        }


        private async void btnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                String cedula = this.tbCedula.Text;
                if (cedula.Length > 0)
                {
                    String urlStream = url + cedula;
                    String json = await GetHttp(urlStream);
                    Infractor infractor = JsonConvert.DeserializeObject<Infractor>(json);

                    this.tbNombreInfractor.Text = infractor.nombre;
                }
                else { 
                   //agregar una alerta en caso de que no se encuentre completo
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        //Metodo asincronico que permite obtener un objeto json desde una api, para consultar a una persona por numero de cedula
        public async Task<string> GetHttp (String apiUrl) {
            WebRequest oRequest = WebRequest.Create(apiUrl);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }
    }
}
