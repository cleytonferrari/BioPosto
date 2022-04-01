/*
 
    AL Software
    Rua Rondônia 3716, Alto Paraíso-RO
    CEP: 78956-000
    BRASIL
 
    Contatos:
        Cleyton Ferrari - cleytonferrari@hotmail.com - fone: 69 9975-0504
        Anderson Lopes de Oliveira - andersonlopes14@msn.com - fone: 69 99884966
 
    Copyright © 2008, AL Software / AL Informática
    Todos os direitos reservados.
    
*/
using System;
using System.Data.OleDb;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BioPosto
{
    /// <summary>
    /// Class para o cadastro de Clientes
    /// </summary>
    class clsCliente
    {
        #region campos banco de dados
        /// <summary>
        /// Cria todos os atributos baseado nos atributos do banco de dados 
        /// </summary>
        private int _cliente_id;
        public int cliente_id
        {
            get
            {
                return _cliente_id;
            }
            set
            {
                _cliente_id = value;
            }
        }
        private int _enderecos_id;
        public int enderecos_id
        {
            get
            {
                return _enderecos_id;
            }
            set
            {
                _enderecos_id = value;
            }
        }
        private int _banco_id;
        public int banco_id
        {
            get
            {
                return _banco_id;
            }
            set
            {
                _banco_id = value;
            }
        }
        private string _nome;
        public string nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        private string _datanascimento;
        public string datanascimento
        {
            get
            {
                return _datanascimento;
            }
            set
            {
                _datanascimento = value;
            }
        }
        private string _pai;
        public string pai
        {
            get
            {
                return _pai;
            }
            set
            {
                _pai = value;
            }
        }
        private string _mae;
        public string mae
        {
            get
            {
                return _mae;
            }
            set
            {
                _mae = value;
            }
        }
        //armazena as opções de pagamento: mensal, semestral, anual
        private string _formadepagamento;
        public string formadepagamento
        {
            get
            {
                return _formadepagamento;
            }
            set
            {
                _formadepagamento = value;
            }
        }
        private string _cc;
        public string cc
        {
            get
            {
                return _cc;
            }
            set
            {
                _cc = value;
            }
        }
        private string _ag;
        public string ag
        {
            get
            {
                return _ag;
            }
            set
            {
                _ag = value;
            }
        }
        private string _status;
        public string status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
        private string _cpf;
        public string cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                _cpf = value;
            }
        }
        private string _rg;
        public string rg
        {
            get
            {
                return _rg;
            }
            set
            {
                _rg = value;
            }
        }
        private string _datacadastro;
        public string datacadastro
        {
            get
            {
                return _datacadastro;
            }
            set
            {
                _datacadastro = value;
            }
        }
        private string _telefones;
        public string telefones
        {
            get
            {
                return _telefones;
            }
            set
            {
                _telefones = value;
            }
        }
        private string _email;
        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        private string _obs;
        public string obs
        {
            get
            {
                return _obs;
            }
            set
            {
                _obs = value;
            }
        }
        private string _natural_id;
        public string natural_id
        {
            get
            {
                return _natural_id;
            }
            set
            {
                _natural_id = value;
            }
        }
        private string _estadocivil;
        public string estadocivil
        {
            get
            {
                return _estadocivil;
            }
            set
            {
                _estadocivil = value;
            }
        }
        private string _profissao;
        public string profissao
        {
            get
            {
                return _profissao;
            }
            set
            {
                _profissao = value;
            }
        }
        private string _nacionalidade;
        public string nacionaldidade
        {
            get
            {
                return _nacionalidade;
            }
            set
            {
                _nacionalidade = value;
            }
        }
        private string _sexo;
        public string sexo
        {
            get
            {
                return _sexo;
            }
            set
            {
                _sexo = value;
            }
        }
        private int _vippai_id;
        public int vippai_id
        {
            get
            {
                return _vippai_id;
            }
            set
            {
                _vippai_id = value;
            }
        }
        private string _numero;
        public string numero
        {
            get
            {
                return _numero;
            }
            set
            {
                _numero = value;
            }
        }
        private string _contrato;
        public string contrato
        {
            get
            {
                return _contrato;
            }
            set
            {
                _contrato = value;
            }
        }
        #endregion
        /// <summary>Metodo que executa uma Query SQL que retorna um DataSet</summary>
        /// <param name="strDescricao">Query SQL a ser executada</param>
        /// <returns>Retorna um DataSet com o resultado da consulta da Query SQL</returns>
        public DataSet Listar(string strDescricao)
        {
            //Cria um stringBuilder para concatenar a Query
            StringBuilder strQuery = new StringBuilder();
            //dados do cliente
            strQuery.Append(" SELECT cliente.cliente_id, cliente.nome, cliente.datanascimento, cliente.pai, cliente.mae, ");
            strQuery.Append(" cliente.formadepagamento, cliente.cc, cliente.ag, cliente.status, cliente.cpf, cliente.rg, ");
            strQuery.Append(" cliente.datacadastro, cliente.telefones, cliente.email, cliente.obs, cliente.estadocivil, ");
            strQuery.Append(" cliente.profissao, cliente.nacionalidade, cliente.sexo, cliente.numero, cliente.contrato, natural_id,");
            //dados do endereco
            strQuery.Append(" enderecos.enderecos_id, enderecos.logradouro, enderecos.cep, ");
            strQuery.Append(" enderecos.bairros_id, bairros.nome as bairro, enderecos.municipio_id, ");
            strQuery.Append(" municipio.nome as municipio, municipio.uf, ");
            //natural
            strQuery.Append(" vwmunicipio.nome as vwmunicipio, vwmunicipio.uf as v_uf, ");
            //banco
            strQuery.Append(" banco.banco_id, banco.banco, ");
            //vippai
            strQuery.Append(" vippai.vippai_id, vippai.nome as vippai, vippai.cpf as vippaicpf, vippai.vipavo_id,");
            strQuery.Append(" vippai.painome as vipavo, vippai.paicpf as vipavocpf ");
            //filtros/relacionamentos
            strQuery.Append(" FROM cliente, enderecos, bairros, municipio, vwmunicipio, vippai,banco ");
            strQuery.Append(" WHERE cliente.enderecos_id = enderecos.enderecos_id");
            strQuery.Append(" AND enderecos.bairros_id = bairros.bairros_id ");
            strQuery.Append(" AND enderecos.municipio_id = municipio.municipio_id ");
            strQuery.Append(" AND cliente.natural_id = vwmunicipio.municipio_id ");
            strQuery.Append(" AND cliente.vippai_id = vippai.vippai_id ");
            strQuery.Append(" AND cliente.banco_id = banco.banco_id ");
            //adiciona o filtro de parametro case esteja fazendo uma pesquisa
            if (!(strDescricao.Equals(string.Empty)))
            {
                strQuery.Append(" AND cliente.nome like '%" + strDescricao + "%' ");
            }
            //executa o metodo RetornaDataSet da classe banco de dados e retorna o DataSet
            clsBancoDados clsBancoDados = new clsBancoDados();
            return clsBancoDados.RetornaDataSet(strQuery.ToString());
        }

        /// <summary>
        /// Metodo utilizado nas pesquisas
        /// </summary>
        /// <param name="strCampo">Informe qual campo vai ser utilizado para se pesquisar</param>
        /// <param name="strDescricao">Informe a string a ser pesquisada no strCampo</param>
        /// <param name="tipoPesq">
        /// Informe o tipo da pesquisa:
        /// qualquer : procura em qualquer parte do texto o valor pesquisado; 
        /// comecar : procura texto que comecem com o valor pesquisado;
        /// exato : procura texto que tenha o valor identico ao valor pesquisado.
        /// </param>
        /// <returns>Retorna um DataSet com o resultado da Pesquisa realizada</returns>
        public DataSet ListarComParametro(string strCampo, string strDescricao, string tipoPesq)
        {
            //Cria um stringBuilder para concatenar a Query
            StringBuilder strQuery = new StringBuilder();
            //dados do cliente
            strQuery.Append(" SELECT cliente.cliente_id, cliente.nome, cliente.datanascimento, cliente.pai, cliente.mae, ");
            strQuery.Append(" cliente.formadepagamento, cliente.cc, cliente.ag, cliente.status, cliente.cpf, cliente.rg, ");
            strQuery.Append(" cliente.datacadastro, cliente.telefones, cliente.email, cliente.obs, cliente.estadocivil, ");
            strQuery.Append(" cliente.profissao, cliente.nacionalidade, cliente.sexo, cliente.numero, cliente.contrato, cliente.natural_id, ");
            //dados do endereco
            strQuery.Append(" enderecos.enderecos_id, enderecos.logradouro, enderecos.cep, ");
            strQuery.Append(" enderecos.bairros_id, bairros.nome as bairro, enderecos.municipio_id, ");
            strQuery.Append(" municipio.nome as municipio, municipio.uf, ");
            //natural
            strQuery.Append(" vwmunicipio.nome as vwmunicipio, vwmunicipio.uf as v_uf, ");
            //banco
            strQuery.Append(" banco.banco_id, banco.banco, ");
            //vippai
            strQuery.Append(" vippai.vippai_id, vippai.nome as vippai, vippai.cpf as vippaicpf, vippai.vipavo_id,");
            strQuery.Append(" vippai.painome as vipavo, vippai.paicpf as vipavocpf ");
            //filtros/relacionamentos
            strQuery.Append(" FROM cliente, enderecos, bairros, municipio, vwmunicipio, vippai,banco ");
            strQuery.Append(" WHERE cliente.enderecos_id = enderecos.enderecos_id");
            strQuery.Append(" AND enderecos.bairros_id = bairros.bairros_id ");
            strQuery.Append(" AND enderecos.municipio_id = municipio.municipio_id ");
            strQuery.Append(" AND cliente.natural_id = vwmunicipio.municipio_id ");
            strQuery.Append(" AND cliente.vippai_id = vippai.vippai_id ");
            strQuery.Append(" AND cliente.banco_id = banco.banco_id ");
            //adiciona o filtro de parametro case esteja fazendo uma pesquisa
            if (!(strDescricao.Equals(string.Empty)))
            {
                //Adiciona o tipo de pesquisa
                switch (tipoPesq)
                {
                    case "qualquer": strQuery.Append(" AND " + strCampo + " like '%" + strDescricao + "%' ");
                        break;
                    case "comecar": strQuery.Append(" AND " + strCampo + " like '" + strDescricao + "%' ");
                        break;
                    case "exato": strQuery.Append(" AND " + strCampo + " = '" + strDescricao + "' ");
                        break;
                }

            }
            //executa o metodo RetornaDataSet da classe banco de dados e retorna o DataSet
            clsBancoDados clsBancoDados = new clsBancoDados();
            return clsBancoDados.RetornaDataSet(strQuery.ToString());
        }

        /// <summary>
        /// Utilizado para localizar o registro que vai entrar em edição
        /// </summary>
        /// <param name="intCodigo">Informe o código do registro a ser editado</param>
        /// <returns>Retorna um DataSet com a tupla que sera colocada em edição</returns>
        public DataSet ListarCliente(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            //dados do cliente
            strQuery.Append(" SELECT cliente.cliente_id, cliente.nome, cliente.datanascimento, cliente.pai, cliente.mae, ");
            strQuery.Append(" cliente.formadepagamento, cliente.cc, cliente.ag, cliente.status, cliente.cpf, cliente.rg, ");
            strQuery.Append(" cliente.datacadastro, cliente.telefones, cliente.email, cliente.obs, cliente.estadocivil, ");
            strQuery.Append(" cliente.profissao, cliente.nacionalidade, cliente.sexo, cliente.numero, cliente.contrato, cliente.natural_id,");
            //dados do endereco
            strQuery.Append(" enderecos.enderecos_id, enderecos.logradouro, enderecos.cep, ");
            strQuery.Append(" enderecos.bairros_id, bairros.nome as bairro, enderecos.municipio_id, ");
            strQuery.Append(" municipio.nome as municipio, municipio.uf, ");
            //natural
            strQuery.Append(" vwmunicipio.nome as vwmunicipio, vwmunicipio.uf as v_uf, ");
            //banco
            strQuery.Append(" banco.banco_id, banco.banco, ");
            //vippai
            strQuery.Append(" vippai.vippai_id, vippai.nome as vippai, vippai.cpf as vippaicpf, vippai.vipavo_id,");
            strQuery.Append(" vippai.painome as vipavo, vippai.paicpf as vipavocpf ");
            //filtros/relacionamentos
            strQuery.Append(" FROM cliente, enderecos, bairros, municipio, vwmunicipio, vippai,banco ");
            strQuery.Append(" WHERE cliente.enderecos_id = enderecos.enderecos_id");
            strQuery.Append(" AND enderecos.bairros_id = bairros.bairros_id ");
            strQuery.Append(" AND enderecos.municipio_id = municipio.municipio_id ");
            strQuery.Append(" AND cliente.natural_id = vwmunicipio.municipio_id ");
            strQuery.Append(" AND cliente.vippai_id = vippai.vippai_id ");
            strQuery.Append(" AND cliente.banco_id = banco.banco_id ");
            strQuery.Append(" AND cliente.cliente_id = " + intCodigo + " ");
            clsBancoDados clsBancoDados = new clsBancoDados();
            return clsBancoDados.RetornaDataSet(strQuery.ToString());
        }
        /*
        public void LotaBanco()
        {
            for (int i = 10001; i <= 20000; i++)
            {
                StringBuilder strQuery = new StringBuilder();
                //dados do cliente
                strQuery.Append(" insert into cliente ( ");
                strQuery.Append(" CLIENTE.CLIENTE_ID     , CLIENTE.ENDERECOS_ID     , CLIENTE.BANCO_ID     , CLIENTE.NOME     , CLIENTE.DATANASCIMENTO ");
                strQuery.Append("      , CLIENTE.PAI     , CLIENTE.MAE     , CLIENTE.FORMADEPAGAMENTO     , CLIENTE.CC     , CLIENTE.AG     , CLIENTE.STATUS ");
                strQuery.Append("      , CLIENTE.CPF     , CLIENTE.RG     , CLIENTE.DATACADASTRO     , CLIENTE.TELEFONES     , CLIENTE.EMAIL     , CLIENTE.NATURAL_ID ");
                strQuery.Append("      , CLIENTE.ESTADOCIVIL     , CLIENTE.PROFISSAO     , CLIENTE.NACIONALIDADE     , CLIENTE.SEXO     , CLIENTE.VIPPAI_ID ");
                strQuery.Append("      , CLIENTE.OBS     , CLIENTE.NUMERO     , CLIENTE.BIO1     , CLIENTE.BIO2) ");

                strQuery.Append(" select      ");
                strQuery.Append(" " + i +"  , CLIENTE.ENDERECOS_ID     , CLIENTE.BANCO_ID     , CLIENTE.NOME     , CLIENTE.DATANASCIMENTO ");
                strQuery.Append("      , CLIENTE.PAI     , CLIENTE.MAE     , CLIENTE.FORMADEPAGAMENTO     , CLIENTE.CC     , CLIENTE.AG     , CLIENTE.STATUS ");
                strQuery.Append("      , CLIENTE.CPF     , CLIENTE.RG     , CLIENTE.DATACADASTRO     , CLIENTE.TELEFONES     , CLIENTE.EMAIL ");
                strQuery.Append("      , CLIENTE.NATURAL_ID     , CLIENTE.ESTADOCIVIL     , CLIENTE.PROFISSAO     , CLIENTE.NACIONALIDADE     , CLIENTE.SEXO ");
                strQuery.Append("      , CLIENTE.VIPPAI_ID     , CLIENTE.OBS     , CLIENTE.NUMERO     , CLIENTE.BIO1     , CLIENTE.BIO2 ");

                strQuery.Append(" from cliente ");
                strQuery.Append("      where cliente_id = 3 ");

                clsBancoDados clsBancoDados = new clsBancoDados();
                clsBancoDados.ExecutaComando(strQuery.ToString());
            }
        }*/

        public bool ExisteCliente(int intCodigo)
        {

            
                DataSet oDs = new DataSet();
                oDs = ListarCliente(intCodigo);
                if (oDs.Tables[0].Rows.Count != 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
        }

        public void InserirCliente(string strQuery)
        {
            clsBancoDados clsBancoDados = new clsBancoDados();
            clsBancoDados.ExecutaComando(strQuery);
        }
    }
}
