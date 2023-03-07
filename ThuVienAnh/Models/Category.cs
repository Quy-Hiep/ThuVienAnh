using System;
using System.Collections.Generic;

namespace ThuVienAnh.Models;

public partial class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Image { get; set; }

    public virtual ICollection<Photo> Photos { get; } = new List<Photo>();
}
