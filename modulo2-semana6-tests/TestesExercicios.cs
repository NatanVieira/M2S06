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
    }
}
