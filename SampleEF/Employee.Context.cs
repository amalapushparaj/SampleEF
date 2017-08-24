﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleEF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    using SampleEF.Module;
    
    public partial class EmployeeDBEntities : DbContext
    {
        public EmployeeDBEntities()
            : base("name=EmployeeDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmpDeptDetail> EmpDeptDetails { get; set; }
        public virtual DbSet<EmployeeAddress> EmployeeAddresses { get; set; }

        public virtual ObjectResult<GetEmployeesByDepartmentId_Result> GetEmployeesByDepartmentId(Nullable<int> employeeId)
        {
            var employeeIdParameter = employeeId.HasValue ? new ObjectParameter("EmployeeId", employeeId) : new ObjectParameter("EmployeeId", typeof(int));

            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetEmployeesByDepartmentId_Result>("GetEmployeesByDepartmentId", employeeIdParameter);
        }
    }
}