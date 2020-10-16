using System;
using System.Text.Json;
using System.Windows.Forms;


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

            //
            RestClient client = new RestClient
            {
                EndPoint = "http://viacep.com.br/ws/" 
            };

            client.Request(BuscarTextBox.Text.Trim());
            Application.DoEvents();

            string RetResponse = client.Response(); 

            textBox1.Text = RetResponse;

            //CEPModel cep = JsonConvert.DeserializeObject<CEPModel>(strResponse);
            
            CepModel cep = JsonSerializer.Deserialize<CepModel>(json: RetResponse);

            dataGridView1.DataSource = cep;

            Application.DoEvents();
            fAguarde.Hide();

        }
    }
}
