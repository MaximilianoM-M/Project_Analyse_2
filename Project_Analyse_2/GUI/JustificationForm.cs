using Project_Analyse_2.Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project_Analyse_2.GUI;


public partial class JustificationForm : Form
{
    private GestionJustification menu;
    public JustificationForm(GestionJustification menu)
    {
        this.menu = menu;
        InitializeComponent();
    }


    private void buttonChargerDonnee_Click(object sender, EventArgs e)
    {
        this.menu.LoadCompData();
    }

    private void buttonSauvegarder_Click(object sender, EventArgs e)
    {
        this.menu.SaveCompData();
    }

    private void buttonQuitter_Click(object sender, EventArgs e)
    {
        this.menu.Stop();
    }

    public void BindDataTable(DataTable dt)
    {
        this.dataGridView1.DataSource = dt;
        this.dataGridView1.Refresh();
    }
}
