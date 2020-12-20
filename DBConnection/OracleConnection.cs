namespace DbConnection
{
    public class OracleConnection : DbConnection
    {
        private const string _connectionName = "Oracle";
        private bool _oracleConnection;

        public OracleConnection(string connectionString)
            : base(connectionString)
        {

        }
        public override void OpenConnection()
        {
            if (_isValidConnection == true && _oracleConnection == false)
            {
                System.Console.WriteLine("Oracle connection open!");
                _oracleConnection = true;
            }
            else if (_isValidConnection == true && _oracleConnection == true)
            {
                System.Console.WriteLine("The Oracle connection is already open");
            }

        }
        public override void CloseConnection()
        {
            if (_isValidConnection == true && _oracleConnection == true)
            {
                System.Console.WriteLine("Oracle connection closed");
                _oracleConnection = false;
            }
            else if (_isValidConnection == true && _oracleConnection == false)
            {
                System.Console.WriteLine("There is no a Oracle connection to close");
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
            }
            CloseConnection();
        }
    }
}