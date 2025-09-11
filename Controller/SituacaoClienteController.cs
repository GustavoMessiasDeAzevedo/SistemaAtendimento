using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaAtendimento.Model;
using SistemaAtendimento.Repositories;
using SistemaAtendimento.View;

namespace SistemaAtendimento.Controller
{
    public class SituacaoClienteController
    {
        private FrmCadastroSituacaoAtendimento _frmCadastroSituacaoAtendimento;
        private SituacaoAtendimentoRepository _situacaoAtendimentoRepository;

        public SituacaoClienteController(FrmCadastroSituacaoAtendimento view)
        {
            _frmCadastroSituacaoAtendimento = view;
            _situacaoAtendimentoRepository = new SituacaoAtendimentoRepository();
        }

        public void ListarSitucao()
        {
            var listaSituacao = _situacaoAtendimentoRepository.Listar();
            _frmCadastroSituacaoAtendimento.ExibirSituacoes(listaSituacao);
        }

        public void Salvar(SituacaoAtendimento situacaoAtendimento)
        {
            try
            {
                _situacaoAtendimentoRepository.Inserir(situacaoAtendimento);
                _frmCadastroSituacaoAtendimento.ExibirMensagem("Situação de atendimento cadastrada com sucesso!");
                ListarSitucao();
            }
            catch (Exception ex)
            {
                _frmCadastroSituacaoAtendimento.ExibirMensagem($"Erro ao salvar a situação de atendimento: {ex.Message}");
            }
        }
    }
}
