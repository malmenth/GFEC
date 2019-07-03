﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GFEC
{
    interface INonLinearSolution
    {
        double[] Solve(IAssembly assembly, ILinearSolution linearScheme, double[] forceVector);
        int numberOfLoadSteps { get; set; }
    }
}