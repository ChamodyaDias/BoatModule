function createSky()
{
   // Create the sprite.
    %Sky = new Sprite(PlayerShip);
    
    // Set the sprite as "static" so it is not affected by gravity.
    %Sky.setBodyType( dynamic );

    // Set the object's center to coordinates 0 0 which corresponds to the center of the Scene
    // Remember that our camera is set to point to coordinates 0 0 as well

    %Sky.Position = "0 0";

    // Set the object's size. Notice that this corresponds to the size of our camera, which was created in
    // scenewindow.cs. The Sky will thus cover the entirety of our scenewindow.
    %Sky.Size = "100 75";
    
    // Set to the furthest Sky layer.
    %Sky.SceneLayer = 31;
    
    // Sets the image to use for our Sky
    %Sky.Image = "BoatModule:Sky";
  
    // Create border collisions.
    // %Sky.createEdgeCollisionShape( -50, -37.5, -50, 37.5 );
    // %Sky.createEdgeCollisionShape( 50, -37.5, 50, 37.5 );
    // %Sky.createEdgeCollisionShape( -50, 37.5, 50, 37.5 );
    // %Sky.createEdgeCollisionShape( -50, -34.5, 50, -34.5 );   
              
    // Add the sprite to the scene.
    SandboxScene.add( %Sky );    
}