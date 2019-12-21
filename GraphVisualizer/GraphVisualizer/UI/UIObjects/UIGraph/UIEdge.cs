using AlgorithmsAndDataStructuresLibrary.DiscreteMath.Graph;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using UIProjectExample;

namespace GraphVisualizer
{
    class UIEdge : UIObject
    {
        private Texture2D texture;
        private UIVertex startVertex, endVertex;
        private float angle;
        private float distance;

        public UIEdge(UIVertex _startVertex, UIVertex _endVertex) : base(new Vector2(0, 0), 2, 2)
        {
            texture = StaticContent.TexturePoint;
            startVertex = _startVertex;
            endVertex = _endVertex;
            angle = (float)Math.Atan2(endVertex.GetCenterPosition().Y - startVertex.GetCenterPosition().Y,
                                      endVertex.GetCenterPosition().X - startVertex.GetCenterPosition().X);
            distance = Vector2.Distance(startVertex.GetCenterPosition(), endVertex.GetCenterPosition());
            color = Color.LightYellow;
        }

        public void SetColor(Color _color)
        {
            color = _color;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture,
                             startVertex.GetCenterPosition(),
                             null,
                             color,
                             angle,
                             new Vector2(0, (float)texture.Height / 2),
                             new Vector2(distance, 1.5F),
                             SpriteEffects.None,
                             0);
        }
    }
}
