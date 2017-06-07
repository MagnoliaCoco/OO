﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class InstructionHandler
    {
        private AbstractNode node;

        public void Handle(string instruction)
        {
            AbstractNode left = null;
            AbstractNode right = null;
            AbstractNode direction = null;
            AbstractNode action = null;
            AbstractNode distance = null;


            Stack<AbstractNode> stack = new Stack<AbstractNode>();
            string[] words = instruction.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if ("and".Equals(words[i]))
                {
                    left = stack.Pop();
                    string word1 = words[ ++ i ];
                    direction = new DirectionNode(word1);
                    string word2 = words[ ++ i ];
                    action = new ActionNode(word2);
                    string word3 = words[ ++ i ];
                    distance = new DistanceNode(word3);
                    right = new SentenceNode(direction, action, distance);
                    stack.Push(new AndNode(left, right));
                }
                else
                {
                    string word1 = words[i];
                    direction = new DirectionNode(word1);
                    string word2 = words[ ++ i ];
                    action = new ActionNode(word2);
                    string word3 = words[ ++ i ];
                    distance = new DistanceNode(word3);
                    left = new SentenceNode(direction, action, distance);
                    stack.Push(left);
                }
            }
            this.node = stack.Pop();
        }

        public string Output()
        {
            string result = node.Interpret();
            return result;
        }
    }
}
