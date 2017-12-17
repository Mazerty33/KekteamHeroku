'use strict';

angular.module('carApp.login', ['ngRoute'])

.controller('loginController', ['$scope', '$rootScope', 'apiService', function($scope, $rootScope, apiService) {

    $scope.data = {
        username : "",
        Password : ""
    };

    $scope.login = function() {
        console.log(angular.toJson($scope.data));
        // If API works
        // apiService.login(angular.toJson($scope.data))
        //     .then(function success(response){
        //         $rootScope.isLogged = true;
        //         $rootScope.userName = response.userName;
        //         console.log(response);
        //     } ,function error(error) {
        //         console.log("Login impossible", error)
        //     });
        $rootScope.name = apiService.login(angular.toJson($scope.data)).userName
        console.log(apiService.login(angular.toJson($scope.data)))
        $rootScope.isLogged = true;
    };

}]);
