using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Analyse_2.DataAccess;
public class ConnectionFactory
{
    private static SqlConnection? CONNECTION;

    public static SqlConnection GetConnection()
    {
        CONNECTION ??= new SqlConnection("Server=.\\SQL2022DEV;TrustServerCertificate=true;Integrated Security=true;Database=gestion_justification");
        return CONNECTION;
    }

}
