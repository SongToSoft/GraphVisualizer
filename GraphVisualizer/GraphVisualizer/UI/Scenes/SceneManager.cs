using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIProjectExample
{
    static class SceneManager
    {
        static public Scene CurrentScene { get; set; }

        static public void LoadComponents()
        {
            CurrentScene.LoadComponents();
        }

        static public void Draw(SpriteBatch spriteBatch)
        {
            CurrentScene.Draw(spriteBatch);
        }

        static public void Update()
        {
            CurrentScene.Update();
        }
    }
}
