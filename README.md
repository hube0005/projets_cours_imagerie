# projets_cours_imagerie
[FR]
Projets du cours de Capture et production de contenus créatifs

Lors de mon cours de capture et production de contenus créatifs, j’ai réalisé plusieurs projets. Le premier était le plus important et portait sur le traitement d’image. L’objectif était d’implémenter des méthodes permettant d’obtenir des images High Dynamic Range (HDR). La première était la méthode de Debevec. Je me suis inspirée du code trouvé sur un dépôt GitHub. J’ai ensuite trouvé une fonction de la librairie OpenCV qui implémente cette même méthode.
Je devais aussi implémenté la méthode de Mertens. Là encore, j’ai trouvé son équivalent dans OpenCV. Cependant pour cette méthode, mon implémentation ne fonctionne pas puisque les couleurs ne seront pas récupérées. Une amélioration est en cours d’écriture.
Lors d’une de mes parties de jeu, je me suis rendue compte que Nvidia propose de prendre des captures d’écran directement en HDR mais aussi de modifier l’intensité des images. J’ai alors appliqué les solutions de Debevec et de Mertens que j’avais sur ces images. J’ai comparé ces trois solutions en utilisant plusieurs images.

Un autre projet consistait à l’implémentation d’une méthode de transfert de couleur. En utilisant deux images, l’une d’elles voit ses couleurs modifiées pour celles de l’autre image. Pour cela, une conversion vers différents domaines de couleurs (RGB vers LAB, RGB vers XYZ, sans conversion).

Enfin le dernier projet portait sur la BRDF, la réflectivité bidirectionnelle. L’objectif était d’implémenter deux méthodes en Javascript/WebGL : Lambert et Cook Torrance. Le première donne un résultat plutôt mat et la deuxième a un reflet de lumière. Plusieurs paramètres sont modifiables : la couleur de l’objet, la couleur de la lumière, l’intensité ou l’indice de réfraction.

[EN]
Soon
