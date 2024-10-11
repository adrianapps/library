﻿using System.ComponentModel.DataAnnotations;

namespace Library.Models;

public class Category
{   
    public int CategoryId { get; set; }
    
    [Required]
    public string Name { get; set; }

    public ICollection<Book> Books { get; set; }
}