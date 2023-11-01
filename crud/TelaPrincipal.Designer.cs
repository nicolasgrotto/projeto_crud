
namespace crud
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.txtbId = new System.Windows.Forms.TextBox();
            this.txtbIdade = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnlEditar = new System.Windows.Forms.Panel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblClosePanel = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnTelaCadastrar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsFIltrarBtn = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.pnlEditar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAluno
            // 
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAluno.Location = new System.Drawing.Point(107, 42);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.Size = new System.Drawing.Size(569, 194);
            this.dgvAluno.TabIndex = 0;
            this.dgvAluno.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAluno_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "idade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(29, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelId.Location = new System.Drawing.Point(29, 95);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "ID";
            // 
            // txtbNome
            // 
            this.txtbNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbNome.Enabled = false;
            this.txtbNome.Location = new System.Drawing.Point(72, 19);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(286, 20);
            this.txtbNome.TabIndex = 4;
            // 
            // txtbId
            // 
            this.txtbId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbId.Enabled = false;
            this.txtbId.Location = new System.Drawing.Point(72, 92);
            this.txtbId.Name = "txtbId";
            this.txtbId.Size = new System.Drawing.Size(286, 20);
            this.txtbId.TabIndex = 5;
            // 
            // txtbIdade
            // 
            this.txtbIdade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbIdade.Enabled = false;
            this.txtbIdade.Location = new System.Drawing.Point(72, 53);
            this.txtbIdade.Name = "txtbIdade";
            this.txtbIdade.Size = new System.Drawing.Size(286, 20);
            this.txtbIdade.TabIndex = 6;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(23, 142);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(88, 50);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pnlEditar
            // 
            this.pnlEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pnlEditar.Controls.Add(this.btnFiltrar);
            this.pnlEditar.Controls.Add(this.lblClosePanel);
            this.pnlEditar.Controls.Add(this.btnDelete);
            this.pnlEditar.Controls.Add(this.label2);
            this.pnlEditar.Controls.Add(this.btnEditar);
            this.pnlEditar.Controls.Add(this.label1);
            this.pnlEditar.Controls.Add(this.txtbIdade);
            this.pnlEditar.Controls.Add(this.labelId);
            this.pnlEditar.Controls.Add(this.txtbId);
            this.pnlEditar.Controls.Add(this.txtbNome);
            this.pnlEditar.Location = new System.Drawing.Point(287, 212);
            this.pnlEditar.Name = "pnlEditar";
            this.pnlEditar.Size = new System.Drawing.Size(419, 216);
            this.pnlEditar.TabIndex = 8;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(314, 139);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(88, 53);
            this.btnFiltrar.TabIndex = 10;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblClosePanel
            // 
            this.lblClosePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClosePanel.AutoSize = true;
            this.lblClosePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClosePanel.ForeColor = System.Drawing.Color.White;
            this.lblClosePanel.Location = new System.Drawing.Point(395, 0);
            this.lblClosePanel.Margin = new System.Windows.Forms.Padding(0);
            this.lblClosePanel.Name = "lblClosePanel";
            this.lblClosePanel.Size = new System.Drawing.Size(24, 24);
            this.lblClosePanel.TabIndex = 9;
            this.lblClosePanel.Text = "X";
            this.lblClosePanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblClosePanel_MouseClick);
            this.lblClosePanel.MouseEnter += new System.EventHandler(this.lblClosePanel_MouseEnter);
            this.lblClosePanel.MouseLeave += new System.EventHandler(this.lblClosePanel_MouseLeave);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(168, 141);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 51);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "apagar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnTelaCadastrar
            // 
            this.btnTelaCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaCadastrar.Location = new System.Drawing.Point(107, 271);
            this.btnTelaCadastrar.Name = "btnTelaCadastrar";
            this.btnTelaCadastrar.Size = new System.Drawing.Size(144, 53);
            this.btnTelaCadastrar.TabIndex = 9;
            this.btnTelaCadastrar.Text = "Cadastrar Alunos";
            this.btnTelaCadastrar.UseVisualStyleBackColor = true;
            this.btnTelaCadastrar.Click += new System.EventHandler(this.btnTelaCadastrar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFIltrarBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsFIltrarBtn
            // 
            this.tsFIltrarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tsFIltrarBtn.Image = ((System.Drawing.Image)(resources.GetObject("tsFIltrarBtn.Image")));
            this.tsFIltrarBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFIltrarBtn.Name = "tsFIltrarBtn";
            this.tsFIltrarBtn.Size = new System.Drawing.Size(57, 22);
            this.tsFIltrarBtn.Text = "Filtrar";
            this.tsFIltrarBtn.Click += new System.EventHandler(this.tsFIltrarBtn_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnTelaCadastrar);
            this.Controls.Add(this.pnlEditar);
            this.Controls.Add(this.dgvAluno);
            this.Name = "TelaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.pnlEditar.ResumeLayout(false);
            this.pnlEditar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.TextBox txtbId;
        private System.Windows.Forms.TextBox txtbIdade;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel pnlEditar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnTelaCadastrar;
        private System.Windows.Forms.Label lblClosePanel;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsFIltrarBtn;
    }
}

