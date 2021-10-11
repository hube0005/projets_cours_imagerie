# projets_cours_imagerie
[FR]
Projets du cours de Capture et production de contenus créatifs

Lors de mon cours de capture et production de contenus créatifs, j’ai réalisé plusieurs projets. Le premier était le plus important et portait sur le traitement d’image. L’objectif était d’implémenter des méthodes permettant d’obtenir des images High Dynamic Range (HDR). La première était la méthode de Debevec. Je me suis inspirée du code trouvé sur un dépôt GitHub. J’ai ensuite trouvé une fonction de la librairie OpenCV qui implémente cette même méthode.
Je devais aussi implémenté la méthode de Mertens. Là encore, j’ai trouvé son équivalent dans OpenCV. Cependant pour cette méthode, mon implémentation ne fonctionne pas puisque les couleurs ne seront pas récupérées. Une amélioration est en cours d’écriture.
Lors d’une de mes parties de jeu, je me suis rendue compte que Nvidia propose de prendre des captures d’écran directement en HDR mais aussi de modifier l’intensité des images. J’ai alors appliqué les solutions de Debevec et de Mertens que j’avais sur ces images. J’ai comparé ces trois solutions en utilisant plusieurs images.

Un autre projet consistait à l’implémentation d’une méthode de transfert de couleur. En utilisant deux images, l’une d’elles voit ses couleurs modifiées pour celles de l’autre image. Pour cela, une conversion vers différents domaines de couleurs (RGB vers LAB, RGB vers XYZ, sans conversion).

Enfin le dernier projet portait sur la BRDF, la réflectivité bidirectionnelle. L’objectif était d’implémenter deux méthodes en Javascript/WebGL : Lambert et Cook Torrance. Le première donne un résultat plutôt mat et la deuxième a un reflet de lumière. Plusieurs paramètres sont modifiables : la couleur de l’objet, la couleur de la lumière, l’intensité ou l’indice de réfraction.

/*=============================================================================================================================================================================*/

[EN]
Projects from the Creative Content Capture and Production course

During my Creative Content Capture and Production course, I realized several projects. The first one was the most important one and was about image processing. The objective was to implement methods to obtain High Dynamic Range (HDR) images. The first one was the Debevec method. I was inspired by the code found on a GitHub repository. I then found a function in the OpenCV library that implements this same method.
I also had to implement the Mertens method. Here again, I found its equivalent in OpenCV. However for this method, my implementation does not work because the colors will not be retrieved. An improvement is being written.
During one of my games, I realized that Nvidia proposes to take screenshots directly in HDR but also to modify the intensity of the images. I then applied the solutions of Debevec and Mertens that I had on these images. I compared these three solutions using several images.

Another project consisted in the implementation of a color transfer method. Using two images, one of them has its colors modified for those of the other image. For this, a conversion to different color domains (RGB to LAB, RGB to XYZ, without conversion).

Finally, the last project was about BRDF, the bidirectional reflectivity. The objective was to implement two methods in Javascript/WebGL: Lambert and Cook Torrance. The first one gives a rather matte result and the second one has a light reflection. Several parameters can be modified : the color of the object, the color of the light, the intensity or the refraction index.
