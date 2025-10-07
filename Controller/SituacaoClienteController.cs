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

        public void ListarSitucao(string termo = "")
        {
            var listaSituacao = _situacaoAtendimentoRepository.Listar(termo);
            _frmCadastroSituacaoAtendimento.ExibirSituacoes(_situacaoAtendimentoRepository.Listar(termo));
            _frmCadastroSituacaoAtendimento.ExibirSituacoes(listaSituacao);
        }

        public void Salvar(SituacaoAtendimento situacaoAtendimento)
        {
            try
            {
                _situacaoAtendimentoRepository.Inserir(situacaoAtendimento);
                _frmCadastroSituacaoAtendimento.ExibirMensagem("Situação de atendimento cadastrada com sucesso!");
                ListarSitucao();
                _frmCadastroSituacaoAtendimento.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroSituacaoAtendimento.ExibirMensagem($"Erro ao salvar a situação de atendimento: {ex.Message}");
            }
        }

        public void Atualizar(SituacaoAtendimento situacaoAtendimento)
        {

            try
            {
                _situacaoAtendimentoRepository.Atualizar(situacaoAtendimento);
                _frmCadastroSituacaoAtendimento.ExibirMensagem("Situação de atendimento atualizada com sucesso!");
                ListarSitucao();

                _frmCadastroSituacaoAtendimento.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroSituacaoAtendimento.ExibirMensagem($"Erro ao atualizar a Situação de atendimento: {ex.Message}");
            }

            
        }

        public void Deletar(SituacaoAtendimento situacaoAtendimento)
        {
            try
            {
                var confirmacao = MessageBox.Show("Tem certeza que deseja deletar esta situação de atendimento?", "Confirmação", MessageBoxButtons.YesNo);

                if (confirmacao == DialogResult.Yes)
                {
                    _situacaoAtendimentoRepository.Deletar(situacaoAtendimento);
                    _frmCadastroSituacaoAtendimento.ExibirMensagem("Situação de atendimento deletada com sucesso!");
                    ListarSitucao();
                    _frmCadastroSituacaoAtendimento.DesabilitarCampos();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Não foi possível deletar essa situação: {ex.Message}");
            }
        }
    }
}
