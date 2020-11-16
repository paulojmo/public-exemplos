
namespace ModuloCadastros
{
    partial class ClasseLista
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpresaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDataGrid.Controls.Add(this.dataGridView1);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.FlatAppearance.BorderSize = 0;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Size = new System.Drawing.Size(142, 25);
            this.labelTitulo.Text = "Lista de classes";
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.FlatAppearance.BorderSize = 0;
            this.buttonFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFiltrar.Location = new System.Drawing.Point(635, 22);
            this.buttonFiltrar.Size = new System.Drawing.Size(110, 27);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.EmpresaId});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(796, 317);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // EmpresaId
            // 
            this.EmpresaId.FillWeight = 120F;
            this.EmpresaId.HeaderText = "Empresa";
            this.EmpresaId.Name = "EmpresaId";
            this.EmpresaId.ReadOnly = true;
            this.EmpresaId.Width = 120;
            // 
            // ClasseLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ClasseLista";
            this.Text = "ClasseLista";
            this.Load += new System.EventHandler(this.ClasseLista_Load);
            this.panel1.ResumeLayout(false);
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.panelDataGrid.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpresaId;
    }
}