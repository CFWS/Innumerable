---
permalink: "/Visualisation/Spiral/"
layout: page
title:  "Golden Spiral"
---
![Golden Spiral]({{ "/img/full/Spiral.png" | prepend: site.baseurl }}){:loading="lazy"}

The Golden Spiral was a challenging visualisation to produce. In order to create the spiral, it was necessary to make many translations to the curve function of the spiral itself. In this case, the translations were applied to the arc function in VB.Net. Challenges presented themselves in discerning the specific translations that were needed for each segment of the curve.

Code
----------
{% highlight vb linenos %}
{% include code/GoldenSpiral.vb %}
{% endhighlight %}

References
----------
[https://en.wikipedia.org/wiki/Golden_spiral](https://en.wikipedia.org/wiki/Golden_spiral){:target="_blank"}