using Umbraco.Core.PropertyEditors;

namespace Our.Umbraco.StyledEditors.Configuration
{
    public class StyledEditorConfiguration
    {
        [ConfigurationField("style", "Style", "textarea",
            Description = "Additional styles to apply")]
        public string Style { get; set; }

        [ConfigurationField("cssclass", "Css Classes", "textstring",
            Description = "Css classes to apply")]
        public string CssClass { get; set; }

        [ConfigurationField("placeholder", "Placeholder", "textstring",
            Description = "Placeholder text to put in box when empty")]
        public string Placeholder { get; set; }

        [ConfigurationField("hideLabel", "Hide Label", "boolean",
            Description = "Hide the label (like a grid element)")]
        public bool HideLabel { get; set; }
    }
}
