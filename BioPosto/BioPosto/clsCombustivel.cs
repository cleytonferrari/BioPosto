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
    /// <summary>Class para o cadastro de abastecimento no banco de dados.</summary>
    public class clsCombustivel
    {
        /// <summary>
        /// Cria todos os atributos baseado nos atributos do banco de dados 
        /// </summary>
        private int _combustivel_id;
        public int combustivel_id
        {
            get
            {
                return _combustivel_id;
            }
            set
            {
                _combustivel_id = value;
            }
        }
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
        private string _data;
        public string data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }
        private string _quantidade;
        public string quantidade
        {
            get
            {
                return _quantidade;
            }
            set
            {
                _quantidade = value;
            }
        }
        /// <summary>Metodo que executa uma Query SQL que retorna um DataSet</summary>
        /// <param name="strDescricao">Query SQL a ser executada</param>
        /// <returns>Retorna um DataSet com o resultado da consulta da Query SQL</returns>
        public DataSet Listar(string strDescricao)
        {
            //Cria um stringBuilder para concatenar a Query
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT combustivel_id, cliente_id, data, quantidade ");
            strQuery.Append(" FROM combustivel ");
            //adiciona o filtro de parametro caso esteja fazendo uma pesquisa
            if (!(strDescricao.Equals(string.Empty)))
            {
                strQuery.Append(" WHERE combustivel_id like '%" + strDescricao + "%' ");
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
            strQuery.Append(" SELECT combustivel_id, cliente_id, data, quantidade ");
            strQuery.Append(" FROM combustivel ");
            //adiciona o filtro de parametro case esteja fazendo uma pesquisa
            if (!(strDescricao.Equals(string.Empty)))
            {
                //Adiciona o tipo de pesquisa
                switch (tipoPesq)
                {
                    case "qualquer": strQuery.Append(" WHERE " + strCampo + " like '%" + strDescricao + "%' ");
                        break;
                    case "comecar": strQuery.Append(" WHERE " + strCampo + " like '" + strDescricao + "%' ");
                        break;
                    case "exato": strQuery.Append(" WHERE " + strCampo + " = '" + strDescricao + "' ");
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
        public DataSet ListarCombustivel(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT combustivel_id, cliente_id, data, quantidade ");
            strQuery.Append(" FROM combustivel ");
            strQuery.Append(" WHERE ");
            strQuery.Append("      combustivel_id = " + intCodigo + " ");
            clsBancoDados clsBancoDados = new clsBancoDados();
            return clsBancoDados.RetornaDataSet(strQuery.ToString());
        }


        public DataSet Relatorio(string strData1, string strData2, string strValor)
        {
            //Cria um stringBuilder para concatenar a Query
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT CLIENTE.cliente_id, CLIENTE.nome, CLIENTE.cpf, COMBUSTIVEL.data, ");
            strQuery.Append(" COMBUSTIVEL.quantidade, (COMBUSTIVEL.quantidade * "+strValor+") AS total ");
            strQuery.Append(" FROM CLIENTE, COMBUSTIVEL ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" CLIENTE.CLIENTE_ID = COMBUSTIVEL.CLIENTE_ID AND ");
            strQuery.Append(" DATA BETWEEN '"+strData1+"' AND '"+strData2+"' ");

            //executa o metodo RetornaDataSet da classe banco de dados e retorna o DataSet
            clsBancoDados clsBancoDados = new clsBancoDados();
            return clsBancoDados.RetornaDataSet(strQuery.ToString());
        }

        public DataSet RelatorioTotais(string strData1, string strData2, string strValor)
        {
            //Cria um stringBuilder para concatenar a Query
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" select sum(quantidade) as total, (sum(quantidade)* " + strValor + ") as valor ");
            strQuery.Append(" FROM COMBUSTIVEL ");
            strQuery.Append(" WHERE ");
            strQuery.Append(" DATA BETWEEN '" + strData1 + "' AND '" + strData2 + "' ");

            //executa o metodo RetornaDataSet da classe banco de dados e retorna o DataSet
            clsBancoDados clsBancoDados = new clsBancoDados();
            return clsBancoDados.RetornaDataSet(strQuery.ToString());
        }

        /// <summary>
        /// Exclui um registro do banco de dados
        /// </summary>
        /// <param name="intCodigo">Informe o código do registro a ser excluido</param>
        public void Excluir(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" DELETE FROM combustivel ");
            strQuery.Append(" WHERE combustivel_id = " + intCodigo + " ");
            //executa o comando utilizando a classe banco de dados
            clsBancoDados clsBancoDados = new clsBancoDados();
            clsBancoDados.ExecutaComando(strQuery.ToString());
            MessageBox.Show("Parabens!\nRegistro excluido com sucesso!", Application.ProductName,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Grava um registro no banco de dados, utilizando os valores de 
        /// seus atributos, setados antes da gravação
        /// </summary>
        public void Gravar()
        {
            clsBancoDados clsBancoDados = new clsBancoDados();

            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" INSERT INTO combustivel ");
            strQuery.Append(" ( ");
            strQuery.Append("   combustivel_id, ");
            strQuery.Append("   cliente_id, ");
            strQuery.Append("   data, ");
            strQuery.Append("   quantidade ");
            strQuery.Append(" ) ");
            strQuery.Append(" VALUES ");
            strQuery.Append(" ( ");
            strQuery.Append("   '" + clsBancoDados.GeraID("combustivel", "combustivel_id") + "', ");
            strQuery.Append("   '" + _cliente_id + "', ");
            strQuery.Append("   '" + _data + "', ");
            strQuery.Append("   '" + _quantidade + "' ");
            strQuery.Append(" ) ");
            clsBancoDados.ExecutaComando(strQuery.ToString());
            MessageBox.Show("Parabens!\nRegistro gravado com sucesso!", Application.ProductName,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Altera um registro no banco de dados, utilizando o valor do codigo 
        /// de seu atributo, setado antes da alteraçao
        /// </summary>
        public void Alterar()
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" UPDATE combustivel ");
            strQuery.Append(" SET ");
            strQuery.Append("     cliente_id = '" + _cliente_id + "', ");
            strQuery.Append("     data = '" + _data + "', ");
            strQuery.Append("     quantidade = '" + _quantidade + "' ");
            strQuery.Append(" WHERE ");
            strQuery.Append("      combustivel_id = " + _combustivel_id + " ");
            clsBancoDados clsBancoDados = new clsBancoDados();
            clsBancoDados.ExecutaComando(strQuery.ToString());
            MessageBox.Show("Parabens!\nRegistro gravado com sucesso!", Application.ProductName,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
