using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaControleVendas
{
    class ClassVendasNaoContabilizada
    {

        string _sql;
        string stringConn = ClassSeguranca.Descriptografar("9UUEoK5YaRaXjDXC9eLqkg7Prh31kSiCYidze0zIx2X787RW+Zpgc9frlclEXhdH70DIx06R57s6u2h3wX/ke2zixO52OdEzjJQ0vke62X8XuSqZtzzrbphZQivXUYi4");

        private int Codigo;
        private string Nome;      
        private string Bairro;
        private string Endereco;
        private string Numero;
        private string Telefone;
        private decimal ValorVenda;
        private string DataVenda;

        public int codigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        public string nome
        {
            get { return Nome; }
            set { Nome = value; }
        }
        public string bairro
        {
            get { return Bairro; }
            set { Bairro = value; }
        }
        public string endereco
        {
            get { return Endereco; }
            set { Endereco = value; }
        }
        public string numero
        {
            get { return Numero; }
            set { Numero = value; }
        }
        public string telefone
        {
            get { return Telefone; }
            set { Telefone = value; }
        }
        public decimal valorVenda
        {
            get { return ValorVenda; }
            set { ValorVenda = value; }
        }
        public string dataVenda
        {
            get { return DataVenda; }
            set { DataVenda = value; }
        }

        public void ConfimarVendaNaoContabilizada()
        {

        }

        public void EditarVendaNaoContabilizada()
        {

        }
    }
}
