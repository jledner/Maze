# VR-Maze
 Find a hidden key to unlock a door and get to the end of the maze

My experience developing this project involved creating the following:
 - Creating the scene from prefabs from the SNAPS Prototype Pack
 - Used Progrids to make sure the scene was aligned
 - Setting up VR interactions by creating the XR origin
 - Creating Raycast interactions with the controllers
 - Defining interactors and interactables
 - Creating a teleportation area and teleportation provider
 - Creating a grab interaction using XR Direct Interaction
 - Enabling snap turns using the controllers
 - Defining the locomotion system
 - Using layer masks to define which interactors can interact with which interactables (i.e. left controller can teleport and right controller can grab)
 - Creating a Key using probuilder
 - Creating a mechanism to pick up the key and holding it as an attached transform 
 - Wrote custom scripts for Trigger Events (Unlocking the door showing the win message)

I had trouble getting set up to build this project to my Meta Quest from my Macbook Studio, but I overcame those issues by being very meticulous about making sure all the right project settings were set up. It took quite a few iterations just to get the project in full VR view, and another handful of iterations to get it to log each interaction to the console. Once I got it rolling though, it was awesome. I got tripped up at times about the different Layers on the gamobjects themselves compared to Layer Masks on the Interactors. It took a bit to realize that Unity made some changes to how these are managed and that those Layer objects are not the same. Overall, an awesome learning experience! First VR game in the books!
