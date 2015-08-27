---
permalink: "/Visualisation/Ant/"
layout: page
title:  "Ant"
---
![Ant]({{ "/img/full/Ant.png" | prepend: site.baseurl }}){:class="lazyload"}

This ant works on two simple rules. Using the number Pi, it visually turns right if it encounters an odd number, and visually turns left if it encounters an even number. Looping through one million digits of pi, it creates a shape. 

If it happens to repeats turns within a square shape already created, it adds to the ‘counter’ at that square, a variable recording how many repeats have occurred. Depending on how many times the ant has been through that square, the brightness of that square once the image is rendered is determined. This was quite a simple program to make, as, experienced making Langton’s ant before, it was just a matter of applying similar rules to a different situation. 

Code
----------
<script src="https://gist.github.com/YC/82b1944da19e392f9758.js"></script>

References
----------
Please refer to Langton's Ant