using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaBaseForms;
using BusinessCadastros;
using SistemaService; 

namespace ModuloCadastros
{
    public partial class ClasseLista : BaseFormLista
    {
        public ClasseLista()
        {
            InitializeComponent();
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Close();  
        }

        private void ClasseLista_Load(object sender, EventArgs e)
        {
            ClasseRepository rep = new ClasseRepository(ConexaoService.GetConnectionString());
            dataGridView1.DataSource = rep.Lista(); 

        }
    }
}
