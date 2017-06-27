(function () {
    var ProjectTasksController = function ($scope, projectTasksService) {
        var projectTasks = function (data) {
            $scope.Tasks = data;
        };
        var errorDetails = function (serviceResp) {
            $scope.Error = "Something went wrong ??";
        };
        projectTasksService.projectTasks().then(projectTasks, errorDetails);
        $scope.Title = "Project Tasks Page";
    };

    app.controller("ProjectTasksController", ["$scope", "projectTasksService", ProjectTasksController]);

}());