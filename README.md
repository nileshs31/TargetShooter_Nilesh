# TargetShooter_Nilesh
A simple game with a playable character that shoots and everything is visible on Mini map display

Code done using SOLID Principles with an event-driven system

Design patterns used are Singleton, Observer Pattern, Factory Pattern

## Project Overview
This project is a simple "Target Shooter" game where a player can shoot projectiles at targets. The game includes:
- A playable character that can shoot using a UI button or space bar.
- A mini-map that displays an overhead view of the scene using a RenderTexture.
- A scoring system that updates when targets are hit.

## Setup Instructions
1. Open the project in Unity.
2. Open the `2_GameScene` found in the Scenes folder.
3. Ensure that the following components are assigned in the Inspector:
   - `Shooter` component references for the projectile prefab and spawn point.
   - `MiniMapController` references for the RawImage and overhead camera.
   - `TargetFactory` references for the target prefab.
4. Press Play to run the game.

## Design Patterns Used
- **Singleton:** `ScoreManager` provides a global point of access to the score.
- **Pub-Sub (Observer):** `EventBus` decouples the event publisher (`Target`) and subscriber (`ScoreManager`).
- **Factory:** `TargetFactory` is used to dynamically generate targets at runtime.

## Assumptions
- The projectile and target prefabs are set up with appropriate colliders and (if needed) Rigidbody components.
- The UI button for shooting is correctly wired to the `Shooter.Shoot()` method.
- The overhead camera is positioned to capture a top-down view of the game scene.

## Video Demo
https://drive.google.com/file/d/1uVo3A4ZyGIwh1TpAnGuUG-DVbLSHg7zs/view?usp=drive_link
