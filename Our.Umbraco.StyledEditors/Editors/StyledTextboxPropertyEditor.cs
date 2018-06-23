using ClientDependency.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace Our.Umbraco.StyledEditors.Editors
{
    [PropertyEditorAsset(ClientDependencyType.Css, StyledEditors.PluginFolder + "Textbox/textbox.css")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, StyledEditors.PluginFolder + "Textbox/textboxController.js")]
    // [PropertyEditorAsset(ClientDependencyType.Javascript, "~/App_Plugins/StyledEditors/Textbox/textboxPreviewController.js")]
    [PropertyEditor("Styled.Textbox", "Styled Textbox", StyledEditors.PluginFolder + "/Textbox/textbox.html",
        Icon = "icon-brush", 
        ValueType = "text",
        Group = "common", 
        IsParameterEditor = true)]
    public class StyledTextboxPropertyEditor : PropertyEditor
    {
        private IDictionary<string, object> defaultPreValues;

        public override IDictionary<string, object> DefaultPreValues {
            get { return this.defaultPreValues; }
            set { this.defaultPreValues = value; }
        }

        public StyledTextboxPropertyEditor()
        {
            this.defaultPreValues = new Dictionary<string, object>
            {
                { "style", "font-size: 36px;\r\nline-height: 1.25;\r\nfont-weight: bold;" },
                { "cssclass", "" },
                { "charCount", 0 },
                { "enforceLimit", false },
                { "hideLabel", 0 }
            };
        }

        protected override PreValueEditor CreatePreValueEditor()
        {
            return new StyledTextboxPreValueEditor();
        }
    }
}
