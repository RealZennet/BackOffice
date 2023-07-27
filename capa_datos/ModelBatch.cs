using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace capa_datos
{
    public class ModelBatch : DataBaseControl
    {
        public int Id { get; set; } //id lote
       // public int IdProduct {get; set;}
        public DateTime FechaActual { get; set; } = DateTime.Now;
        public int ProductsAmount { get; set; }

        public void Save()
        {
            this.Command.CommandText = $"INSERT INTO lote (fech_Crea, cant_Prod_Lote) VALUES " +
                $"('{this.FechaActual.ToString("yyyy-MM-dd HH:mm:ss")}', {this.ProductsAmount})";
            this.Command.ExecuteNonQuery();
        }

        public List<ModelBatch> TodosLosItems()
        {
            this.Command.CommandText = "SELECT * FROM lote"; 
            this.Reader = this.Command.ExecuteReader();

            List<ModelBatch> result = new List<ModelBatch>();
            while (this.Reader.Read())
            {
                ModelBatch lote = new ModelBatch();
                lote.Id = Int32.Parse(this.Reader["id_Lote"].ToString());
                lote.FechaActual = DateTime.Parse(this.Reader["fech_Crea"].ToString());
                lote.ProductsAmount = Int32.Parse(this.Reader["cant_Prod_Lote"].ToString());
                result.Add(lote);
            }
            return result;
        }
        public void Delete()
        {
            this.Command.CommandText = $"DELETE FROM lote WHERE id_Lote = {this.Id}";
            this.Command.ExecuteNonQuery();
        }

    }
}
