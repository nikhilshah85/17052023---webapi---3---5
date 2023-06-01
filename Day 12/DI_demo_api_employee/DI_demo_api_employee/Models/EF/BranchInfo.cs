using System;
using System.Collections.Generic;

namespace DI_demo_api_employee.Models.EF;

public partial class BranchInfo
{
    public int BrNo { get; set; }

    public string? BrName { get; set; }

    public string? BrCity { get; set; }
}
