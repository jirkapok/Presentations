module.exports = function (config) {
    config.set({
        frameworks: ["jasmine", "karma-typescript"],
        files: [
            { pattern: "src/**/*.ts" }
        ],
        preprocessors: {
            "**/*.ts": ["karma-typescript"]
        },
        reporters: ["dots", "karma-typescript"],
        browsers: ["ChromeDebugging"],
        customLaunchers: {
            ChromeDebugging: {
              base: 'ChromeHeadless',
              flags: [ '--remote-debugging-port=9333' ]
            }
          },

        singleRun: false
    });
};