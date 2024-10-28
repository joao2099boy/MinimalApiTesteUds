using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MinimalApiTesteUds.Application.Models;
using ApiTesteUds.Application.Interfaces.Repositories;

namespace MinimalApiTesteUds.Infraestructure.Repositories;

public class ExternalApiRepository(HttpClient httpClient) : IExternalApiRepository
{
    public async Task<List<ExternalApiModel>> GetPersonsAsync()
    {
        var response = await httpClient.GetStringAsync("https://swapi.dev/api/people/");
        
        var result = JsonConvert.DeserializeObject<ExternalApiResponse>(response);

        return result?.Results ?? [];
    }
}