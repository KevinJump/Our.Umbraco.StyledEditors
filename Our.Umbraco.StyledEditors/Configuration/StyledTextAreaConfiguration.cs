using Umbraco.Core.PropertyEditors;

namespace Our.Umbraco.StyledEditors.Configuration
{
    public class StyledTextAreaConfiguration : StyledTextboxConfiguration
    {
        [ConfigurationField("rows", "Number of rows", "number",
            Description = "If empty - 10 rows would be set as the default value")]
        public int? Rows { get; set; }
    }
}
