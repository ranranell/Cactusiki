using Cactusiki.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cactusiki.Classes
{
    internal class ConnectionDB
    {

        public static Entities db = new Entities();
        public static Roles role;
        public static Cactus cactus;
        public static Exhibitions exhibitions;
    }
}
