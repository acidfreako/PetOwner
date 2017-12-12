angular.module('app').directive('petOwner', petOwner);
function petOwner() {
    return {
        templateUrl: 'Scripts/Angular/Directives/PetOwner/petOwner.html',
        controller: ['$scope', 'petOwnerService', function ($scope, petOwnerService) {
            var vm = this;
            vm.femalePetList = [];
            vm.malePetList = [];
            vm.init = function () {
                petOwnerService.init(vm);
            };

            vm.init();
        }],
        controllerAs: 'petOwner',
        restrict: 'E',
        scope: {},
        bindToController: true
    };
}
