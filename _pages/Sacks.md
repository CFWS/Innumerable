---
permalink: "/Visualisation/Sacks/"
layout: page
title:  "Sacks Spiral"
---
![Sacks Spiral]({{ "/img/full/Sacks.png" | prepend: site.baseurl }}){:loading="lazy"}

The Sacks and Ulams spiral explores prime numbers, by displaying them in a regular, observable pattern. The Sacks spiral works by looping integers, and detecting prime numbers as they occur. Should the number be detected as a prime number, a coloured dot is displayed in the corresponding numerical position within the spiral. If the number is not detected as a a prime, a dot is not shown. The dots are subsequently coloured according to how large the number is, thus a spiral is created.

The Ulams spiral is similar to the Sacks spiral, but instead of looping in a spiral effect, detected primes are looped in a square, thus creating a different pattern of prime numbers.

Code
----------
{% highlight vb linenos %}
{% include code/SacksSpiral.vb %}
{% endhighlight %}

References
----------
[https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes](https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes){:target="_blank"}
[http://www.dcs.gla.ac.uk/~jhw/spirals/](http://www.dcs.gla.ac.uk/~jhw/spirals/){:target="_blank"}