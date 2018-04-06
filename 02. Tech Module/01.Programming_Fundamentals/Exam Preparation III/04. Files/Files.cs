using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Files
{
    public class Files
    {
        public static void Main()
        {
            var filesByRoot = new Dictionary<string, Dictionary<string, long>>();

            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                var routeParams = Console.ReadLine()
                    .Split('\\')
                    .ToArray();

                var root = routeParams[0];
                var fileAndSize = routeParams[routeParams.Length - 1]
                    .Split(';')
                    .ToArray();

                var fileNameWithExtention = fileAndSize[0];
                var fileSize = long.Parse(fileAndSize[1]);

                if (!filesByRoot.ContainsKey(root))
                {
                    filesByRoot.Add(root, new Dictionary<string, long>());
                }

                if (!filesByRoot[root].ContainsKey(fileNameWithExtention))
                {
                    filesByRoot[root].Add(fileNameWithExtention, fileSize);
                }
                else
                {
                    filesByRoot[root][fileNameWithExtention] = fileSize;
                }
            }

            var queryString = Console.ReadLine()
                .Split()
                .ToArray();

            var queryExtention = queryString[0];
            var queryRoot = queryString[2];

            if (filesByRoot.ContainsKey(queryRoot)) // && filesByRoot.ContainsKey(queryExtention))
            {
                var foundFiles = filesByRoot[queryRoot]
                    .OrderByDescending(s => s.Value)
                    .ThenBy(n => n.Key);

                foreach (var file in foundFiles)
                {
                    if (file.Key.EndsWith(queryExtention))
                    {
                        Console.WriteLine($"{file.Key} - {file.Value} KB");
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
