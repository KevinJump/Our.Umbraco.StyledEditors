using System.Collections.Generic;
using Umbraco.Core.PropertyEditors;

namespace Our.Umbraco.StyledEditors.Configuration
{
    public abstract class StyledConfigurationEditor<TConfiguration> :
        ConfigurationEditor<TConfiguration>
        where TConfiguration : new()
    {
        public override IDictionary<string, object> DefaultConfiguration => new Dictionary<string, object>
        {
            { "style", "font-size: 20px;\r\nline-height: 1.2;\r\nfont - weight: bold;" },
            { "cssclass", "" },
            { "hideLabel", false }
        };
    }

    public class StyledTextBoxConfigurationEditor :
        StyledConfigurationEditor<StyledTextboxConfiguration>
    {
        public override IDictionary<string, object> DefaultConfiguration
        {
            get
            {
                var config = base.DefaultConfiguration;
                config["style"] = "font-size: 32px;\r\nline-height: 1.4;\r\nfont - weight: bold;";
                return config;
            }
        }
    }

    public class StyledTextAreaConfigurationEditor :
        StyledConfigurationEditor<StyledTextAreaConfiguration>
    { }

    public class StyledNumericConfigurationEditor :
        StyledConfigurationEditor<StyledNumericConfiguration>
    { }

    public class StyledDecimalConfigurationEditor :
        StyledConfigurationEditor<StyledDecimalConfiguration>
    { }
}
