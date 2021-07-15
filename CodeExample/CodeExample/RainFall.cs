using System.Linq;

namespace RainFall
{   
    /// <summary>
    /// class for rainfall
    /// </summary>
    class RainFall
    {
        private double[] yearRain;
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="stuff"></param>
        public RainFall(double[] stuff)
        {
            this.yearRain = stuff;
        }
        
        /// <summary>
        /// returns the sum of all attributes of the array
        /// </summary>
        /// <returns>array sum</returns>
        public double TotalRain()
        {
            double total = 0;

            foreach (double month in yearRain)
            {
                total += month;
            }

            return total;
        }
        
        /// <summary>
        /// returns the average rainfall for the entirety of the array
        /// </summary>
        /// <returns>array average</returns>
        public double AvgRain()
        {
            double total = 0;
            double avg;

            foreach (double month in yearRain)
            {
                total += month;
            }

            avg = total / yearRain.Length;

            return avg;
        }
        
        /// <summary>
        /// returns the value with the highest recoreded rainfall
        /// </summary>
        /// <returns>highest decimal</returns>
        public double MostRain()
        {
            double high = yearRain.Max();

            return high;
        }
        
        /// <summary>
        /// Returns the value with the lowest recorded rainfall
        /// </summary>
        /// <returns>lowest decimal</returns>
        public double LeastRain()
        {
            double low = yearRain.Min();

            return low;
        }
    }
}
