﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagenent.Contracts
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfJoining { get; set; }

        public int DepartmentId { get; set; }

        
        public Department? Department { get; set; }
    }
}
