using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace ComponentDesignPattern
{
    public class Program
    {
        public const int screenWidth = 800;
        public const int screenHeight = 600;
        public static List<Shape> shapes = new List<Shape>();

        static void Main()
        {
            Raylib.InitWindow(screenWidth, screenHeight, "Random Circle and Square with Component Design Pattern!");
            Raylib.SetTargetFPS(60);

            shapes.Add(CreateShape("circle"));
            shapes.Add(CreateShape("square"));

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);

                foreach (var entity in shapes)
                {
                    entity.Draw();
                }

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }

        public static Shape CreateShape(string shape)
        {
            switch (shape.ToLower())
            {
                case "circle":
                    return CreateCircle();
                case "square":
                    return CreateSquare();
                default:
                    return CreateCircle();
            }
        }

        public static Shape CreateCircle()
        {
            Random random = new Random();

            // Create a circle at a random position
            var positionComponent = new PositionComponent
            {
                X = random.Next(0, screenWidth - 50),
                Y = random.Next(0, screenHeight - 50)
            };

            var renderComponent = new CircleRenderComponent(positionComponent, 30, Color.Red);
            var Entity = new Shape(positionComponent, renderComponent);

            return Entity;
        }

        public static Shape CreateSquare()
        {
            Random random = new Random();

            // Create a circle at a random position
            var positionComponent = new PositionComponent
            {
                X = random.Next(0, screenWidth - 50),
                Y = random.Next(0, screenHeight - 50)
            };

            var renderComponent = new SquareRenderComponent(positionComponent, 50, 50, Color.Blue);
            var Entity = new Shape(positionComponent, renderComponent);

            return Entity;
        }
    }
}
