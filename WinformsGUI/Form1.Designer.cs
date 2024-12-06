namespace WinformsGUI
{
    partial class btnUppdateraDataGridViewFordon
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
            btnLaggTill = new Button();
            btnTaBortFordon = new Button();
            dataGridViewFordon = new DataGridView();
            lblDataGridViewFordon = new Label();
            btnUppdateraGrid = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFordon).BeginInit();
            SuspendLayout();
            // 
            // btnLaggTill
            // 
            btnLaggTill.Location = new Point(0, 371);
            btnLaggTill.Name = "btnLaggTill";
            btnLaggTill.Size = new Size(98, 23);
            btnLaggTill.TabIndex = 0;
            btnLaggTill.Text = "Lägg till fordon";
            btnLaggTill.UseVisualStyleBackColor = true;
            btnLaggTill.Click += btnLaggTill_Click;
            // 
            // btnTaBortFordon
            // 
            btnTaBortFordon.Location = new Point(104, 371);
            btnTaBortFordon.Name = "btnTaBortFordon";
            btnTaBortFordon.Size = new Size(93, 23);
            btnTaBortFordon.TabIndex = 1;
            btnTaBortFordon.Text = "Ta bort fordon";
            btnTaBortFordon.UseVisualStyleBackColor = true;
            btnTaBortFordon.Click += btnTaBortFordon_Click;
            // 
            // dataGridViewFordon
            // 
            dataGridViewFordon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFordon.Location = new Point(0, 27);
            dataGridViewFordon.MultiSelect = false;
            dataGridViewFordon.Name = "dataGridViewFordon";
            dataGridViewFordon.ReadOnly = true;
            dataGridViewFordon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFordon.Size = new Size(788, 329);
            dataGridViewFordon.TabIndex = 3;
            dataGridViewFordon.CellClick += dataGridViewFordon_CellClick;
            // 
            // lblDataGridViewFordon
            // 
            lblDataGridViewFordon.AutoSize = true;
            lblDataGridViewFordon.Location = new Point(0, 9);
            lblDataGridViewFordon.Name = "lblDataGridViewFordon";
            lblDataGridViewFordon.Size = new Size(45, 15);
            lblDataGridViewFordon.TabIndex = 4;
            lblDataGridViewFordon.Text = "Fordon";
            // 
            // btnUppdateraGrid
            // 
            btnUppdateraGrid.Location = new Point(626, 371);
            btnUppdateraGrid.Name = "btnUppdateraGrid";
            btnUppdateraGrid.Size = new Size(162, 32);
            btnUppdateraGrid.TabIndex = 5;
            btnUppdateraGrid.Text = "Uppdatera DataGridView";
            btnUppdateraGrid.UseVisualStyleBackColor = true;
            btnUppdateraGrid.Click += btnUppdateraGrid_Click;
            // 
            // btnUppdateraDataGridViewFordon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUppdateraGrid);
            Controls.Add(lblDataGridViewFordon);
            Controls.Add(dataGridViewFordon);
            Controls.Add(btnTaBortFordon);
            Controls.Add(btnLaggTill);
            Name = "btnUppdateraDataGridViewFordon";
            Text = "Fordon";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFordon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLaggTill;
        private Button btnTaBortFordon;
        
        private DataGridView dataGridViewFordon;
        private Label lblDataGridViewFordon;
        private Button btnUppdateraGrid;
    }
}
