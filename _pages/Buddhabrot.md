---
permalink: "/Visualisation/Buddhabrot/"
layout: page
title:  "Buddhabrot"
---
![Buddhabrot]({{ "/img/full/Buddhabrot.png" | prepend: site.baseurl }}){:class="lazyload"}

The Buddhabrot set was also similar to the Filled Julia set and the Mandelbrot set. It picks a random value from the complex plane, and uses that as the c value for the function z^2 + c. Starting from zero, the output yields of the function are recorded and stored in an array. The function continues to iterate until output yield values are greater than 2, and thus approaching infinity. Subsequently, the visualisation takes the log of all the recorded values, and then plots the values on a picture, giving the buddhabrot set.  

This was relatively challenging to program, as values were hard to interpret. Once it was worked out however, the programming of the buddhabrot itself was easy, as once again, the base was set out in the subroutines already created for the Mandelbrot, which could just be modified and adapted.

Code
----------
<script src="https://gist.github.com/YC/ac17551baf6fc68d150b.js"></script>