using System.ComponentModel.DataAnnotations;

namespace Library.Models;

public class Borrow
{
    public int BorrowId { get; set; }
    
    [Required]
    public int BookId { get; set; }
    public Book Book { get; set; }
    
    [Required]
    public int UserId { get; set; }
    public User User { get; set; }
    
    [Required]
    public DateTime BorrowDate { get; set; }
    
    [Required]
    public DateTime? ReturnDate { get; set; }
    
    [Required]
    public BorrowStatus Status { get; set; }
}

public enum BorrowStatus
{
    Returned,
    Borrowed
}