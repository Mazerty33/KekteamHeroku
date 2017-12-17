angular.module('carApp.apiService', [])
  .factory('apiService', ['$http', function($http) {

      var apiService = {};

      apiService.getAll = function(){
        // If API works
        //  return $http.get("http://backendcake.azurewebsites.net/api/Cars");
        //Get from file
          return $http.get("Cars.json");
      }
      apiService.getOneById = function(id){
          return $http.get("http://localhost:3000/popular?page=", id);
      }
      apiService.login = function(creditentials){
        // If API works
        // return $http.post("http://backendcake.azurewebsites.net/api/Auth", creditentials);
          return {userName : "John Doe"}
      }

      return apiService;

  }]);
