---
permalink: "/Visualisation/deJong/"
layout: page
title:  "Peter de Jong Attractor"
---
![Peter de Jong Attractor]({{ "/img/full/deJong.png" | prepend: site.baseurl }}){:class="lazyload"}

Attractor & Animation
----------
The Peter de Jong Attractor Animation was produced to complement the static visualisations. The attractor itself, is a mathematical system, represented by coordinates on a set of axes. Each coordinate changes depending on, in this case, a trigonometric function, as well as the position of the previous coordinate. By changing the variables of the Peter de Jong attractor, a series of continuous frames were produced, which were subsequently combined to form the Innumerable animation. 

In order to render the Peter de Jong attractor, we utilised open-sourced code on Open Processing. After converting the code, it was soon discovered that the program was too slow to be a practical or viable for use. In order to fix this, we optimised the code by using better suited data structures and integrated multithreading to double the efficiency of the program. 

There were also issues with the nature of the attractor. That is, the attractor algorithm would periodically produce blank frames, where the coordinates returned by the attractor were scattered, and hence did not produce an image. This was due to the nature of the trigonometric functions used. The problem was fixed by detecting individual blank frames and simply omitting the blank frame, and moving to the next frame by changing the values of the function, in order to create a continuous visualisation.

After finalising the program, a powerful desktop computer from the school’s IT faculty was utilised in order to render a sequence of attractor frames overnight. The images were then processed in Adobe After Effects as an image sequence and rendered as an animation. 

The animation for this visualisation is also accompanied by an original composition. Set out on an orchestral scale and part of the Innumerable portfolio, it is also a showcase of what the group is capable of. 

The animation can be viewed on the home page. 

Code
----------
<script src="https://gist.github.com/YC/8484eb73b3b66959308d.js"></script>

References
----------
[http://www.openprocessing.org/sketch/2097](http://paulbourke.net/fractals/peterdejong/){:target="_blank"}  
[http://paulbourke.net/fractals/peterdejong/](http://paulbourke.net/fractals/peterdejong/){:target="_blank"}

License
----------
Strange Attractor code were derived from:  "de Jong Attractor" by Thor Frølich 
Licensed under Creative Commons Attribution-Share Alike 3.0 and GNU GPL license. 
Original Work: http://openprocessing.org/visuals/?visualID=2097

Modifications were made. 
Modified Code:  See Above  

http://creativecommons.org/licenses/by-sa/3.0/ 
http://creativecommons.org/licenses/GPL/2.0/ 

These licenses apply to the Henon and Peter de Jong attractors.