/// <reference path="Scripts/angular.js" />
"use strict";

define(['angularAMD', 'angular-route'], function (angularAMD) {
    var app = angular.module('employeeApp', ['ngRoute']);

    app.config(function ($routeProvider, $locationProvider) {

        $routeProvider.
            when("/", angularAMD.route({
                templateUrl: 'app/Example/Example.html'
            })).
            when("/Index", angularAMD.route({
                templateUrl: 'app/Example/Example.html'
            })).
            when("/Employees", angularAMD.route({
                templateUrl: 'app/Employee/Employee.html', controller: 'employeeController',
                controllerUrl: 'app/Employee/EmployeeController.js'
            })).
         otherwise({ redirectTo: "/" });

        $locationProvider.html5Mode(true);
    });


    return angularAMD.bootstrap(app);

});
