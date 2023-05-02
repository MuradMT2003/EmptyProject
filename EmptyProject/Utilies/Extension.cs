using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyProject.Utilies;

internal static class Extension
{
    public static bool FileSize(this int number)
    {
        return number > 100;
    }
}
