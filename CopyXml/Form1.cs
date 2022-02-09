using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyXml
{
    public partial class Form1 : Form
    {

        private static CancellationTokenSource source = new CancellationTokenSource();
        CancellationToken token = source.Token;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void abrirdialog_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Btnorigem_Click(object sender, EventArgs e)
        {
            if (abrirdialog.ShowDialog() == DialogResult.OK)
            {
                txtorigem.Text = abrirdialog.SelectedPath;
            }
        }

        private void Btndestino_Click(object sender, EventArgs e)
        {
            if (abrirdialog.ShowDialog() == DialogResult.OK)
            {
                txtdestino.Text = abrirdialog.SelectedPath;
            }
        }

        private async void Btniniciar_Click(object sender, EventArgs e)
        {
            var inicio = DateTime.Now;

            if (txtorigem.Text == string.Empty)
            {
                MessageBox.Show("Campo origem deve ser preenchidos!", "Atenção: ", MessageBoxButtons.OK);

                txtorigem.BackColor = Color.Yellow;

                Btniniciar.Enabled = false;

            }

            if (txtdestino.Text == string.Empty)
            {
                MessageBox.Show("Campo destino deve ser preenchidos!", "Atenção: ", MessageBoxButtons.OK);
                txtdestino.BackColor = Color.Yellow;
                Btniniciar.Enabled = false;
            }


            string sourceDir = txtorigem.Text;
            string backupDir = txtdestino.Text;


            StatusBuscar status = new StatusBuscar();
            status.Show();

            try
            {
                
                Task<string[]> task = Task<string[]>.Factory.StartNew(() =>
                {

                    var xmlfile = Directory.GetFiles(sourceDir, "*.xml", SearchOption.AllDirectories);
                    return xmlfile;

                });




                await task;


                status.Visible = false;
                label3.Visible = true;
                Btncancelar.Enabled = true;
                Btniniciar.Enabled = false;
                ;

                try
                {


                    foreach (string f in task.Result)
                    {

                        //Chamando CancellationToken
                        if (token.IsCancellationRequested)
                        {
                            MessageBox.Show("Operação cancelada. Sistema será fechado!", "Aviso");
                            this.Close();
                            break;
                        }


                        await Task.Delay(1);

                        //Colocando o nome do arquivo no split \\ 
                        string fName = f.Substring(sourceDir.Length + 1);
                        var cam = fName.Split('\\');

                        //Nome do arquivo separado do diretório
                        var subpasta = cam[cam.Length - 1];

                        //Add na listbox e mostrando status de copy
                        ListBoxStatus.Items.Add(subpasta);
                        ListBoxStatus.Refresh();

                        try
                        {
                            //Copiando os arquivos passados no subdiretorios
                            File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, subpasta), true);
                        }
                        catch (IOException erro)
                        {
                            MessageBox.Show("Algo deu errado ao tentar copiar este arquivo!" + fName + " " + erro.Message, "Aviso");

                        }
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Algo deu errado!", "Aviso");
                    throw;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Campos Origem e Destino devem ser válidos!", "Aviso");
                txtorigem.Focus();
                throw;
                
            }
            
                var fim = DateTime.Now;
                var result_tem = inicio - fim;
                labeltemp.Visible = true;
                labeltemp.Text = result_tem.ToString();
                Btncancelar.Enabled = false;
                Btniniciar.Enabled = true;
                MessageBox.Show("Operação finalizada com sucesso! Arquivos copiados para: " + backupDir);


           


        }
    

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            source.Cancel();


        }

    }


}
