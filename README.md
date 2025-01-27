# QuickEscape - Projet Unity

## Description

QuickEscape est un jeu développé avec Unity dans lequel le joueur doit s’échapper de chaque niveau en moins de 10 secondes. Si le joueur échoue, il est téléporté au point de départ du niveau. Le jeu comprend une mécanique de clé et de porte, des animations, un système de chronomètre affiché à l’écran, et des interactions immersives.

## Fonctionnalités
- Chronomètre de 10 secondes affiché à l’écran.
- Mécanique de clé : le joueur doit ramasser une clé pour ouvrir la porte.
- Téléportation au point de départ après l’expiration du temps.
- Progression de niveau avec réinitialisation du chronomètre à chaque niveau.
- Interface utilisateur avec des messages contextuels ("Appuyez sur E").

## Prérequis
- Unity 2021 ou version ultérieure.
- Un éditeur de code (Visual Studio recommandé).

## Installation
1. Clonez ce dépôt ou téléchargez les fichiers :
   ```
   git clone https://github.com/HugoPoullain31/QuickEscape
   ```
2. Ouvrez Unity et chargez le projet.
3. Vérifiez que tous les packages nécessaires sont installés via le **Package Manager**.
4. Assurez-vous que les fichiers de scripts sont correctement assignés aux objets dans la scène.

## Utilisation
1. Lancez le jeu dans Unity (touche "Play").
2. Déplacez le personnage pour explorer le niveau.
3. Interagissez avec les objets (ex. : ramasser la clé avec **E**).
4. Trouvez la porte et échappez-vous avant la fin du chronomètre !

## Structure du projet

- **Assets**
  - `Scripts/`
    - `CollisionDetector.cs`: Gère les collisions et interactions.
    - `Key.cs`: Script pour la mécanique de la clé.
    - `Door.cs`: Contrôle l’animation de la porte.
    - `Timer.cs`: Gère le chronomètre et les événements associés.
  - `Prefabs/`
    - Objets réutilisables (clé, porte, etc.).
  - `UI/`
    - Canevas pour l’interface utilisateur (chronomètre, messages).

## Fonctionnalités principales
### Chronomètre
Le chronomètre est affiché en haut de l’écran. Il commence à 10 secondes à chaque niveau et redémarre si le joueur passe au niveau suivant. Si le temps expire, le joueur est téléporté au début du niveau.

### Interaction avec la clé et la porte
- Lorsque le joueur s’approche de la clé, un message "Appuyez sur E" apparaît.
- En appuyant sur **E**, la clé est ramassée et la porte peut être ouverte.
- La porte joue une animation d'ouverture lorsqu'elle est déverrouillée.

### Gestion des niveaux
- Chaque niveau comporte un point de départ et une porte de sortie.
- À la fin d'un niveau, le joueur est téléporté au point de départ du niveau suivant.

## Problèmes connus
- Le texte de l’interface utilisateur peut apparaître flou si les dimensions du canevas ne sont pas adaptées. Veuillez vérifier les paramètres de mise à l’échelle.

## Améliorations futures
- Ajouter des niveaux supplémentaires avec des défis uniques.
- Intégrer des sons et des effets visuels pour améliorer l’immersion.
- Ajouter un tableau des scores.
- Implémenter un mode multijoueur.


---

Merci de jouer à notre Escape Game ! Amusez-vous bien !

