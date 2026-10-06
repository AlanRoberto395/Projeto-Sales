using SalesWebMvc.Models;
using System.Linq;

namespace SalesWebMvc.Services

{
    public class DepartmentService
    {
                private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {

            _context = context;
        }

        public List<Department> Findall()
        {

            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
