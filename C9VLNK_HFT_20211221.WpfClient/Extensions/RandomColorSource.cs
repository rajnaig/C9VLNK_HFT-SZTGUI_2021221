using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C9VLNK_HFT_20211221.WpfClient.Extensions
{
    public class RandomColorSource :IColorService
    {
        static Random random;

        string [] colors;
        public RandomColorSource()
        {
            random = new Random();
            colors = new string[]
            {
                "#ffb73a",
                "#5bc5ff",
                "#844eff",
                "#4eff91",
                "#ecff4e"
            };
        }
        public string RandomColor()
        {
            var rnd = random.Next(0, colors.Length);
            return colors[rnd];
        }
    }
}
