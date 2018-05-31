using Umbraco.Core.PropertyEditors;

namespace Our.Umbraco.StyledEditors.Editors
{
    public class StyledTextboxPreValueEditor : PreValueEditor
    {
        [PreValueField("style", "Style", "textarea",
            Description = "Addtional styles to apply")]
        public string Style { get; set; }

        [PreValueField("cssclass", "Css Class", "textstring",
            Description = "CSS classes to apply")]
        public string CssClass { get; set; }

        /*
        [PreValueField("multiLine", "Multi-line", "boolean",
            Description = "Multiline textbox (textarea)")]
        public bool MultiLine { get; set; }
        */

        [PreValueField("placeholder", "Placeholder", "textstring",
            Description = "Placeholder text to put in box when empty")]
        public string Placeholder { get; set; }

        [PreValueField("charCount", "Character Count", "number",
            Description = "Number fo characters before warning/limit is reached")]
        public int MaxChars { get; set; }

        [PreValueField("enforceLimit", "Enforce Limit", "boolean",
            Description = "Don't let the editor go beyond the character count")]
        public bool EnforceLimit { get; set; }

        [PreValueField("hideLabel", "Full width", "boolean",
            Description = "Make the box go right across the editor (like a grid control does)")]
        public bool FullWidth { get; set; }
    }
}
