using System;
using System.Collections.Generic;

namespace DataLayer.Models;

public partial class ValidationInfo
{
    public int Id { get; set; }

    public string CardType { get; set; } = null!;

    public int Length { get; set; }

    public string StartWith { get; set; } = null!;
}
