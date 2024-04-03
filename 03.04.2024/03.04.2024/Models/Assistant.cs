using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._04._2024.Models
{
    internal class Assistant : Manager
    {
        public void GetFeedback(Employee employee)
        {
            if (employee.IsSuccessfull)
            {
                employee = GetPromotion(employee);

                Console.WriteLine(employee.Salary + ": new salary");
            }
            else
            {
                Console.WriteLine("Try again");
            }
        }
    }
}
