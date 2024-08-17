namespace TestProjectMSTest.Valores
{
    [TestClass]
    public class TestaValores
    {
        private int _valor = 0;
        private string _mensagemValorDiferenteDoEsperado = "Falhou! Valor é diferente do esperado.";

        [TestInitialize]
        public async Task SetUp()
        {
            _valor = 1;
        }

        [TestMethod]
        public void VerificaValor_Igual()
        {
            Console.WriteLine($"{_valor} == 1?");
            Assert.AreEqual(_valor, 1, _mensagemValorDiferenteDoEsperado);
        }

        [TestMethod]
        public void VerificaValor_Diferente()
        {
            Console.WriteLine($"{_valor} == 2?");
            Assert.AreEqual(_valor, 2, _mensagemValorDiferenteDoEsperado);
        }
    }
}