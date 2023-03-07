using System;
using System.Collections.Generic;

namespace ThuVienAnh.Models;

public partial class Photo
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Image { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }
}
