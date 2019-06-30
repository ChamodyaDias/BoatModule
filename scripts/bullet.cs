function createBullet(%position,%speed)
{
   // Create the sprite.
    %Bullet = new Sprite();
    
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
  
    // Create border collisions.
    // %MainPlane.createEdgeCollisionShape( -50, -37.5, -50, 37.5 );
    // %MainPlane.createEdgeCollisionShape( 50, -37.5, 50, 37.5 );
    // %MainPlane.createEdgeCollisionShape( -50, 37.5, 50, 37.5 );
    // %MainPlane.createEdgeCollisionShape( -50, -34.5, 50, -34.5 );   
              
    // Add the sprite to the scene.
    SandboxScene.add( %Bullet );  

    %Bullet.setLinearVelocityX(%speed);
    return %Bullet;
}


