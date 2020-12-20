using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //Below you can find different scenearios:
            //  

            string stringConnection = "ThisIsAValidConnectionString";
            string stringConnectionNoValid = "";
            //1- When the all the parameters are valid
            var dbCommand1 = new DbCommand(stringConnection, "delete", "oracle");
            System.Console.WriteLine("-------------------------");

            //2- When the command is not valid
            var dbCommand2 = new DbCommand(stringConnection, "deleteNoValid", "oracle");
            System.Console.WriteLine("-------------------------");

            //3- When the istrinConnection is not valid
            var dbCommand3 = new DbCommand(stringConnectionNoValid, "delete", "oracle");
            System.Console.WriteLine("-------------------------");
        }
    }
}