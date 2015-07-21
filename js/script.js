/*global smooth_scroll_to, YT*/

// Return Location of Tag
function returnlocation(pageid) {
    "use strict";
    var location = (document.getElementById(pageid).getBoundingClientRect().top) - document.body.getBoundingClientRect().top;
    return location;
}

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

//https://developers.google.com/youtube/iframe_api_reference#Loading_a_Video_Player
function onYouTubeIframeAPIReady() {
    "use strict";
    player = new YT.Player('player', {
        events: {
            'onReady': onPlayerReady,
            'onStateChange': onPlayerStateChange
        }
    });
}


function initlinks() {
    "use strict";
    document.getElementById('herolink').onclick = function () {
        smooth_scroll_to(returnlocation('hero'), 1000);
    };
    document.getElementById('portfoliolink').onclick = function () {
        smooth_scroll_to(returnlocation('portfolio'), 1000);
    };
    document.getElementById('arrowcontain').onclick = function () {
        smooth_scroll_to(returnlocation('portfolio'), 1000);
    };
    document.getElementById('videolink').onclick = function () {
        smooth_scroll_to(returnlocation('video'), 1000);
        loadYT();
    };
}


//function menuanimation() {
//    "use strict";
//    if (window.scrollY >= document.getElementById('video').offsetTop && window.scrollY < document.getElementById('portfolio').offsetTop) {
//        document.getElementById('menu').className = "animateoutmenu";
//    } else {
//        document.getElementById('menu').className = "";
//    }
//}

function fadein(e) {
    "use strict";
    e.className = e.className + " fadein";
}

// Document Load
document.onreadystatechange = function () {
    "use strict";
    if (document.readyState === "complete") {

        initlinks();
        //menuanimation();
        var project = document.getElementById('hero');
        project.onload = fadein(project);

        //smooth_scroll_to(returnlocation('hero'), 1000);
    }
};

//document.onscroll = function () {
//    "use strict";
//    //menuanimation();
//    //console.log("Main " + document.getElementById('hero').offsetTop);
//    //console.log("Player " + document.getElementById('player').offsetTop);
//    //console.log("Portfolio " + document.getElementById('portfolio').offsetTop);
//    //console.log(window.scrollY);
//};