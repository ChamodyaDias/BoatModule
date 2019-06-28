function createOcean()
{
   // Create the sprite.
    %Ocean = new Sprite();
    
    // Set the sprite as "static" so it is not affected by gravity.
    %Ocean.setBodyType( static );

    // Set the object's center to coordinates 0 0 which corresponds to the center of the Scene
    // Remember that our camera is set to point to coordinates 0 0 as well

    %Ocean.Position = "0 0";

    // Set the object's size. Notice that this corresponds to the size of our camera, which was created in
    // scenewindow.cs. The Ocean will thus cover the entirety of our scenewindow.
    %Ocean.Size = "100 75";
    
    // Set to the furthest Ocean layer.
    %Ocean.SceneLayer = 31;
    
    // Sets the image to use for our Ocean
    %Ocean.Animation = "BoatModule:OceanAnim";
  
    // Create border collisions.
    // %Ocean.createEdgeCollisionShape( -50, -37.5, -50, 37.5 );
    // %Ocean.createEdgeCollisionShape( 50, -37.5, 50, 37.5 );
    // %Ocean.createEdgeCollisionShape( -50, 37.5, 50, 37.5 );
    // %Ocean.createEdgeCollisionShape( -50, -34.5, 50, -34.5 );   
              
    // Add the sprite to the scene.
    SandboxScene.add( %Ocean );    
}