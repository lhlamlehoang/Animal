using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Animals
    {
        MY_DB mydb = new MY_DB();

        public bool addAnimal(int id, string name, string ability, string food, MemoryStream image)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Animals(id, name,ability,food,image) VALUES (@id, @name,@ability,@food,@image)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@ability", SqlDbType.NVarChar).Value = ability;
            command.Parameters.Add("@food", SqlDbType.NVarChar).Value = food;
            command.Parameters.Add("@image", SqlDbType.Image).Value = image.ToArray();


            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }

        public DataTable getAnimals(string name)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Animals WHERE name = '"+ name + "'", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
