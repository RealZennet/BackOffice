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
        public string ProductName { get; set; }
        public int ProductWeight { get; set; }
        public string ProductDescription { get; set; }
        public bool ActivedProduct { get; set; }

        public void Save()
        {
            this.Command.CommandText = $"INSERT INTO producto(nom_Prod, peso_Prod, desc_Prod , bajalogica) VALUES(" +
                $"'{this.ProductName}', " +
                $"{this.ProductWeight}, " +
                $"'{this.ProductDescription}'," +
                $"{this.ActivedProduct})";
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
                producto.ProductName = this.Reader["nom_Prod"].ToString();
                producto.ProductWeight = Int32.Parse(this.Reader["peso_Prod"].ToString());
                producto.ProductDescription = this.Reader["desc_Prod"].ToString();
                producto.ActivedProduct = Convert.ToBoolean(this.Reader["bajalogica"].ToString());
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
