using Sistema.Negocio;
using System;
using System.Windows.Forms;
using Sistema.Servico.BuscaCep; 


namespace WinFormsApp
{
    /// <summary>
    ///    form de consulta ao CEP digitado. 
    /// </summary>
    public partial class BuscaCEPForm : Form
    {
        public BuscaCEPForm()
        {
            InitializeComponent();
            Application.DoEvents();
        }

        /// <summary>
        ///    executa consulta ao CEP digitado. 
        /// </summary>
        private void BuscaCEPButton_Click(object sender, EventArgs e)
        {

            AguardeForm fAguarde = new AguardeForm
            {
                cMensagem = "Localizando CEP..."
            };
            fAguarde.Show();
            Application.DoEvents();

            BuscaCEPService buscacep = new BuscaCEPService();

            dataGridView1.DataSource = buscacep.CepModel(BuscarTextBox.Text.Trim());

            Application.DoEvents();
            fAguarde.Hide();

        }
    }
}
