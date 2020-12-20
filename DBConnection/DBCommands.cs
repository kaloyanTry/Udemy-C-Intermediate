namespace DbConnection
{
    public class DbCommand : DbConnection
    {
        public DbCommand(string stringConnection, string command, string dbms)
            : base(stringConnection, command)
        {
            if (_isValidConnection == true)
            {
                if (dbms == "sql")
                {
                    var sql = new SqlConnection(stringConnection);
                    sql.Execute(command);
                }
                else if (dbms == "oracle")
                {
                    var oracle = new OracleConnection(stringConnection);
                    oracle.Execute(command);
                }
            }
            else
            {
                System.Console.WriteLine("Please verify the parameters that you inserted. See the details that appear above. {0}", dbms);
            }
        }


        public override void OpenConnection()
        {
            throw new System.NotImplementedException();
        }

        public override void Execute(string command)
        {
            throw new System.NotImplementedException();
        }

        public override void CloseConnection()
        {

        }
    }
}