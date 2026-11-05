- buttons, very basic. if collision (button) whatever gameobject transform or something.

- platforms -> collider 2D, effector -> Platform Effector 2D
Try on new tilemap w/ one platform

Camera:
on a script. U can use a coroutine for example.

Main inspirations:
	Level devil




-Static things: on tilemap.
Everything in its own tilemap (ex: spikes on their own).

Items and moving platforms shall not be in the tilemap because u can't manage them individually.

Who manages player collisions player itself or object collided with? Well It could depend.
Res: Doesn't really matter, can be the door with no problem.

Do I need a gamemanager to manage player death?

Empty GO_ collision, tag: pitofdeath (orsmth) on collisionenter -> player dies, wait for seconds before respawn.
