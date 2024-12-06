namespace WinformsGUI
{
    partial class FormAddFordon
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
            txtBatteriStatus = new TextBox();
            txtID = new TextBox();
            txtFordonsStatus = new TextBox();
            txtFordonsTyp = new TextBox();
            lablID = new Label();
            lblFordonsTyp = new Label();
            lblBatteriStatus = new Label();
            lblFordonsStatus = new Label();
            btnAvsluta = new Button();
            Spara = new Button();
            SuspendLayout();
            // 
            // txtBatteriStatus
            // 
            txtBatteriStatus.Location = new Point(143, 147);
            txtBatteriStatus.Name = "txtBatteriStatus";
            txtBatteriStatus.Size = new Size(265, 23);
            txtBatteriStatus.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Location = new Point(143, 49);
            txtID.Name = "txtID";
            txtID.Size = new Size(265, 23);
            txtID.TabIndex = 1;
            // 
            // txtFordonsStatus
            // 
            txtFordonsStatus.Location = new Point(143, 198);
            txtFordonsStatus.Name = "txtFordonsStatus";
            txtFordonsStatus.Size = new Size(265, 23);
            txtFordonsStatus.TabIndex = 2;
            // 
            // txtFordonsTyp
            // 
            txtFordonsTyp.Location = new Point(143, 90);
            txtFordonsTyp.Name = "txtFordonsTyp";
            txtFordonsTyp.Size = new Size(265, 23);
            txtFordonsTyp.TabIndex = 3;
            // 
            // lablID
            // 
            lablID.AutoSize = true;
            lablID.Location = new Point(55, 52);
            lablID.Name = "lablID";
            lablID.Size = new Size(21, 15);
            lablID.TabIndex = 4;
            lablID.Text = "ID:";
            // 
            // lblFordonsTyp
            // 
            lblFordonsTyp.AutoSize = true;
            lblFordonsTyp.Location = new Point(55, 98);
            lblFordonsTyp.Name = "lblFordonsTyp";
            lblFordonsTyp.Size = new Size(71, 15);
            lblFordonsTyp.TabIndex = 5;
            lblFordonsTyp.Text = "FordonsTyp:";
            // 
            // lblBatteriStatus
            // 
            lblBatteriStatus.AutoSize = true;
            lblBatteriStatus.Location = new Point(55, 155);
            lblBatteriStatus.Name = "lblBatteriStatus";
            lblBatteriStatus.Size = new Size(76, 15);
            lblBatteriStatus.TabIndex = 6;
            lblBatteriStatus.Text = "BatteriStatus:";
            // 
            // lblFordonsStatus
            // 
            lblFordonsStatus.AutoSize = true;
            lblFordonsStatus.Location = new Point(55, 201);
            lblFordonsStatus.Name = "lblFordonsStatus";
            lblFordonsStatus.Size = new Size(85, 15);
            lblFordonsStatus.TabIndex = 7;
            lblFordonsStatus.Text = "FordonsStatus:";
            // 
            // btnAvsluta
            // 
            btnAvsluta.Location = new Point(183, 239);
            btnAvsluta.Name = "btnAvsluta";
            btnAvsluta.Size = new Size(111, 23);
            btnAvsluta.TabIndex = 8;
            btnAvsluta.Text = "Avsluta";
            btnAvsluta.UseVisualStyleBackColor = true;
            btnAvsluta.Click += btnAvsluta_Click;
            // 
            // Spara
            // 
            Spara.Location = new Point(300, 239);
            Spara.Name = "Spara";
            Spara.Size = new Size(108, 23);
            Spara.TabIndex = 9;
            Spara.Text = "Spara";
            Spara.UseVisualStyleBackColor = true;
            Spara.Click += Spara_Click;
            // 
            // FormAddFordon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 286);
            Controls.Add(Spara);
            Controls.Add(btnAvsluta);
            Controls.Add(lblFordonsStatus);
            Controls.Add(lblBatteriStatus);
            Controls.Add(lblFordonsTyp);
            Controls.Add(lablID);
            Controls.Add(txtFordonsTyp);
            Controls.Add(txtFordonsStatus);
            Controls.Add(txtID);
            Controls.Add(txtBatteriStatus);
            Name = "FormAddFordon";
            Text = "FormAddFordon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBatteriStatus;
        private TextBox txtID;
        private TextBox txtFordonsStatus;
        private TextBox txtFordonsTyp;
        private Label lablID;
        private Label lblFordonsTyp;
        private Label lblBatteriStatus;
        private Label lblFordonsStatus;
        private Button btnAvsluta;
        private Button Spara;
    }
}