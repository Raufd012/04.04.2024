﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._04._2024.Models
{
    internal class Manager
    {
        protected Employee GetPromotion(Employee employee)
        {
            employee.Salary += 100;

            return employee;
        }
    }
}
