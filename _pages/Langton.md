---
permalink: "/Visualisation/Langton/"
layout: page
title:  "Langton's Ant"
---
![Langton's Ant]({{ "/img/full/Langton.png" | prepend: site.baseurl }}){:class="lazyload"}

The Langton’s Ant visualisation is produced using the simple set of rules devised by Chris Langton in 1986, in which an ant ‘walks’ on a two-dimensional grid of black and white cells. Within each move or iteration, the ant progresses one step. 

- When reaching a white square, the ant turns 90 degrees, flips the colour of the square to black and progresses one step
- When reaching a black square, the ant turns 90 degrees in the opposite direction, flips the colour of the square to white, and progresses one step

It is believed that regardless of the direction that the ant starts in, the ant will always emerge onto a ‘highway’ pattern, which is shown in the image above. 
The concept has been further explored by mathematicians and computer scientists, who have added ant colonies(termites) to produce further complex patterns. 

Code
----------
{% highlight java linenos %}
{% include code/Ant.pde %}
{% endhighlight %}

References
----------
[http://mathworld.wolfram.com/LangtonsAnt.html](http://mathworld.wolfram.com/LangtonsAnt.html){:target="_blank"} 
[https://en.wikipedia.org/wiki/Langton%27s_ant](https://en.wikipedia.org/wiki/Langton%27s_ant){:target="_blank"}