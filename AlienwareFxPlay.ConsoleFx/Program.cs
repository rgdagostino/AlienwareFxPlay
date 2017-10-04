using AlienwareFxPlay;
using AlienwareFxPlay.Colours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFx
    // Simple console application to quickly try to functions
{
    class Program
    {
        static void Main(string[] args)
        {
            AlienLightController ctl = new AlienLightController();
            ctl.Initialize();
            ctl.Start();

            uint bla = ctl.GetNumberOfDevices();

            // Test yellow light change

            ctl.ChangeLights(BasicColors.Yellow);

        }
    }
}
