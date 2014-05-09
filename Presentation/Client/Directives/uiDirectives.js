
demoApp.directive('uiProgressBar', function () {
    return {
        templateUrl: '/Client/Directives/Templates/uiProgressBar.html',
        restrict: 'EA',
        scope: {
            percentage: '=percentage'
        }
    };
});