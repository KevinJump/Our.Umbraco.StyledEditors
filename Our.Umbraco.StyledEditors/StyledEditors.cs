using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Our.Umbraco.StyledEditors
{
    public class StyledEditors
    {
        public const string PluginFolder = "~/App_Plugins/Our.Umbraco.StyledEditors";

        public class Views
        {
            public const string TextBox = PluginFolder + "/StyledTextbox.html";
            public const string TextArea = PluginFolder + "/StyledTextarea.html";
            public const string Numeric = PluginFolder + "/StyledNumeric.html";
            public const string Decimal = PluginFolder + "/StyledDecimal.html";
        }

        public class Aliases
        {
            public const string TextBox = "Our.Umbraco.StyledTextbox";
            public const string TextArea = "Our.Umbraco.StyledTextarea";
            public const string Numeric = "Our.Umbraco.StyledNumeric";
            public const string Decimal = "Our.Umbraco.SryledDecimal";
                
        }
    }
}
