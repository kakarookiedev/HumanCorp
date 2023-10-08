namespace HumanCorp.Apontamento
{
    partial class RegistroHoras
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
            this.btn_registrarPontos = new System.Windows.Forms.Button();
            this.txt_observacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_hSaida = new System.Windows.Forms.TextBox();
            this.txt_hRetorno = new System.Windows.Forms.TextBox();
            this.txt_hIntervalo = new System.Windows.Forms.TextBox();
            this.txt_hEntrada = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_periodo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_idFuncionario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_registrarPontos);
            this.groupBox1.Controls.Add(this.txt_observacao);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_hSaida);
            this.groupBox1.Controls.Add(this.txt_hRetorno);
            this.groupBox1.Controls.Add(this.txt_hIntervalo);
            this.groupBox1.Controls.Add(this.txt_hEntrada);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dt_periodo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_idFuncionario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Pontos de Funcionário";
            // 
            // btn_registrarPontos
            // 
            this.btn_registrarPontos.Location = new System.Drawing.Point(554, 203);
            this.btn_registrarPontos.Name = "btn_registrarPontos";
            this.btn_registrarPontos.Size = new System.Drawing.Size(134, 48);
            this.btn_registrarPontos.TabIndex = 13;
            this.btn_registrarPontos.Text = "Registrar";
            this.btn_registrarPontos.UseVisualStyleBackColor = true;
            this.btn_registrarPontos.Click += new System.EventHandler(this.btn_registrarPontos_Click);
            // 
            // txt_observacao
            // 
            this.txt_observacao.Location = new System.Drawing.Point(178, 144);
            this.txt_observacao.Name = "txt_observacao";
            this.txt_observacao.Size = new System.Drawing.Size(100, 22);
            this.txt_observacao.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Observação";
            // 
            // txt_hSaida
            // 
            this.txt_hSaida.Location = new System.Drawing.Point(539, 84);
            this.txt_hSaida.Name = "txt_hSaida";
            this.txt_hSaida.Size = new System.Drawing.Size(59, 22);
            this.txt_hSaida.TabIndex = 10;
            // 
            // txt_hRetorno
            // 
            this.txt_hRetorno.Location = new System.Drawing.Point(398, 87);
            this.txt_hRetorno.Name = "txt_hRetorno";
            this.txt_hRetorno.Size = new System.Drawing.Size(59, 22);
            this.txt_hRetorno.TabIndex = 9;
            // 
            // txt_hIntervalo
            // 
            this.txt_hIntervalo.Location = new System.Drawing.Point(238, 84);
            this.txt_hIntervalo.Name = "txt_hIntervalo";
            this.txt_hIntervalo.Size = new System.Drawing.Size(59, 22);
            this.txt_hIntervalo.TabIndex = 8;
            // 
            // txt_hEntrada
            // 
            this.txt_hEntrada.Location = new System.Drawing.Point(93, 84);
            this.txt_hEntrada.Name = "txt_hEntrada";
            this.txt_hEntrada.Size = new System.Drawing.Size(59, 22);
            this.txt_hEntrada.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Saída";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Retorno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Intervalo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Entrada";
            // 
            // dt_periodo
            // 
            this.dt_periodo.Location = new System.Drawing.Point(398, 42);
            this.dt_periodo.Name = "dt_periodo";
            this.dt_periodo.Size = new System.Drawing.Size(200, 22);
            this.dt_periodo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Observação:";
            // 
            // cmb_idFuncionario
            // 
            this.cmb_idFuncionario.FormattingEnabled = true;
            this.cmb_idFuncionario.Location = new System.Drawing.Point(92, 44);
            this.cmb_idFuncionario.Name = "cmb_idFuncionario";
            this.cmb_idFuncionario.Size = new System.Drawing.Size(130, 24);
            this.cmb_idFuncionario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funcionário:";
            // 
            // RegistroHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 299);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistroHoras";
            this.Text = "RegistroHoras";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_registrarPontos;
        private System.Windows.Forms.TextBox txt_observacao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_hSaida;
        private System.Windows.Forms.TextBox txt_hRetorno;
        private System.Windows.Forms.TextBox txt_hIntervalo;
        private System.Windows.Forms.TextBox txt_hEntrada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_periodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_idFuncionario;
        private System.Windows.Forms.Label label1;
    }
}