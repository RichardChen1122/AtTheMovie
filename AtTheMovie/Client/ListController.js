(function (app) {
    var ListController = function ($scope) {
        $scope.message = "HelloWorld!";
    };
    app.controller("ListController", ListController);
}(angular.module("atTheMovies")));