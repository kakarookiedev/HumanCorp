using HumanCorp.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanCorp.Cadastro
{
    public partial class Departamento : Form
    {
        public Departamento()
        {
            InitializeComponent();
        }

        private void btn_CadastrarDepartamento_Click(object sender, EventArgs e)
        {
            mdlDepartamento Ctl = new mdlDepartamento();

            MessageBox.Show("Departamento Cadastrado");

            Ctl.idDepartamento = int.Parse(txt_idDepartamento.Text);
            Ctl.departamentoNome = txt_DepartamentoNome.Text;
        }
    }
}
