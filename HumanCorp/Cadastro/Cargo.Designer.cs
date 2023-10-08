namespace HumanCorp.Cadastro
{
    partial class Cargo
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
            this.btn_CadastrarCargo = new System.Windows.Forms.Button();
            this.txt_salario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Cargo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_departamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_CadastrarCargo);
            this.groupBox1.Controls.Add(this.txt_salario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Cargo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_departamento);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Cargo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "Excluir Cargo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_CadastrarCargo
            // 
            this.btn_CadastrarCargo.Location = new System.Drawing.Point(504, 127);
            this.btn_CadastrarCargo.Name = "btn_CadastrarCargo";
            this.btn_CadastrarCargo.Size = new System.Drawing.Size(115, 44);
            this.btn_CadastrarCargo.TabIndex = 6;
            this.btn_CadastrarCargo.Text = "Cadastrar Cargo";
            this.btn_CadastrarCargo.UseVisualStyleBackColor = true;
            this.btn_CadastrarCargo.Click += new System.EventHandler(this.btn_CadastrarCargo_Click);
            // 
            // txt_salario
            // 
            this.txt_salario.Location = new System.Drawing.Point(69, 76);
            this.txt_salario.Name = "txt_salario";
            this.txt_salario.Size = new System.Drawing.Size(178, 22);
            this.txt_salario.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salário:";
            // 
            // txt_Cargo
            // 
            this.txt_Cargo.Location = new System.Drawing.Point(343, 30);
            this.txt_Cargo.Name = "txt_Cargo";
            this.txt_Cargo.Size = new System.Drawing.Size(277, 22);
            this.txt_Cargo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cargo:";
            // 
            // cmb_departamento
            // 
            this.cmb_departamento.FormattingEnabled = true;
            this.cmb_departamento.Location = new System.Drawing.Point(108, 30);
            this.cmb_departamento.Name = "cmb_departamento";
            this.cmb_departamento.Size = new System.Drawing.Size(139, 24);
            this.cmb_departamento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamento:";
            // 
            // Cargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 329);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cargo";
            this.Text = "Cargo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_departamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_CadastrarCargo;
        private System.Windows.Forms.TextBox txt_salario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Cargo;
        private System.Windows.Forms.Label label2;
    }
}