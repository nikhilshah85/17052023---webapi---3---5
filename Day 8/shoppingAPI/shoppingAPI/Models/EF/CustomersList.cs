using System;
using System.Collections.Generic;

namespace shoppingAPI.Models.EF;

public partial class CustomersList
{
    public int CId { get; set; }

    public string? CName { get; set; }

    public string? CType { get; set; }

    public int? CWalletBalance { get; set; }
}
