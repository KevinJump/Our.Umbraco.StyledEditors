using Our.Umbraco.StyledEditors.Configuration;
using System;
using Umbraco.Core;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace Our.Umbraco.StyledEditors.Editors
{
    public class StyledTextValueEditor : TextOnlyValueEditor
    {
        public StyledTextValueEditor(DataEditorAttribute attribute)
            : base(attribute)
        {}

        public override object Configuration {
            get => base.Configuration;
            set {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));
                if (!(value is StyledEditorConfiguration configuration))
                    throw new ArgumentException($"Expected a {typeof(StyledEditorConfiguration).Name} instance, but got {value.GetType().Name}.", nameof(value));
                base.Configuration = value;

                HideLabel = configuration.HideLabel.TryConvertTo<bool>().Result;
            }
        }
    }
}
