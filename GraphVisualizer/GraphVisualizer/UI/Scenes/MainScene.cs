using AlgorithmsAndDataStructuresLibrary.DiscreteMath.Graph;
using Microsoft.Xna.Framework;
using UIProjectExample;

namespace GraphVisualizer
{
    class MainScene : Scene
    {
        private Graph graph = new Graph(StaticContent.numberVertex);
        private UIGraph uiGraph;
        private UIPanel mainPanel;
        private UIText debugText;
        private int startIndex = -1, endIndex = -1;

        public override void LoadComponents()
        {
            UICanvas mainCanvas = new UICanvas(new Vector2(0, 0), StaticContent.screenHeight, StaticContent.screenWidth);
            mainPanel = new UIPanel(new Vector2(0, 0), StaticContent.screenHeight, StaticContent.screenWidth);
            mainPanel.SetColor(Color.Turquoise);
            mainCanvas.AddObject(mainPanel);

            mainCanvas.AddObject(mainPanel);

            SetupGraph();
            uiGraph = new UIGraph(graph, mainPanel);
            mainCanvas.AddObject(uiGraph);

            debugText = new UIText(new Vector2(0, 0), "You can add new edge just click on two vertex");
            mainCanvas.AddObject(debugText);
            AddCanvas(mainCanvas);
        }

        public void SetupGraph()
        {
            graph.AddEdge(0, 1);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 8);
            graph.AddEdge(3, 4);
            graph.AddEdge(4, 7);
            graph.AddEdge(4, 8);
            graph.AddEdge(5, 6);
            graph.AddEdge(6, 8);
            graph.AddEdge(8, 9);
            graph.AddEdge(9, 1);
            graph.AddEdge(7, 5);

            graph.GetVertex(0).SetPosition(70, 130);
            graph.GetVertex(1).SetPosition(130, 80);
            graph.GetVertex(2).SetPosition(195, 90);
            graph.GetVertex(3).SetPosition(350, 250);
            graph.GetVertex(4).SetPosition(250, 170);
            graph.GetVertex(5).SetPosition(550, 370);
            graph.GetVertex(6).SetPosition(650, 300);
            graph.GetVertex(7).SetPosition(130, 200);
            graph.GetVertex(8).SetPosition(500, 130);
            graph.GetVertex(9).SetPosition(400, 220);
        }

        public void AddEdge(int index)
        {
            if (startIndex == -1)
            {
                startIndex = index;
                SetDebugText("Set first vertex: " + index);
            }
            else
            {
                if (startIndex != endIndex)
                {
                    SetDebugText("Set second vertex: " + index + " and create new edge");
                    endIndex = index;
                    graph.AddEdge(startIndex, endIndex);
                    uiGraph.AddEdge(startIndex, endIndex);
                }
                else
                {
                    SetDebugText("You try make edge from one vertex to itself");
                }
                startIndex = -1;
                endIndex = -1;
            }
        }

        public void SetDebugText(string text)
        {
            debugText.Text = text;
        }
    }
}
