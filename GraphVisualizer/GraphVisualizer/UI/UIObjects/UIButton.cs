using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIProjectExample
{
    delegate void ButtonMethod();
    class UIButton : UIObject
    {
        private string text = "";
        private Texture2D texture = StaticContent.TexturePoint;
        private SpriteFont spriteFont = StaticContent.SFTextButton;
        private ButtonMethod buttonMethod;
        private MouseState currentMouseState;
        private MouseState lastMouseState;
        private Vector2 textPosition;
        private Color textColor = Color.Black;
        private int textScale = 11;

        public UIButton(Vector2 _position, int _height, int _width, string _text, ButtonMethod _buttonMethod) : base(_position, _height, _width)
        {
            text = _text;
            buttonMethod = _buttonMethod;
            textPosition = new Vector2(Position.X, Position.Y + Height / 2 - textScale);
        }

        public void Update()
        {
            lastMouseState = currentMouseState;
            currentMouseState = Mouse.GetState();
            if (GetRectangle().Contains(currentMouseState.X, currentMouseState.Y))
            {
                if ((lastMouseState.LeftButton == ButtonState.Released && currentMouseState.LeftButton == ButtonState.Pressed))
                {
                    buttonMethod();
                }
            }
        }

        public void SetTextColor(Color _color)
        {
            textColor = _color;
        }

        public void SetTextScale(int _textScale)
        {
            textScale = _textScale;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (IsVisible())
            {
                spriteBatch.Draw(texture, GetRectangle(), color);
                spriteBatch.DrawString(spriteFont, text, textPosition, textColor);
            }
        }
    }
}
