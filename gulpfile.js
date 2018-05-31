/// <binding ProjectOpened='default' />
/*
    copy the app_plugins folder when it changes
    means we don't have to rebuild, and umbraco
    loads the changes quicker.
*/
var gulp = require('gulp'),
    watch = require('gulp-watch');

var sources = [
    './Our.Umbraco.StyledEditors/App_Plugins'],
    dest = './StyledEditors.Site/App_Plugins';

gulp.task('monitor', function () {

    sources.forEach(function (source) {
        watch(source + '/**/*', { ignoreInitial: false, verbose: true })
            .pipe(gulp.dest(dest));
    });
});

gulp.task('default', ['monitor'])