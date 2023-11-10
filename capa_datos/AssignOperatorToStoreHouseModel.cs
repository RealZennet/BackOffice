using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_datos
{
    public class AssignOperatorToStoreHouseModel : DataBaseControl
    {
        public int IDStoreHouse { get; set; }
        public int IDOperator { get; set; }

        public void Save()
        {
            try
            {
                this.Command.CommandText = $"INSERT INTO gestiona(id_operario, id_alma) VALUES(" +
                   $"{this.IDStoreHouse}, " +
                   $"{this.IDOperator})";
                this.Command.ExecuteNonQuery();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public List<AssignOperatorToStoreHouseModel> GetAllOperatorsAssignedToStoreHouses()
        {
            this.Command.CommandText = "SELECT * FROM gestiona";
            this.Reader = this.Command.ExecuteReader();

            List<AssignOperatorToStoreHouseModel> result = new List<AssignOperatorToStoreHouseModel>();
            while (this.Reader.Read())
            {
                AssignOperatorToStoreHouseModel assignedoperatorstostorehouse = new AssignOperatorToStoreHouseModel();
                assignedoperatorstostorehouse.IDStoreHouse = Int32.Parse(this.Reader["id_alma"].ToString());
                assignedoperatorstostorehouse.IDOperator = Int32.Parse(this.Reader["id_operario"].ToString());
                result.Add(assignedoperatorstostorehouse);
            }
            this.Reader.Close();
            return result;
        }
        public void Delete()
        {
            this.Command.CommandText = $"DELETE FROM gestiona WHERE id_operario = {this.IDOperator}";
            this.Command.ExecuteNonQuery();
        }
    }
}

