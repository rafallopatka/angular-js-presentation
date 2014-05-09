demoApp.controller('setListController', [
    '$scope', '$sce', 'songListService', function ($scope, $sce, songListService) {
        $scope.playList = songListService.query();
        $scope.currentSong = null;

        $scope.playSong = function (song) {
            var url = "//www.youtube-nocookie.com/embed/" + song.id + "?hd=1&iv_load_policy=3&autoplay=1";
            $scope.currentSong = {
                url: $sce.trustAsResourceUrl(url),
                song: song
            };
        };

        $scope.playNextSong = function () {
            var songIndex = $scope.playList.indexOf($scope.currentSong.song);
            var nextIndex = songIndex == $scope.playList.length - 1 ? 0 : songIndex + 1;
            var nextSong = $scope.playList[nextIndex];
            $scope.playSong(nextSong);
        };

        $scope.playPreviousSong = function () {
            var songIndex = $scope.playList.indexOf($scope.currentSong.song);
            var nextIndex = songIndex == 0 ? $scope.playList.length - 1 : songIndex - 1;
            var nextSong = $scope.playList[nextIndex];
            $scope.playSong(nextSong);
        };

        $scope.removeSong = function(song) {
            var i = $scope.playList.indexOf(song);
            $scope.playList.splice(i, 1);
        };
    }
]);

