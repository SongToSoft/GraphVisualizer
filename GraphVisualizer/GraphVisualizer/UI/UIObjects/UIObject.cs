using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIProjectExample
{
    abstract class UIObject
    {
        //Parent is canvas which have this object
        protected UIObject parent;
        public int Height { get; set; }
        public int Width { get; set; }
        public Vector2 Position { get; set; }
        protected Color color = Color.White;
        
        public UIObject(Vector2 _position, int _height, int _width)
        {
            Position = _position;
            Height = _height;
            Width = _width;
        }

        public void SetColor(Color _color)
        {
            color = _color;
        }

        public void SetParent(UIObject _parent)
        {
            parent = _parent;
        }

        protected bool IsVisible()
        {
            if (parent != null)
            {
                if ((Position.X >= parent.Position.X) && (Position.X <= parent.Position.X + parent.Width) &&
                    (Position.Y >= parent.Position.Y) && (Position.Y <= parent.Position.Y + parent.Height))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public Rectangle GetRectangle()
        {
            return (new Rectangle((int)Position.X, (int)Position.Y, Width, Height));
        }

        public abstract void Draw(SpriteBatch spriteBatch);      
    }
}
