using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace Tarea_3_corta.Models
{
    public class Connection
    {
        private String dataSource;
        private String userID;
        private String initialCatalog;

        public Connection(String pDataSource, String pUserID, String pInitialCatalog)
        {
            dataSource = pDataSource;
            userID = pUserID;
            initialCatalog = pInitialCatalog;
        }

        public void registerCarrer(String pNombre, String pUbication, String pEncargado, int pIdentificator, String pPassword)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = dataSource;
            builder.UserID = userID;
            builder.Password = pPassword;
            builder.InitialCatalog = initialCatalog;
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            connection.Open();
            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append("insertCarrer ");
            sb.Append("'" + pNombre + "'");
            sb.Append(",");
            sb.Append("'" + pUbication + "'");
            sb.Append(",");
            sb.Append("'" + pEncargado + "'");
            sb.Append(",");
            sb.Append(pIdentificator);
            String sql = sb.ToString();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
        }

        public void updateCarrer(String pNombre, String pUbication, String pEncargado, int pIdentificator, String pPassword)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = dataSource;
            builder.UserID = userID;
            builder.Password = pPassword;
            builder.InitialCatalog = initialCatalog;
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            connection.Open();
            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append("updateCarrer ");
            sb.Append("'" + pNombre + "'");
            sb.Append(",");
            sb.Append("'" + pUbication + "'");
            sb.Append(",");
            sb.Append("'" + pEncargado + "'");
            sb.Append(",");
            sb.Append(pIdentificator);
            String sql = sb.ToString();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
        }

        public void deleteCarrer(int pIdentificator, String pPassword)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = dataSource;
            builder.UserID = userID;
            builder.Password = pPassword;
            builder.InitialCatalog = initialCatalog;
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            connection.Open();
            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append("deleteCarrer ");
            
            sb.Append(pIdentificator);
            String sql = sb.ToString();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
        }

        public List<Carrer> getCarrer(String pPassword)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = dataSource;
            builder.UserID = userID;
            builder.Password = pPassword;
            builder.InitialCatalog = initialCatalog;
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            connection.Open();
            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append("getCarrer");

            String sql = sb.ToString();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Carrer> listCarrer = new List<Carrer>();
            while (reader.Read())
            {
                Carrer newCarrer = new Carrer(reader.GetString(0), reader.GetString(1), reader.GetString(3), reader.GetInt32(4));
                listCarrer.Add(newCarrer);
            }
            return listCarrer;
        }

    }
}