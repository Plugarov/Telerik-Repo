const gulp = require('gulp');
const gulpsync = require('gulp-sync')(gulp);
const babel = require('gulp-babel');
const nodemon = require('gulp-nodemon');
const clean = require('gulp-clean');
const strip = require('gulp-strip-comments');

gulp.task('clean', () => {
    return gulp
        .src('build', {
            read: false,
        })
        .pipe(clean());
});

gulp.task('compile:server', () => {
    return gulp.src([
            './server/**/*.js',
        ])
        .pipe(strip())
        .pipe(babel({
            presets: ['es2015'],
        }))
        .pipe(gulp.dest('./build/server/'));
});

gulp.task('compile:public', () => {
    return gulp.src([
            './public/**/*.js',
        ])
        .pipe(gulp.dest('./build/public/'));
});

gulp.task('copy:app', () => {
    return gulp
        .src([
            './app/**/*.js',
        ])
        .pipe(strip())
        .pipe(gulp.dest('./build/app'));
});

gulp.task('copy:templates', () => {
    return gulp
        .src('./public/templates/**/*.handlebars')
        .pipe(gulp.dest('./build/public/templates'));
});

gulp.task('copy', ['copy:app', 'copy:templates']);

gulp.task('build', gulpsync.sync([ 'clean', 'compile:public', 'compile:server', 'copy']));

gulp.task('serve', ['build'], () => {
    nodemon({
        script: './build/server/app.js',
        ext: 'js html css scss',
        ignore: ['build'],
        tasks: ['build'],
    });
});
