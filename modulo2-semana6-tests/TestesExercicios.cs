namespace modulo2_semana6_tests {
    public class TestesExercicios : ConfiguracaoHostApi {

        [Theory]
        [InlineData("true")]
        public async Task Teste_Exercicio_1_Texto_Verdadeiro_Sucesso(string tipo) {

            var resultado = await client.GetAsync($"/Exercicio1/{tipo}");
            Assert.NotNull(resultado);

            var responseApi = await resultado.Content.ReadAsStringAsync();

            Assert.NotNull(responseApi);
            Assert.Equal("true",tipo);

        }

        [Theory]
        [InlineData("false")]
        public async Task Teste_Exercicio_1_Texto_Falso_Sucesso(string tipo) {

            var resultado = await client.GetAsync($"/Exercicio1/{tipo}");
            Assert.NotNull(resultado);

            var responseApi = await resultado.Content.ReadAsStringAsync();

            Assert.NotNull(responseApi);
            Assert.Equal("false",tipo);

        }

        [Theory]
        [InlineData("natanael@email.com")]
        [InlineData("email@email.com")]
        [InlineData("teste.com")]
        public async Task Teste_Exercicio_6_Validacao_Email_Sucesso(string email){
            
            var resultado = await client.GetAsync($"/Exercicio4/{email}");
            Assert.NotNull(resultado);

            var responseApi = await resultado.Content.ReadAsStringAsync();

            Assert.NotNull(responseApi);
            Assert.Equal("E-mail válido",responseApi);
        }

        [Theory]
        [InlineData("natanael@email")]
        [InlineData("email.com")]
        [InlineData("teste.com")]
        [InlineData("teste@email.com")]
        public async Task Teste_Exercicio_6_Validacao_Email_Erro(string email){
            
            var resultado = await client.GetAsync($"/Exercicio4/{email}");
            Assert.NotNull(resultado);

            var responseApi = await resultado.Content.ReadAsStringAsync();

            Assert.NotNull(responseApi);
            Assert.Equal("E-mail inválido",responseApi);
        }
    }
}
