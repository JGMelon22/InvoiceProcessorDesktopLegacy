namespace InvoiceProcessorDesktopLegacy
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnImportarUnico = new System.Windows.Forms.Button();
            this.btnImportarMultiplos = new System.Windows.Forms.Button();
            this.btnListarTodas = new System.Windows.Forms.Button();
            this.btnBuscarNumero = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.dgvNotasFiscais = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBoxOperacoes = new System.Windows.Forms.GroupBox();
            this.groupBoxBusca = new System.Windows.Forms.GroupBox();
            this.groupBoxResultados = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasFiscais)).BeginInit();
            this.groupBoxOperacoes.SuspendLayout();
            this.groupBoxBusca.SuspendLayout();
            this.groupBoxResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImportarUnico
            // 
            this.btnImportarUnico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportarUnico.Location = new System.Drawing.Point(11, 20);
            this.btnImportarUnico.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportarUnico.Name = "btnImportarUnico";
            this.btnImportarUnico.Size = new System.Drawing.Size(135, 28);
            this.btnImportarUnico.TabIndex = 0;
            this.btnImportarUnico.Text = "Importar Único XML";
            this.btnImportarUnico.UseVisualStyleBackColor = true;
            this.btnImportarUnico.Click += new System.EventHandler(this.btnImportarUnico_Click);
            // 
            // btnImportarMultiplos
            // 
            this.btnImportarMultiplos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImportarMultiplos.Location = new System.Drawing.Point(158, 20);
            this.btnImportarMultiplos.Margin = new System.Windows.Forms.Padding(2);
            this.btnImportarMultiplos.Name = "btnImportarMultiplos";
            this.btnImportarMultiplos.Size = new System.Drawing.Size(135, 28);
            this.btnImportarMultiplos.TabIndex = 1;
            this.btnImportarMultiplos.Text = "Importar Múltiplos XMLs";
            this.btnImportarMultiplos.UseVisualStyleBackColor = true;
            this.btnImportarMultiplos.Click += new System.EventHandler(this.btnImportarMultiplos_Click);
            // 
            // btnListarTodas
            // 
            this.btnListarTodas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListarTodas.Location = new System.Drawing.Point(304, 20);
            this.btnListarTodas.Margin = new System.Windows.Forms.Padding(2);
            this.btnListarTodas.Name = "btnListarTodas";
            this.btnListarTodas.Size = new System.Drawing.Size(135, 28);
            this.btnListarTodas.TabIndex = 2;
            this.btnListarTodas.Text = "Listar Todas";
            this.btnListarTodas.UseVisualStyleBackColor = true;
            this.btnListarTodas.Click += new System.EventHandler(this.btnListarTodas_Click);
            // 
            // btnBuscarNumero
            // 
            this.btnBuscarNumero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarNumero.Location = new System.Drawing.Point(161, 20);
            this.btnBuscarNumero.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarNumero.Name = "btnBuscarNumero";
            this.btnBuscarNumero.Size = new System.Drawing.Size(75, 24);
            this.btnBuscarNumero.TabIndex = 3;
            this.btnBuscarNumero.Text = "Buscar";
            this.btnBuscarNumero.UseVisualStyleBackColor = true;
            this.btnBuscarNumero.Click += new System.EventHandler(this.btnBuscarNumero_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(56, 24);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(91, 20);
            this.txtNumero.TabIndex = 4;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(8, 26);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 5;
            this.lblNumero.Text = "Número:";
            // 
            // dgvNotasFiscais
            // 
            this.dgvNotasFiscais.AllowUserToAddRows = false;
            this.dgvNotasFiscais.AllowUserToDeleteRows = false;
            this.dgvNotasFiscais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotasFiscais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotasFiscais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotasFiscais.Location = new System.Drawing.Point(2, 15);
            this.dgvNotasFiscais.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNotasFiscais.Name = "dgvNotasFiscais";
            this.dgvNotasFiscais.ReadOnly = true;
            this.dgvNotasFiscais.RowHeadersWidth = 51;
            this.dgvNotasFiscais.RowTemplate.Height = 24;
            this.dgvNotasFiscais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotasFiscais.Size = new System.Drawing.Size(746, 349);
            this.dgvNotasFiscais.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(9, 463);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(124, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Pronto para operações...";
            // 
            // groupBoxOperacoes
            // 
            this.groupBoxOperacoes.Controls.Add(this.btnImportarUnico);
            this.groupBoxOperacoes.Controls.Add(this.btnImportarMultiplos);
            this.groupBoxOperacoes.Controls.Add(this.btnListarTodas);
            this.groupBoxOperacoes.Location = new System.Drawing.Point(11, 12);
            this.groupBoxOperacoes.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxOperacoes.Name = "groupBoxOperacoes";
            this.groupBoxOperacoes.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxOperacoes.Size = new System.Drawing.Size(450, 61);
            this.groupBoxOperacoes.TabIndex = 8;
            this.groupBoxOperacoes.TabStop = false;
            this.groupBoxOperacoes.Text = "Operações";
            // 
            // groupBoxBusca
            // 
            this.groupBoxBusca.Controls.Add(this.lblNumero);
            this.groupBoxBusca.Controls.Add(this.txtNumero);
            this.groupBoxBusca.Controls.Add(this.btnBuscarNumero);
            this.groupBoxBusca.Location = new System.Drawing.Point(480, 12);
            this.groupBoxBusca.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxBusca.Name = "groupBoxBusca";
            this.groupBoxBusca.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxBusca.Size = new System.Drawing.Size(270, 61);
            this.groupBoxBusca.TabIndex = 9;
            this.groupBoxBusca.TabStop = false;
            this.groupBoxBusca.Text = "Buscar por Número";
            // 
            // groupBoxResultados
            // 
            this.groupBoxResultados.Controls.Add(this.dgvNotasFiscais);
            this.groupBoxResultados.Location = new System.Drawing.Point(11, 85);
            this.groupBoxResultados.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxResultados.Name = "groupBoxResultados";
            this.groupBoxResultados.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxResultados.Size = new System.Drawing.Size(750, 366);
            this.groupBoxResultados.TabIndex = 10;
            this.groupBoxResultados.TabStop = false;
            this.groupBoxResultados.Text = "Resultados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 490);
            this.Controls.Add(this.groupBoxResultados);
            this.Controls.Add(this.groupBoxBusca);
            this.Controls.Add(this.groupBoxOperacoes);
            this.Controls.Add(this.lblStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Importação de Notas Fiscais - UneCont";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotasFiscais)).EndInit();
            this.groupBoxOperacoes.ResumeLayout(false);
            this.groupBoxBusca.ResumeLayout(false);
            this.groupBoxBusca.PerformLayout();
            this.groupBoxResultados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnImportarUnico;
        private System.Windows.Forms.Button btnImportarMultiplos;
        private System.Windows.Forms.Button btnListarTodas;
        private System.Windows.Forms.Button btnBuscarNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.DataGridView dgvNotasFiscais;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBoxOperacoes;
        private System.Windows.Forms.GroupBox groupBoxBusca;
        private System.Windows.Forms.GroupBox groupBoxResultados;

        #endregion
    }
}

