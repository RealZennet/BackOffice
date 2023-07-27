using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class ModelProduct:DataBaseControl
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public int PesoProducto { get; set; }
        public int CantidadProducto { get; set; }
        public string DescripcionProducto { get; set; }

        public void Save()
        {
            this.Command.CommandText = $"INSERT INTO producto(nom_Prod, peso_Prod, cant_Prod, desc_Prod) VALUES(" +
                $"'{this.NombreProducto}', " +
                $"{this.PesoProducto}, " +
                $"{this.CantidadProducto}, " +
                $"'{this.DescripcionProducto}')";
            this.Command.ExecuteNonQuery();
        }

        public List<ModelProduct> GetAllItems()
        {
            this.Command.CommandText = "SELECT * FROM producto";
            this.Reader = this.Command.ExecuteReader();

            List<ModelProduct> result = new List<ModelProduct>();
            while (this.Reader.Read())
            {
                ModelProduct producto = new ModelProduct();
                producto.Id = Int32.Parse(this.Reader["id_Prod"].ToString());
                producto.NombreProducto = this.Reader["nom_Prod"].ToString();
                producto.PesoProducto = Int32.Parse(this.Reader["peso_Prod"].ToString());
                producto.CantidadProducto = Int32.Parse(this.Reader["cant_Prod"].ToString());
                producto.DescripcionProducto = this.Reader["desc_Prod"].ToString();
                result.Add(producto);
            }
            return result;
        }
        public void Delete()
        {
            this.Command.CommandText = $"DELETE FROM producto WHERE id_Prod = {this.Id}";
            this.Command.ExecuteNonQuery();
        }

    }
}
