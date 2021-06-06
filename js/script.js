/* global smooth_scroll_to, YT, document, Image */

// Load Youtube Player
// https://developers.google.com/youtube/iframe_api_reference#Loading_a_Video_Player
var player;
function onPlayerReady(event) {
    "use strict";
    event.target.setVolume(100);
    event.target.playVideo();
}
function onPlayerStateChange(event) {
    "use strict";
    if (event.data === 0) {
        document.getElementById('video').className = "animateoutvideo";
        document.getElementById('menu').className = "animatemenu";
    }
}
function onYouTubeIframeAPIReady() {
    "use strict";
    player = new YT.Player('player', {
        events: {
            'onReady': onPlayerReady,
            'onStateChange': onPlayerStateChange
        }
    });
}
// Document Load
document.onreadystatechange = function () {
    "use strict";
    if (document.readyState === "interactive") {
        var time = 1000;
        document.getElementById('videolink').onclick = function () {
            document.getElementById('video').className = "animateinvideo";
            var tag = document.createElement('script'), firstScriptTag = document.getElementsByTagName('script')[0];
            tag.src = "https://www.youtube.com/iframe_api";
            firstScriptTag.parentNode.insertBefore(tag, firstScriptTag);
            document.getElementById('video').scrollIntoView({ behavior: 'smooth' });
        };

        var image = new Image();
        image.src = "img/hero.png";
        image.onload = function() {
            var project = document.getElementById('hero');
                project.className = "fadein";
                project.style.backgroundImage = "img/hero.png";
        };
    }
};
