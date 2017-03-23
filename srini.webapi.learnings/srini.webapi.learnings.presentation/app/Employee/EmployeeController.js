/// <reference path="../Scripts/angular.js" />
"use strict";

define(['app'], function (app) {
    app.controller('employeeController', ['$scope', '$http', function ($scope, $http) {
        $scope.employees;
        $scope.message = "Hello Angular";

        $scope.AddEmployee = function (emp) {
            $http.post("/api/Employees",emp).
            success(function (data, status) {
                $scope.employees.push(data);
                alert("Added employee successfully");
            });
            
        };

        $scope.DelEmployee = function (employee) {
            var index = $scope.employees.indexOf(employee);
            $scope.employees.splice(index, 1);
        };

        $scope.EditEmployee = function (employee) {
            //$scope.employees.
        };

        $http.get("/api/Employees").
            then(function (response) {
                $scope.employees = response.data;
            });

        $http.post("/api/AddEmployee").
            then(function (response) {
                $scope.message = "Added employee successfully";
            });

        $http.post("/api/EditEmployee").
            then(function (response) {
                $scope.message = "Added employee successfully";
            });

        $http.post("/api/DelEmployee").
            then(function (response) {
                $scope.message = "Added employee successfully";
            });


    }]);
})

