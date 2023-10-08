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
    public partial class Cargo : Form
    {
        public Cargo()
        {
            InitializeComponent();
        }

        private void btn_CadastrarCargo_Click(object sender, EventArgs e)
        {
            mdlCargo Ctl = new mdlCargo();

            MessageBox.Show("Cargo Cadastrado.");

            Ctl.idDepartamento = cmb_departamento.TabIndex;
            Ctl.Cargo = txt_Cargo.Text;
            Ctl.Salario = double.Parse(txt_salario.Text);


        }
    }
}
