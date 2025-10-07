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
    public class EtapaController
    {
        private FrmCadastroEtapa _frmCadastroEtapa;
        private EtapaRepository _etapaRepository;

        public EtapaController(FrmCadastroEtapa view) 
        {
            _frmCadastroEtapa = view;
            _etapaRepository = new EtapaRepository();
        }

        public void ListarEtapas(string termo = "") 
        { 
            var listarEtapas = _etapaRepository.Listar(termo);
            _frmCadastroEtapa.ExibirEtapas(_etapaRepository.Listar(termo));
            _frmCadastroEtapa.ExibirEtapas(listarEtapas);
        }

        public void Salvar(Etapas etapa)
        {
            try 
            { 
                _etapaRepository.Inserir(etapa);
                _frmCadastroEtapa.ExibirMensagem("Etapa cadastrada com sucesso!");
                ListarEtapas();
                _frmCadastroEtapa.DesabilitarCampos();
            }
            catch (Exception ex)
            { 
                _frmCadastroEtapa.ExibirMensagem($"Erro ao salvar a etapa: {ex.Message}");
            }
        }


        public void Atualizar(Etapas etapa)
        {

            try
            {
                _etapaRepository.Atualizar(etapa);
                _frmCadastroEtapa.ExibirMensagem("Etapa atualizada com sucesso!");
                ListarEtapas();

                _frmCadastroEtapa.DesabilitarCampos();
            }
            catch (Exception ex)
            {
                _frmCadastroEtapa.ExibirMensagem($"Erro ao atualizar a etapa: {ex.Message}");
            }
        }

        public void Deletar(Etapas etapa)
        {
            try
            {
                var confirmacao = MessageBox.Show("Tem certeza que deseja deletar esta etapa?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirmacao == DialogResult.Yes)
                {
                    _etapaRepository.Deletar(etapa);
                    _frmCadastroEtapa.ExibirMensagem("Etapa deletada com sucesso!");
                    ListarEtapas();
                    _frmCadastroEtapa.DesabilitarCampos();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Não foi possível deletar a etapa: {ex.Message}");
            }
        }
    }
}
