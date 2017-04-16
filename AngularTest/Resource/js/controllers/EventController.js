'use strict'
eventsApp.controller('EventController',
    function EventController($scope, $log, eventData) {
        $scope.myClass = "blue";
        $scope.sortorder = "name";
        $scope.query = "";

        eventData.getEvent()
        .success(function (event) {
            $scope.event = event;})
        .error(function (data, status, headers, config) {
            $log.warn('TEST Failed');
        });        

        $scope.upVoteSession = function (session) {
            session.upVoteCount++;
        }

        $scope.downVoteSession = function (session) {
            session.upVoteCount--;
        }

    });