using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

public class Book
{
    public int BookId { get; set; }
    
    [Required]
    [StringLength(50, ErrorMessage = "Title cannot be longer than 50 characters")]
    public string Title { get; set; }
    
    [Required]
    [StringLength(13, ErrorMessage = "ISBN cannot be longer than 13 characters")]
    public string ISBN { get; set; }
    
    public string Description { get; set; }
    
    [DataType(DataType.Date)] 
    public DateTime ReleaseDate { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public ICollection<Tag> Tags { get; set; } = new List<Tag>();
    
    public ICollection<BookFile> Files { get; set; } = new List<BookFile>();

    [Required]
    public int Stock { get; set; }
    
    public ICollection<Borrow> Borrows { get; set; } = new List<Borrow>();
}