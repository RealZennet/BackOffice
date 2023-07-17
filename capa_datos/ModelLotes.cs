using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace capa_datos
{
    public class ModelLotes : DataBaseControl
    {
        public int Id { get; set; } //id lote
       // public int IdProduct {get; set;}
        public DateTime FechaActual { get; set; } = DateTime.Now;
        public int ProductsAmount { get; set; }

        public void Save()
        {
            this.Command.CommandText = $"INSERT INTO lote (fech_Crea, cant_Prod_Lote) VALUES " +
                $"('{this.FechaActual.ToString("yyyy-MM-dd HH:mm:ss")}', {this.ProductsAmount})";
            //this.Command.CommandText = $"INSERT INTO pertenece (id_Prod, id_Lote) VALUES ({this.Id}, {this.IdProduct})"; //Se deberia crear el lote pero al asignar, se deberia usar otra tabla(pertenece)
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
