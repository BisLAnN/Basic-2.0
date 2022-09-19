using Basic.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Core
{
    public static class UserParser
    {
        public static IEnumerable<User> ParseFile(string path)
        {
            foreach (string line in File.ReadAllLines("users2.txt").Skip(1))
            {
                string[] props = line.Split(';');

                yield return new User(Convert.ToInt32(props[0]), props[1],
                    Convert.ToDateTime(props[2]), Convert.ToDecimal(props[3]));
            }
        }
    }
}
