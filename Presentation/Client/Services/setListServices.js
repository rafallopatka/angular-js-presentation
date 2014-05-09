var setListServices = angular.module('setListServices', ['ngResource']);

setListServices.factory('songListService', ['$resource', function ($resource) {
    return $resource('/Api/Song/', {}, {
        query: {
            method: 'GET',
            isArray: true
        }
    });
}]);