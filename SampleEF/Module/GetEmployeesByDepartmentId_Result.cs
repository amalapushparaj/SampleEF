using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEF.Module
{
    public class GetEmployeesByDepartmentId_Result
    {
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }
    }
}
