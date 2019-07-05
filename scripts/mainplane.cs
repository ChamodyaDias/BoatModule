function createMainPlane()
{
   // Create the sprite.
    %MainPlane = new Sprite(PlayerShip);
    
    // Set the sprite as "static" so it is not affected by gravity.
    %MainPlane.setBodyType( dynamic );

    // Set the object's center to coordinates 0 0 which corresponds to the center of the Scene
    // Remember that our camera is set to point to coordinates 0 0 as well

    %MainPlane.Position = "0 0";

    // Set the object's size. Notice that this corresponds to the size of our camera, which was created in
    // scenewindow.cs. The MainPlane will thus cover the entirety of our scenewindow.
    %MainPlane.Size = "15 10";
    
    // Set to the furthest MainPlane layer.
    %MainPlane.SceneLayer = 1;
    
    // Sets the image to use for our MainPlane
    %MainPlane.Animation = "BoatModule:PlaneAnim";

    %MainPlane.createPolygonBoxCollisionShape();
  
    // Create border collisions.
    // %MainPlane.createEdgeCollisionShape( -50, -37.5, -50, 37.5 );
    // %MainPlane.createEdgeCollisionShape( 50, -37.5, 50, 37.5 );
    // %MainPlane.createEdgeCollisionShape( -50, 37.5, 50, 37.5 );
    // %MainPlane.createEdgeCollisionShape( -50, -34.5, 50, -34.5 );   
              
    // Add the sprite to the scene.
    %MainPlane.setCollisionCallback( true );
    SandboxScene.add( %MainPlane );  
    return %MainPlane;
}

function PlayerShip::onCollision(%this, %sceneobject, %collisiondetails)
{
  echo("collided");
    if(%sceneobject.getSceneGroup() == 20)
  {
    // ParticlePlayer is also derived from SceneObject, we add it just like we've added all the other
    //objects so far
    %explosion = new ParticlePlayer();

    //We load the particle asset from our ToyAssets module
    %explosion.Particle = "BoatModule:impactExplosion";

    //We set the Particle Player's position to %Sceneobject's position
    %explosion.setPosition(%sceneobject.getPosition());

    //This Scales the particles to twice their original size
    %explosion.setSizeScale(2);

    //When we add a Particle Effect to the Scene, it automatically plays
    SandboxScene.add(%explosion);

    //We delete the asteroid
    %sceneobject.safedelete();
    
    //We create a new asteroid just like we did at the start of the game!
  }

}