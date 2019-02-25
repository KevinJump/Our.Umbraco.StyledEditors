using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors.ValueConverters;

namespace Our.Umbraco.StyledEditors.Converters
{
    public class StyledNumericValueConverter : IntegerValueConverter
    {
        public override bool IsConverter(PublishedPropertyType propertyType)
            => StyledEditors.Aliases.Numeric.Equals(propertyType.EditorAlias);

    }
}
