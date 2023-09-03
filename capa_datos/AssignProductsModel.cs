using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class AssignProductsModel : DataBaseControl
    {
        public int IDProduct { get; set; }
        public int IDBatch { get; set; }

        public void Save()
        {
            try
            {
                this.Command.CommandText = $"INSERT INTO pertenece (id_Prod, id_Lote) VALUES ({this.IDProduct}, {this.IDBatch})";
                this.Command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                
            }
        }

        public List<AssignProductsModel> TodosLosItems()
        {
            this.Command.CommandText = "SELECT * FROM pertenece";
            this.Reader = this.Command.ExecuteReader();

            List<AssignProductsModel> result = new List<AssignProductsModel>();
            while (this.Reader.Read())
            {
                AssignProductsModel assignedProduct = new AssignProductsModel();
                assignedProduct.IDBatch = Int32.Parse(this.Reader["id_Lote"].ToString());
                assignedProduct.IDProduct = Int32.Parse(this.Reader["id_Prod"].ToString());
                result.Add(assignedProduct);
            }
            return result;
        }

        public void Delete()
        {
            this.Command.CommandText = $"DELETE FROM pertenece WHERE id_Lote = {this.IDBatch}";
            this.Command.ExecuteNonQuery();
        }

    }
}
