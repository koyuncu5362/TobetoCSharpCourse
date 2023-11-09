using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class RecourseManager
    {
        public void DoRecourse(ICreditManager creditManager,ILoggerService loggerService)
        {
          
            creditManager.Calculate();
            loggerService.Log();
        }
        public void CreditPreInfo(List<ICreditManager> credits )
        {
            foreach (var item in credits)
            {
                Console.WriteLine(item);
            }
        }
    }
}
