(function () {
    var ProjectsController = function ($scope, $http) {
        var projects = function (serviceResp) {
            $scope.Projects = serviceResp.data;
        };
        var errorDetails = function (serviceResp) {
            $scope.Error = "Something went wrong ??";
        };
        $http.get("http://localhost:57786/api/projects/1")
            .then(projects, errorDetails);
        $scope.Title = "Project Details Page";
    };
    app.controller("ProjectsController", ProjectsController);
}());