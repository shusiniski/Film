namespace Film
{
    partial class Form1
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
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtFN = new System.Windows.Forms.TextBox();
            this.TxtRm = new System.Windows.Forms.TextBox();
            this.TxtDT = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv
            // 
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.Dgv.Location = new System.Drawing.Point(228, 69);
            this.Dgv.Name = "Dgv";
            this.Dgv.Size = new System.Drawing.Size(515, 150);
            this.Dgv.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Film Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Rooms";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Data Time";
            this.Column3.Name = "Column3";
            // 
            // TxtFN
            // 
            this.TxtFN.Location = new System.Drawing.Point(24, 69);
            this.TxtFN.Name = "TxtFN";
            this.TxtFN.Size = new System.Drawing.Size(140, 20);
            this.TxtFN.TabIndex = 1;
            // 
            // TxtRm
            // 
            this.TxtRm.Location = new System.Drawing.Point(24, 105);
            this.TxtRm.Name = "TxtRm";
            this.TxtRm.Size = new System.Drawing.Size(140, 20);
            this.TxtRm.TabIndex = 2;
            // 
            // TxtDT
            // 
            this.TxtDT.Location = new System.Drawing.Point(24, 143);
            this.TxtDT.Name = "TxtDT";
            this.TxtDT.Size = new System.Drawing.Size(140, 20);
            this.TxtDT.TabIndex = 3;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(88, 198);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 429);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtDT);
            this.Controls.Add(this.TxtRm);
            this.Controls.Add(this.TxtFN);
            this.Controls.Add(this.Dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox TxtFN;
        private System.Windows.Forms.TextBox TxtRm;
        private System.Windows.Forms.TextBox TxtDT;
        private System.Windows.Forms.Button BtnSave;
    }
}