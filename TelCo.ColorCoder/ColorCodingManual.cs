using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class ColorCodingManual:ColorMap
    {
        public static void printColorManual()
        {
            int numricValueOfColorPair = 1;
            System.Console.WriteLine("Number  Major Color  Minor Color");
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.WriteLine(" {0}        {1}          {2}",numricValueOfColorPair,ColorMap.colorMapMajor[i].Name,ColorMap.colorMapMinor[j].Name);
                    numricValueOfColorPair++;
                }
            }
        }
            
        
    }
}
