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
