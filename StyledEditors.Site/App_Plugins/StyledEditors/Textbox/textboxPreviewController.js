/*
 *  experimental preview - controller
 * 
 *  watches the config change (in the parent,parent,parent!)
 *  and updates an input box on the prevalue page
 */
(function () {

    'use strict';

    function previewController($scope, editorState) {

        var vm = this;
        vm.preValues = $scope.$parent.$parent.$parent.preValues;

        vm.config = {};

        $scope.$watch('$parent.$parent.$parent.preValues', function () {

            if ($scope.$parent.$parent.$parent.preValues != undefined) {
                vm.preValues = $scope.$parent.$parent.$parent.preValues;

                vm.config.placeholder = _.where(vm.preValues, { alias: 'placeholder' })[0].value;
                vm.config.cssclass = _.where(vm.preValues, { alias: 'cssclass' })[0].value;
                vm.config.style = _.where(vm.preValues, { alias: 'style' })[0].value;
            }

        }, true);
    };

    angular.module('umbraco')
        .controller('styledTextPreviewController', previewController);

})();