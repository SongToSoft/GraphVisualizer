using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace UIProjectExample
{
    enum EPanelType
    {
        FILLED,
        EDGING
    }

    class UIPanel : UIObject
    {
        private EPanelType panelType;
        private int border;
        private Texture2D texture;
        private Color foneColor = StaticContent.FoneColor;
  
        public UIPanel(Vector2 _position, int _height, int _width, EPanelType _panelType = EPanelType.FILLED, int _border = 0 ) : base(_position, _height, _width)
        {
            panelType = _panelType;
            border = _border;
            texture = StaticContent.TexturePoint;
        }

        public void SetFoneColor(Color _color)
        {
            foneColor = _color;
        }

        private Rectangle GetEdgingRectangle()
        {
            return (new Rectangle((int)Position.X + border, (int)Position.Y + border, Width - border * 2, Height - border * 2));
        }
        
        public override void Draw(SpriteBatch spriteBatch)
        {
            if (IsVisible())
            {
                spriteBatch.Draw(texture, GetRectangle(), color);
                if (panelType == EPanelType.EDGING)
                {
                    spriteBatch.Draw(texture, GetEdgingRectangle(), foneColor);
                }
            }
        }

        public void InsertImage(UIImage image)
        {
            image.Position = new Vector2(Position.X + border, Position.Y + border);
            image.Width = Width - border * 2;
            image.Height = Height - border * 2;
        }

        public void InsertText(UIText text)
        {
            text.Position = new Vector2(Position.X + border, Position.Y + border);
        }
    }
}
