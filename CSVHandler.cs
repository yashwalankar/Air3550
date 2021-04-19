using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Air3550
{
    class CSVHandler
    {
        public static List<string> CSVReader(string filepath, string searchString)
        {
            List<string> lines = new List<string>();

            using (StreamReader stream = File.OpenText(filepath))
            {
                string readline;
                bool objectFound = false;
                while ((readline = stream.ReadLine()) != null)
                {
                    if (readline.Contains(searchString))
                    {
                        objectFound = true;
                    }

                    if (objectFound = true)
                    {
                        lines.Add(readline);
                    }

                    if (readline.Contains("end,"))
                    {
                        lines.Remove(readline);
                        break;
                    }
                }
            }
            return lines;
        }
    }
}
