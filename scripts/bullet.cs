function createBullet(%position,%speed)
{
   // Create the sprite.
    %Bullet = new Sprite(Bullet);
    
    // Set the sprite as "static" so it is not affected by gravity.
    %Bullet.setBodyType( dynamic );
    %Bullet.Image="BoatModule:Bullet";

    // Set the object's center to coordinates 0 0 which corresponds to the center of the Scene
    // Remember that our camera is set to point to coordinates 0 0 as well

    %Bullet.Position = %position;

    // Set the object's size. Notice that this corresponds to the size of our camera, which was created in
    // scenewindow.cs. The MainPlane will thus cover the entirety of our scenewindow.
    %Bullet.Size = "5 5";
    
    // Set to the furthest MainPlane layer.
    %Bullet.SceneLayer = 1;

    %Bullet.createPolygonBoxCollisionShape();
    %Bullet.setCollisionGroups(20);
  
    // Create border collisions.
    // %MainPlane.createEdgeCollisionShape( -50, -37.5, -50, 37.5 );
    // %MainPlane.createEdgeCollisionShape( 50, -37.5, 50, 37.5 );
    // %MainPlane.createEdgeCollisionShape( -50, 37.5, 50, 37.5 );
    // %MainPlane.createEdgeCollisionShape( -50, -34.5, 50, -34.5 );   
              
    // Add the sprite to the scene.
    %Bullet.setCollisionCallback( true );
    SandboxScene.add( %Bullet );  

    %Bullet.setLinearVelocityX(%speed);
    return %Bullet;
}

$collisionCount=0;

function Bullet::onCollision(%this, %sceneobject, %collisiondetails)
{
  echo("bullet collided on asteroid");
    if(%sceneobject.getSceneGroup() == 20){
    $collisionCount+=1;

    if(%sceneobject.getSize() >12 && $collisionCount >4){
      $collisionCount=0;

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
    
      $NumScore += 1; 
      createAsteroids(1);
    }
    else if(%sceneobject.getSize() >6 && $collisionCount >2){
      $collisionCount=0;

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
      $NumScore += 1; 
      createAsteroids(1);
    }

    else if(%sceneobject.getSize() >0 && $collisionCount >0){
      $collisionCount=0;

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
      $NumScore += 1; 
      createAsteroids(1);
    }
    // ParticlePlayer is also derived from SceneObject, we add it just like we've added all the other
    //objects so far

      %this.safedelete();
    
    //We create a new asteroid just like we did at the start of the game!
    //createAsteroids(1); 
    $Score.setText($NumScore);
  }

}


