﻿using Entities.structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServices.PathFinding
{
    public interface IPathFindingRegionSelector
    {
        bool IsPassableRegion(Neighbour neighbour);
    }
}
