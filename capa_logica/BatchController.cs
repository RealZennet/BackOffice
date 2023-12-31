﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;

namespace capa_logica
{
    public static class BatchController
    {
        public static void Crear(string email, DateTime ShippingDate, int idshipp, bool activedbatch)
        {
            try
            {

            DateTime DateCreation = DateTime.Now;
            ModelBatch lote = new ModelBatch();
            lote.Email = email;
            lote.ShippingDate = ShippingDate;
            lote.DateOfCreation = DateCreation;
            lote.IDShipp = idshipp;
            lote.ActivedBatch = activedbatch;
            lote.Save();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataTable Obtener()
        {
            ModelBatch LotsTableModel = new ModelBatch();
            List<ModelBatch> lotes = LotsTableModel.GetAllLots();
            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Fecha de creacion", typeof(DateTime));
            table.Columns.Add("Fecha de envio", typeof(DateTime));
            table.Columns.Add("ID Envio", typeof(int));
            table.Columns.Add("Activo", typeof(bool));

            foreach (ModelBatch lote in lotes)
            {
                DataRow row = table.NewRow();
                row["id"] = lote.IDBatch;
                row["Email"] = lote.Email;
                row["Fecha de creacion"] = lote.DateOfCreation;
                row["Fecha de envio"] = lote.ShippingDate;
                row["ID Envio"] = lote.IDShipp;
                row["Activo"] = lote.ActivedBatch;
                table.Rows.Add(row);
            }
            return table;
        }
        public static void EliminarLote(int id)
        {
            ModelBatch lote = new ModelBatch();
            lote.IDBatch = id;
            lote.DeleteLots();
        }
    }
}
