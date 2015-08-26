---
permalink: "/Visualisation/Julia/"
layout: page
title:  "Julia Set"
---
![Julia Set]({{ "/img/full/Julia.png" | prepend: site.baseurl }})

The filled Julia set is similar to the Mandelbrot set, but instead of changing the c value within the function z^2 + c, the first iterant value is changed from 0, to the particular point on the complex plane. This allows for a fixed c value and a range of different pictures. 

Creation of this visualisation was comparatively simple, as the complex number function from Mandelbrot could be reused and applied easily to a new iteration of the visualisation. The difficulty in making this however, was picking the correct c value, and colouring the dots created so an aesthetically pleasing spiral was created. 