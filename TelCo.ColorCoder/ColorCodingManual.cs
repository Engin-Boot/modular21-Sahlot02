using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class ColorCodingManual
    {
        public Ienvironment enivronment;

        public ColorCodingManual(Ienvironment inputEnvironment)
        {
            this.enivronment = inputEnvironment;
        }

        public void printColorManual()
        {
            enivronment.print();
        }
    }
}
