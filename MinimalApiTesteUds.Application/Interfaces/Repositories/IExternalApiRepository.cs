using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinimalApiTesteUds.Application.Models;

namespace ApiTesteUds.Application.Interfaces.Repositories;

public interface IExternalApiRepository
{
    Task<List<ExternalApiModel>> GetPersonsAsync();
}