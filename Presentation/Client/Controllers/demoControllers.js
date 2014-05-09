demoApp.controller('demo1Controller', [
    '$scope', '$http', function ($scope, $http) {
        $scope.a = 5;
        $scope.b = 12;

        $scope.foo = {
            a: 10,
            b: 12
        };

        $scope.bar = [1, 2, 3, 4, 5, 6];

        $scope.model = {
            a: 0,
            b: 1
        };

        $scope.compute = function () {
            return $scope.model.a * 1 + $scope.model.b * 1;
        };
    }
]);

demoApp.controller('demo2Controller', [
    '$scope', function ($scope) {
        $scope.array = [
            { id: 1, firstName: 'foo1', lastName: 'bar1' },
            { id: 2, firstName: 'foo2', lastName: 'bar2' },
            { id: 3, firstName: 'foo3', lastName: 'bar3' },
            { id: 4, firstName: 'foo4', lastName: 'bar4' },
            { id: 5, firstName: 'foo5', lastName: 'bar5' }
        ];

        $scope.addItem = function() {
            var maxId = Enumerable.From($scope.array).Max(function(x) {
                return x.id;
            }) + 1;

            $scope.array.push({
                id: maxId,
                firstName: "foo" + maxId,
                lastName: "bar" + maxId
            });
        };

        $scope.removeLast = function() {
            $scope.array.pop();
        };


        $scope.filters = [
            { id: 0, name: "filter 1", selected: false },
            { id: 1, name: "filter 2", selected: true },
            { id: 2, name: "filter 3", selected: false },
            { id: 3, name: "filter 4", selected: false },
            { id: 4, name: "filter 5", selected: false },
            { id: 5, name: "filter 6", selected: false }
        ];

        $scope.getSelectedFilters = function () {
            return Enumerable.From($scope.filters)
                .Where(function (x) { return x.selected == true; })
                .ToArray();
        };

        $scope.model = { selected: 1 };

        $scope.colors = [
            { id: 0, name: 'white' },
            { id: 1, name: 'black' },
            { id: 2, name: 'yellow' },
            { id: 3, name: 'red' }
        ];
    }
]);

demoApp.controller('demo3Controller', [
    '$scope', 'arrayService', 'colorService', 'filterService', 'colorShadesSerice',
    function ($scope, arrayService, colorService, filterService, colorShadesSerice) {
        $scope.array = arrayService();

        $scope.addItem = function () {
            var maxId = Enumerable.From($scope.array).Max(function (x) {
                return x.id;
            }) + 1;

            $scope.array.push({
                id: maxId,
                firstName: "foo" + maxId,
                lastName: "bar" + maxId
            });
        };

        $scope.removeLast = function () {
            $scope.array.pop();
        };

        $scope.filters = filterService.query();

        $scope.getSelectedFilters = function () {
            return Enumerable.From($scope.filters)
                .Where(function (x) { return x.selected == true; })
                .ToArray();
        };

        $scope.model = { selected: 1 };

        $scope.colors = colorService.success(function (data) {
                $scope.colors = data;
        });

        $scope.$watch('model.selectedItem', function () {
            if ($scope.model.selectedItem == null) {
                $scope.colorShades = [];
                return;
            }

            $scope.colorShades = colorShadesSerice.query({
                id: $scope.model.selectedItem.id
            });
        });


        $scope.vcard = {
            name: 'Jan',
            surname: 'Kowalski',
        };


        $scope.values = [
            "january",
            "february",
            "march",
            "april",
            "may",
            "june",
            "july",
            "august",
            "september",
            "october",
            "november",
            "december"
        ];
    }
]);