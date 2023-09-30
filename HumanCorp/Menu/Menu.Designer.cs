namespace HumanCorp.Menu
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folhaSalarialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apontamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aasdasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adsadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.apontamentoToolStripMenuItem,
            this.folhaSalarialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1207, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aasdasToolStripMenuItem,
            this.departamentoToolStripMenuItem,
            this.cargoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // folhaSalarialToolStripMenuItem
            // 
            this.folhaSalarialToolStripMenuItem.Name = "folhaSalarialToolStripMenuItem";
            this.folhaSalarialToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.folhaSalarialToolStripMenuItem.Text = "Folha Salarial";
            // 
            // apontamentoToolStripMenuItem
            // 
            this.apontamentoToolStripMenuItem.Name = "apontamentoToolStripMenuItem";
            this.apontamentoToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.apontamentoToolStripMenuItem.Text = "Apontamento";
            // 
            // aasdasToolStripMenuItem
            // 
            this.aasdasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adsadToolStripMenuItem});
            this.aasdasToolStripMenuItem.Name = "aasdasToolStripMenuItem";
            this.aasdasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aasdasToolStripMenuItem.Text = "Funcionário";
            // 
            // adsadToolStripMenuItem
            // 
            this.adsadToolStripMenuItem.Name = "adsadToolStripMenuItem";
            this.adsadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adsadToolStripMenuItem.Text = "adsad";
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.departamentoToolStripMenuItem.Text = "Departamento";
            // 
            // cargoToolStripMenuItem
            // 
            this.cargoToolStripMenuItem.Name = "cargoToolStripMenuItem";
            this.cargoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cargoToolStripMenuItem.Text = "cargo";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 513);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folhaSalarialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aasdasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adsadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apontamentoToolStripMenuItem;
    }
}