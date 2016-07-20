namespace MySpooler.View
{
    partial class frmClient
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
            this.components = new System.ComponentModel.Container();
            this.txtDirFile = new System.Windows.Forms.Label();
            this.lpCarregar = new System.Windows.Forms.Label();
            this.lpEnviar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lpInst1 = new System.Windows.Forms.Label();
            this.lpInst2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pgBar = new System.Windows.Forms.ProgressBar();
            this.btFechar = new System.Windows.Forms.Button();
            this.btEnviar = new System.Windows.Forms.Button();
            this.pnImport = new System.Windows.Forms.Panel();
            this.lpSucess = new System.Windows.Forms.Panel();
            this.btEnviarOutro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lpSucess.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDirFile
            // 
            this.txtDirFile.AutoSize = true;
            this.txtDirFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDirFile.Location = new System.Drawing.Point(36, 270);
            this.txtDirFile.Name = "txtDirFile";
            this.txtDirFile.Size = new System.Drawing.Size(0, 13);
            this.txtDirFile.TabIndex = 6;
            this.txtDirFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lpCarregar
            // 
            this.lpCarregar.AutoSize = true;
            this.lpCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpCarregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lpCarregar.Location = new System.Drawing.Point(23, 48);
            this.lpCarregar.Name = "lpCarregar";
            this.lpCarregar.Size = new System.Drawing.Size(165, 16);
            this.lpCarregar.TabIndex = 7;
            this.lpCarregar.Text = "1 - CARREGAR ARQUIVO";
            // 
            // lpEnviar
            // 
            this.lpEnviar.AutoSize = true;
            this.lpEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpEnviar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lpEnviar.Location = new System.Drawing.Point(23, 92);
            this.lpEnviar.Name = "lpEnviar";
            this.lpEnviar.Size = new System.Drawing.Size(197, 16);
            this.lpEnviar.TabIndex = 8;
            this.lpEnviar.Text = "2 - ENVIAR PARA IMPRESSÃO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(60, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "INSTRUÇÕES";
            // 
            // lpInst1
            // 
            this.lpInst1.AutoSize = true;
            this.lpInst1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lpInst1.Location = new System.Drawing.Point(45, 64);
            this.lpInst1.Name = "lpInst1";
            this.lpInst1.Size = new System.Drawing.Size(119, 13);
            this.lpInst1.TabIndex = 10;
            this.lpInst1.Text = "Basta arrastar o arquivo";
            // 
            // lpInst2
            // 
            this.lpInst2.AutoSize = true;
            this.lpInst2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lpInst2.Location = new System.Drawing.Point(49, 114);
            this.lpInst2.Name = "lpInst2";
            this.lpInst2.Size = new System.Drawing.Size(103, 13);
            this.lpInst2.TabIndex = 11;
            this.lpInst2.Text = "Clicar em \"ENVIAR\"";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pgBar
            // 
            this.pgBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pgBar.Location = new System.Drawing.Point(39, 244);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(545, 23);
            this.pgBar.TabIndex = 12;
            // 
            // btFechar
            // 
            this.btFechar.Image = global::MySpooler.Properties.Resources.exit32;
            this.btFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFechar.Location = new System.Drawing.Point(473, 287);
            this.btFechar.Name = "btFechar";
            this.btFechar.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btFechar.Size = new System.Drawing.Size(111, 40);
            this.btFechar.TabIndex = 0;
            this.btFechar.Text = "&Fechar";
            this.btFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btEnviar
            // 
            this.btEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEnviar.Enabled = false;
            this.btEnviar.Image = global::MySpooler.Properties.Resources.send48;
            this.btEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEnviar.Location = new System.Drawing.Point(275, 172);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btEnviar.Size = new System.Drawing.Size(122, 58);
            this.btEnviar.TabIndex = 4;
            this.btEnviar.Text = "&Enviar";
            this.btEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // pnImport
            // 
            this.pnImport.AllowDrop = true;
            this.pnImport.BackColor = System.Drawing.SystemColors.Control;
            this.pnImport.BackgroundImage = global::MySpooler.Properties.Resources.imgDrag;
            this.pnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnImport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnImport.Location = new System.Drawing.Point(62, 3);
            this.pnImport.Name = "pnImport";
            this.pnImport.Size = new System.Drawing.Size(547, 146);
            this.pnImport.TabIndex = 0;
            this.pnImport.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnImport_DragDrop);
            this.pnImport.DragOver += new System.Windows.Forms.DragEventHandler(this.pnImport_DragOver);
            // 
            // lpSucess
            // 
            this.lpSucess.BackgroundImage = global::MySpooler.Properties.Resources.checkedPaint;
            this.lpSucess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lpSucess.Controls.Add(this.btEnviarOutro);
            this.lpSucess.Controls.Add(this.label2);
            this.lpSucess.Location = new System.Drawing.Point(18, 12);
            this.lpSucess.Name = "lpSucess";
            this.lpSucess.Size = new System.Drawing.Size(589, 255);
            this.lpSucess.TabIndex = 15;
            this.lpSucess.Visible = false;
            // 
            // btEnviarOutro
            // 
            this.btEnviarOutro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEnviarOutro.Image = global::MySpooler.Properties.Resources.send32;
            this.btEnviarOutro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEnviarOutro.Location = new System.Drawing.Point(455, 208);
            this.btEnviarOutro.Name = "btEnviarOutro";
            this.btEnviarOutro.Size = new System.Drawing.Size(111, 44);
            this.btEnviarOutro.TabIndex = 0;
            this.btEnviarOutro.Text = "&Enviar Outro";
            this.btEnviarOutro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEnviarOutro.UseVisualStyleBackColor = true;
            this.btEnviarOutro.Click += new System.EventHandler(this.btEnviarOutro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(45, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Arquivo enviado para impressão com sucesso :)";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(619, 350);
            this.Controls.Add(this.lpSucess);
            this.Controls.Add(this.lpInst2);
            this.Controls.Add(this.pgBar);
            this.Controls.Add(this.lpInst1);
            this.Controls.Add(this.txtDirFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.lpEnviar);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.lpCarregar);
            this.Controls.Add(this.pnImport);
            this.Name = "frmClient";
            this.Text = "frmClient";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.lpSucess.ResumeLayout(false);
            this.lpSucess.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnImport;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Label txtDirFile;
        private System.Windows.Forms.Label lpInst2;
        private System.Windows.Forms.Label lpInst1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lpEnviar;
        private System.Windows.Forms.Label lpCarregar;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pgBar;
        private System.Windows.Forms.Panel lpSucess;
        private System.Windows.Forms.Button btEnviarOutro;
        private System.Windows.Forms.Label label2;
    }
}