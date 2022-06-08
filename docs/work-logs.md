# Dynamic Path Generation System for Continuous Walking in Finite Space using PragPal algorithm in VR
Kandarp Devmurari

## Week 0 [17 May 2022 - 21 May 2022]
### Tuesday
- Read the ‘Designing Limitless Path in Virtual Reality Environment’ and ‘Enhancing Configurable    Limitless Paths in Virtual Environments’ pdf papers. 
- Tried to setup VR environment settings in Unity
- Visualized a new approach to obtain parallel width boundaries around the central path in the PragPal algorithm while trying to eliminate the problem of narrow path width at turns and the problem of change(increase/decrease/skew) in path width at the last path segment due to the addition of new path segment at the front (after removing the end path segment)

### Wedenesday
- Made LATEX for the 3rd point of the task on 17th May
- Setup Unity editor version 2019.4.20f1 to run the existing project on Unity

### Thursday
- Cloned the PragPal project from github and ran it in Unity
- Tested the dynamic_path_boundary_generation script with my method

### Friday
- Made diagrams for my boundary generation method in draw.io
- Made a new LATEX using the above diagrams and added the issue with old method and issue solved by my method
- Found a small flaw in dynamic_path_boundary_generation script which was causing distorted/narrowed path at the end point. No need to keep pathWidthMultiplier as 1 for end point, keep the pathWidthMultiplier same as that for the intermediate points for the end point as well.


## Week 1 [23 May 2022 - 28 May 2022]
### Monday
- Found the conditions for valid path generations for acute and obtuse turn angles(beta), also found when the path expands and shrinks for an acute beta angle and the limit till which the path can shrink or expand.
- Made a sketch and layout of obstacles, game mechanism and scoring system for 3 different game ideas.
- Started working on making the wall layout in Unity for game idea 1.

### Tuesday
- Made 2 wall layouts of different colors(for game 1) in Unity, which will be used as walls for infinite path generation.

### Wednesday
- Made a scene using 2 walls, a capsule player and wrote the movement script for the player(and camera) to move on the 3 left, middle, right part of the path. Also added jump command for the player.   

### Thursday
- Wrote infinite tile generation script and 5 different random obstacle generation script in Unity and ran it.

### Friday
- Solved the problem of spawning jump obstacle in place of duck obstacle.
- Added colliders to the various obstacles.
- Solved the problem of player passing through some(left, right) obstacles and not stopping.
- Added 3 KeyDown functions, which allows the player to toggle between orangeLight and blueLight material, also toggles the wallType and skybox color(between orange and blue).

### Saturday
- Wrote OnColliderCollisionHit function to trigger collision with obstacles(forcefield, duck and jump) and OnTriggerEnter function to trigger what happens on entering Gates.
- GAME OVERS when a player collides with an obstacles or passes through a gate with different color.


## Week 2 [30 May 2022 - 4 June 2022]
### Monday 
- Made a turret(orange and blue) obstacle which shoots the player.

### Tuesday
- Made a Tron Legacy inspired disc weapon(along with disc shoot function that the player can use to shoot using left mouse click) which can be used to destroy the turrets of opposite color.

### Wednesday
- Made a character with run animation using Blender and Unity to replace the current capsule Player.

### Thursday
- Replaced the capsule Player with the Tron Player and added the run aniamtion using Animator component.
- Made some changes in the previous scripts attached to the capsule Player so that now it works with the Tron Player.
- Found the problem why the disc was shooting backwards.

### Friday
- Tried to setup the PragPal algorithm Unity project in Occulus


## Week 3 [6 June 2022 - 11 June 2022]
### Monday
- Wrote a script which changes the wall color instantly rather than spawning the new toggled wall color after sometime(kind of like dynamic rendering ****). Therefore, the environment now changes instanteneously giving a better gameplay/user experience.

### Tuesday
- Made the shooting disc script to work properly
- Added new constraints for path length for obtuse beta angles(i.e at corners) in my left and right point generation(for wall) enchancement code; because of these constraints the wall neither seems to go beyond the room boundaries nor traps the player at the corner(with the walls). 

### Wedenesday
- Added a GAMEOVER screen with Replay and Quit buttons in the game; and a START button. The game overs when player collides with a forcefield or passes a gate with wrong color or is hit by the turret bullet.
