using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Box_Data_Validation
{
    public class Box
    {
        private double length;        
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;            
        }

        public double Length
        {
            get => this.length;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        
        public double Width
        {
            get => this.width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get => this.height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                this.height = value;
            }
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
