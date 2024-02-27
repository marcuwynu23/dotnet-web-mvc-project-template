using System;
using System.IO;

namespace BHMS.Lib
{
    public static class DotEnv
    {
        public static void Load(string filePath = ".env")
        {
            if (File.Exists(filePath))
            {
                foreach (var line in File.ReadAllLines(filePath))
                {
                    var parts = line.Split('=', 2);
                    if (parts.Length == 2)
                    {
                        Environment.SetEnvironmentVariable(parts[0], parts[1]);
                    }
                }
            }
        }
    }
}
