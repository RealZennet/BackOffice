using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace capa_datos
{
    public class ModelLotes: DataBaseControl
    {
        public int Id { get; set; }
        public DateTime FechaActual { get; set; } = DateTime.Now;
        public int CantidadProductoLote { get; set; }

        public void Save()
        {
            this.Command.CommandText = $"INSERT INTO lote (fech_Crea, cant_Prod_Lote) VALUES " +
                $"('{this.FechaActual.ToString("yyyy-MM-dd HH:mm:ss")}', {this.CantidadProductoLote})";
            this.Command.ExecuteNonQuery();
        }

        public List<ModelLotes> TodosLosItems()
        {
            this.Command.CommandText = "SELECT * FROM lote";
            this.Reader = this.Command.ExecuteReader();

            List<ModelLotes> result = new List<ModelLotes>();
            while (this.Reader.Read())
            {
                ModelLotes lote = new ModelLotes();
                lote.Id = Int32.Parse(this.Reader["id_Lote"].ToString());
                lote.FechaActual = DateTime.Parse(this.Reader["fech_Crea"].ToString());
                lote.CantidadProductoLote = Int32.Parse(this.Reader["cant_Prod_Lote"].ToString());
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
