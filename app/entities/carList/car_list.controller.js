'use strict';

angular.module('carApp.carList', ['ngRoute'])

.controller('carListController', ['$scope', '$rootScope', 'apiService', function($scope, $rootScope, apiService) {

    $scope.currentPage = 1;
    $scope.totalPages = 0;

    var getCars = function(){
      apiService.getAll()
          .then(function success(response){
            var carsTotal = response.data;
            $scope.totalPages = Math.round(carsTotal.length/20)+1;
            $scope.cars = carsTotal.slice(($scope.currentPage-1)*20, $scope.currentPage*20-1);
          } ,function error(error) {
              console.log("get carlist immpossible", error)
          });
    }

    getCars();

    $scope.pageChanged = function(direction){
      $scope.currentPage += direction;
      getCars();
    }
}]);
