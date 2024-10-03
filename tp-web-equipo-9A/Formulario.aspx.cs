using Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utils;

namespace tp_web_equipo_9A
{
    public partial class Formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnParticipar_Click(object sender, EventArgs e)
        {
            ClienteServices clienteServices = new ClienteServices();
            VoucherServices voucherServices = new VoucherServices();
            try
            {
                Cliente cliente = new Cliente();
                Voucher voucher = new Voucher();
                Articulo articulo = new Articulo();

                if (!cboxTerminos.Checked)
                {
                    lblError.Text = "Debes aceptar los términos y condiciones.";
                    return;
                }

                cliente.Documento = txtDni.Text;
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Email = txtEmail.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Ciudad = txtCiudad.Text;
                cliente.CP = int.Parse(txtCp.Text);

                if (!clienteServices.repeatedCode(cliente.Documento))
                {
                    clienteServices.add(cliente);
                    lblError.Text = "Registro agregardo correctamente";
                }

                int idCliente = clienteServices.ObtenerId(cliente.Documento);
                if (idCliente <= 0)
                {
                    throw new Exception("ID de cliente no válido.");
                }
                else
                {
                    voucher.IdCliente = idCliente;
                    voucher.FechaCanje = DateTime.Now;
                    voucher.CodigoVoucher = "Codigo02"; //Dato hardcodeado, me va allegar en el request
                    voucher.IdArticulo = 2;//Dato hardcodeado, me va allegar en el request
                    voucherServices.modify(voucher);
                    
                }


            }
            catch (FormatException)
            {
                lblError.Text = "Debe ingresar valores numericos en el campo de CP";

            }
            catch (Exception ex)
            {

                lblError.Text = "Ocurrio un error" + ex;

            }
        }

        protected void txtDni_TextChanged(object sender, EventArgs e)
        {
            DataBaseAccess dbAccess = new DataBaseAccess();
            string dni = txtDni.Text;

            try
            {

                dbAccess.setQuery("SELECT Nombre, Apellido, Email, Direccion, Ciudad, CP FROM Clientes WHERE Documento = @dni");


                dbAccess.setParameter("@dni", dni);

                dbAccess.excecuteQuery();

                if (dbAccess.Reader.Read())
                {

                    txtNombre.Text = dbAccess.Reader["Nombre"].ToString();
                    txtApellido.Text = dbAccess.Reader["Apellido"].ToString();
                    txtEmail.Text = dbAccess.Reader["Email"].ToString();
                    txtDireccion.Text = dbAccess.Reader["Direccion"].ToString();
                    txtCiudad.Text = dbAccess.Reader["Ciudad"].ToString();
                    txtCp.Text = dbAccess.Reader["CP"].ToString();

                    btnParticipar.Text = "Participar";
                    lblError.Text = "Datos precargados correctamente.";
                }
                else
                {

                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtEmail.Text = "";
                    txtDireccion.Text = "";
                    txtCiudad.Text = "";
                    txtCp.Text = "";

                    lblError.Text = "El cliente no existe. Puedes agregar uno nuevo.";
                    btnParticipar.Text = "Registrar y participar";
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "Ocurrió un error: " + ex.Message;
            }
            finally
            {
                dbAccess.CloseConnection();
                dbAccess.clearParameters();
            }
        }

    }
}