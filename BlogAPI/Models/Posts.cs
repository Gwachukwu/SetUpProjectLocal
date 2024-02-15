using System.ComponentModel.DataAnnotations;
namespace BlogAPI.Models;

public class Post
{
    public int BlogId {get; set;}
    [Key]
    public int Id {get; set;}
    public DateTime PublishDate {get; set;}
    public string? Name {get; set;}
    public string Content  {get; set;}
};