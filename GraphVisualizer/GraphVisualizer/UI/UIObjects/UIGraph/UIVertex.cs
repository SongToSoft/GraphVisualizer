﻿using AlgorithmsAndDataStructuresLibrary.DiscreteMath.Graph;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using UIProjectExample;

namespace GraphVisualizer
{
    class UIVertex : UIObject
    {
        private Texture2D texture;
        private UIText number;
        private MouseState currentMouseState;
        private MouseState lastMouseState;
   
        public UIVertex(Vertex vertex, UIGraph uiGraph, int vertexNumber, int _height = 30, int _width = 30) : base(new Vector2(vertex.GetPositionX() + uiGraph.Position.X, vertex.GetPositionY() + uiGraph.Position.Y), _height, _width)
        {
            texture = StaticContent.TextureGraphVertex;
            number = new UIText(GetCenterPosition(), vertexNumber.ToString());
            number.Position = GetTextPosition();
            number.SetColor(Color.GhostWhite);
            color = Color.LightPink;
        }

        public Vector2 GetCenterPosition()
        {
            return new Vector2(Position.X + Width / 2, Position.Y + Height / 2);
        }

        public Vector2 GetTextPosition()
        {
            return new Vector2(Position.X + Width / 2 - 5,
                               Position.Y + Height / 2 - 11);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, GetRectangle(), color);
            number.Draw(spriteBatch);
        }

        public void Update()
        {
            lastMouseState = currentMouseState;
            currentMouseState = Mouse.GetState();
            if (GetRectangle().Contains(currentMouseState.X, currentMouseState.Y))
            {
                if ((lastMouseState.LeftButton == ButtonState.Released && currentMouseState.LeftButton == ButtonState.Pressed))
                {
                    (SceneManager.CurrentScene as MainScene).AddEdge(Convert.ToInt32(number.Text));
                }
            }
        }
    }
}
