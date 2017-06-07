using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class SentenceNode : AbstractNode
    {
        private AbstractNode direction;
        private AbstractNode action;
        private AbstractNode distance;

        public SentenceNode(AbstractNode direction, AbstractNode action, AbstractNode distance)
        {
            this.action = action;
            this.direction = direction;
            this.distance = distance;
        }

        public override string Interpret()
        {
            return direction.Interpret() + action.Interpret() + distance.Interpret();
        }
    }
}
