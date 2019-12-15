using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIProjectExample
{
    abstract class Scene
    {
        protected List<UICanvas> canvases;

        public Scene()
        {
            canvases = new List<UICanvas>();
        }

        public void AddCanvas(UICanvas canvas)
        {
            canvases.Add(canvas);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < canvases.Count; ++i)
            {
                canvases[i].Draw(spriteBatch);
            }
        }

        public void Update()
        {
            for (int i = 0; i < canvases.Count; ++i)
            {
                canvases[i].Update();
            }
        }

        abstract public void LoadComponents();
    }
}
