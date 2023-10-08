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

namespace HumanCorp.Apontamento
{
    public partial class RegistroHoras : Form
    {
        public RegistroHoras()
        {
            InitializeComponent();
        }

        private void btn_registrarPontos_Click(object sender, EventArgs e)
        {
            mdlPontos Ctl = new mdlPontos();

            Ctl.idFuncionario = cmb_idFuncionario.TabIndex;
            Ctl.periodo = dt_periodo.Value;
            Ctl.hEntrada = txt_hEntrada.Text;
            Ctl.hIntervalo = txt_hIntervalo.Text;
            Ctl.hRetorno = txt_hRetorno.Text;
            Ctl.hSaida = txt_hSaida.Text;
            Ctl.observacao = txt_observacao.Text;
        }
    }
}
