using Umbraco.Core.PropertyEditors;

namespace Our.Umbraco.StyledEditors.Configuration
{
    public class StyledTextboxConfiguration : StyledEditorConfiguration
    {
        [ConfigurationField("maxChars", "Maximum allowed characters", "textstringlimited", 
            Description = "If empty, 500 character limit")]
        public int? MaxChars { get; set; }

        [ConfigurationField("enforceLimit", "Enforce Limit", "boolean",
            Description = "Don't let the editor go beyond the character count")]
        public bool EnforceLimit { get; set; }

    }
}
