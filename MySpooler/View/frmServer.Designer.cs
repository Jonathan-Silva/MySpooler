namespace MySpooler.View
{
    partial class frmServer
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
            this.dgFila = new System.Windows.Forms.DataGridView();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.nmCopy = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.File = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileDir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgFila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCopy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFila
            // 
            this.dgFila.AllowUserToAddRows = false;
            this.dgFila.AllowUserToDeleteRows = false;
            this.dgFila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.File,
            this.Type,
            this.FileDir});
            this.dgFila.Location = new System.Drawing.Point(12, 35);
            this.dgFila.Name = "dgFila";
            this.dgFila.ReadOnly = true;
            this.dgFila.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFila.Size = new System.Drawing.Size(646, 343);
            this.dgFila.TabIndex = 0;
            this.dgFila.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFila_CellClick);
            this.dgFila.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFila_CellDoubleClick);
            // 
            // btImprimir
            // 
            this.btImprimir.Location = new System.Drawing.Point(522, 404);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(136, 39);
            this.btImprimir.TabIndex = 1;
            this.btImprimir.Text = "&IMPRIMIR";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Location = new System.Drawing.Point(370, 404);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(136, 39);
            this.btDeletar.TabIndex = 2;
            this.btDeletar.Text = "&DELETAR";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(218, 404);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(136, 39);
            this.btLimpar.TabIndex = 3;
            this.btLimpar.Text = "&LIMPAR FILA";
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(522, 469);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(136, 39);
            this.btVoltar.TabIndex = 4;
            this.btVoltar.Text = "&VOLTAR";
            this.btVoltar.UseVisualStyleBackColor = true;
            // 
            // nmCopy
            // 
            this.nmCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCopy.Location = new System.Drawing.Point(16, 417);
            this.nmCopy.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nmCopy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmCopy.Name = "nmCopy";
            this.nmCopy.Size = new System.Drawing.Size(121, 26);
            this.nmCopy.TabIndex = 5;
            this.nmCopy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmCopy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Copias";
            // 
            // File
            // 
            this.File.HeaderText = "Arquivo";
            this.File.Name = "File";
            this.File.ReadOnly = true;
            this.File.Width = 400;
            // 
            // Type
            // 
            this.Type.HeaderText = "Tipo";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 200;
            // 
            // FileDir
            // 
            this.FileDir.HeaderText = "Diretório";
            this.FileDir.Name = "FileDir";
            this.FileDir.ReadOnly = true;
            this.FileDir.Visible = false;
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmCopy);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.dgFila);
            this.Name = "frmServer";
            this.Text = "Servidor de Impressão";
            this.Load += new System.EventHandler(this.frmServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCopy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFila;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.NumericUpDown nmCopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn File;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileDir;
    }
}