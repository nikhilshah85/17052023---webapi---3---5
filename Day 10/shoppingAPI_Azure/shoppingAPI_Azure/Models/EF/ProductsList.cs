using System;
using System.Collections.Generic;

namespace shoppingAPI_Azure.Models.EF;

public partial class ProductsList
{
    public int Pid { get; set; }

    public string? Pname { get; set; }

    public string? Pcategory { get; set; }

    public int? Pprice { get; set; }

    public bool? PIsInStock { get; set; }
}
