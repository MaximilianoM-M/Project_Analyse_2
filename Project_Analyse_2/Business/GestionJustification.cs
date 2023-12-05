using Project_Analyse_2.DataAccess;
using Project_Analyse_2.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Analyse_2.Business;
public class GestionJustification
{

    private JustificationForm menu;
    private DataSet dataset;
    private JustificationDAO justificationDAO;
    private Login login;

    public GestionJustification()
    {
        ApplicationConfiguration.Initialize();
        this.menu = new JustificationForm(this);
        this.login = new Login();
        this.dataset = new DataSet();
        this.justificationDAO = new JustificationDAO(ConnectionFactory.GetConnection());



    }


    public void Start()
    {
        DialogResult result = this.login.ShowDialog();
        if (result == DialogResult.OK)
        {
            Application.Run(this.menu);
        }
        else
        {
            MessageBox.Show("Login requis, l'application va se terminer");
            Application.Exit(); // ou this.Stop();
        }
    }


    public void Stop()
    {
        Application.Exit();
    }

    public void LoadCompData()
    {
        DataTable table = this.justificationDAO.GetDataTable(this.dataset);
        this.menu.BindDataTable(table);
    }

    public void SaveCompData()
    {
        justificationDAO.SaveChanges(dataset);
        this.LoadCompData();
    }

}
