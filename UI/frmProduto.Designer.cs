namespace UI {
    partial class frmProduto {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btnSalvar = new Button();
            lblNome = new Label();
            lblQuantidade = new Label();
            txtNome = new TextBox();
            numQuantidade = new NumericUpDown();
            lblDataHora = new Label();
            dgvProdutos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            DataHora = new DataGridViewTextBoxColumn();
            dtpDataHora = new DateTimePicker();
            txtId = new TextBox();
            lblId = new Label();
            btnNovo = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(398, 97);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(101, 19);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(401, 19);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(72, 15);
            lblQuantidade.TabIndex = 2;
            lblQuantidade.Text = "Quantidade:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(101, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(276, 23);
            txtNome.TabIndex = 3;
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(401, 37);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(77, 23);
            numQuantidade.TabIndex = 4;
            // 
            // lblDataHora
            // 
            lblDataHora.AutoSize = true;
            lblDataHora.Location = new Point(41, 80);
            lblDataHora.Name = "lblDataHora";
            lblDataHora.Size = new Size(72, 15);
            lblDataHora.TabIndex = 6;
            lblDataHora.Text = "Data e Hora:";
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Quantidade, DataHora });
            dgvProdutos.Location = new Point(41, 143);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(437, 267);
            dgvProdutos.TabIndex = 7;
            dgvProdutos.CellClick += dgvProdutos_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Quantidade
            // 
            Quantidade.DataPropertyName = "Quantidade";
            Quantidade.HeaderText = "Qtde";
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            // 
            // DataHora
            // 
            DataHora.DataPropertyName = "DataHora";
            DataHora.HeaderText = "Data e Hora";
            DataHora.Name = "DataHora";
            DataHora.ReadOnly = true;
            // 
            // dtpDataHora
            // 
            dtpDataHora.Location = new Point(41, 98);
            dtpDataHora.Name = "dtpDataHora";
            dtpDataHora.Size = new Size(256, 23);
            dtpDataHora.TabIndex = 8;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(41, 37);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(54, 23);
            txtId.TabIndex = 9;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(41, 19);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 10;
            lblId.Text = "Id:";
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(317, 97);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 11;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(403, 416);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // frmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 511);
            Controls.Add(btnExcluir);
            Controls.Add(btnNovo);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(dtpDataHora);
            Controls.Add(dgvProdutos);
            Controls.Add(lblDataHora);
            Controls.Add(numQuantidade);
            Controls.Add(txtNome);
            Controls.Add(lblQuantidade);
            Controls.Add(lblNome);
            Controls.Add(btnSalvar);
            Name = "frmProduto";
            Text = "frmProduto";
            Load += frmProduto_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Label lblNome;
        private Label lblQuantidade;
        private TextBox txtNome;
        private NumericUpDown numQuantidade;
        private Label lblDataHora;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn DataHora;
        private DateTimePicker dtpDataHora;
        private TextBox txtId;
        private Label lblId;
        private Button btnNovo;
        private Button btnExcluir;
    }
}