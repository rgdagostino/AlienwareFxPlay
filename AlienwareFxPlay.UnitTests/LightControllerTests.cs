using Shouldly;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlienwareFxPlay.Colours;
using AlienwareFxPlay;

namespace AlecTec.Alienware.UnitTests
{
    [TestClass]
    public class LightControllerTests
    {
        private ILightController _lightController;

        [TestInitialize]
        public void Init()
        {
            _lightController = new AlienLightController();

            _lightController.Start();

        }

        [TestMethod]
        public void InitializeLights()
        {
            
        }

        [TestMethod]
        public void Change_Light_Color()
        {
            
        }

        [TestMethod]
        public void Turn_Lights_Dark()
        {
            _lightController.GoDark();
            
        }
       
        [TestMethod]
        public void Get_Number_Of_Devices()
        {
            var numOfDevices = _lightController.GetNumberOfDevices();

            numOfDevices.ShouldBe<uint>(1);
        }

        [TestMethod]
        public void Change_Lights_To_Red()
        {
            _lightController.ChangeLights(BasicColors.Red);
        }

        public void Change_Lights_To_Maroon()
        {
            var maroon = BasicColors.GetCustomColor(128, 0, 0);

            _lightController.ChangeLights(maroon);
        }


        // Integration Tests
        // TODO:

        // Cycle basic colors


    


    }
}
