function createMainBoat()
{
   // Create the sprite.
    %MainBoat = new Sprite(PlayerShip);
    
    // Set the sprite as "static" so it is not affected by gravity.
    %MainBoat.setBodyType( dynamic );

    // Set the object's center to coordinates 0 0 which corresponds to the center of the Scene
    // Remember that our camera is set to point to coordinates 0 0 as well

    %MainBoat.Position = "0 0";

    // Set the object's size. Notice that this corresponds to the size of our camera, which was created in
    // scenewindow.cs. The MainBoat will thus cover the entirety of our scenewindow.
    %MainBoat.Size = "30 20";
    
    // Set to the furthest MainBoat layer.
    %MainBoat.SceneLayer = 1;
    
    // Sets the image to use for our MainBoat
    %MainBoat.Image = "BoatModule:MainBoat";
  
    // Create border collisions.
    // %MainBoat.createEdgeCollisionShape( -50, -37.5, -50, 37.5 );
    // %MainBoat.createEdgeCollisionShape( 50, -37.5, 50, 37.5 );
    // %MainBoat.createEdgeCollisionShape( -50, 37.5, 50, 37.5 );
    // %MainBoat.createEdgeCollisionShape( -50, -34.5, 50, -34.5 );   
              
    // Add the sprite to the scene.
    SandboxScene.add( %MainBoat );    
}