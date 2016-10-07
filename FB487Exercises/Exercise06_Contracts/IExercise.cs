using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Exercise06
{
    [ServiceContract]
    public interface IExercise
    {
        [OperationContract]
        int GetTotalNumberOfChars(string[] arrayOfStrings);

        [OperationContract]
        int Factorial(int number);

        [OperationContract]
        string HowManyDaysOld(Person person);
    }
}
