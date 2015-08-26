---
permalink: "/Visualisation/Mandelbrot/"
layout: page
title:  "Mandelbrot"
---
![Mandelbrot]({{ "/img/full/Mandelbrot.png" | prepend: site.baseurl }})

The Mandelbrot visualisation is one of the most fascinating visualisations on the website, simply due to the intriguing nature of the Mandelbrot itself. Visualised using the Mandelbrot set, each individual pixel is generated according to the set rules. 

In creating the Mandelbrot, mathematical guidelines needed to be adhered to in order for the visualisation to be created correctly. The Mandelbrot set works by iterating through each pixel, using each individual pixel as a point in the complex plane. Iterating from 0, the visualisation uses the equation, z^2 + c, where z is the iterant and c is the point on the complex plane, until the resultant visualisation approaches infinity. Programmed using VB.Net, it also created a base for a class, which would also be used for the Filled Julia set and the Buddhabrot.