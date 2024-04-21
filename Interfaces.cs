using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace ComponentDesignPattern
{
    // Position Component
    public interface IPositionComponent
    {
        int X { get; set; }
        int Y { get; set; }
    }

    public class PositionComponent : IPositionComponent
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    // Render Component
    public interface IRenderComponent
    {
        void Render();
    }

    public class CircleRenderComponent : IRenderComponent
    {
        public IPositionComponent Position { get; set; }
        public int Radius { get; set; }
        public Color Color { get; set; }

        public CircleRenderComponent(IPositionComponent position, int radius, Color color)
        {
            Position = position;
            Radius = radius;
            Color = color;
        }

        public void Render()
        {
            Raylib.DrawCircle(Position.X, Position.Y, Radius, Color);
        }
    }

    public class SquareRenderComponent : IRenderComponent
    {
        public IPositionComponent Position { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }

        public SquareRenderComponent(IPositionComponent position, int width, int height, Color color)
        {
            Position = position;
            Width = width;
            Height = height;
            Color = color;
        }

        public void Render()
        {
            Raylib.DrawRectangle(Position.X, Position.Y, Width, Height, Color);
        }
    }
}