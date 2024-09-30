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
    internal class VoucherServices
    {
        private DataBaseAccess DB = new DataBaseAccess();

        public void add(Voucher newVoucher)
        {
            try
            {
                DB.clearParameters();
                DB.setQuery("Insert into Vouchers (CodigoVoucher, IdCliente, FechaCanje, IdArticulo) values (@CodigoVoucher, @IdCliente, @FechaCanje, @IdArticulo)");

                DB.setParameter("@CodigoVoucher", newVoucher.CodigoVoucher);
                DB.setParameter("@IdCliente", newVoucher.IdCliente);
                DB.setParameter("@FechaCanje", newVoucher.FechaCanje);
                DB.setParameter("@IdArticulo", newVoucher.IdArticulo);


                DB.excecuteAction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar Voucher. Comuníquese con el Soporte.", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.CloseConnection();
            }
        }

        public void modify(Voucher voucher)
        {
            try
            {
                DB.clearParameters();
                DB.setQuery("Update Vouchers set CodigoVoucher = @CodigoVoucher, IdCliente = @IdCliente, FechaCanje = @FechaCanje, IdArticulo = @IdArticulo Where CodigoVoucher = @CodigoVoucher");

                DB.setParameter("@CodigoVoucher", voucher.CodigoVoucher);
                DB.setParameter("@IdCliente", voucher.IdCliente);
                DB.setParameter("@FechaCanje", voucher.FechaCanje);
                DB.setParameter("@IdArticulo", voucher.IdArticulo);

                DB.excecuteAction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar Voucher. Comuníquese con el Soporte.", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DB.setQuery("Delete from Vouchers where CodigoVoucher = @CodigoVoucher");
                DB.setParameter("@Id", Id);
                DB.excecuteAction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar Voucher. Comuníquese con el Soporte.", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.CloseConnection();
            }
        }
    }
}
