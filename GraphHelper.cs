using System.Collections.Generic;
using System.IO;

namespace BFS
{
    public static class GraphHelper
    {
        public static Dictionary<int, List<int>> Parse(string path)
        {
            string input = File.ReadAllText(path);
            string[] rows = input.Split('\n');
            int vertexCount = rows.Length;

            Dictionary<int, List<int>> result = new Dictionary<int, List<int>>();

            for (int i = 0; i < vertexCount; i++)
            {
                result[i] = new List<int>();
                string[] cols = rows[i].Split(' ');

                for (int j = 0; j < cols.Length; j++)
                {
                    result[i].Add(int.Parse(cols[j]));
                }
            }
            return result;
        }
    }
}