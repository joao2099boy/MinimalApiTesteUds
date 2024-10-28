using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinimalApiTesteUds.Application.Models;

namespace MinimalApiTesteUds.Application.Interfaces.Services;

public interface IExternalApiService
{
    Task<List<ExternalApiModel>> GetPersonOrFiltersAsync(string? name, string? gender);
}