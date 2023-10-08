namespace HumanCorp.Cadastro
{
    partial class Departamento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_CadastrarDepartamento = new System.Windows.Forms.Button();
            this.txt_DepartamentoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_idDepartamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_CadastrarDepartamento);
            this.groupBox1.Controls.Add(this.txt_DepartamentoNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_idDepartamento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Departamento";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(401, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_CadastrarDepartamento
            // 
            this.btn_CadastrarDepartamento.Location = new System.Drawing.Point(530, 102);
            this.btn_CadastrarDepartamento.Name = "btn_CadastrarDepartamento";
            this.btn_CadastrarDepartamento.Size = new System.Drawing.Size(112, 31);
            this.btn_CadastrarDepartamento.TabIndex = 4;
            this.btn_CadastrarDepartamento.Text = "Cadastrar\r\n";
            this.btn_CadastrarDepartamento.UseVisualStyleBackColor = true;
            this.btn_CadastrarDepartamento.Click += new System.EventHandler(this.btn_CadastrarDepartamento_Click);
            // 
            // txt_DepartamentoNome
            // 
            this.txt_DepartamentoNome.Location = new System.Drawing.Point(286, 52);
            this.txt_DepartamentoNome.Name = "txt_DepartamentoNome";
            this.txt_DepartamentoNome.Size = new System.Drawing.Size(350, 22);
            this.txt_DepartamentoNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txt_idDepartamento
            // 
            this.txt_idDepartamento.Location = new System.Drawing.Point(122, 52);
            this.txt_idDepartamento.Name = "txt_idDepartamento";
            this.txt_idDepartamento.Size = new System.Drawing.Size(47, 22);
            this.txt_idDepartamento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Departamento:";
            // 
            // Departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 170);
            this.Controls.Add(this.groupBox1);
            this.Name = "Departamento";
            this.Text = "Departamento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_CadastrarDepartamento;
        private System.Windows.Forms.TextBox txt_DepartamentoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_idDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}