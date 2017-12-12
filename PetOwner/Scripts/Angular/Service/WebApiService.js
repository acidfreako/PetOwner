//TODO: put base URL to constant file.
//TODO: angular caching strategy? 
app.service('WebApiService', ['$http', function ($http) {

    this.getAllOwnerPetList = function () {
        return $http({
            method: 'GET',
            url: 'http://localhost:52472/api/owner/get-all-owner-pet-list'
        });
    };

}]);