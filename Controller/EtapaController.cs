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

        public void ListarEtapas() 
        { 
            var listarEtapas = _etapaRepository.Listar();
            _frmCadastroEtapa.ExibirEtapas(listarEtapas);
        }

        public void Salvar(Etapas etapa)
        {
            try 
            { 
                _etapaRepository.Inserir(etapa);
                _frmCadastroEtapa.ExibirMensagem("Etapa cadastrada com sucesso!");
                ListarEtapas();
            }
            catch (Exception ex)
            { 
                _frmCadastroEtapa.ExibirMensagem($"Erro ao salvar a etapa: {ex.Message}");
            }
        }
    }
}
