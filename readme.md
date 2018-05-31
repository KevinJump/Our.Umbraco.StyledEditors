# Our.Umbraco.StyledEditors

In place replacement styleable controls for Umbraco's built in editors

## Getting Started
This repo contains the styled editors assembly, and a test website. 

### Setup

**Get the javascript library stuff :**
* npm install

**Build the test site :** 
* build the solution 
* Delete the umbraco version number from the web.config
* Delete the umbracoDSN line from the web.config
* run the site 
* Do a blank install (SqlCE - no starter kit)

Umbraco should install, and uSync will put all the settings/content back for you.

*You shouldn't need to check in the web.config as the install 
will just put the values you have removed back into the file*

### Development
All the editors / files are in the our.umbraco.stylededitors project, there is a background gulp task that will copy the files from App_Plugins into the test site, so you don't need to rebuild to test html/js changes. 

## Editors 

* Styled Textbox 
* Styled Textarea

