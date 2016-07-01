/* global smooth_scroll_to, YT, document, Image */

// Load Youtube Player
// https://developers.google.com/youtube/iframe_api_reference#Loading_a_Video_Player
var player;
function loadYT() {
    "use strict";
    document.getElementById('video').className = "animateinvideo";
    var tag = document.createElement('script'), firstScriptTag = document.getElementsByTagName('script')[0];

    tag.src = "https://www.youtube.com/iframe_api";
    firstScriptTag.parentNode.insertBefore(tag, firstScriptTag);
}
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


// Return Location of Tag
function returnlocation(pageid) {
    "use strict";
    var location = (document.getElementById(pageid).getBoundingClientRect().top) - document.body.getBoundingClientRect().top;
    return location;
}
// Navigation Bar Clicks
function initlinks() {
    "use strict";
    var time = 1000;
    document.getElementById('herolink').onclick = function () {
        smooth_scroll_to(returnlocation('hero'), time);
    };
    document.getElementById('portfoliolink').onclick = function () {
        smooth_scroll_to(returnlocation('portfolio'), time);
    };
    document.getElementById('arrowcontain').onclick = function () {
        smooth_scroll_to(returnlocation('portfolio'), time);
    };
    document.getElementById('videolink').onclick = function () {
        smooth_scroll_to(returnlocation('video'), time);
        loadYT();
    };
}

// Fadein Element
function fadein(e) {
    "use strict";
    e.className = "fadein";
    e.style.backgroundImage = "img/hero.png";
}
// Document Load
document.onreadystatechange = function () {
    "use strict";
    if (document.readyState === "interactive") {
        initlinks();
        var image = new Image();
        image.src = "img/hero.png";
        image.onload = function() {
            var project = document.getElementById('hero');
            project.onload = fadein(project);
        };
    }
};
