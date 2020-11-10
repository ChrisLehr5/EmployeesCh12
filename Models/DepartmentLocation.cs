﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesCh12.Models
{
    public class DepartmentLocation
    {
        //Composite primary key and foreign key for Dept
        public int DepartmentID { get; set; }

        //Composite primary key and foreign key for Location 
        public int LocationID { get; set; }

        //navigation properties
        public Department Department { get; set; }
        public Location Location { get; set; }
        


    }
}
