using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAtendimento.Model
{
    public class SituacaoAtendimento
    {
        public int? Id { get; set; }
        public string? nome { get; set; }
        public string? cor { get; set; }
        public bool? Ativo { get; set; }
    }
}
