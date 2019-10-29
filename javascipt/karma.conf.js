module.exports = function (config) {
  config.set({
    basePath: '',
    frameworks: ['jasmine'],
    files: [
      'src/*.spec.js',
      'src/*.js'
    ],
    plugins: [
      require('karma-chrome-launcher'),
      require('karma-jasmine-html-reporter'),
      require('karma-jasmine')
    ],
    client: {
      clearContext: false // leave Jasmine Spec Runner output visible in browser
    },
    exclude: [
    ],
    preprocessors: {

    },
    reporters: ['progress', 'kjhtml'],
    port: 9876,
    colors: true,
    logLevel: config.LOG_INFO,
    autoWatch: true,
    browsers: ['Chrome'],
    singleRun: false
  });
};
