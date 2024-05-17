using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main() {
            Controller controller = new Controller();

            IView view = new View();

            controller.Start(view);
        }
    }
}