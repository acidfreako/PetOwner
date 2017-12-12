describe("petOwner", function () {
    var element, scope, controller, classGrid, vm, WebApiService, myPetOwnerService, data, row, httpBackend, q;

    beforeEach(module('app'));

    beforeEach(inject(function ($compile, $rootScope, $controller, $filter, $httpBackend,$q, petOwnerService, _WebApiService_) {
        myPetOwnerService = petOwnerService;
        WebApiService = _WebApiService_;
        httpBackend = $httpBackend;
        q = $q;
    }));


    
    it("should have called WebApiService.getAllOwnerPetList", function () {
        var vm;
        spyOn(WebApiService, 'getAllOwnerPetList').and.callThrough();

        myPetOwnerService.init(vm);

        expect(WebApiService.getAllOwnerPetList).toHaveBeenCalled();
    })
})