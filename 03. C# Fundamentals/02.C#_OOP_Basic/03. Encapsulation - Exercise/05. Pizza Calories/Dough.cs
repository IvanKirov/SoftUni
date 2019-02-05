using System;
using System.Linq;

namespace Pizza_Calories
{
    public class Dough
    {
        private string flour;
        private string bakingTechnique;
        private int weight;
        private double calories;

        public Dough(string flour, string bakingTechnique, int weight)
        {
            Weight = weight;
            this.BakingTechnique = bakingTechnique;
            Flour = flour;
            Calories = calories;
        }

        public double Calories
        {
            get => calories;
            set
            {
                double flourMultiplier = 1.5;
                if (flour == "wholegrain")
                {
                    flourMultiplier = 1.0;
                }

                double bakingTechniqueMultiplier = 1.0;
                if (bakingTechnique == "crispy")
                {
                    bakingTechniqueMultiplier = 0.9;
                }
                else if (bakingTechnique == "chewy")
                {
                    bakingTechniqueMultiplier = 1.1;
                }

                calories = 2 * this.weight * flourMultiplier * bakingTechniqueMultiplier;
            }
        }

        private int Weight
        {
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        private string BakingTechnique
        {
            set
            {
                var bakingTypes = new String[] { "crispy", "chewy", "homemade" };
                if (!bakingTypes.Contains(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                bakingTechnique = value;
            }
        }

        private string Flour
        {
            set
            {
                if (value != "white" && value != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flour = value;
            }
        }
    }
}
