app.service('petOwnerService', ['$http', '$filter', 'WebApiService', function ($http, $filter, WebApiService) {
    var service = this;

    service.init = function (vm) {
        WebApiService.getAllOwnerPetList().then(function successCallback(response, status, headers, config) {
            vm.femalePetList = angular.copy(response.data.FemalePetList);
            vm.malePetList = angular.copy(response.data.MalePetList);
        
        }, function errorCallback(response, status, headers, config) {
            //TODO: handle errror
            console.log(response);
        });
    };

}]);