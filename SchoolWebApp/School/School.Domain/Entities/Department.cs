using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Entities
{
    public class Department:AuditableEntity
    {
      
            public int DepartmentId { get; set; }

            public string? Name
                    { get; set; }


            public decimal Budget { get; set; }

            public DateTime StartDate { get; set; }


            public int MyProAdministratorperty { get; set; }




    }
}
