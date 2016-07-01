---
permalink: "/Visualisation/Ant/"
layout: page
title:  "Ant"
---
![Ant]({{ "/img/full/Ant.png" | prepend: site.baseurl }}){:class="lazyload"}

This ant works on two simple rules. Using the number Pi, it visually turns right if it encounters an odd number, and visually turns left if it encounters an even number. Looping through one million digits of pi, a shape is created. 

If it happens to repeat turns within a square, it adds to the ‘counter’ at that square, a variable recording the number of repeats. This counter is then used to determine the brightness of that square. This was quite a simple program to make, as, having had experience creating Langston's ant before, it was just a matter of applying similar rules to a different situation. 

Code
----------
{% highlight vb linenos %}
{% include code/Ant.vb %}
{% endhighlight %}

References
----------
Please refer to Langton's Ant