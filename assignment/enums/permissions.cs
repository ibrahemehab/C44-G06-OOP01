using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.enums
{
    [Flags]
    public enum Permissions : byte 
    {
        delete = 1 ,
        execute = 2, 
        read = 4 , 
        write = 8
    }
}
