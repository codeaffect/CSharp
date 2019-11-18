using System;
using System.Collections.Generic;

namespace dfs
{
    public class Source
    {
        /*
                        a
                    b___|___c
                    |       |
                d___e___i___f___g
        */
        public Dictionary<string, List<string>> NodesWithNeighbors
        {
            get
            {
                return new Dictionary<string, List<string>>()
            {
                {"a", new List<string>{"b","c"}},
                {"b", new List<string>{"a","d","e"}},
                {"c", new List<string>{"a","f","g"}},
                {"e", new List<string>{"i","b"}},
                {"f", new List<string>{"i","c"}},
                {"d", new List<string>{"b"}},
                {"g", new List<string>{"c"}},
                {"i", new List<string>{"e","f"}},
                {"x", new List<string>()},
                {"y", new List<string>()}
            };
            }
        }
    }
}