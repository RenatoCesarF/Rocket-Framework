using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Mars.Draw.DrawPrimitive;

namespace Mars
{    
public class Line2D
    {
        #region private Members
        private Texture2D SimpleTexture; 
        private Rectangle rectangle;
        private Vector2 fromPosition, toPosition;
        private Color color;
        private float thickness;
        #endregion
        
        ///<summary>
        /// A game component line segment that receves, position, thikness and lenght
        ///</summary>
        public Line2D(Vector2 fromPosition , Vector2 toPosition, float thickness = 5){

            this.fromPosition = fromPosition;
            this.toPosition = toPosition;
            this.thickness = thickness;

            this.color = Color.Orange;
        }
        public virtual void Draw(){
            DrawPrimitive.DrawLineToPoint(Global.spriteBatch,this.fromPosition,this.toPosition,this.color,this.thickness);
        }
        public virtual void Update(){
            this.fromPosition = Game1.square.getPosition();
            this.toPosition = Game1.square2.getPosition();
        }
    }
}