
using System.Windows.Forms;

using HumanCorp.ControleLogin;

namespace HumanCorp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void btn_logar_Click(object sender, System.EventArgs e)
        {
            Ctl Ctl = new Ctl();

            string login = txt_login.Text.ToUpper();
            string senha = txt_senha.Text.ToUpper();

            if (Ctl.ValidarLogin(login, senha))
            {
                MessageBox.Show("Login Feito");
            } 
            else
            {
                MessageBox.Show("Erro");
            }
        }
    }
}
