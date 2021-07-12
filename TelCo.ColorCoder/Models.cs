using System;
using System.Diagnostics;
using System.Drawing;
namespace TelCo.ColorCoder
{
    class ColorMap
    {
        protected readonly static Color[] colorMapMajor;
        protected readonly static Color[] colorMapMinor;

        static ColorMap()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
    }

    public class ColorPair
    {
        public Color majorColor { get; set; }
        public Color minorColor { get; set; }

        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }
    }
}
