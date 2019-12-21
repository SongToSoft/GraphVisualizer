using GraphVisualizer;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using UIProjectExample;

namespace UIProjectExample
{
    class UICanvas : UIObject
    {
        private List<UIObject> objects;

        public UICanvas(Vector2 _position, int _height, int _width) : base(_position, _height, _width)
        {
            objects = new List<UIObject>();
        }
        
        public void AddObject(UIObject uiObject)
        {
            uiObject.SetParent(this);
            objects.Add(uiObject);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < objects.Count; ++i)
            {
                objects[i].Draw(spriteBatch);
            }
        }

        public void Update()
        {
            for (int i = 0; i < objects.Count; ++i)
            {
                if (objects[i] is UIButton)
                {
                    (objects[i] as UIButton).Update();
                }
                if (objects[i] is UIGraph)
                {
                    (objects[i] as UIGraph).Update();
                }
            }
        }
    }
}
