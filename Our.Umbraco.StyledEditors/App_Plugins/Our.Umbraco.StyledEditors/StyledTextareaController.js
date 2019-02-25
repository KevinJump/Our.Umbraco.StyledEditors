(function () {
    'use strict';

    function styledTextareaController($scope) {

        var vm = this;
        vm.countStyle = 'color-green';
        vm.config = {};

        vm.change = change;
        vm.getCount = getCount;

        /////////

        if ($scope.model.config) {
            vm.config = $scope.model.config;
        }

        vm.maxlength = false;
        if ($scope.model.config.maxChars) {
            vm.maxlength = true;
        }

        if (vm.maxlength) {
            if ($scope.model.value === undefined) {
                $scope.model.count = ($scope.model.config.maxChars * 1);
            } else {
                $scope.model.count = ($scope.model.config.maxChars * 1) - $scope.model.value.length;
            }
            updateStyle($scope.model.count);
        }

        //////////
        function change() {
            if ($scope.model.config && $scope.model.config.maxChars) {
                if ($scope.model.value === undefined) {
                    $scope.model.count = ($scope.model.config.maxChars * 1);
                } else {
                    $scope.model.count = ($scope.model.config.maxChars * 1) - $scope.model.value.length;
                }

                if ($scope.model.count < 0) {
                    if (vm.config.enforceLimit === true) {
                        $scope.model.value = $scope.model.value.substring(0, ($scope.model.config.maxChars * 1));
                        $scope.model.count = 0;
                    }
                }

                updateStyle($scope.model.count);
            }
        }

        function getCount(count) {
            return Math.abs(count);
        }

        function updateStyle(count) {
            if (count < 0) {
                vm.countStyle = 'color-red';
            }
            else if (count < 10) {
                vm.countStyle = 'color-orange';
            }
            else {
                vm.countStyle = 'color-green';
            }
        }


    }

    angular.module('umbraco')
        .controller('StyledEditors.textareaController', styledTextareaController);

})();