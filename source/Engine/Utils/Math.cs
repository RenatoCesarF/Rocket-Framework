using Microsoft.Xna.Framework;
using System;
namespace Mars
{
    
    public class MarsMath
    {
        public static void rotate(Vector2 vector, float anglesDegrees, Vector2 origin){
            float x = vector.X - origin.X;
            float y = vector.Y - origin.Y;

            float cos = (float)(Math.Cos((Math.PI / 180) * anglesDegrees));
            float sin = (float)(Math.Sin((Math.PI / 180) * anglesDegrees));

            float xPrime = (x * cos) - (y * sin);
            float yPrime = (x * sin) - (y * cos);

            vector.X = xPrime;
            vector.Y = yPrime;
        }

        public static bool compare(float x, float y, float epsilon = float.MinValue){
            return Math.Abs(x - y) <= epsilon * Math.Max(1.0f,Math.Max(Math.Abs(x), Math.Abs(y)));
        }
        public static bool compare(Vector2  vec , Vector2 vec2, float epsilon = float.MinValue){
            return compare(vec.X,vec2.X,epsilon) && compare(vec.Y,vec2.Y,epsilon);
        }

        
    }
}