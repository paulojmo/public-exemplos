using Sistema.Negocio;

namespace WinFormsApp
{
    partial class BuscaCEPForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BuscaCEPButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarTextBox = new System.Windows.Forms.TextBox();
            this.barraTituloPanel = new System.Windows.Forms.Panel();
            this.descFormLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ibgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siafiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            this.barraTituloPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEPModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.BuscaCEPButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BuscarTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 64);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(835, 0);
            this.panel3.TabIndex = 5;
            // 
            // BuscaCEPButton
            // 
            this.BuscaCEPButton.Location = new System.Drawing.Point(207, 20);
            this.BuscaCEPButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuscaCEPButton.Name = "BuscaCEPButton";
            this.BuscaCEPButton.Size = new System.Drawing.Size(111, 32);
            this.BuscaCEPButton.TabIndex = 4;
            this.BuscaCEPButton.Text = "Buscar";
            this.BuscaCEPButton.UseVisualStyleBackColor = true;
            this.BuscaCEPButton.Click += new System.EventHandler(this.BuscaCEPButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o CEP";
            // 
            // BuscarTextBox
            // 
            this.BuscarTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BuscarTextBox.Location = new System.Drawing.Point(12, 23);
            this.BuscarTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuscarTextBox.Name = "BuscarTextBox";
            this.BuscarTextBox.Size = new System.Drawing.Size(185, 29);
            this.BuscarTextBox.TabIndex = 0;
            // 
            // barraTituloPanel
            // 
            this.barraTituloPanel.BackColor = System.Drawing.Color.Blue;
            this.barraTituloPanel.Controls.Add(this.descFormLabel);
            this.barraTituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTituloPanel.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.barraTituloPanel.Location = new System.Drawing.Point(0, 0);
            this.barraTituloPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barraTituloPanel.Name = "barraTituloPanel";
            this.barraTituloPanel.Size = new System.Drawing.Size(835, 37);
            this.barraTituloPanel.TabIndex = 13;
            // 
            // descFormLabel
            // 
            this.descFormLabel.AutoSize = true;
            this.descFormLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Italic);
            this.descFormLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.descFormLabel.Location = new System.Drawing.Point(4, 6);
            this.descFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descFormLabel.Name = "descFormLabel";
            this.descFormLabel.Size = new System.Drawing.Size(142, 28);
            this.descFormLabel.TabIndex = 0;
            this.descFormLabel.Text = "Buscar CEP";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(326, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(463, 29);
            this.textBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cepDataGridViewTextBoxColumn,
            this.logradouroDataGridViewTextBoxColumn,
            this.complementoDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.localidadeDataGridViewTextBoxColumn,
            this.ufDataGridViewTextBoxColumn,
            this.ibgeDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.dddDataGridViewTextBoxColumn,
            this.siafiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cEPModelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(835, 189);
            this.dataGridView1.TabIndex = 15;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            // 
            // logradouroDataGridViewTextBoxColumn
            // 
            this.logradouroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.logradouroDataGridViewTextBoxColumn.DataPropertyName = "logradouro";
            this.logradouroDataGridViewTextBoxColumn.HeaderText = "logradouro";
            this.logradouroDataGridViewTextBoxColumn.Name = "logradouroDataGridViewTextBoxColumn";
            // 
            // complementoDataGridViewTextBoxColumn
            // 
            this.complementoDataGridViewTextBoxColumn.DataPropertyName = "complemento";
            this.complementoDataGridViewTextBoxColumn.HeaderText = "complemento";
            this.complementoDataGridViewTextBoxColumn.Name = "complementoDataGridViewTextBoxColumn";
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            // 
            // localidadeDataGridViewTextBoxColumn
            // 
            this.localidadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.localidadeDataGridViewTextBoxColumn.DataPropertyName = "localidade";
            this.localidadeDataGridViewTextBoxColumn.HeaderText = "localidade";
            this.localidadeDataGridViewTextBoxColumn.Name = "localidadeDataGridViewTextBoxColumn";
            // 
            // ufDataGridViewTextBoxColumn
            // 
            this.ufDataGridViewTextBoxColumn.DataPropertyName = "uf";
            this.ufDataGridViewTextBoxColumn.HeaderText = "uf";
            this.ufDataGridViewTextBoxColumn.Name = "ufDataGridViewTextBoxColumn";
            // 
            // ibgeDataGridViewTextBoxColumn
            // 
            this.ibgeDataGridViewTextBoxColumn.DataPropertyName = "ibge";
            this.ibgeDataGridViewTextBoxColumn.HeaderText = "ibge";
            this.ibgeDataGridViewTextBoxColumn.Name = "ibgeDataGridViewTextBoxColumn";
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "gia";
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            // 
            // dddDataGridViewTextBoxColumn
            // 
            this.dddDataGridViewTextBoxColumn.DataPropertyName = "ddd";
            this.dddDataGridViewTextBoxColumn.HeaderText = "ddd";
            this.dddDataGridViewTextBoxColumn.Name = "dddDataGridViewTextBoxColumn";
            // 
            // siafiDataGridViewTextBoxColumn
            // 
            this.siafiDataGridViewTextBoxColumn.DataPropertyName = "siafi";
            this.siafiDataGridViewTextBoxColumn.HeaderText = "siafi";
            this.siafiDataGridViewTextBoxColumn.Name = "siafiDataGridViewTextBoxColumn";
            // 
            // cEPModelBindingSource
            // 
            this.cEPModelBindingSource.DataSource = typeof(CepModel);
            // 
            // BuscaCEPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 290);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.barraTituloPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BuscaCEPForm";
            this.Text = "BuscaCEPForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.barraTituloPanel.ResumeLayout(false);
            this.barraTituloPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cEPModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BuscaCEPButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BuscarTextBox;
        private System.Windows.Forms.Panel barraTituloPanel;
        private System.Windows.Forms.Label descFormLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cEPModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ibgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siafiDataGridViewTextBoxColumn;
    }
}