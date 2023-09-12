using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class StoreHouseModel: DataBaseControl
    {
        public int IDStoreHouse { get; set; }
        public bool ActivatedStoreHouse { get; set; }
        public string Street { get; set; }
        public int DoorNumber { get; set; }
        public string Corner { get; set; }

        public void Save()
        {
            int activatedValue = this.ActivatedStoreHouse ? 1 : 0;
            this.Command.CommandText = $"INSERT INTO almacen(calle, num, esq, bajalogica) VALUES(" +
               $"'{this.Street}', " +
               $"{this.DoorNumber}, " +
               $"'{this.Corner}'," +
               $"{activatedValue})";
            this.Command.ExecuteNonQuery();
        }

        public List<StoreHouseModel> GetAllStoreHouse()
        {
            this.Command.CommandText = "SELECT * FROM almacen";
            this.Reader = this.Command.ExecuteReader();

            List<StoreHouseModel> result = new List<StoreHouseModel>();
            while (this.Reader.Read())
            {
                StoreHouseModel storehouse = new StoreHouseModel();
                storehouse.IDStoreHouse = Int32.Parse(this.Reader["id_alma"].ToString());
                storehouse.Street = this.Reader["calle"].ToString();
                storehouse.DoorNumber = Int32.Parse(this.Reader["num"].ToString());
                storehouse.Corner = this.Reader["esq"].ToString();
                storehouse.ActivatedStoreHouse = this.Reader.GetBoolean("bajalogica");
                result.Add(storehouse);
            }
            this.Reader.Close();
            return result;
        }
        public void Delete()
        {
            this.Command.CommandText = $"DELETE FROM almacen WHERE id_alma = {this.IDStoreHouse}";
            this.Command.ExecuteNonQuery();
        }
    }
}
