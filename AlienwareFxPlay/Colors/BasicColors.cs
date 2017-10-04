using LightFX;

namespace AlienwareFxPlay.Colours
{
    public static class BasicColors
    {
        public static LFX_ColorStruct Red => new LFX_ColorStruct(255, 255, 0, 0);

        public static LFX_ColorStruct Green => new LFX_ColorStruct(255, 0, 255, 0);

        public static LFX_ColorStruct Blue => new LFX_ColorStruct(255, 0, 0, 255);

        public static LFX_ColorStruct Black => new LFX_ColorStruct(255, 0, 0, 0);

        public static LFX_ColorStruct White => new LFX_ColorStruct(255, 255, 255, 255);

        public static LFX_ColorStruct Yellow => new LFX_ColorStruct(255, 255, 255, 0);

        public static LFX_ColorStruct Purple => new LFX_ColorStruct(255, 128, 0, 128);

        public static LFX_ColorStruct GetCustomColor(byte red, byte green, byte blue)
        {
            return new LFX_ColorStruct(255, red, green, blue);
        }

    }
}
