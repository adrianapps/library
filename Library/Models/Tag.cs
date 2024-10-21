﻿using System.ComponentModel.DataAnnotations;

namespace Library.Models;

public class Tag
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Book>? Books { get; set; }
}