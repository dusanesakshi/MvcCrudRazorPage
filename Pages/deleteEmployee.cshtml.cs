using ADO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ADO.Pages
{
    public class deleteEmployeeModel : PageModel
    {
        EmployeeDataAccessLayer objemployee = new EmployeeDataAccessLayer();
        public Employee employee { get; set; }
        public ActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            employee = objemployee.GetEmployeeData(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Page();
        }
        public ActionResult OnPost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            objemployee.DeleteEmployee(id);
            return RedirectToPage("./EmployeeIndex");
        }
    }
    }
