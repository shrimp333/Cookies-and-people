using System;

namespace cookies
{
    class Cookie
    {
        public int weight;
        public string shape;
        
        public Color color {get; set;}

        public Cookie(int pWeight, string pShape, Color pColor)
        {
            weight = pWeight;
            shape = pShape;
            color = pColor;
        }
        public string getDetails() => $"Weight: {weight} Shape: {shape} Colour: {color.color}";
    }



    class Color
        {
            public int red;
            public int green;
            public int blue;
            public string color;
            public Color(int r, int g, int b, string name)
            {
                red = r;
                green = g;
                blue = b;
                color = name;
            }
        }
}
