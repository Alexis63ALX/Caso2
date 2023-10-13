using System;
using System.Collections.Generic;

namespace Caso2.Models;

public partial class Country
{
    public int IdCountry { get; set; }

    public string? Descripcion { get; set; }

    public string? Code { get; set; }

    public string? Currency { get; set; }
}
