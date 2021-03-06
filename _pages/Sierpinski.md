---
permalink: "/Visualisation/Sierpinski/"
layout: page
title:  "Sierpinski Triangle & Carpet"
---
![Sierpinski Triangle]({{ "/img/full/Sierpinski.png" | prepend: site.baseurl }}){:loading="lazy"}

Sierpinski’s Triangle is the famous fractal pattern triangle - wherein the largest triangle is filled with an infinite number of smaller triangles down to the pixel. The beauty of the triangle is in its simplicity, which makes the triangle eye-catching yet understandable.

In this case, the visualisation was produced by generating an array in a loop, which took into consideration each individual part of the triangle and removing the relevant triangles to create a fractal effect. Similar to this was Sierpinski’s carpet, which utilised a square shape instead, producing an equally stunning fractal.

![Sierpinski Carpet]({{ "/img/full/Carpet.png" | prepend: site.baseurl }})

Code
----------
{% highlight vb linenos %}
{% include code/Carpet.vb %}
{% endhighlight %}
{% highlight vb linenos %}
{% include code/Triangle.vb %}
{% endhighlight %}

References
----------
[http://mathworld.wolfram.com/SierpinskiSieve.html](http://mathworld.wolfram.com/SierpinskiSieve.html){:target="_blank"}