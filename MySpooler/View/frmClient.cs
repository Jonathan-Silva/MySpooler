using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace MySpooler.View
{
    public partial class frmClient : Form
    { 
        public frmClient()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtDirFile.Text = dialog.FileName;
                }
            }
        }


        private void frmClient_Load(object sender, EventArgs e)
        {

        }

        private void pnImport_DragDrop(object sender, DragEventArgs e)
        {
            string[] arquivos = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (arquivos != null && arquivos.Any())
            {
                if (Verificar(arquivos.First()))
                {
                    txtDirFile.Text = arquivos.First();
                    ChangeIntru(1);
                }
                else
                {
                    MessageBox.Show("Formato inválido", "Erro ao carregar arquivo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void pnImport_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ChangeIntru(int x)
        {
            if (x == 0)
            {
                lpCarregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                lpInst1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                lpEnviar.ForeColor = System.Drawing.SystemColors.ControlDark;
                lpInst2.ForeColor = System.Drawing.SystemColors.ControlDark;
                this.pnImport.BackgroundImage = global::MySpooler.Properties.Resources.imgDrag;
                btEnviar.Enabled = false;
                pgBar.Value = 0;
                txtDirFile.Text = "";
            }
            else if (x == 1)
            {
                lpCarregar.ForeColor = System.Drawing.SystemColors.ControlDark;
                lpInst1.ForeColor = System.Drawing.SystemColors.ControlDark;
                lpEnviar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                lpInst2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                btEnviar.Enabled = true;
                this.pnImport.BackgroundImage = global::MySpooler.Properties.Resources.filechecked;
               
            }
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            string dirEmvio = @" C:\Users\Suporte-01\Pictures\amostra\";
            string x = "copy " + txtDirFile.Text + dirEmvio;
            ExecutarComandoCMD(x);
            timer1.Start();
            
           
            
        }

        public static string ExecutarComandoCMD(string ComandoCMD)
        {
            using (Process processo = new Process())
            {
                // Obtém a localidade do cmd.exe
                processo.StartInfo.FileName = Environment.GetEnvironmentVariable("comspec");

                // Formata a string para passar como argumento para o cmd.exe
                processo.StartInfo.Arguments = string.Format("/c {0}", ComandoCMD);



                // Para redirecionar a saída para uma string ou StreamReader 
                processo.StartInfo.RedirectStandardOutput = true;

                // Para redirecionar a saída de um processo
                processo.StartInfo.UseShellExecute = false;

                // Para não criar a janela do cmd.exe
                processo.StartInfo.CreateNoWindow = true;

                // Inicia o cmd.exe
                processo.Start();

                // Aguarda o término
                processo.WaitForExit();

                // Lê a saída do processo, aqui poderia ser usado também um StreamReader
                string saida = processo.StandardOutput.ReadToEnd();
                return saida;
            }
        }



        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEnviarOutro_Click(object sender, EventArgs e)
        {
            lpSucess.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pgBar.Value>=100)
            {
                lpSucess.Visible = true;
                ChangeIntru(0);
                timer1.Stop();
                btEnviar.Focus();
            }
            else
            {
                pgBar.Increment(10);
            }
        }

        private bool Verificar(string DirFile)
        {
            Char[] xc = DirFile.ToCharArray();
            int x = xc.Count() - 1;
            string ext = "";
            for (int i = x; i > 0; i--)
            {
                if (xc[i].Equals('.'))
                {
                    break;
                }
                else
                {
                    ext += xc[i].ToString();
                }
            }

            Char[] extChar = ext.ToCharArray();
            x = extChar.Count() - 1;
            ext = "";
            for (int i = x; i >= 0; i--)
            {
                ext += extChar[i].ToString();
            }


            if (ext.Equals("txt") || ext.Equals("doc") || ext.Equals("xls") || ext.Equals("ppt") || ext.Equals("pdf") || ext.Equals("docx") || ext.Equals("xlsx") || ext.Equals("pptx") || ext.Equals("ods"))
            {
                return true;
            }
            else if (ext.Equals("png") || ext.Equals("jpg") || ext.Equals("bitmap"))
            {
                return true;
            }
            return false;

        }
    }
}
