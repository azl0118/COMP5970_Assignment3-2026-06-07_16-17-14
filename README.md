# Space Shooter Game (Unity 2D)

A 2D arcade-style space shooter built in Unity where the player fights enemies, avoids meteor hazards, and survives as long as possible while earning points.

---

## Screen Shots
<img width="326" height="537" alt="image" src="https://github.com/user-attachments/assets/51f33fe8-a349-4952-b515-fde82b92d819" />
<img width="331" height="547" alt="image" src="https://github.com/user-attachments/assets/672edd9f-7f31-4689-8b33-512b00270988" />
<img width="333" height="540" alt="image" src="https://github.com/user-attachments/assets/284c0eca-841a-4d62-aae6-91086f3df3a5" />
<img width="343" height="553" alt="image" src="https://github.com/user-attachments/assets/14e46f4a-0979-4f76-926d-80616c68076e" />




## Features

- Player movement and shooting
- Enemy spawning from both sides of the screen
- Enemy bullets that damage the player
- Meteor hazards that spawn and move across the map
- Player health system with UI heart icons
- Score system for destroying enemies
- Explosion sound effects for:
  - Enemy destruction
  - Player death
  - Meteor collision
- Game Over system with restart option
- Press R to restart instantly
- Full gameplay loop

---

## Controls

| Action        | Key / Input |
|--------------|-------------|
| Move Player   | Arrow Keys / WASD |
| Shoot         | Left Mouse Key |
| Restart Game  | R (after Game Over) |

---

## Gameplay Loop

1. Player spawns with limited health
2. Enemies spawn from the sides and move across the screen
3. Enemy bullets damage the player
4. Meteors spawn and move downward across the screen
5. Player destroys enemies to gain score
6. Game ends when health reaches zero or meteor hits player
7. Press R to restart instantly

---

## Systems Overview

### Player System
- Movement using Rigidbody2D or transform controls
- Shooting projectile bullets
- Collision detection with enemies, bullets, and meteors

### Enemy System
- Spawns from left or right side
- Moves across the screen
- Shoots bullets at intervals
- Plays explosion sound when destroyed

### Meteor System
- Spawns from upper screen area
- Moves downward
- Destroys player on contact
- Triggers explosion sound

### Health System
- Player starts with limited lives (3)
- UI hearts (ships) disappear when hit
- Game over when health reaches zero

### Score System
- Score increases when enemies are destroyed (100 points)
- Displayed using TextMeshPro UI

### Audio System
- Explosion sound for enemy destruction
- Explosion sound for player death
- Explosion sound for meteor collision

---

## UI

- Score displayed at top of screen
- Health displayed using heart icons
- Game Over text appears on death
- Restart prompt shown after game over

---

## Game Over System

When the player dies:
- Game freezes (Time.timeScale = 0)
- Explosion sound plays
- Game Over message appears
- Player can press R to restart

---

## Built With

- Unity Engine (2D)
- C#
- TextMeshPro UI
- Unity Input System (or legacy input)

---

## How to Run

1. Open project in Unity Hub
2. Open the main scene
3. Press Play in the Unity Editor
4. Survive as long as possible

---

## Scripts
- Bullet.cs - player's bullet, audio for bullet, contact with enemy and adds score
- Enemy.cs - enemy movements patterns, and shooting patterns
- EnemyBullet.cs - enemy's bullet towards player and destroys player
- EnemySpawner.cs - where enemy's can spawn and how often
- HealthManager.cs - more of game manager, health status of player, players lives icons, plays death sound if player is killed, restarts game with R key
- Meteor.cs - destroys player on contact, plays meteor collsion sound, how fast the meteors fall
- MeteorSpawner.cs - rate of meteors spawn in game and where in game
- PlayerController.cs - players start point, fire rate, shooting sound
- ScoreManager.cs - updates score

---
## Notes

- Ensure all prefabs (Enemy, Bullet, Meteor) are assigned correctly in the Inspector
- Tags must be set correctly:
  - Player → Player
  - Enemy → Enemy
  - Bullet → Bullet
- Audio clips must be assigned in their respective scripts

 ## Author
 - Adam Lee
 - This project uses video instructions from Module 3 in COMP5970, Game Development, Dr. Abhishek Jariwala

## Assets
- This project uses assets from the Kenney Space Shooter extension and sci-fi sounds pack.
- Kenney Assets: https://kenney.nl/assets/space-shooter-extension
- Audio files: https://kenney.nl/assets/sci-fi-sounds

