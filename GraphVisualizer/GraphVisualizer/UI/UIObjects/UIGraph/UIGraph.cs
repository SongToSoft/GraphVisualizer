using AlgorithmsAndDataStructuresLibrary.DiscreteMath.Graph;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using UIProjectExample;

namespace GraphVisualizer
{
    class UIGraph : UIObject
    {
        private List<UIVertex> vertexes;
        private List<UIEdge> edges;

        public UIGraph(Graph graph, UIPanel panel) : base(new Vector2(panel.Position.X, panel.Position.Y), 0, 0)
        {
            vertexes = new List<UIVertex>();
            for (int i = 0; i < StaticContent.numberVertex; ++i)
            {
                vertexes.Add(new UIVertex(graph.GetVertex(i), this, i));
            }
            edges = new List<UIEdge>();
            for (int i = 0; i < vertexes.Count; ++i)
            {
                for (int j = 0; j < vertexes.Count; ++j)
                {
                    if (graph.GetVertex(i).CheckEdge(j))
                    {
                        AddEdge(i, j);
                    }
                }
            }
        }

        public void AddEdge(int start, int end)
        {
            edges.Add(new UIEdge(vertexes[start], vertexes[end]));
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < edges.Count; ++i)
            {
                edges[i].Draw(spriteBatch);
            }
            for (int i = 0; i < vertexes.Count; ++i)
            {
                vertexes[i].Draw(spriteBatch);
            }
        }

        public void Update()
        {
            for (int i = 0; i < vertexes.Count; ++i)
            {
                vertexes[i].Update();
            }
        }
    }
}
