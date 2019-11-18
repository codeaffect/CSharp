using System;
using System.Collections.Generic;

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
                {"b", new List<string>{"d","e"}},
                {"c", new List<string>{"f","g"}},
                {"e", new List<string>{"i","b"}},
                {"f", new List<string>{"i","c"}},
                {"d", new List<string>{""}},
                {"g", new List<string>{""}},
                {"i", new List<string>{"e","f"}}
            };
        }
    }
}