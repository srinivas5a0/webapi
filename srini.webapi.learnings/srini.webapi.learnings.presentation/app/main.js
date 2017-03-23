/// <reference path="D:\DotNetProjects\webapi\srini.webapi.learnings\srini.webapi.learnings\Scripts/require.js" />

require.config({
    baseUrl: "app",
    paths: {
        'angular': 'Scripts/angular',
        'angular-route': 'Scripts/angular-route',
        'jquery': 'Scripts/jquery-1.10.2',
        'angularAMD': 'Scripts/angularAMD',
        'bootstrap': 'Scripts/bootstrap'
    },
    shim: {
        'angularAMD': ['angular'],
        'angular-route': ['angular'],
        'ngload': ['angularAMD'],
        'bootstrap': ['jquery']
        
    },
    deps: ['app']
});
