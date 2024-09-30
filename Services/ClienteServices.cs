﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Services
{
    internal class ClienteServices
    {
        private DataBaseAccess DB = new DataBaseAccess();

        public void add(Cliente newCliente)
        {
            try
            {
                DB.clearParameters();
                DB.setQuery("Insert into Clientes (Id, Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) values (@Id, @Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP)");

                DB.setParameter("@Id", newCliente.Id);
                DB.setParameter("@Documento", newCliente.Documento);
                DB.setParameter("@Nombre", newCliente.Nombre);
                DB.setParameter("@Apellido", newCliente.Apellido);
                DB.setParameter("@Email", newCliente.Email);
                DB.setParameter("@Direccion", newCliente.Direccion);
                DB.setParameter("@Ciudad", newCliente.Ciudad);
                DB.setParameter("@CP", newCliente.CP);

                DB.excecuteAction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar Cliente. Comuníquese con el Soporte.", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.CloseConnection();
            }
        }

        public void modify(Cliente cliente)
        {
            try
            {
                DB.clearParameters();
                DB.setQuery("Update Clientes set Id = @Id, Documento = @Documento, Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Direccion = @Direccion, Ciudad = @Ciudad, CP = @CP Where Id = @Id");

                DB.setParameter("@Id", cliente.Id);
                DB.setParameter("@Documento", cliente.Documento);
                DB.setParameter("@Nombre", cliente.Nombre);
                DB.setParameter("@Apellido", cliente.Apellido);
                DB.setParameter("@Email", cliente.Email);
                DB.setParameter("@Direccion", cliente.Direccion);
                DB.setParameter("@Ciudad", cliente.Ciudad);
                DB.setParameter("@CP", cliente.CP);

                DB.excecuteAction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar Cliente. Comuníquese con el Soporte.", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.CloseConnection();
            }
        }

        public void delete(int Id)
        {
            try
            {
                DB.clearParameters();
                DB.setQuery("Delete from Clientes where Id = @Id");
                DB.setParameter("@Id", Id);
                DB.excecuteAction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar Cliente. Comuníquese con el Soporte.", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.CloseConnection();
            }
        }
    }
}
