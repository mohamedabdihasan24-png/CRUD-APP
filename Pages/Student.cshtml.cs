using Azure; 
using Microsoft.AspNetCore.Mvc.RazorPages; 
 
public class StudentModel : PageModel 
{ 
    // Connect to Database  
    private readonly AppDbContext _context; 
    public StudentModel(AppDbContext context) 
    { 
        _context=context; 
    } 
 
    public List<Student> Students {get; set;} 
 
    public void OnGet() 
    { 
        Students=_context.Students.ToList(); 
    } 
} 
 