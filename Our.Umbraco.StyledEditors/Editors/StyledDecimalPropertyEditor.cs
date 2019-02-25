using Our.Umbraco.StyledEditors.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Umbraco.Core;
using Umbraco.Core.Logging;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace Our.Umbraco.StyledEditors.Editors
{
    [DataEditor(StyledEditors.Aliases.Decimal, EditorType.PropertyValue | EditorType.MacroParameter,
        "Styled Decimal", StyledEditors.Views.Decimal, ValueType = ValueTypes.Decimal,
        Icon = "icon-brush-alt-2 color-indigo", Group = "Common")]
    public class StyledDecimalPropertyEditor : DecimalPropertyEditor
    {
        public StyledDecimalPropertyEditor(ILogger logger) : base(logger)
        { }

        protected override IDataValueEditor CreateValueEditor()
        {
            var editor = base.CreateValueEditor();
            editor.Validators.Add(new StyledDecimalValidator());
            return editor;
        }

        protected override IConfigurationEditor CreateConfigurationEditor()
            => new StyledDecimalConfigurationEditor();
    }

    internal class StyledDecimalValidator: IManifestValueValidator
    {
        public string ValidationName => "Decimal";

        public IEnumerable<ValidationResult> Validate(object value, string valueType, object dataTypeConfiguration)
        {
            if (value == null || value.ToString() == string.Empty)
                yield break;

            var result = value.TryConvertTo<Decimal>();
            if (result.Success == false)
                yield return new ValidationResult("The value " + value + " is not a valid decimal", new[] { "value" });
        }
    }
}
