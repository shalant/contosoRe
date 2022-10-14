using ContosoUniversity.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Pages.Courses
{
    public class DepartmentNamePageModel : PageModel
    {
        public SelectList DepartmentNameSL { get; set; }

        public void PopulateDepartmentsDropDownList(SchoolContext _context,
            object selectedDepartment = null)
        {
            var departmentQuery = from d in _context.Departments
                                  orderby d.Name // sort by name
                                  select d;

            DepartmentNameSL = new SelectList(departmentQuery.AsNoTracking(),
                "DepartmentID", "Name", selectedDepartment);
        }
    }
}
