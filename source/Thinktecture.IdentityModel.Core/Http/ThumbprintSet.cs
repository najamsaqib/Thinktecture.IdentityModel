﻿/*
 * Copyright (c) Dominick Baier, Brock Allen.  All rights reserved.
 * Contribution by Pedro Felix
 * see LICENSE
 */

using System;
using System.Linq;
using System.Collections.Generic;

namespace Thinktecture.IdentityModel.Http
{
    public class ThumbprintSet : HashSet<string>
    {
        public ThumbprintSet(params string[] thumbprints)
            : base(from t in thumbprints select t.Replace(" ", ""), StringComparer.OrdinalIgnoreCase)
        { }
    }
}
