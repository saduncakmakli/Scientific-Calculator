using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScientificCalculation
{
    internal enum ErrorEnumerators
    {
        UNSUCCESSFUL, SUCCESSFUL, INVALID_OPERATION, NUMBER_NOT_FOUND
    }

    internal enum ResourceEnumerators
    {
        KEYBOARD, MOUSE, SCREEN
    }
    
    internal enum Operations
    {
        NULL,EXP,ROOT,CROSS,DIVISION,PLUS,MINUS
    }
}