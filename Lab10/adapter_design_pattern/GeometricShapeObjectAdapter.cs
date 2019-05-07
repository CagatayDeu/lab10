using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_design_pattern
{
    class GeometricShapeObjectAdapter : Shape
    {
        private GeometricShape _shape;

        public GeometricShapeObjectAdapter(GeometricShape shape)
        {
            _shape = shape;
        }

        public void draw()
        {
            _shape.drawShape();
        }
    }
}
