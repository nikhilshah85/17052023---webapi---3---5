using System;
using System.Collections.Generic;

namespace shoppingAPI_Azure.Models.EF;

public partial class MProductList
{
    public int PId { get; set; }

    public string? PCompany { get; set; }

    public string? PProduct { get; set; }

    public string? PStock { get; set; }
}
