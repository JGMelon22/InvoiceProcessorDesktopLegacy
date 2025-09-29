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
            this.btnImportarUnico.Location = new System.Drawing.Point(15, 25);
            this.btnImportarUnico.Name = "btnImportarUnico";
            this.btnImportarUnico.Size = new System.Drawing.Size(180, 35);
            this.btnImportarUnico.TabIndex = 0;
            this.btnImportarUnico.Text = "Importar Único XML";
            this.btnImportarUnico.UseVisualStyleBackColor = true;
            // this.btnImportarUnico.Click += new System.EventHandler(this.btnImportarUnico_Click);
            // 
            // btnImportarMultiplos
            // 
            this.btnImportarMultiplos.Location = new System.Drawing.Point(210, 25);
            this.btnImportarMultiplos.Name = "btnImportarMultiplos";
            this.btnImportarMultiplos.Size = new System.Drawing.Size(180, 35);
            this.btnImportarMultiplos.TabIndex = 1;
            this.btnImportarMultiplos.Text = "Importar Múltiplos XMLs";
            this.btnImportarMultiplos.UseVisualStyleBackColor = true;
            // this.btnImportarMultiplos.Click += new System.EventHandler(this.btnImportarMultiplos_Click);
            // 
            // btnListarTodas
            // 
            this.btnListarTodas.Location = new System.Drawing.Point(405, 25);
            this.btnListarTodas.Name = "btnListarTodas";
            this.btnListarTodas.Size = new System.Drawing.Size(180, 35);
            this.btnListarTodas.TabIndex = 2;
            this.btnListarTodas.Text = "Listar Todas";
            this.btnListarTodas.UseVisualStyleBackColor = true;
            // this.btnListarTodas.Click += new System.EventHandler(this.btnListarTodas_Click);
            // 
            // btnBuscarNumero
            // 
            this.btnBuscarNumero.Location = new System.Drawing.Point(215, 25);
            this.btnBuscarNumero.Name = "btnBuscarNumero";
            this.btnBuscarNumero.Size = new System.Drawing.Size(100, 30);
            this.btnBuscarNumero.TabIndex = 3;
            this.btnBuscarNumero.Text = "Buscar";
            this.btnBuscarNumero.UseVisualStyleBackColor = true;
            // this.btnBuscarNumero.Click += new System.EventHandler(this.btnBuscarNumero_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(75, 29);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(120, 22);
            this.txtNumero.TabIndex = 4;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(10, 32);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(59, 16);
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
            this.dgvNotasFiscais.Location = new System.Drawing.Point(3, 18);
            this.dgvNotasFiscais.Name = "dgvNotasFiscais";
            this.dgvNotasFiscais.ReadOnly = true;
            this.dgvNotasFiscais.RowHeadersWidth = 51;
            this.dgvNotasFiscais.RowTemplate.Height = 24;
            this.dgvNotasFiscais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotasFiscais.Size = new System.Drawing.Size(994, 350);
            this.dgvNotasFiscais.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 570);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(157, 16);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Pronto para operações...";
            // 
            // groupBoxOperacoes
            // 
            this.groupBoxOperacoes.Controls.Add(this.btnImportarUnico);
            this.groupBoxOperacoes.Controls.Add(this.btnImportarMultiplos);
            this.groupBoxOperacoes.Controls.Add(this.btnListarTodas);
            this.groupBoxOperacoes.Location = new System.Drawing.Point(15, 15);
            this.groupBoxOperacoes.Name = "groupBoxOperacoes";
            this.groupBoxOperacoes.Size = new System.Drawing.Size(600, 75);
            this.groupBoxOperacoes.TabIndex = 8;
            this.groupBoxOperacoes.TabStop = false;
            this.groupBoxOperacoes.Text = "Operações";
            // 
            // groupBoxBusca
            // 
            this.groupBoxBusca.Controls.Add(this.lblNumero);
            this.groupBoxBusca.Controls.Add(this.txtNumero);
            this.groupBoxBusca.Controls.Add(this.btnBuscarNumero);
            this.groupBoxBusca.Location = new System.Drawing.Point(640, 15);
            this.groupBoxBusca.Name = "groupBoxBusca";
            this.groupBoxBusca.Size = new System.Drawing.Size(360, 75);
            this.groupBoxBusca.TabIndex = 9;
            this.groupBoxBusca.TabStop = false;
            this.groupBoxBusca.Text = "Buscar por Número";
            // 
            // groupBoxResultados
            // 
            this.groupBoxResultados.Controls.Add(this.dgvNotasFiscais);
            this.groupBoxResultados.Location = new System.Drawing.Point(15, 105);
            this.groupBoxResultados.Name = "groupBoxResultados";
            this.groupBoxResultados.Size = new System.Drawing.Size(1000, 450);
            this.groupBoxResultados.TabIndex = 10;
            this.groupBoxResultados.TabStop = false;
            this.groupBoxResultados.Text = "Resultados";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 603);
            this.Controls.Add(this.groupBoxResultados);
            this.Controls.Add(this.groupBoxBusca);
            this.Controls.Add(this.groupBoxOperacoes);
            this.Controls.Add(this.lblStatus);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Importação de Notas Fiscais - UneCont";
            // this.Load += new System.EventHandler(this.MainForm_Load);
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

