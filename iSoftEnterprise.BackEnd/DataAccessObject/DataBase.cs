using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
  public class DataBase
  {
    SqlConnection cnxDataBase;

    public DataBase()
    { cnxDataBase = new SqlConnection(); }

    public DataBase(string connectionString)
    { cnxDataBase = new SqlConnection(connectionString); }

    public DataBase(string dataSource, string dataBase, string user, string password)
    {
      string connectionString =
      "Data Source=" + dataSource + ";Initial Catalog=" + dataBase + ";User Id=" + user + ";Password=" + password + "";
      cnxDataBase = new SqlConnection(connectionString);
    }

    public void Open()
    { cnxDataBase.Open(); }

    public void Close()
    { cnxDataBase.Close(); }

    public SqlTransaction BeginTransaction()
    { return cnxDataBase.BeginTransaction(); }

    public SqlTransaction BeginTransaction(string transactionName)
    { return cnxDataBase.BeginTransaction(transactionName); }

    public SqlTransaction BeginTransaction(System.Data.IsolationLevel iso)
    { return cnxDataBase.BeginTransaction(iso); }

    public SqlTransaction BeginTransaction(System.Data.IsolationLevel iso, string transactionName)
    { return cnxDataBase.BeginTransaction(iso, transactionName); }

    public SqlCommand CreateCommand()
    { return cnxDataBase.CreateCommand(); }

    public System.Data.DataTable GetSchema()
    { return cnxDataBase.GetSchema(); }

    public System.Data.DataTable GetSchema(string collectionName)
    { return cnxDataBase.GetSchema(collectionName); }

    public System.Data.DataTable GetSchema(string collectionName, string[] restrictionValues)
    { return cnxDataBase.GetSchema(collectionName, restrictionValues); }

    public string AccessToken 
    { get { return cnxDataBase.AccessToken; } set { cnxDataBase.AccessToken = value; } }

    public string ConnectionString { get { return cnxDataBase.ConnectionString; } set { cnxDataBase.ConnectionString = value; } }

    public System.Data.ConnectionState State { get { return cnxDataBase.State; } }

  }
}
