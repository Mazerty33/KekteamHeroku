'use strict';


angular.module('carApp.carDetails', ['ngRoute'])

.controller('carDetailsController', ['$scope', '$routeParams', 'apiService', function($scope, $routeParams, apiService) {

  var carId = $routeParams.carId;
  console.log(carId);

  function id(element){
    return element.id.increment == carId;
  }

  var getCarById = function(){
    apiService.getAll()
        .then(function success(response){
          var carsTotal = response.data;
          $scope.car = carsTotal.find(id);
          console.log($scope.car);
        } ,function error(error) {
            console.log("get car immpossible", error)
        });
  }

  getCarById();

  var car_details = this;
  $scope.Brand = "maroute"
  $scope.Model = "maroute"
  $scope.Color = "maroute"
  $scope.Price = "maroute"
  $scope.Year = "maroute"
  $scope.Kilometer = "maroute"
  $scope.HousePower = "maroute"
  $scope.NbDoors = "maroute"
  $scope.Store = "maroute"
}]);
