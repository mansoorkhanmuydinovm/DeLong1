﻿using DeLong.Domain.Common;

namespace DeLong.Domain.Entities;

public class Category : Auditable
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
