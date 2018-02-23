var PersonApp = angular.module('PersonApp', []);

PersonApp.controller('TestController', function ($scope) {
    $scope.message = "Angular is a success!";
});

PersonApp.controller('PersonController', function ($scope, PeopleService) {

    getPeoples();
    function getPeoples() {
        PeopleService.getPeoples().success(function (peps) {
            $scope.people = peps;
            console.log($scope.people);
        })
        .error(function (error) {
            $scope.status = "Unable to load people data: " + error.message;
            console.log($scope.status);
        });
    }
});

PersonApp.controller('SecondPersonController', function ($scope, $http) {
    $http.get("people_sql.aspx").then(function (response) { $scope.people = response.data.records; });
});

PersonApp.factory('PeopleService', ['$http', function ($http) {
    var PeopleService = {};
    PeopleService.getPeoples = function () {
        return $http.get('/Controllers/PeopleController');
    };
    return PeopleService;
}]);