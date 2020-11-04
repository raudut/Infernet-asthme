// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace HarnessingTheCrowd
{
    /// <summary>
    /// The random model runner.
    /// </summary>
    public class RandomModelRunner : RunnerBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RandomModelRunner"/> class. 
        /// </summary>
        /// <param name="dataMapping">
        /// The data mapping
        /// </param>
        public RandomModelRunner(CrowdDataMapping dataMapping)
            : base(dataMapping)
        {
        }

        /// <inheritdoc />
        protected override void SetPredictions()
        {
            this.Predictions = this.DataMapping.GetRandomLabelsPerTweetId();
        }
    }
}
