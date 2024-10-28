using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalApiTesteUds.Application.Models;

public record ExternalApiResponse
{
   public List<ExternalApiModel> Results { get; set; }
}