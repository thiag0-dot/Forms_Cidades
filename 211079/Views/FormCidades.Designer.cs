namespace _211079.Views
{
    partial class FormCidades
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_cidades = new System.Windows.Forms.DataGridView();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cidades)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cidade:";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(27, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.Size = new System.Drawing.Size(408, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtUF
            // 
            this.txtUF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUF.Location = new System.Drawing.Point(456, 44);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(122, 20);
            this.txtUF.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "UF:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.dgv_cidades);
            this.groupBox1.Controls.Add(this.btn_pesquisar);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(27, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 273);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // dgv_cidades
            // 
            this.dgv_cidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cidades.Location = new System.Drawing.Point(10, 99);
            this.dgv_cidades.Name = "dgv_cidades";
            this.dgv_cidades.Size = new System.Drawing.Size(658, 151);
            this.dgv_cidades.TabIndex = 14;
            this.dgv_cidades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cidades_CellContentClick);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_pesquisar.BackgroundImage = global::_211079.Properties.Resources.Lupa;
            this.btn_pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_pesquisar.FlatAppearance.BorderSize = 0;
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_pesquisar.Location = new System.Drawing.Point(572, 16);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(96, 58);
            this.btn_pesquisar.TabIndex = 12;
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(10, 50);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(541, 24);
            this.txtPesquisa.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Digite o nome da cidade para pesquisa:";
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackgroundImage = global::_211079.Properties.Resources.Excluir;
            this.btn_excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Location = new System.Drawing.Point(420, 101);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(122, 54);
            this.btn_excluir.TabIndex = 10;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackgroundImage = global::_211079.Properties.Resources.Fechar;
            this.btn_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Location = new System.Drawing.Point(588, 101);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(122, 54);
            this.btn_fechar.TabIndex = 9;
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = global::_211079.Properties.Resources.Cancelar;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(283, 101);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(122, 54);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackgroundImage = global::_211079.Properties.Resources.Alterar;
            this.btn_alterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alterar.FlatAppearance.BorderSize = 0;
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.Location = new System.Drawing.Point(155, 101);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(122, 54);
            this.btn_alterar.TabIndex = 7;
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.BackgroundImage = global::_211079.Properties.Resources.Adicionar1;
            this.btn_iniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_iniciar.FlatAppearance.BorderSize = 0;
            this.btn_iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_iniciar.Location = new System.Drawing.Point(27, 101);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(122, 54);
            this.btn_iniciar.TabIndex = 6;
            this.btn_iniciar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click_1);
            // 
            // FormCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(753, 529);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Name = "FormCidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cidades";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCidades_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_cidades;
    }
}