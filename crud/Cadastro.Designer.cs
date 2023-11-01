
namespace crud
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCloseApplication = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.txtbIdade = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Idade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "CADASTRAR ALUNO";
            // 
            // lblCloseApplication
            // 
            this.lblCloseApplication.AutoSize = true;
            this.lblCloseApplication.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblCloseApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseApplication.ForeColor = System.Drawing.Color.Black;
            this.lblCloseApplication.Location = new System.Drawing.Point(775, -1);
            this.lblCloseApplication.Name = "lblCloseApplication";
            this.lblCloseApplication.Size = new System.Drawing.Size(26, 25);
            this.lblCloseApplication.TabIndex = 3;
            this.lblCloseApplication.Text = "X";
            this.lblCloseApplication.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblCloseApplication_MouseClick);
            this.lblCloseApplication.MouseEnter += new System.EventHandler(this.lblCloseApplication_MouseEnter);
            this.lblCloseApplication.MouseLeave += new System.EventHandler(this.lblCloseApplication_MouseLeave);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(357, 339);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(113, 40);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(325, 175);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(194, 20);
            this.txtbNome.TabIndex = 5;
            // 
            // txtbIdade
            // 
            this.txtbIdade.Location = new System.Drawing.Point(325, 245);
            this.txtbIdade.Name = "txtbIdade";
            this.txtbIdade.Size = new System.Drawing.Size(194, 20);
            this.txtbIdade.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbIdade);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblCloseApplication);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCloseApplication;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.TextBox txtbIdade;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}