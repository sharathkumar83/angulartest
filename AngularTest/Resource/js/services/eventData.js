eventsApp.factory('eventData', function ($http, $log) {
    return {
        getEvent: function () {
            return $http({ method: 'GET', url: '/api/events' });
        }
        /*
        error(function (data, status, headers, config) {
                $log.warn('TEST Failed');
        });
    */
    };
});

eventsApp.factory("")


eventsApp.factory("eventDataTest", function () {
    return {
        event: {
            name: 'Angular Test',
            date: '5/03/2017',
            time: '10:30 AM',
            location: {
                address: 'Sydney',
                postcode: 215
            },
            sessions: [{
                name: 'Controller',
                duration: 1,
                level: 'Beginer',
                upVoteCount: 0
            },
            {
                name: 'Services',
                duration: 2,
                level: 'Inter',
                upVoteCount: 0
            },
            {
                name: 'Drectives',
                duration: 3,
                level: 'Expert',
                upVoteCount: 0
            },
            {
                name: 'AAAAA',
                duration: 4,
                level: 'Inter',
                upVoteCount: 0
            }
            ]
        }
    };
});