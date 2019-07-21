using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmaServerSelector
{
    class ModResidual : Exception
    { };
    class ArmaMod
    {
        public string Name { get; }
        public string Path { get; }
        public int ID { get; }
        private readonly string[] CPPFiles =
        {
            "\\meta.cpp",
            "\\mod.cpp"
        };
        private string ParseModFile(string path)
        {
            string line;

            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith("name = \""))
                    {
                        return line.Split('\"')[1];
                    }
                }
            }
            return null;
        }

        private string GetNameForMod(string path)
        {
            string name = null;

            foreach (string s in CPPFiles)
            {
                if (File.Exists(path + s))
                    name = ParseModFile(path + s);
                if (name != null)
                    return name;
            }
            throw new ModResidual();
        }

        public ArmaMod(string path)
        {
            this.Path = path;
            this.ID = int.Parse(path.Split('\\').Last());
            this.Name = GetNameForMod(path);
        }

        public ArmaMod(string path, string name, int ID)
        {
            Path = path;
            Name = name;
            this.ID = ID;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
