using Microsoft.AspNetCore.Mvc.Testing;
using modulo2_semana6_api;

namespace modulo2_semana6_tests;

public class ConfiguracaoHostApi {

    private const string url = "https://localhost:5000";
    private protected HttpClient client;

    public ConfiguracaoHostApi() {
        var application = new WebApplicationFactory<Program>();
        application.ClientOptions.BaseAddress = new(url);
        client = application.CreateClient();
    }
}