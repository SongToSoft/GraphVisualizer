using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIProjectExample
{
    class UIImage : UIObject
    {
        private Texture2D texture;

        public UIImage(Vector2 _position, int _height, int _width, Texture2D _texture) : base(_position, _height, _width)
        {
            texture = _texture;
        }

        private Rectangle GetEdgingRectangle()
        {
            return (new Rectangle((int)Position.X, (int)Position.Y, Width, Height));
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (IsVisible())
            {
                spriteBatch.Draw(texture, GetRectangle(), color);
            }
        }
    }
}
