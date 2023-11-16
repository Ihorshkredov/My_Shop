using System;
using System.Collections.Generic;

namespace My_Shop.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public int? Quantity { get; set; }
}
