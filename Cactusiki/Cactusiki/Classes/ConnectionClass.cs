using Cactusiki.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cactusiki.Classes
{
    internal class ConnectionClass
    {
        public static Entities5 db = new Entities5();
        public static Cactus cactus;
        public static Exhibitions exhibitions;
    }
}
