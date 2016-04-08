
var appMainModule = angular.module('appMain', ['ngRoute'])
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider.when('/', { templateUrl: '/Templates/Home.html', controller: 'homeViewModel' });
        $routeProvider.when('/customer/list', { templateUrl: '/Templates/CustomerList.html', controller: 'customerListViewModel' });
        $routeProvider.when('/customer/detail', { templateUrl: '/Templates/CustomerDetail.html', controller: 'customerDetailViewModel' });
        $routeProvider.otherwise({ redirectTo: '/' });
        $locationProvider.html5Mode(true);
    });

appMainModule.controller("indexViewModel", function ($scope, $http, $location) {
    $scope.headingCaption = 'Angular Routing Primer';
});

appMainModule.controller("homeViewModel", function ($scope, $http, $location) {

    $scope.headingCaption = 'This is a list of people:';

    $scope.people = [
        { FirstName: 'Miguel', LastName: 'Castro' },
        { FirstName: 'Andrew', LastName: 'Brust' },
        { FirstName: 'Brian', LastName: 'Noyes' },
        { FirstName: 'John', LastName: 'Petersen' },
        { FirstName: 'Brian', LastName: 'Randell' },
        { FirstName: 'Gus', LastName: 'Emery' }
    ];

    $scope.showPerson = function (person) {
        alert('You selected ' + person.FirstName + ' ' + person.LastName);
    }
});

appMainModule.controller("customerListViewModel", function ($scope, $http, $location) {
    $scope.heading = 'Customer List View';
});

appMainModule.controller("customerDetailViewModel", function ($scope, $http, $location) {
    $scope.heading = 'Customer Detail View';
});
