using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.PropertyEditors;

namespace Our.Umbraco.StyledEditors.Configuration
{
    public class StyledNumericConfiguration : StyledEditorConfiguration
    {
        [ConfigurationField("min", "Minimum", "number",
            Description = "Enter the minimum amount of number to be entered")]
        public int? Min { get; set; }

        [ConfigurationField("step", "Step Size", "number",
            Description = "Enter the intervals amount between each step of number to be entered")]
        public int? Steps { get; set; }

        [ConfigurationField("max", "Maximum", "number",
            Description = "Enter the maximum amount of number to be entered")]
        public int? Max { get; set; }
    }
}
