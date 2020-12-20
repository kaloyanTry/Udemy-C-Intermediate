namespace DbConnection
{
    public class SqlConnection : DbConnection
    {
        private const string _connectionName = "Sql";
        private bool _sqlConnection;

        public SqlConnection(string connectionString)
            : base(connectionString)
        {

        }
        public override void OpenConnection()
        {
            if (_isValidConnection == true && _sqlConnection == false)
            {
                System.Console.WriteLine("Sql connection open!");
                _sqlConnection = true;
            }
            else if (_isValidConnection == true && _sqlConnection == true)
            {
                System.Console.WriteLine("The Sql connection is already open");
            }

        }
        public override void CloseConnection()
        {
            if (_isValidConnection == true && _sqlConnection == true)
            {
                System.Console.WriteLine("Sql connection closed");
                _sqlConnection = false;
            }
            else if (_isValidConnection == true && _sqlConnection == false)
            {
                System.Console.WriteLine("There is no a Sql connection to close");
            }
        }

        public override void Execute(string command)
        {
            OpenConnection();
            switch (command)
            {
                case "create":
                    System.Console.WriteLine("Executing {0} -> {1}", command, _connectionName);
                    break;
                case "read":
                    System.Console.WriteLine("Executing {0} -> {1}", command, _connectionName);
                    break;
                case "update":
                    System.Console.WriteLine("Executing {0} -> {1}", command, _connectionName);
                    break;
                case "delete":
                    System.Console.WriteLine("Executing {0} -> {1}", command, _connectionName);
                    break;
                default:
                    System.Console.WriteLine();
                    throw new System.InvalidOperationException("Please insert a valid command!  :)");

            }
            CloseConnection();
        }
    }
}