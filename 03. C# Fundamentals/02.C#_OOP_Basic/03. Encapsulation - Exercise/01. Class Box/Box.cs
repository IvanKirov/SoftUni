using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Box
{
    public class Box
    {
        private double length;
        private double height;
        private double width;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.height = height;
            this.width = width;
        }

        public override string ToString()
        {
            var answer = new StringBuilder();
            var lateralSurfaceArea = 2 * height * (length + width);
            var surfaceArea = 2 * (length * width) + lateralSurfaceArea;
            answer.Append($"Surface Area - {surfaceArea:F2}");
            answer.Append(Environment.NewLine);            
            answer.Append($"Lateral Surface Area - {lateralSurfaceArea:F2}");
            answer.Append(Environment.NewLine);

            var volume = length * height * width;
            answer.Append($"Volume - {volume:F2}");
            answer.Append(Environment.NewLine);

            return answer.ToString();
        }
    }
}
