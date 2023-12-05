using Microsoft.Data.SqlClient;
using Project_Analyse_2.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Analyse_2.GUI;
using Project_Analyse_2.Business;

namespace Project_Analyse_2.GUI;
public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label1_Click_1(object sender, EventArgs e)
    {

    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        var username = txtUsername.Text;
        var password = txtPassword.Text;
        try
        {
            bool result = ComparerUsernamePassword(username, password);
            if (result)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private bool ComparerUsernamePassword(string username, string password)
    {
        var connection = ConnectionFactory.GetConnection();
        {
            connection.Open();
            string query = "SELECT Password FROM loginjustification WHERE Username = @username";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string correctPassword = reader.GetString(0);
                        if (password == correctPassword)
                        {
                            return true;
                        }
                        else
                        {
                            throw new Exception("Mauvais mot de passe");
                        }
                    }
                    else
                    {
                        throw new Exception("Username inexistant");
                    }
                }
            }
           
        }
     
    }

    private void btnLeave_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
