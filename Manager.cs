using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentDesignPattern
{
    public class Shape
    {
        private IPositionComponent positionComponent;
        private IRenderComponent renderComponent;

        public Shape(IPositionComponent position, IRenderComponent render)
        {
            positionComponent = position;
            renderComponent = render;
        }

        public void Draw()
        {
            renderComponent.Render();
        }
    }

}