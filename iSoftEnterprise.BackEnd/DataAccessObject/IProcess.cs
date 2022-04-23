using System.Data;
using System.Data.SqlClient;

namespace DataAccessObject
{
  public interface IProcess
  {

    public void Cancel();

    protected SqlParameter CreateParameter();

    public int ExecuteNonQuery();

    public SqlDataReader ExecuteReader();

    public void Prepare();

    public void ResetCommandTimeout();

    public string CommandText { get; set; }

    public int CommandTimeout { get; set; }

    public CommandType CommandType { get; set; }

    public SqlConnection Connection { get; set; }



  }
}
