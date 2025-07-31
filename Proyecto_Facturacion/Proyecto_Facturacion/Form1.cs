using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facturacion;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Configuration;

namespace Proyecto_Facturacion
{
    public partial class Form1 : Form
    {
        private string importeFinal;
        private string fechaFormateada;
        private string fechaAsuntoCorreo;
        private string fechaId;

        private const string BBDD = "empresa";


        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarMeses();
            CargarClientes();
        }
        private void btnEmitirFactura_Click(object sender, EventArgs e)
        {
            EnviarCorreo();
            BuscarImporte();

            string cadenaConexion = ConfigurationManager.ConnectionStrings["MySqlConexion"].ConnectionString;
            Clientes clienteSeleccionado = (Clientes)lbxClientes.SelectedItem;

            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Selecciona un cliente para emitir la factura.");
                return;
            }

            string idFactura = fechaId + clienteSeleccionado.IdCliente;
            string insertQuery = $@"
        INSERT INTO factura (idFactura, nombreEmpresa, fechaFactura, importeFinal) 
        VALUES ('{idFactura}', '{clienteSeleccionado.NombreEmpresa}', '{fechaFormateada}', '{importeFinal}')
    ";

            using (var conexion = new MySqlConnection(cadenaConexion))
            using (var comando = new MySqlCommand(insertQuery, conexion))
            {
                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Factura emitida correctamente.");
                    LimpiarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al emitir factura: " + ex.Message);
                }
            }

            LimpiaPlantilla();
        }

        private void InsertarBaseDatos()
        {
            string cadenaConexion;
            string cadenaComando;
            MySql.Data.MySqlClient.MySqlConnection conexion;
            MySql.Data.MySqlClient.MySqlCommand comando;

            //código para asignarle un id al nuevo cliente que sea 10 más que el id del último cliente en el listbox
            int idCliente;
            int lastIndex = lbxClientes2.Items.Count - 1;
            Clientes ultimoCliente = (Clientes)(lbxClientes2.Items[lastIndex]);
            idCliente = int.Parse(ultimoCliente.IdCliente) + 10;

            cadenaConexion = $"server=localhost;uid=root;password=1234;database={BBDD}";

            cadenaComando = $"INSERT INTO `clientes` (`idCliente`, `nombreEmpresa`, `nif`, `direccion`, `ciudad`, `provincia`, `codigoPostal`, `telefono`, `correoElectronico`) VALUES ('{idCliente}', '{txtNombreEmpresa.Text}', '{txtNif.Text}', '{txtDireccion.Text}', '{txtCiudad.Text}', '{txtProvincia.Text}', '{txtCodigoPostal.Text}', '{txtTelefono.Text}', '{txtCorreoElectronico.Text}')";
            conexion = new MySqlConnection(cadenaConexion);
            comando = new MySqlCommand(cadenaComando, conexion);

            if (txtNombreEmpresa.Text.Length > 0 && txtNif.Text.Length > 0 && txtDireccion.Text.Length > 0 && txtCiudad.Text.Length > 0 && txtProvincia.Text.Length > 0 && txtCodigoPostal.Text.Length > 0 && txtTelefono.Text.Length > 0 && txtCorreoElectronico.Text.Length > 0)
            {
                try
                {
                    conexion.Open();

                    comando.ExecuteNonQuery();
                    MessageBox.Show("Alta empresa correcta");
                    LimpiarDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conexion.Close();
            }
            else
            {
                lblAvisos.Visible = true;
            }
            CargarClientes();
        }
        private void EnviarCorreo()
        {
            Clientes clienteSeleccionado = (Clientes)lbxClientes.SelectedItem;
            if (clienteSeleccionado == null) return;

            string correoDestino = clienteSeleccionado.CorreoElectronico;
            string usuario = "ejemplo@gmail.com";
            string password = Environment.GetEnvironmentVariable("APP_GMAIL_PASS"); // ⚠️ Mejor manejarlo con variables de entorno

            var smtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                EnableSsl = true,
                Credentials = new NetworkCredential(usuario, password),
                Timeout = 30000
            };

            var correo = new MailMessage
            {
                From = new MailAddress(usuario, "Facturación"),
                Subject = "Factura",
                Body = "Remitimos la factura solicitada."
            };

            correo.To.Add(correoDestino);

            try
            {
                smtp.Send(correo);
                MessageBox.Show("Correo enviado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar correo: " + ex.Message);
            }
        }


        private void btnAltaEmpresa_Click(object sender, EventArgs e)
        {
            InsertarBaseDatos();
        }
        private void ImportarPlantilla()
        {
            rtbPlantilla.Clear();
            fechaId = DateTime.Now.ToString("ddMMyyyy");
            Clientes clienteSeleccionado;
            clienteSeleccionado = (Clientes)lbxClientes.SelectedItem;

            fechaAsuntoCorreo = DateTime.Now.Day.ToString("D2") + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
            fechaFormateada = DateTime.Now.ToString("yyyy-MM-dd");

            string plantillaSelecionada = clienteSeleccionado.NombreEmpresa + ".rtf";
            string rutaArchivo = Path.Combine("Plantillas", plantillaSelecionada);

            rtbPlantilla.LoadFile(rutaArchivo);

            int indiceFecha = rtbPlantilla.Find("fecha:");
            if (indiceFecha >= 0)
            {
                rtbPlantilla.SelectionStart = indiceFecha + "FECHA:".Length;
                rtbPlantilla.SelectionLength = 0;
                rtbPlantilla.SelectedText = " " + DateTime.Now.ToShortDateString();
            }

            int indiceFactura = rtbPlantilla.Find("FACTURA Nº:");
            if (indiceFactura >= 0)
            {
                rtbPlantilla.SelectionStart = indiceFactura + "FACTURA Nº:".Length;
                rtbPlantilla.SelectionLength = 0;
                rtbPlantilla.SelectedText = " " + fechaId + clienteSeleccionado.IdCliente.ToString();
            }
        }
        private void lbxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbPlantilla.Clear();
            ImportarPlantilla();
            lbxMeses.SelectedIndex = -1;
        }
        private void lbxMeses_SelectedIndexChanged(object sender, EventArgs e)
        {

            Clientes clienteSeleccionado;
            clienteSeleccionado = (Clientes)lbxClientes.SelectedItem;

            if (lbxMeses.SelectedIndex != -1)
            {

                Mes mesSelecionado;
                mesSelecionado = (Mes)lbxMeses.SelectedItem;

                fechaId = DateTime.Now.Day.ToString("D2") + mesSelecionado.IdMes.ToString() + DateTime.Now.Year.ToString();

                int indiceFecha = rtbPlantilla.Find("FECHA:");
                if (indiceFecha >= 0)
                {
                    rtbPlantilla.SelectionStart = indiceFecha + "FECHA:".Length;
                    rtbPlantilla.SelectionLength = 11;
                    rtbPlantilla.SelectedText = " " + DateTime.Now.Day.ToString("D2") + "/" + mesSelecionado.IdMes.ToString() + "/" + DateTime.Now.Year.ToString();
                    fechaAsuntoCorreo = DateTime.Now.Day.ToString("D2") + "/" + mesSelecionado.IdMes.ToString() + "/" + DateTime.Now.Year.ToString();
                    fechaFormateada = DateTime.Now.Year.ToString() + "-" + mesSelecionado.IdMes.ToString() + "-" + DateTime.Now.Day.ToString();
                }

                int indiceFactura = rtbPlantilla.Find("FACTURA Nº:");
                if (indiceFactura >= 0)
                {
                    rtbPlantilla.SelectionStart = indiceFactura + "FACTURA Nº:".Length;
                    rtbPlantilla.SelectionLength = "FACTURA Nº:".Length;
                    rtbPlantilla.SelectedText = " " + fechaId + clienteSeleccionado.IdCliente;


                }


            }


        }
        private void CargarMeses()
        {
            Mes uno = new Mes("Enero", "01"); lbxMeses.Items.Add(uno);
            Mes dos = new Mes("Febrero", "02"); lbxMeses.Items.Add(dos);
            Mes tres = new Mes("Marzo", "03"); lbxMeses.Items.Add(tres);
            Mes cuatro = new Mes("Abril", "04"); lbxMeses.Items.Add(cuatro);
            Mes cinco = new Mes("Mayo", "05"); lbxMeses.Items.Add(cinco);
            Mes seis = new Mes("Junio", "06"); lbxMeses.Items.Add(seis);
            Mes siete = new Mes("Julio", "07"); lbxMeses.Items.Add(siete);
            Mes ocho = new Mes("Agosto", "08"); lbxMeses.Items.Add(ocho);
            Mes nueve = new Mes("Septiembre", "09"); lbxMeses.Items.Add(nueve);
            Mes diez = new Mes("Octubre", "10"); lbxMeses.Items.Add(diez);
            Mes once = new Mes("Noviembre", "11"); lbxMeses.Items.Add(once);
            Mes doce = new Mes("Diciembre", "12"); lbxMeses.Items.Add(doce);
        }
        private void CargarClientes()
        {
            lbxClientes.Items.Clear();
            lbxClientes2.Items.Clear();

            MySql.Data.MySqlClient.MySqlConnection conexion;
            MySql.Data.MySqlClient.MySqlCommand comando;
            MySql.Data.MySqlClient.MySqlDataAdapter adaptador;

            System.Data.DataSet ds;

            Clientes cliente;

            string cadenaComando, cadenaConexion;

            cadenaConexion = $"server=localhost;uid=root;password=1234;database={BBDD}";
            cadenaComando = "SELECT * FROM `clientes`";

            conexion = new MySqlConnection(cadenaConexion);
            comando = new MySqlCommand(cadenaComando, conexion);

            adaptador = new MySqlDataAdapter(comando);
            ds = new DataSet();

            try
            {
                adaptador.Fill(ds);
                conexion.Close();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    cliente = new Clientes(dr.ItemArray[0].ToString(), dr.ItemArray[1].ToString(), dr.ItemArray[2].ToString(), dr.ItemArray[3].ToString(), dr.ItemArray[4].ToString(), dr.ItemArray[5].ToString(), (dr.ItemArray[6].ToString()), dr.ItemArray[7].ToString(), dr.ItemArray[8].ToString());
                    lbxClientes.Items.Add(cliente);
                    lbxClientes2.Items.Add(cliente);
                    //lbxClientes3.Items.Add(cliente);


                }

            }
            catch
            {
                return; 
            }

        }
        private void LimpiarDatos()
        {
            txtNombreEmpresa.Clear();
            txtNif.Clear();
            txtTelefono.Clear();
            txtCiudad.Clear();
            txtDireccion.Clear();
            txtProvincia.Clear();
            txtCodigoPostal.Clear();
            txtCorreoElectronico.Clear();
            lblAvisos.Visible = false;
        }
        private void LimpiaPlantilla() 
        {
            rtbPlantilla.Clear();
        }

   

        private void BuscarImporte()
        {
            
            string texto;
            texto = rtbPlantilla.Text;
            
            int indiceInicio;
            indiceInicio = texto.LastIndexOf("TOTAL");
            
            int indiceFinal;
            indiceFinal = -1;

            if (indiceInicio >= 0)
            {
                indiceFinal = texto.IndexOf("€", indiceInicio + "TOTAL".Length);
            }

            if(indiceFinal >= 0)
            {
                importeFinal = texto.Substring(indiceInicio + "TOTAL".Length+1,indiceFinal-indiceInicio-"TOTAL".Length-1);
            }
           
        }

  
    }
}
