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
    %MainPlane.Size = "30 20";
    
    // Set to the furthest MainPlane layer.
    %MainPlane.SceneLayer = 1;
    
    // Sets the image to use for our MainPlane
    %MainPlane.Animation = "BoatModule:PlaneAnim";
  
    // Create border collisions.
    // %MainPlane.createEdgeCollisionShape( -50, -37.5, -50, 37.5 );
    // %MainPlane.createEdgeCollisionShape( 50, -37.5, 50, 37.5 );
    // %MainPlane.createEdgeCollisionShape( -50, 37.5, 50, 37.5 );
    // %MainPlane.createEdgeCollisionShape( -50, -34.5, 50, -34.5 );   
              
    // Add the sprite to the scene.
    SandboxScene.add( %MainPlane );  
    return %MainPlane;
}

