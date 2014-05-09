demoApp.directive('uiRedClass', function () {
    var link = function (scope, element, attrs) {
        element.addClass('label-danger');
    };

    return {
        restrict: 'A',
        link: link
    };
});


demoApp.directive('uiVCard', function () {
    return {
        templateUrl: '/Client/Directives/Templates/uiVCard.html',
        restrict: 'EA',
        scope: {
            firstname: '=firstname',
            lastname: '=lastname'
        }
    };
});



demoApp.directive('uiClock', function ($interval, dateFilter) {
    function link(scope, element, attrs) {
        var timeoutId;

        function updateTime() {
            element.text(dateFilter(new Date(), 'M/d/yy h:mm:ss a'));
        };

        element.on('$destroy', function() {
            $interval.cancel(timeoutId);
        });

        timeoutId = $interval(function() {
            updateTime();
        }, 1000);
    }

    return {
        link: link
    };
});

demoApp.directive('uiAutocomplete', function () {
    function link(scope, element, attrs) {
        var onValueChange = function (event, ui) {
            scope.selectedValue = element.val();
        };

        $(element).autocomplete({
            source: scope.dataSource,
            change: onValueChange
        });

        scope.$watch(scope.dataSource, function () {
            $(element).autocomplete("option", "source", scope.dataSource);
        });
    }

    return {
        link: link,
        scope: {
            dataSource: '=source',
            selectedValue: '=ngModel'
        }
    };
});

