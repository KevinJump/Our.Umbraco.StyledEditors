using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors.ValueConverters;

namespace Our.Umbraco.StyledEditors.Converters
{
    public class StyledTextPropertyValueConverter : TextStringValueConverter
    {
        private static readonly string[] PropertyTypeAliases =
        {
            StyledEditors.Aliases.TextBox,
            StyledEditors.Aliases.TextArea
        };

        public override bool IsConverter(PublishedPropertyType propertyType)
            => PropertyTypeAliases.Contains(propertyType.EditorAlias);
    }
}
