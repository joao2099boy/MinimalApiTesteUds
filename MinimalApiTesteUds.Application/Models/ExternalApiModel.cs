using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalApiTesteUds.Application.Models;

public record ExternalApiModel
{
    public string Name { get; init; }
    public string Gender { get; init; }
}