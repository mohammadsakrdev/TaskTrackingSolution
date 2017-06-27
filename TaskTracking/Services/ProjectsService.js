(function () {
    var projectService = function ($http) {
        var projects = function () {
            return $http.get("http://localhost:2464/api/projects")
                        .then(function (serviceResp) {
                            return serviceResp.data;
                        });
        };
        return {
            projects: projects
        };
    };
    var module = angular.module("TaskTrackingModule");

    module.factory("projectService", ["$http", projectService]);

}());