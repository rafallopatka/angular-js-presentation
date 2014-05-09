var demoServices = angular.module('demoServices', ['ngResource']);

demoServices.factory('arrayService', function () {
    return function() {
        return [
            { id: 1, firstName: 'foo1', lastName: 'bar1' },
            { id: 2, firstName: 'foo2', lastName: 'bar2' },
            { id: 3, firstName: 'foo3', lastName: 'bar3' },
            { id: 4, firstName: 'foo4', lastName: 'bar4' },
            { id: 5, firstName: 'foo5', lastName: 'bar5' }
        ];
    };
});

demoServices.factory('colorService', ['$http', function($http) {
        return $http.get('/Api/Color');
    }
]);

demoServices.factory('filterService', ['$resource', function ($resource) {
        return $resource('/Api/Filter/', {}, {
            query: {
                method: 'GET',
                isArray: true
            }
        });
    }
]);

demoServices.factory('colorShadesSerice', ['$resource', function ($resource) {
        return $resource('/Api/Shade/:id', {}, {
            query: {
                method: 'GET',
                isArray: true,
                params: {
                    id: 'id'
                }
            }
        });
    }
]);