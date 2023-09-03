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
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ShippingDate { get; set; }

        public void Save()
        {
            this.Command.CommandText = $"INSERT INTO lote (fech_Crea, fech_Entre) VALUES " +
                $"('{this.CreatedDate.ToString("yyyy-MM-dd HH:mm:ss")}', {this.ShippingDate})";
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
                lote.CreatedDate = DateTime.Parse(this.Reader["fech_Crea"].ToString());
                lote.ShippingDate = DateTime.Parse(this.Reader["fech_Entre"].ToString());
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
