using ADO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ADO.Pages
{
    public class createEmployeeModel : PageModel
    {
        EmployeeDataAccessLayer objemployee = new EmployeeDataAccessLayer();
        [BindProperty]
        public Employee employee { get; set; }
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            objemployee.AddEmployee(employee);
            return RedirectToPage("./employeeIndex");

        }   
    }
}
