using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySpooler.View
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
         
            frmClient Client = new frmClient();
            Client.Show();
            InitializeComponent();
            Timer.Enabled = true;
            Timer.Start();
        }

        int ContadorTime = 0;
        string sourceDIR = @"C:\Users\Suporte-01\Pictures\amostra";
        string fileDIR = "";
        private void frmServer_Load(object sender, EventArgs e)
        {
            RefreshFila();
        }

        private void RefreshFila()
        {
            DeletarLinhas();
           
            string[] arquivos = Directory.GetFiles(sourceDIR);

            foreach (string dirFile in arquivos)
            {
                string nameFile = dirFile.Replace(sourceDIR + @"\", "").ToUpper();
                dgFila.Rows.Add(nameFile, DefiniType(dirFile), dirFile);

            }


        }
        private void DeletarLinhas()
        {
            int x = dgFila.Rows.Count;
            for (int i = 0; i < x; i++)
            {
                dgFila.Rows.Remove(dgFila.Rows[0]);
            }

        }

        private static void PrintFile(string FileDir, int Copys)
        {
            for (int i = 0; i < Copys; i++)
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.Verb = "print";
                info.FileName = FileDir;
                info.CreateNoWindow = true;
                info.WindowStyle = ProcessWindowStyle.Hidden;

                Process p = new Process();
                p.StartInfo = info;
                p.Start();


                System.Threading.Thread.Sleep(3000);
                p.Close();
            }
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir este [ "+fileDIR.Replace(sourceDIR+@"\","")+" ] arquivos da fila ?", "MySpooler Questiona", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                DeletarFile(fileDIR);
                RefreshFila();
            }
        }

        private static void DeletarFile(string file)
        {
            string cmdDel = "del " + file;
            ExecutarComandoCMD(cmdDel);
        }


        public static string ExecutarComandoCMD(string ComandoCMD)
        {
            using (Process processo = new Process())
            {

                processo.StartInfo.FileName = Environment.GetEnvironmentVariable("comspec");


                processo.StartInfo.Arguments = string.Format("/c {0}", ComandoCMD);

                processo.StartInfo.RedirectStandardOutput = true;


                processo.StartInfo.UseShellExecute = false;

     
                processo.StartInfo.CreateNoWindow = true;


                processo.Start();


                processo.WaitForExit();

                string saida = processo.StandardOutput.ReadToEnd();
                return saida;
            }
        }

        private void dgFila_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            PrintFile(dgFila.Rows[e.RowIndex].Cells[2].Value.ToString(), Convert.ToInt32(nmCopy.Value));
            System.Threading.Thread.Sleep(3000);
            DeletarFile(fileDIR);
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            PrintFile(fileDIR, Convert.ToInt32(nmCopy.Value));
            DeletarFile(fileDIR);
        }

        private  string DefiniType(string DirFile)
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
                return "doc";
            }
            else if (ext.Equals("png") || ext.Equals("jpg") || ext.Equals("bitmap"))
            {
                return "img";
            }
            return "nop";

        }

        private void dgFila_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string x = dgFila.Rows[e.RowIndex].Cells[1].Value.ToString();
            fileDIR = dgFila.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (x.Equals("img"))
            {
                nmCopy.Enabled = false;
                nmCopy.Value = 1;
            }
            else
            {
                nmCopy.Enabled = true;
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            RefreshFila();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ContadorTime++;
            if (ContadorTime == 5)
            {
                ContadorTime = 0;
                RefreshFila();
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja excluir todos os arquivos da fila ?", "MySpooler Questiona", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string cmdDEL = "del /f /q " + sourceDIR + @"\*";
                ExecutarComandoCMD(cmdDEL);
                RefreshFila();
            }

        }

        private void dgFila_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
