using Our.Umbraco.StyledEditors.Configuration;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Umbraco.Core;
using Umbraco.Core.Logging;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace Our.Umbraco.StyledEditors.Editors
{
    [DataEditor(StyledEditors.Aliases.Numeric, EditorType.PropertyValue | EditorType.MacroParameter,
        "Styled Numeric", StyledEditors.Views.Numeric, ValueType = ValueTypes.Integer, 
        Icon = "icon-brush-alt-2 color-indigo", Group = "Common")]
    public class StyledNumericPropertyEditor : IntegerPropertyEditor
    {
        public StyledNumericPropertyEditor(ILogger logger) : base(logger)
        { }

        protected override IDataValueEditor CreateValueEditor()
        {
            var editor = base.CreateValueEditor();
            editor.Validators.Add(new StyledNumericValidator());
            return editor;
        }

        protected override IConfigurationEditor CreateConfigurationEditor()
            => new StyledNumericConfigurationEditor();
    }

    internal class StyledNumericValidator : IManifestValueValidator
    {
        public string ValidationName => "Integer";

        public IEnumerable<ValidationResult> Validate(object value, string valueType, object dataTypeConfiguration)
        {
            if (value == null || value.ToString() == string.Empty)
                yield break;

            var result = value.TryConvertTo<int>();
            if (result.Success == false)
                yield return new ValidationResult("The value " + value + " is not a valid interger", new[] { "value" });
        }
    }

}
