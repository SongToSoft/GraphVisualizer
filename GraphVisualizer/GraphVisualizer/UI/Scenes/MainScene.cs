using AlgorithmsAndDataStructuresLibrary.DiscreteMath.Graph;
using Microsoft.Xna.Framework;
using UIProjectExample;

namespace GraphVisualizer
{
    class MainScene : Scene
    {
        private Graph graph = new Graph(StaticContent.numberVertex);

        public override void LoadComponents()
        {
            UICanvas mainCanvas = new UICanvas(new Vector2(0, 0), StaticContent.screenHeight, StaticContent.screenWidth);
            UIPanel mainPanel = new UIPanel(new Vector2(0, 0), StaticContent.screenHeight, StaticContent.screenWidth, EPanelType.EDGING, 5);
            mainPanel.SetColor(Color.Black);
            mainPanel.SetFoneColor(Color.White);
            mainCanvas.AddObject(mainPanel);

            UICanvas graphCanvas = new UICanvas(new Vector2(50, 30), 400, 700);
            UIPanel graphPanel = new UIPanel(new Vector2(50, 30), 400, 700, EPanelType.EDGING, 5);
            graphPanel.SetColor(Color.Black);
            graphPanel.SetFoneColor(Color.White);
            graphCanvas.AddObject(graphPanel);

            SetupGraph();
            UIGraph uiGraph = new UIGraph(graph, graphPanel);
            graphCanvas.AddObject(uiGraph);

            AddCanvas(mainCanvas);
            AddCanvas(graphCanvas);
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

            graph.GetVertex(0).SetPosition(20, 20);
            graph.GetVertex(1).SetPosition(80, 30);
            graph.GetVertex(2).SetPosition(120, 10);
            graph.GetVertex(3).SetPosition(300, 200);
            graph.GetVertex(4).SetPosition(200, 120);
            graph.GetVertex(5).SetPosition(500, 320);
            graph.GetVertex(6).SetPosition(600, 250);
            graph.GetVertex(7).SetPosition(70, 150);
            graph.GetVertex(8).SetPosition(450, 70);
            graph.GetVertex(9).SetPosition(350, 220);
        }
    }
}
