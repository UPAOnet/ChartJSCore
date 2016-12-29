﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChartJSCore.Models
{
    public class Scale
    {
        /// <summary>
        /// Type of scale being employed. Custom scales can be created and registered with a string key. Options: "category", "linear", "logarithmic", "time", "radialLinear".
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// If true, show the scale including gridlines, ticks, and labels. Overrides gridLines.display, scaleLabel.display, and ticks.display.
        /// </summary>
        public string Display { get; set; }

        /// <summary>
        /// Position of the scale. Possible values are 'top', 'left', 'bottom' and 'right'.
        /// </summary>
        public bool Position { get; set; }

        /// <summary>
        /// The ID is used to link datasets and scale axes together. The properties datasets.xAxisID or datasets.yAxisID have to match the scale properties scales.xAxes.id or scales.yAxes.id. This is especially needed if multi-axes charts are used.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Callback called before the update process starts. Passed a single argument, the scale instance.
        /// </summary>
        public string BeforeUpdate { get; set; }

        /// <summary>
        /// Callback that runs before dimensions are set. Passed a single argument, the scale instance.
        /// </summary>
        public string BeforeSetDimensions { get; set; }

        /// <summary>
        /// Callback that runs after dimensions are set. Passed a single argument, the scale instance.
        /// </summary>
        public string AfterSetDimensions { get; set; }

        /// <summary>
        /// Callback that runs before data limits are determined. Passed a single argument, the scale instance.
        /// </summary>
        public string BeforeDataLimits { get; set; }

        /// <summary>
        /// Callback that runs after data limits are determined. Passed a single argument, the scale instance.
        /// </summary>
        public string AfterDataLimits { get; set; }

        /// <summary>
        /// Callback that runs before ticks are created. Passed a single argument, the scale instance.
        /// </summary>
        public string BeforeBuildTicks { get; set; }

        /// <summary>
        /// Callback that runs after ticks are created. Useful for filtering ticks. Passed a single argument, the scale instance.
        /// </summary>
        public string AfterBuildTicks { get; set; }

        /// <summary>
        /// Callback that runs before ticks are converted into strings. Passed a single argument, the scale instance.
        /// </summary>
        public string BeforeTickToLabelConversion { get; set; }

        /// <summary>
        /// Callback that runs after ticks are converted into strings. Passed a single argument, the scale instance.
        /// </summary>
        public string AfterTickToLabelConversion { get; set; }

        /// <summary>
        /// Callback that runs before tick rotation is determined. Passed a single argument, the scale instance.
        /// </summary>
        public string BeforeCalculateTickRotation { get; set; }

        /// <summary>
        /// Callback that runs after tick rotation is determined. Passed a single argument, the scale instance.
        /// </summary>
        public string AfterCalculateTickRotation { get; set; }

        /// <summary>
        /// Callback that runs before the scale fits to the canvas. Passed a single argument, the scale instance.
        /// </summary>
        public string BeforeFit { get; set; }

        /// <summary>
        /// Callback that runs after the scale fits to the canvas. Passed a single argument, the scale instance.
        /// </summary>
        public string AfterFit { get; set; }

        /// <summary>
        /// Callback that runs at the end of the update process. Passed a single argument, the scale instance.
        /// </summary>
        public string AfterUpdate { get; set; }

        /// <summary>
        /// The grid line configuration is nested under the scale configuration in the gridLines key. It defines options for the grid lines that run perpendicular to the axis.
        /// </summary>
        public IList<GridLine> GridLines { get; set; }

        /// <summary>
        /// The scale label configuration is nested under the scale configuration in the scaleLabel key. It defines options for the scale title.
        /// </summary>
        public ScaleLabel ScaleLabel { get; set; }

        /// <summary>
        /// The tick configuration is nested under the scale configuration in the ticks key. It defines options for the tick marks that are generated by the axis.
        /// </summary>
        public Tick Ticks { get; set; }
    }
}
