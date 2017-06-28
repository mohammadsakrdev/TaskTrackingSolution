(function () {
    var projectService = function ($http, $log) {
        var projects = function () {
            return $http.get("http://localhost:2464/api/projects")
                        .then(function (serviceResp) {
                            return serviceResp.data;
                        });
        };
        var insertProject = function (project) {
            return $http.post("http://localhost:2464/api/projects", project)
            .then(function () {
                $log.info("Insert Successful");
                return;
            });
        };
        var singleProject = function (id) {
            return $http.get("http://localhost:2464/api/ptprojects/" + id)
                        .then(function (serviceResp) {
                            return serviceResp.data;
                        });
        };
        var modifyProject = function (project) {
            return $http.put("http://localhost:2464/api/ptprojects", project)
            .then(function () {
                $log.info("Update Successful");
                return;
            });
        };

        return {
            projects: projects,
            insertProject: insertProject,
            modifyProject: modifyProject
        };
    };
    var module = angular.module("TaskTrackingModule");
    module.factory("projectService", projectService);
}());