using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanCorp.Apontamento
{
    public class mdlPontos
    {
        public int idFuncionario { get; set; }
        public DateTime periodo { get; set; }
        public string hEntrada { get; set; }
        public string hIntervalo { get; set; }
        public string hRetorno { get; set; }
        public string hSaida { get; set; }
        public string descricao { get; set; }
    }
}
