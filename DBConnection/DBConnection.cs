using System;
using System.Collections.Generic;
using System.Text;

namespace DbConnection
{
    public abstract class DbConnection
    {
        private bool _isStringConnectionValid;
        private bool _isCommandValid;
        public bool _isValidConnection;
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }


        public DbConnection(string stringConnection)
        {
            IsStringConnectionValid(stringConnection);
            if (_isStringConnectionValid == true)
            {
                _isValidConnection = true;
            }
            else
            {
                _isValidConnection = false;
            }
        }
        public DbConnection(string stringConnection, string command)
            : this(stringConnection)
        {
            IsCommandValid(command);
            if (_isStringConnectionValid == true && _isCommandValid == true)
            {
                _isValidConnection = true;
            }
            else
            {
                _isValidConnection = false;
            }
        }


        public abstract void OpenConnection();
        public abstract void CloseConnection();
        public abstract void Execute(string command);

        public bool IsCommandValid(string command)
        {
            if (command == "create"
                || command == "read"
                || command == "update"
                || command == "delete")
            {
                _isCommandValid = true;
                return true;
            }
            else
                Console.WriteLine("Please insert a valid command : ) -----> {0} is not valid", command);
            _isCommandValid = false;
            return false;
        }

        public bool IsStringConnectionValid(string stringConnection)
        {
            if (stringConnection == null || stringConnection == "")
            {
                Console.WriteLine("The connectionString should not be empty or null");
                _isStringConnectionValid = false;
                return false;
            }
            else
            {
                _isStringConnectionValid = true;
                return true;
            }
        }
    }
}