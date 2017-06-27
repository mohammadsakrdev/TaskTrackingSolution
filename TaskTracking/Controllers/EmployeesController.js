(function () {
    var EmployeesController = function ($scope, $http) {
        var employees = function (serviceResp) {
            $scope.Employees = serviceResp.data;
        };
        $scope.SearchEmployees = function (EmployeeName) {
            $http.get("http://localhost:57786/api/employees/" + EmployeeName)
            .then(employees, errorDetails);
        };
        var errorDetails = function (serviceResp) {
            $scope.Error = "Something went wrong ??";
        };
        $http.get("http://localhost:57786/api/employees")
            .then(employees, errorDetails);
        $scope.Title = "Employee Details Page";
    };
    app.controller("EmployeesController", EmployeesController);
}());