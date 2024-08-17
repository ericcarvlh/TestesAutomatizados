using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectMSTest.Domain.DTO
{
    public class PessoaDTO
    {
        public string NomePessoa { get; set; }
        public string SexoPessoa { get; set; }
        public DateTime DataNascimento { get; set; }
        public EnderecoDTO Endereco { get; set; }

        public PessoaDTO(string nomePessoa, string sexoPessoa, DateTime dataNascimento, EnderecoDTO endereco) 
        {
            this.NomePessoa = nomePessoa;
            this.SexoPessoa = sexoPessoa;
            this.DataNascimento = dataNascimento;
            this.Endereco = endereco;
        }
    }
}
