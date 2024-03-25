using ADO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ADO.Pages
{
    public class editEmployeeModel : PageModel
    {
        EmployeeDataAccessLayer objemployee = new EmployeeDataAccessLayer();
        [BindProperty]
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
        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            objemployee.UpdateEmployee(employee);
            return RedirectToPage("./employeeIndex");
        }
    }

}

