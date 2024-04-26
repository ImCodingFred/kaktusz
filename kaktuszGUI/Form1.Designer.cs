namespace kaktuszGUI
{
    partial class Form1
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
            label1 = new Label();
            tb_keres = new TextBox();
            DGV = new DataGridView();
            nev = new DataGridViewTextBoxColumn();
            nehezseg = new DataGridViewTextBoxColumn();
            vigeny = new DataGridViewTextBoxColumn();
            figeny = new DataGridViewTextBoxColumn();
            tnev = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(26, 21);
            label1.Name = "label1";
            label1.Size = new Size(156, 21);
            label1.TabIndex = 0;
            label1.Text = "Szűrés név alapján:";
            // 
            // tb_keres
            // 
            tb_keres.Location = new Point(198, 23);
            tb_keres.Name = "tb_keres";
            tb_keres.Size = new Size(549, 23);
            tb_keres.TabIndex = 1;
            tb_keres.TextChanged += tb_keres_TextChanged;
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Columns.AddRange(new DataGridViewColumn[] { nev, nehezseg, vigeny, figeny, tnev });
            DGV.Location = new Point(12, 52);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.RowHeadersVisible = false;
            DGV.Size = new Size(776, 422);
            DGV.TabIndex = 2;
            DGV.CellClick += DGV_CellClick;
            // 
            // nev
            // 
            nev.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nev.HeaderText = "Név";
            nev.Name = "nev";
            nev.ReadOnly = true;
            // 
            // nehezseg
            // 
            nehezseg.HeaderText = "Nehézség";
            nehezseg.Name = "nehezseg";
            nehezseg.ReadOnly = true;
            // 
            // vigeny
            // 
            vigeny.HeaderText = "Vízigény";
            vigeny.Name = "vigeny";
            vigeny.ReadOnly = true;
            // 
            // figeny
            // 
            figeny.HeaderText = "Fényigény";
            figeny.Name = "figeny";
            figeny.ReadOnly = true;
            // 
            // tnev
            // 
            tnev.HeaderText = "Tudományos név";
            tnev.Name = "tnev";
            tnev.ReadOnly = true;
            tnev.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 486);
            Controls.Add(DGV);
            Controls.Add(tb_keres);
            Controls.Add(label1);
            Name = "Form1";
            Text = "KaktuszokGUI";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_keres;
        private DataGridView DGV;
        private DataGridViewTextBoxColumn nev;
        private DataGridViewTextBoxColumn nehezseg;
        private DataGridViewTextBoxColumn vigeny;
        private DataGridViewTextBoxColumn figeny;
        private DataGridViewTextBoxColumn tnev;
    }
}
