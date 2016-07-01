---
permalink: "/Visualisation/Julia/"
layout: page
title:  "Julia Set"
---
![Julia Set]({{ "/img/full/Julia.png" | prepend: site.baseurl }}){:class="lazyload"}

The filled Julia set is similar to the Mandelbrot set, but instead of changing the c value within the function z^2 + c, the first iterant value is changed from 0, to the particular point on the complex plane. This allows for a fixed c value and a range of different pictures.  
Creation of this visualisation was comparatively simple, as the complex number function from Mandelbrot could be reused and applied to a new iteration of the visualisation. The difficulty in making this however, was in picking the correct c value and artifically colouring the resultant picture. 

Code
----------
{% highlight vb linenos %}
{% include code/JuliaSet.vb %}
{% endhighlight %}

References
----------
[https://en.wikipedia.org/wiki/Julia_set](https://en.wikipedia.org/wiki/Julia_set){:target="_blank"}