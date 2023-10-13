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
        public int IDBatch { get; set; }
        public DateTime DateOfCreation { get; set; }
        public DateTime ShippingDate { get; set; }
        public int IDShipp { get; set; }
        public bool ActivedBatch { get; set; }

        public void Save()
        {
            try {
            this.Command.CommandText = $"INSERT INTO lote (fech_Crea, fech_Entre, id_Des, bajalogica) VALUES " +
                $"('{this.DateOfCreation.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                $"'{this.ShippingDate.ToString("yyyy-MM-dd HH:mm:ss")}'," +
                $"{this.IDShipp}," +
                $"{this.ActivedBatch})";
            this.Command.ExecuteNonQuery();

            this.Command.CommandText = "SELECT last_insert_id()";
            this.IDBatch = Convert.ToInt32(this.Command.ExecuteScalar());
            }catch(Exception ex)
            {
                throw new Exception("Revisa los datos ingresados.");
            }
        }

        public List<ModelBatch> GetAllLots()
        {
            this.Command.CommandText = $"SELECT * FROM lote";
            this.Reader = this.Command.ExecuteReader();

            List<ModelBatch> result = new List<ModelBatch>();
            while (this.Reader.Read())
            {
                ModelBatch lote = new ModelBatch();
                lote.IDBatch = Int32.Parse(this.Reader["id_Lote"].ToString());
                lote.DateOfCreation = DateTime.Parse(this.Reader["fech_Crea"].ToString());
                lote.ShippingDate = DateTime.Parse(this.Reader["fech_Entre"].ToString());
                lote.IDShipp = Int32.Parse(this.Reader["id_Des"].ToString());
                lote.ActivedBatch = Convert.ToBoolean(this.Reader["bajalogica"]);
                result.Add(lote);
            }
            this.Reader.Close();
            return result;
        }
        public void DeleteLots()
        {
            this.Command.CommandText = $"DELETE FROM lote WHERE id_Lote = {this.IDBatch}";
            this.Command.ExecuteNonQuery();
        }

        public bool CheckIfBatchExists(int id)
        {
            this.Command.CommandText = $"SELECT COUNT(*) FROM lote WHERE id_Lote = {id}";
            object result = this.Command.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                if (int.TryParse(result.ToString(), out int rowCount))
                {
                    return rowCount > 0;
                }
            }
            return false;
        }

    }
}
