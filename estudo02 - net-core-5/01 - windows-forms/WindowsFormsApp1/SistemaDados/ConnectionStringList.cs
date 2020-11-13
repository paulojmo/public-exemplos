using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDados
{
    // essa classe é utilizada para obter a string 
    // de conexão com o banco de dados no appsettings.json
    // utilizada em Startup.cs 
    //************************************************
    public class ConnectionStringList
    {
        public string ConnectionString1 { get; set; }
    }
}
