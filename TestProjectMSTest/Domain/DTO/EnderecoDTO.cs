namespace TestProjectMSTest.Domain.DTO
{
    public class EnderecoDTO
    {
        public string CEP { get; set; }
        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Numero { get; set; }

        public EnderecoDTO(string CEP, string Logradouro, string Bairro, string Numero) 
        {
            this.CEP = CEP;
            this.Logradouro = Logradouro;
            this.Bairro = Bairro;
            this.Numero = Numero;
        }
    }
}