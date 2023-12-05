using System.Drawing;
using System.Windows.Forms;

namespace Project_Analyse_2.GUI;

partial class JustificationForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        dataGridView1 = new DataGridView();
        buttonChargerDonnee = new Button();
        buttonSauvegarder = new Button();
        buttonQuitter = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(12, 12);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowTemplate.Height = 25;
        dataGridView1.Size = new Size(600, 202);
        dataGridView1.TabIndex = 0;
        // 
        // buttonChargerDonnee
        // 
        buttonChargerDonnee.Location = new Point(85, 246);
        buttonChargerDonnee.Name = "buttonChargerDonnee";
        buttonChargerDonnee.Size = new Size(137, 39);
        buttonChargerDonnee.TabIndex = 1;
        buttonChargerDonnee.Text = "Charger les données";
        buttonChargerDonnee.UseVisualStyleBackColor = true;
        buttonChargerDonnee.Click += buttonChargerDonnee_Click;
        // 
        // buttonSauvegarder
        // 
        buttonSauvegarder.Location = new Point(261, 246);
        buttonSauvegarder.Name = "buttonSauvegarder";
        buttonSauvegarder.Size = new Size(104, 39);
        buttonSauvegarder.TabIndex = 2;
        buttonSauvegarder.Text = "Sauvegarder";
        buttonSauvegarder.UseVisualStyleBackColor = true;
        buttonSauvegarder.Click += buttonSauvegarder_Click;
        // 
        // buttonQuitter
        // 
        buttonQuitter.Location = new Point(409, 246);
        buttonQuitter.Name = "buttonQuitter";
        buttonQuitter.Size = new Size(104, 39);
        buttonQuitter.TabIndex = 3;
        buttonQuitter.Text = "Quitter";
        buttonQuitter.UseVisualStyleBackColor = true;
        buttonQuitter.Click += buttonQuitter_Click;
        // 
        // JustificationForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(624, 304);
        Controls.Add(buttonQuitter);
        Controls.Add(buttonSauvegarder);
        Controls.Add(buttonChargerDonnee);
        Controls.Add(dataGridView1);
        Name = "JustificationForm";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView1;
    private Button buttonChargerDonnee;
    private Button buttonSauvegarder;
    private Button buttonQuitter;
}
