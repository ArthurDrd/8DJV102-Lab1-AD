# ***Projet #1***

Utilisation de différents concepts de base de développement de jeux vidéo dans le moteur Unity

Projet #1 réalisé dans le cadre du cours 8DJV102 - FONDEMENTS THÉORIQUES DES MOTEURS DE JEUX VIDÉO

## **[Github](https://github.com/ArthurDrd/8DJV102-Lab1-AD)**

## *Auteur*

* **Arthur durand**

## *Contenu*

Tout mes élements se trouve dans la scène 1.

J'ai réalisé 4 scripts : 

- CapsuleMovement -> Contient la 2ème loi de newton pour calculer l'acceleration que je donne a ma capsule au debut de la scene et lui faire faire un mouvement linéaire
- DivideWall -> Divise par 2 la velocité de l'objet qui touche le mur et rotate de 90 degrés l'objet
- MultiplyWall -> Multiplie par 2 la velocité de l'objet qui touche le mur et rotate de 90 degrés l'objet
- Spawner -> Créer un timer qui lance toutes les 1 secondes la fonction spawn qui instancie des prefab et leur donne une force dans une direction aléatoire

J'ai utilisé l'accélération et la décéleration ainsi que la gestions des collisions avec les murs.
Les objets spawn par mon spawner sont sur une couche différente pour pas qu'il interagisse avec la capsule de base.
J'ai 1 sprites custom qui est la "pokeball".
La gravité de la capsule est inversé ce qui lui donne un comportement  "impossible"
