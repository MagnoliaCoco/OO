using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class DirectionNode : AbstractNode
    {
        private string direction;

        public DirectionNode(string direction)
        {
            this.direction = direction;
        }

        public override string Interpret()
        {
            if ("up".Equals(direction))
            {
                return " turn up ";
            }
            else if ("down".Equals(direction))
            {
                return " turn down ";
            }
            else if ("left".Equals(direction))
            {
                return " turn left ";
            }
            else if ("right".Equals(direction))
            {
                return " turn right ";
            }
            else
            {
                return "invalid operation";
            }
        }
    }
}
