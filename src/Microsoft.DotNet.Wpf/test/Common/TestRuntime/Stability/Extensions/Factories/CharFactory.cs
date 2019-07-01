// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
    
using System;
using Microsoft.Test.Stability.Core;

namespace Microsoft.Test.Stability.Extensions.Factories
{
    class CharFactory : DiscoverableFactory<Char>
    {
        public override Char Create(DeterministicRandom random)
        {
            return (char)random.Next(255);
        }
    }
}
