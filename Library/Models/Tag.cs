using System.ComponentModel.DataAnnotations;

namespace Library.Models;

public class Tag
{
    public int TagId { get; set; }
    
    [Required]
    public string Name { get; set; }
    
    public ICollection<Book> Books { get; set; }
}