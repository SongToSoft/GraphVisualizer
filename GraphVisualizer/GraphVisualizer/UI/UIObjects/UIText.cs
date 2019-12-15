using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIProjectExample
{
    class UIText : UIObject
    {
        public SpriteFont SpriteFont { get; set; }
        public string Text { get; set; }

        public UIText(Vector2 _position, string _text) : base(_position, 0, 0)
        {
            SpriteFont = StaticContent.SFText;
            Text = _text;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (IsVisible())
            {
                spriteBatch.DrawString(SpriteFont, Text, Position, color);
            }
        }
    }
}
