using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
public class RegisterModel: PageModel
{
private readonly AppDbContext _context;
public RegisterModel(AppDbContext context)
{
_context=context;
}
[BindProperty]
public string Name { get; set; }
[BindProperty]
public string Address { get; set; }
[BindProperty]
public DateTime Date { get; set; }
[BindProperty]
public string Gender { get; set; }
public IActionResult OnPost()
{
var student = new Student
{
Name=Name,
Address=Address,
Date=Date,
Gender=Gender,
};
_context.Students.Add(student);
_context.SaveChanges();
return RedirectToPage();
}
}