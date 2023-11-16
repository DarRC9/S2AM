using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccesComponent
{
    public class DataConnection
    {
        private readonly string connectionString;
        private SqlConnection sqlConnection;
        private DataSet dataSet;
        public DataConnection()
        {
            if (ConfigurationManager.ConnectionStrings["DBConnectionString"] != null)
            {
                connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            }
            else
            {
                
            }
        }
     
        private void Connect()
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(connectionString);
            }
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
        }
        private void Disconnect()
        {
            if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public DataSet GetTable(string tableName)
        {
            Connect();
            dataSet = new DataSet();
            string query = string.Format("Select * from {0}", tableName);
            
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
            {
                adapter.Fill(dataSet);
            }

            Disconnect();
            return dataSet;
        }
        public DataSet GetQueryData(string query)
        {
            Connect();
            dataSet = new DataSet();

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
            {
                adapter.Fill(dataSet);
            }

            Disconnect();
            return dataSet;
        }
        public DataSet GetQueryData(string query, string tableName)
        {
            Connect();
            dataSet = new DataSet();

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
            {
                adapter.Fill(dataSet, tableName);
            }

            Disconnect();
            return dataSet;
        }
        public void UpdateData(string query, DataSet dataSet)
        {
            Connect();

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
            {
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(dataSet.Tables[0]);
            }

            Disconnect();
        }
        protected void ExecuteQuery(string query)
        {
            Connect();

            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.ExecuteNonQuery();
            }

            Disconnect();
        }
    }
}
