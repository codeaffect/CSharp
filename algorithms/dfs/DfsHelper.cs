using System;
using System.Collections.Generic;

namespace dfs
{
    public class DfsHelper
    {
        private Dictionary<string, List<string>> sourceNodes;

        public DfsHelper()
        {
            sourceNodes = new Source().NodesWithNeighbors;
        }

        public void Traverse()
        {
            foreach (var node in sourceNodes)
            {
                var visitedNodes = new List<string>();
                var key = node.Key;
                Console.WriteLine("");
                Start(key, visitedNodes);
            }
        }

        private void Start(string node, List<string> visitedNodes)
        {
            if (visitedNodes.Contains(node))
            {
                return;
            }
            else if (sourceNodes[node].Count == 0)
            {
                Console.Write($"{node} ");
                visitedNodes.Add(node);
                return;
            }

            Console.Write($"{node} ");
            visitedNodes.Add(node);

            foreach (var item in sourceNodes[node])
            {
                Start(item, visitedNodes);
            }
        }
    }
}