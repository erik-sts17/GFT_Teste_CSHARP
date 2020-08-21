using System;
using System.Collections.Generic;
using System.Text;

namespace POO_ClassePessoa
{
    class Pessoa
    {
        private string _nome;
        private string _endereco;
        private string _telefone;

        public string GetNome()
        {
            return _nome;
        }

        public void setNome(string nome)
        {
            _nome = nome;
        }

        public string GetEndereco()
        {
            return _endereco;
        }

        public void setEndereco(string endereco)
        {
            _endereco = endereco;
        }

        public string GetTelefone()
        {
            return _telefone;
        }

        public void setTelefone(string telefone)
        {
            _telefone = telefone;
        }

        public Pessoa(string nome, string endereco, string telefone)
        {
            _nome = nome;
            _endereco = endereco;
            _telefone = telefone;
        }

        public override string ToString()
        {
            return 
                "Nome: " + GetNome() +
                "\nEndereco : " + GetEndereco() +
                "\nTelefone: " + GetTelefone() + 
                "\n" ;
        }
    }
}
