using System.ComponentModel.DataAnnotations;

namespace Library.Models;

public class BookFile
{
    public int BookFileId { get; set; }
    
    [Required]
    public string FileName { get; set; }
    
    public string Description { get; set; }
    
    [Required]
    public string FilePath { get; set; }
    
    [Required]
    public int BookId { get; set; }
    public Book Book { get; set; }
}