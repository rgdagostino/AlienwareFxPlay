using System;
using System.Diagnostics;
using AlienwareFxPlay.Exceptions;
using LightFX;
using AlienwareFxPlay.Colours;

namespace AlienwareFxPlay
{
    public class AlienLightController : ILightController
    {
        private readonly LightFXController _lightFxController;

        public AlienLightController()
        {
            _lightFxController = new LightFXController();
        }

        public LFX_Result Initialize()
        {
            return _lightFxController.LFX_Initialize();
        }

        public void Start()
        {
            var result = Initialize();
            if (result != LFX_Result.LFX_Success)
                throw new UnableToInitializeLightsException($"ErrorCode: {result.ToString()}");

            // Start fresh
            _lightFxController.LFX_Reset();

        }
        public void GoDark()
        {
            // Turn off all active lights
            var numberOfLights = GetNumberOfDevices();
            WriteDataPointToDebugOutput(nameof(numberOfLights), numberOfLights);

        }

        public void ChangeLights(LFX_ColorStruct color)
        {
            _lightFxController.LFX_SetLightColor(0, 0, color);
            _lightFxController.LFX_SetLightColor(0, 1, color);
            _lightFxController.LFX_Update();
        }
        public void ChangeLight(uint device, uint light, LFX_ColorStruct color)
        {
            _lightFxController.LFX_SetLightColor(device, light, color);
        }

        public void Update()
        {
            _lightFxController.LFX_Update();
        }
        public uint GetNumberOfDevices()
        {
            uint numberOfDevices;
            _lightFxController.LFX_GetNumDevices(out numberOfDevices);
            return numberOfDevices;
        }
        public uint GetNumberOfLights(uint devIndex)
        {
            uint numberOfLights;
            _lightFxController.LFX_GetNumLights(devIndex, out numberOfLights);
            return numberOfLights;
        }
        private void WriteDataPointToDebugOutput(string key, object value)
        {
            Debug.WriteLine("{0}: {1}", key, value);
        }
    }
}
