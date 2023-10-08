using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanCorp.ControleLogin
{
    public class Ctl
    {
        private string _login = "HUMANCORP";
        private string _senha = "ADMHC";
        public Boolean ValidarLogin(string login, string senha)
        {
            if (_login == login && _senha == senha)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
