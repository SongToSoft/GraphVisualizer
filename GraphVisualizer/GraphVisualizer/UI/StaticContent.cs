using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIProjectExample
{
    static class StaticContent
    {
        static public Color FoneColor { get; set; }
        static public Texture2D TexturePoint { get; set; }
        static public Texture2D TextureGraphVertex { get; set; }
        static public SpriteFont SFText{ get; set; }
        static public SpriteFont SFTextButton { get; set; }
        static public int screenWidth = 800;
        static public int screenHeight = 500;
        static public int numberVertex = 10;

        static public void LoadContent(ContentManager content)
        {
            TexturePoint = content.Load<Texture2D>("Point");
            TextureGraphVertex = content.Load<Texture2D>("RedCircle");
            SFText = content.Load<SpriteFont>("Text");
            SFTextButton = content.Load<SpriteFont>("TextButton");
        }
    }
}
