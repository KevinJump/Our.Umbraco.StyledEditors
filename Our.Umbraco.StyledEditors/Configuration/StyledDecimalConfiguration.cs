using Our.Umbraco.StyledEditors.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.PropertyEditors;

namespace Our.Umbraco.StyledEditors.Configuration
{
    public class StyledDecimalConfiguration : StyledEditorConfiguration
    {
        [ConfigurationField("min", "Minimum", "number",
          Description = "Enter the minimum amount of number to be entered")]
        public Decimal Min { get; set; }

        [ConfigurationField("step", "Step Size", "number",
            Description = "Enter the intervals amount between each step of number to be entered")]
        public Decimal Steps { get; set; }

        [ConfigurationField("max", "Maximum", "number",
            Description = "Enter the maximum amount of number to be entered")]
        public Decimal Max { get; set; }
    }
}
