/// <binding ProjectOpened='default' />
const { watch, src, dest } = require('gulp');
var config = require('./gulp.config.json');

/*
 * umbraco app_plugin folder script 
 * 
 * copies files from a app_plugin folder in a library to your
 * umbraco site.
 * 
 * config.json should look like : 
 * 
 * {
 *   "library": "folder-library-lives-in",
 *   "site": "YourProject.Site",
 *   "pluginFolder": "folder-in-app-plugins"
 * }
 */

const appPluginPath = '/App_Plugins/' + config.pluginFolder;
const sourceFolder = config.library + appPluginPath + '/';
const destination = config.site + appPluginPath;
const source = sourceFolder + '**/*';


console.log('umbraco app_plugin sync script running');
console.log('--------------------------------------');
console.log('from : ', source);
console.log('to   : ', destination);
console.log('--------------------------------------');


function copy(path) {

    return src(path, { base: sourceFolder })
        .pipe(dest(destination));
}

function time() {
    return '[' + new Date().toISOString().slice(11, -5) + ']';
}

exports.default = function () {
    watch(source, { ignoreInitial: false })
        .on('change', function (path, stats) {
            console.log(time(), path, 'changed');
            copy(path);
        })
        .on('add', function (path, stats) {
            console.log(time(), path, 'added');
            copy(path);
        });
};
    

