﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAF.Infrastructure.Core.Data.Hooks
{
    public class HookedEntityEntry
    {
        public object Entity { get; set; }
        public EntityState PreSaveState { get; set; }
    }
}