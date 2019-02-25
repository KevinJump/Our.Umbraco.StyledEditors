using ClientDependency.Core;
using Our.Umbraco.StyledEditors.Configuration;
using System.Collections.Generic;
using Umbraco.Core.Logging;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace Our.Umbraco.StyledEditors.Editors
{
    [PropertyEditorAsset(ClientDependencyType.Css, StyledEditors.PluginFolder + "/stylededitors.css")]
    [PropertyEditorAsset(ClientDependencyType.Javascript, StyledEditors.PluginFolder + "/StyledTextboxController.js")]

    [DataEditor(StyledEditors.Aliases.TextBox, EditorType.PropertyValue | EditorType.MacroParameter, "Styled Textbox", 
        StyledEditors.Views.TextBox, Icon = "icon-brush color-indigo", Group = "Common")]
    public class StyledTextboxPropertyEditor : DataEditor
    {
        public StyledTextboxPropertyEditor(ILogger logger)
             : base(logger)
        { }

        protected override IDataValueEditor CreateValueEditor()
            => new StyledTextValueEditor(Attribute);

        protected override IConfigurationEditor CreateConfigurationEditor()
            => new StyledTextBoxConfigurationEditor();
    }
}
