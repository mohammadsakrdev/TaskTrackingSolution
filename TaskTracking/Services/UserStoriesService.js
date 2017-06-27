(function () {
    var userStoriesService = function ($http) {
        var userStories = function () {
            return $http.get("http://localhost:2464/api/userstories")
                        .then(function (serviceResp) {
                            return serviceResp.data;
                        });
        };
        return {
            userStories: userStories
        };
    };
    var module = angular.module("TaskTrackingModule");

    module.factory("userStoriesService", ["$http", userStoriesService]);

}());