/* Author/Source: https://coderwall.com/p/hujlhg/smooth-scrolling-without-jquery*/
/* https://developer.mozilla.org/en-US/docs/Web/API/Window.scrollY*/
/* CFWS: Modified as it doesn't work with Firefox to scroll the entire page (document.body) - 
Changed to window.scrollY and window.scroll(0, target) -> Where 0 is for Horizontal*/

/**
    Smoothly scroll element to the given target (element.scrollTop)
    for the given duration

    Returns a promise that's fulfilled when done, or rejected if
    interrupted
 */

function scrollPosition() {
    if (window.scrollY === 0 || window.scrollY === undefined) {
        return document.documentElement.scrollTop;
    } else {
        return window.scrollY;
    }
}

var smooth_scroll_to = function (target, duration) {
    target = Math.round(target);
    duration = Math.round(duration);
    if (duration < 0) {
        return Promise.reject("bad duration");
    }
    if (duration === 0) {
        window.scroll(0, target);
        //element.scrollTop = target;
        return Promise.resolve();
    }

    var start_time = Date.now();
    var end_time = start_time + duration;

    //var start_top = element.scrollTop;
    var start_top = scrollPosition();

    var distance = target - start_top;

    // based on http://en.wikipedia.org/wiki/Smoothstep
    var smooth_step = function (start, end, point) {
        if (point <= start) {
            return 0;
        }
        if (point >= end) {
            return 1;
        }
        var x = (point - start) / (end - start); // interpolation
        return x * x * (3 - 2 * x);
    };

    return new Promise(function (resolve, reject) {
        // This is to keep track of where the element's scrollTop is
        // supposed to be, based on what we're doing
        //var previous_top = element.scrollTop;

        var previous_top = scrollPosition();

        // This is like a think function from a game loop
        var scroll_frame = function () {
            //if(element.scrollTop != previous_top) {
            if (scrollPosition() !== previous_top) {
                if (navigator.userAgent.match(/iPhone/i) === false || (navigator.userAgent.match(/iPod/i))) === false {
                                reject("interrupted");
                return;

                }
                
            }

            // set the scrollTop for this frame
            var now = Date.now();
            var point = smooth_step(start_time, end_time, now);
            var frameTop = Math.round(start_top + (distance * point));
            //element.scrollTop = frameTop;
            window.scroll(0, frameTop);

            // check if we're done!
            if (now >= end_time) {
                resolve();
                return;
            }

            // If we were supposed to scroll but didn't, then we
            // probably hit the limit, so consider it done; not
            // interrupted.
            /*            if(element.scrollTop === previous_top
                && element.scrollTop !== frameTop) {
                resolve();
                return;
            }

            if(scrollPosition() === previous_top
               && scrollPosition() !== frameTop) {
                resolve();
                return;
            }
            */

            if (target === scrollPosition) {
                resolve();
                return;
            }

            previous_top = scrollPosition();

            // schedule next frame for execution
            setTimeout(scroll_frame, 0);
        };

        // boostrap the animation process
        setTimeout(scroll_frame, 0);
    });
};