using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Analyse_2.DataAccess;
public class JustificationDAO
{
    private SqlConnection connection;
    private SqlDataAdapter adapter;

    private static readonly string TABLE_NAME = "dbo.gestion_justification";
    private static readonly string SELECT_QUERY = $"SELECT * FROM {TABLE_NAME};";
    private static readonly string INSERT_QUERY = $"INSERT INTO {TABLE_NAME}  ( NomEtudiant, Justification,Commentaire) " +
        $"VALUES ( @NomEtudiant, @Justification, @Commentaire); SELECT * FROM {TABLE_NAME} WHERE Id = SCOPE_IDENTITY();";
    private static readonly string UPDATE_QUERY = $"UPDATE {TABLE_NAME} " +
        $"SET NomEtudiant = @NomEtudiant, " +
        $"Justification = @Justification, " +
         $"Commentaire = @Commentaire " +
        $"WHERE Id = @Id";



    private static readonly string DELETE_QUERY = $"DELETE FROM {TABLE_NAME} WHERE Id = @Id;";

    public JustificationDAO(SqlConnection connection)
    {
        this.connection = connection;
        this.adapter = CreateDataAdapter();
    }

    private SqlDataAdapter CreateDataAdapter()
    {
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        dataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

        dataAdapter.SelectCommand = new SqlCommand(SELECT_QUERY, this.connection);

        dataAdapter.InsertCommand = new SqlCommand(INSERT_QUERY, this.connection);

        dataAdapter.InsertCommand.UpdatedRowSource = UpdateRowSource.FirstReturnedRecord;
        dataAdapter.InsertCommand.Parameters.Add("@NomEtudiant", SqlDbType.NVarChar, 64, "NomEtudiant");
        dataAdapter.InsertCommand.Parameters.Add("@Justification", SqlDbType.NVarChar, 200, "Justification");
        dataAdapter.InsertCommand.Parameters.Add("@Commentaire", SqlDbType.NVarChar, 200, "Commentaire");


        dataAdapter.UpdateCommand = new SqlCommand(UPDATE_QUERY, this.connection);

        dataAdapter.UpdateCommand.Parameters.Add("@NomEtudiant", SqlDbType.NVarChar, 64, "NomEtudiant");
        dataAdapter.UpdateCommand.Parameters.Add("@Justification", SqlDbType.NVarChar, 200, "Justification");
        dataAdapter.UpdateCommand.Parameters.Add("@Commentaire", SqlDbType.NVarChar, 200, "Commentaire");


        SqlCommand sqlCommand = new SqlCommand(DELETE_QUERY, this.connection);
        dataAdapter.DeleteCommand = sqlCommand;
        dataAdapter.DeleteCommand.Parameters.Add("@Id", SqlDbType.Int, 7, "Id");


        return dataAdapter;
    }

    public DataTable GetDataTable(DataSet dataSet)
    {
        this.LoadData(dataSet);
        DataTable dt = dataSet.Tables[TABLE_NAME] ?? throw new Exception("table does not exist in dataset.");
        this.ConfigureDataTable(dt);
        return dt;
    }


    public void LoadData(DataSet dataSet)
    {
        if (this.connection.State != ConnectionState.Open)
        {
            this.connection.Open();
        }


        if (dataSet.Tables.Contains(TABLE_NAME))
        {
            dataSet.Tables[TABLE_NAME]?.Clear();
        }

        adapter.Fill(dataSet, TABLE_NAME);
        DataTable table = dataSet.Tables[TABLE_NAME] ?? throw new Exception("table does not exist in dataset.");
    }

    private void ConfigureDataTable(DataTable table)
    {
        DataColumn idColumn = table.Columns["Id"] ?? throw new Exception("Column [Id] does not exist");
        idColumn.ReadOnly = true;
        idColumn.AllowDBNull = true;

        DataColumn NomEtudiantColumn = table.Columns["NomEtudiant"] ?? throw new Exception("Column [NomEtudiant] does not exist");
        NomEtudiantColumn.MaxLength = 64;

        DataColumn JustificationColumn = table.Columns["Justification"] ?? throw new Exception("Column [Justification] does not exist");
        JustificationColumn.MaxLength = 200;

        DataColumn CommentaireColumn = table.Columns["Commentaire"] ?? throw new Exception("Column [Commentaire] does not exist");
        CommentaireColumn.MaxLength = 200;

        DataColumn DateCreatedColumn = table.Columns["DateCreated"] ?? throw new Exception("Column [DateCreated] does not exist");
        DateCreatedColumn.AllowDBNull = true;
        DateCreatedColumn.ReadOnly = true;

    }

    public void SaveChanges(DataSet dataSet)
    {
        if (this.connection.State != ConnectionState.Open)
        {
            this.connection.Open();
        }

        adapter.Update(dataSet, TABLE_NAME);
      
    }


}
