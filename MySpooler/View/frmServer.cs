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
            InitializeComponent();
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            string DIR = @"C:\Users\Public\Pictures\Sample Pictures";
            string[] arquivos = Directory.GetFiles(DIR);

            foreach (string dirFile in arquivos)
            {
                string nameFile = dirFile.Replace(@"C:\Users\Public\Pictures\Sample Pictures\","").ToUpper();
                dgFila.Rows.Add(nameFile, DefiniTpe(dirFile), dirFile);

            }
        }

        private void RefreshFila()
        {
            int itensNaFila = dgFila.RowCount;
            for (int i = 0; i < itensNaFila; i++)
            {
                dgFila.Rows.RemoveAt(0);
            }

            //string[] diretorios = Directory.GetDirectories("C:\\");
            


        }

        private static void PrintFile (string FileDir, int Copys)
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
            DeletarFile(@"C:\Users\Suporte-01\Desktop\x.png");
        }

        private static void DeletarFile(string FileDir)
        {
            string cmdDel = "del " + FileDir;
            ExecutarComandoCMD(cmdDel);
        }


        public static string ExecutarComandoCMD(string ComandoCMD)
        {
            using (Process processo = new Process())
            {
                // Obtém a localidade do cmd.exe
                processo.StartInfo.FileName = Environment.GetEnvironmentVariable("comspec");

                // Formata a string para passar como argumento para o cmd.exe
                processo.StartInfo.Arguments = string.Format("/c {0}", ComandoCMD);

                // Define a área de trabalho como diretório atual de trabalho
                processo.StartInfo.WorkingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

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

        private void dgFila_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
       
            PrintFile(dgFila.Rows[e.RowIndex].Cells[2].Value.ToString(), Convert.ToInt32(nmCopy.Value));
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {

        }

        private static string DefiniTpe(string DirFile)
        {
            Char [] xc = DirFile.ToCharArray();
            int x = xc.Count()-1;
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


            if (ext.Equals("txt")|| ext.Equals("doc") || ext.Equals("xls") || ext.Equals("ppt") || ext.Equals("pdf") || ext.Equals("docx") || ext.Equals("xlsx") || ext.Equals("pptx"))
            {
                return "doc";
            }
            else
            {
                return "img";
            }

        }

        private void dgFila_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string x = dgFila.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (x.Equals("img"))
            {

            }
        }


    }
}
