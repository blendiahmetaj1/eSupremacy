﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sociatis_Test_Suite.Dummies
{
    public interface IDummyCreator<EntityT>
    {
        EntityT Create();
    }
}
