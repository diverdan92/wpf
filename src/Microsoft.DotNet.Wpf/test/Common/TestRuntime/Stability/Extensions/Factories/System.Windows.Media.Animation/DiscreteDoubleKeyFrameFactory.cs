// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
        
using System.Windows.Media.Animation;
using Microsoft.Test.Stability.Core;

namespace Microsoft.Test.Stability.Extensions.Factories
{
    internal class DiscreteDoubleKeyFrameFactory : DoubleKeyFrameFactory<DiscreteDoubleKeyFrame>
    {
        #region Override Members

        public override DiscreteDoubleKeyFrame Create(DeterministicRandom random)
        {
            DiscreteDoubleKeyFrame discreteDoubleKeyFrame = new DiscreteDoubleKeyFrame();
            ApplyDoubleKeyFrameProperties(discreteDoubleKeyFrame, random);

            return discreteDoubleKeyFrame;
        }

        #endregion
    }
}
