
namespace SistemaBaseForms
{
    partial class BaseFormLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseFormLista));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            this.comboBoxOpcaoFiltro = new System.Windows.Forms.ComboBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelFiltros.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelDataGrid);
            this.panel1.Controls.Add(this.panelFiltros);
            this.panel1.Controls.Add(this.panelButtons);
            this.panel1.Controls.Add(this.panelTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGrid.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelDataGrid.Location = new System.Drawing.Point(0, 89);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(798, 319);
            this.panelDataGrid.TabIndex = 2;
            // 
            // panelFiltros
            // 
            this.panelFiltros.Controls.Add(this.label2);
            this.panelFiltros.Controls.Add(this.label1);
            this.panelFiltros.Controls.Add(this.buttonFiltrar);
            this.panelFiltros.Controls.Add(this.textBoxFiltro);
            this.panelFiltros.Controls.Add(this.comboBoxOpcaoFiltro);
            this.panelFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiltros.Location = new System.Drawing.Point(0, 33);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(798, 56);
            this.panelFiltros.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bucar por ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite";
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiltrar.Location = new System.Drawing.Point(635, 20);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(110, 30);
            this.buttonFiltrar.TabIndex = 2;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(186, 22);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(443, 29);
            this.textBoxFiltro.TabIndex = 1;
            // 
            // comboBoxOpcaoFiltro
            // 
            this.comboBoxOpcaoFiltro.FormattingEnabled = true;
            this.comboBoxOpcaoFiltro.Location = new System.Drawing.Point(11, 22);
            this.comboBoxOpcaoFiltro.Name = "comboBoxOpcaoFiltro";
            this.comboBoxOpcaoFiltro.Size = new System.Drawing.Size(169, 29);
            this.comboBoxOpcaoFiltro.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.button4);
            this.panelButtons.Controls.Add(this.button3);
            this.panelButtons.Controls.Add(this.button1);
            this.panelButtons.Controls.Add(this.button2);
            this.panelButtons.Controls.Add(this.buttonVoltar);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 408);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(798, 40);
            this.panelButtons.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImageKey = "registro.excluir-48.png";
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(464, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 40);
            this.button4.TabIndex = 5;
            this.button4.Text = "Excluir";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "form.voltar-48.png");
            this.imageList1.Images.SetKeyName(1, "form.configuracoes-48.png");
            this.imageList1.Images.SetKeyName(2, "registro.adicionar-48.png");
            this.imageList1.Images.SetKeyName(3, "registro.editar-48.png");
            this.imageList1.Images.SetKeyName(4, "registro.excluir-48.png");
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageKey = "registro.editar-48.png";
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(348, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Editar";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageKey = "registro.adicionar-48.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(232, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Novo";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageKey = "form.configuracoes-48.png";
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(116, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Opções";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonVoltar.FlatAppearance.BorderSize = 0;
            this.buttonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVoltar.ImageKey = "form.voltar-48.png";
            this.buttonVoltar.ImageList = this.imageList1;
            this.buttonVoltar.Location = new System.Drawing.Point(0, 0);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(116, 40);
            this.buttonVoltar.TabIndex = 0;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonVoltar.UseVisualStyleBackColor = true;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelTitulo.Controls.Add(this.labelTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(798, 33);
            this.panelTitulo.TabIndex = 0;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(138, 25);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "BaseFormLista";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BaseFormLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseFormLista";
            this.Text = "BaseFormLista";
            this.panel1.ResumeLayout(false);
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panelFiltros;
        public System.Windows.Forms.Panel panelDataGrid;
        public System.Windows.Forms.Panel panelButtons;
        public System.Windows.Forms.Button buttonVoltar;
        public System.Windows.Forms.Panel panelTitulo;
        public System.Windows.Forms.Label labelTitulo;
        public System.Windows.Forms.Button buttonFiltrar;
        public System.Windows.Forms.TextBox textBoxFiltro;
        public System.Windows.Forms.ComboBox comboBoxOpcaoFiltro;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
    }
}