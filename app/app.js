'use strict';

// Declare app level module which depends on views, and components
angular.module('carApp', [
  'ngRoute',
  'ui.bootstrap',
  'carApp.login',
  'carApp.carList',
  'carApp.carDetails',
  'carApp.apiService',
  'carApp.version'
]).
config(['$locationProvider', '$routeProvider', function($locationProvider, $routeProvider) {
  $locationProvider.hashPrefix('!');

  $routeProvider
  .when('/login', {
     templateUrl: 'entities/login/login.html',
     controller: 'loginController'
  })
  .when('/carList', {
     templateUrl: 'entities/carList/car_list.html',
     controller: 'carListController'
  })
  .when('/carDetails/:carId', {
     templateUrl: 'entities/carDetails/car_details.html',
     controller: 'carDetailsController'
  })
  .otherwise({redirectTo: '/carList'});
}]);
