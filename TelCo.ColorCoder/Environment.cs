using System;
using System.Diagnostics;
namespace TelCo.ColorCoder
{
    public interface Ienvironment
    {
        public void print();
    }

    public class test:Ienvironment
    {
        public void print(){
            int totalMajorColor = ColorMap.colorMapMajor.Length;
            int totalMinorColor = ColorMap.colorMapMinor.Length;
            Debug.Assert(totalMajorColor == 5);
            Debug.Assert(totalMinorColor == 5);
            int numricValueOfColorPair = 1;
            System.Console.WriteLine("    Testing Color Coding Manual     ");
            for (int i = 0; i < totalMajorColor; i++){
                for (int j = 0; j < totalMinorColor; j++){
                    ColorPair color = new ColorPair { majorColor = ColorMap.colorMapMajor[i], minorColor = ColorMap.colorMapMinor[j] };
                    int correctPairNumber = getNumber.GetPairNumberFromColor(color);
                    Debug.Assert(numricValueOfColorPair == correctPairNumber);
                    numricValueOfColorPair++;
                }
            }
            Debug.Assert(numricValueOfColorPair-1 == 25);
        }
    }

    public class printColorManual : Ienvironment
    {
        int totalMajorColor = ColorMap.colorMapMajor.Length;
        int totalMinorColor = ColorMap.colorMapMinor.Length;
        int numricValueOfColorPair = 1;

        public void print(){
            System.Console.WriteLine("     Color Coding Manual     ");
            System.Console.WriteLine("Number  Major Color  Minor Color");
            for (int i = 0; i < totalMajorColor; i++){
                for (int j = 0; j < totalMinorColor; j++){
                    Console.WriteLine(" {0}        {1}          {2}", numricValueOfColorPair, ColorMap.colorMapMajor[i].Name, ColorMap.colorMapMinor[j].Name);
                    numricValueOfColorPair++;
                }
            }
        }
    }
}

