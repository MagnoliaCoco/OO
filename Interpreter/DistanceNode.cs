using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class DistanceNode : AbstractNode
    {
        private string distance;

        public DistanceNode(string distance)
        {
            this.distance = distance;
        }

        public override string Interpret()
        {
            return this.distance;
        }
    }
}
