using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiTesteUds.Application.Interfaces.Repositories;
using MinimalApiTesteUds.Application.Interfaces.Services;
using MinimalApiTesteUds.Application.Models;

namespace MinimalApiTesteUds.Application.Services;

public class ExternalApiService(IExternalApiRepository externalApiRepository) : IExternalApiService
{

    public async Task<List<ExternalApiModel>> GetPersonOrFiltersAsync(string? name, string? gender)
    {
        var result = await externalApiRepository.GetPersonsAsync();

        return result.Where(r => (string.IsNullOrEmpty(name)
        || r.Name.Contains(name, StringComparison.OrdinalIgnoreCase)) && (string.IsNullOrEmpty(gender)
        || r.Gender.Equals(gender, StringComparison.OrdinalIgnoreCase))).ToList();
    }
}