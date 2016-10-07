using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    [ServiceBehavior(UseSynchronizationContext = false)]
    public class Exercise : IExercise
    {
        public int GetTotalNumberOfChars(string[] arrayOfStrings)
        {
            return arrayOfStrings.Sum(x => x.Length);
        }

        public int Factorial(int number)
        {
            if (number == 0) return 1;
            return number * Factorial(number - 1);
        }

        public string HowManyDaysOld(Person person)
        {
            return string.Format("{0} is {1:N0} days old.", person.FirstName, DateTime.Today.Subtract(person.DateOfBirth).TotalDays + 1);
        }
    }
}
