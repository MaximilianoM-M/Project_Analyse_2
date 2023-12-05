namespace Project_Analyse_2.GUI;

partial class Login
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        controlPanel = new System.Windows.Forms.Panel();
        btnLogin = new System.Windows.Forms.Button();
        btnLeave = new System.Windows.Forms.Button();
        txtPassword = new System.Windows.Forms.TextBox();
        passwordLabel = new System.Windows.Forms.Label();
        txtUsername = new System.Windows.Forms.TextBox();
        usernameLabel = new System.Windows.Forms.Label();
        tableLayoutPanel1.SuspendLayout();
        controlPanel.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
        tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
        tableLayoutPanel1.Controls.Add(controlPanel, 1, 0);
        tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new System.Drawing.Size(350, 361);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // controlPanel
        // 
        controlPanel.Controls.Add(btnLogin);
        controlPanel.Controls.Add(btnLeave);
        controlPanel.Controls.Add(txtPassword);
        controlPanel.Controls.Add(passwordLabel);
        controlPanel.Controls.Add(txtUsername);
        controlPanel.Controls.Add(usernameLabel);
        controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        controlPanel.Location = new System.Drawing.Point(79, 23);
        controlPanel.Name = "controlPanel";
        controlPanel.Size = new System.Drawing.Size(192, 315);
        controlPanel.TabIndex = 0;
        // 
        // btnLogin
        // 
        btnLogin.Location = new System.Drawing.Point(26, 198);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new System.Drawing.Size(149, 23);
        btnLogin.TabIndex = 1;
        btnLogin.Text = "Se connecter";
        btnLogin.UseVisualStyleBackColor = true;
        btnLogin.Click += btnLogin_Click;
        // 
        // btnLeave
        // 
        btnLeave.Location = new System.Drawing.Point(26, 258);
        btnLeave.Name = "btnLeave";
        btnLeave.Size = new System.Drawing.Size(149, 20);
        btnLeave.TabIndex = 4;
        btnLeave.Text = "Quitter";
        btnLeave.UseVisualStyleBackColor = true;
        btnLeave.Click += btnLeave_Click;
        // 
        // txtPassword
        // 
        txtPassword.Location = new System.Drawing.Point(26, 113);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.PlaceholderText = "Password";
        txtPassword.Size = new System.Drawing.Size(149, 23);
        txtPassword.TabIndex = 3;
        // 
        // passwordLabel
        // 
        passwordLabel.AutoSize = true;
        passwordLabel.Location = new System.Drawing.Point(26, 82);
        passwordLabel.Name = "passwordLabel";
        passwordLabel.Size = new System.Drawing.Size(66, 15);
        passwordLabel.TabIndex = 2;
        passwordLabel.Text = "Password : ";
        // 
        // txtUsername
        // 
        txtUsername.Location = new System.Drawing.Point(26, 46);
        txtUsername.Name = "txtUsername";
        txtUsername.PlaceholderText = "Username";
        txtUsername.Size = new System.Drawing.Size(149, 23);
        txtUsername.TabIndex = 1;
        // 
        // usernameLabel
        // 
        usernameLabel.AutoSize = true;
        usernameLabel.Location = new System.Drawing.Point(26, 19);
        usernameLabel.Name = "usernameLabel";
        usernameLabel.Size = new System.Drawing.Size(69, 15);
        usernameLabel.TabIndex = 0;
        usernameLabel.Text = "Username : ";
        // 
        // Login
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(350, 361);
        Controls.Add(tableLayoutPanel1);
        Name = "Login";
        Text = "Login";
        tableLayoutPanel1.ResumeLayout(false);
        controlPanel.ResumeLayout(false);
        controlPanel.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel controlPanel;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.Label usernameLabel;
    private System.Windows.Forms.Button btnLeave;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label passwordLabel;
    private System.Windows.Forms.Button btnLogin;
}