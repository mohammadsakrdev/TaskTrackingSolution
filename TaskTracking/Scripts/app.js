var app = angular.module('TaskTrackingModule', ['ngRoute']);
app.config(function ($routeProvider) {
    $routeProvider
        .when("/Home", {
            templateUrl: "/Home.html",
            controller: "HomeController"
        })
        .when("/Projects", {
            templateUrl: "/ProjectManagement/ProjectsDetails.html",
            controller: "ProjectsController"
        })
        .when("/UserStories", {
            templateUrl: "/UserStories/UserStoryDetails.html",
            controller: "/UserStoriesController"
        })
        .when("/Employees", {
            templateUrl: "/Employees/EmployeesDetails.html",
            controller: "EmployeesController"
        })
        .when("/Tasks", {
            templateUrl: "/Tasks/ProjectTaskDetails.html",
            controller: "ProjectTasksController"
        })
        .when("/NewProject", {
            templateUrl: "/ProjectManagement/ProjectInsert.html",
            controller: "ProjectsController"
        })
        .when("/ModifyProject/:projectID", {
            templateUrl: "/ProjectManagement/ProjectModify.html",
            controller: "ProjectsController"
        })
    .otherwise({ redirectTo: "/Home" })
});