using ClientDependency.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Logging;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;
using Our.Umbraco.StyledEditors.Configuration;

namespace Our.Umbraco.StyledEditors.Editors
{
    [PropertyEditorAsset(ClientDependencyType.Javascript, StyledEditors.PluginFolder + "/StyledTextareaController.js")]

    [DataEditor(StyledEditors.Aliases.TextArea, EditorType.PropertyValue | EditorType.MacroParameter, "Styled Textarea",
        StyledEditors.Views.TextArea, Icon = "icon-brush-alt color-indigo", ValueType = ValueTypes.Text, Group = "Common")]
    public class StyledTextAreaPropertEditor : DataEditor
    {
        public StyledTextAreaPropertEditor(ILogger logger)
                   : base(logger)
        { }


        protected override IDataValueEditor CreateValueEditor()
            => new StyledTextValueEditor(Attribute);

        protected override IConfigurationEditor CreateConfigurationEditor()
            => new StyledTextAreaConfigurationEditor();
    }
}
