function createAsteroids(%num)
{
   
   for(%i=0;%i<%num;%i++)
   {
   // Create the sprite.
    %asteroid = new Sprite(Aster);

    %asteroid.setBodyType( kinematic );
       
    // Set the position.
    %asteroid.Position = "80" SPC getRandom(-30,30);

    // Set the size.  
    %randomsize = getRandom(5,15);
    %asteroid.Size = %randomsize;      

    
    // Set to the frontmost layer.
    %asteroid.SceneLayer = 1;

    //Sets the collision shape to a circle with a radius of 1.5 units
    %asteroid.createCircleCollisionShape( (%randomsize*0.85) / 2);

    //This function determines how bouncy our asteroids will be if collisions occur
    //values between 0.0 and 1.0 should be used in most situations
    %asteroid.setDefaultRestitution(getRandom(0.5,1.1));

    //This sets the horizontal speed of our Asteroids between 15 and 35 towards the right side of the screen
    //Negative values would send them to the left instead
    %asteroid.setLinearVelocity(getRandom(-5,-15),0);

    //This will make the Asteroids rotate automatically
    %asteroid.setAngularVelocity(getRandom(5,25));

    //Here we assign all created Asteroids to SceneGroup 20. More on this in Chapter 11.
    %asteroid.SceneGroup = 20;

    %asteroid.Image = "BoatModule:Asteroid";

   //You will notice that the asset file for ToyAssets:Asteroids defines 4 different images
   //in one single file. setImageFrame chooses from one of these images to add variety.
    %asteroid.setImageFrame(getRandom(0,3));
    // Add the sprite to the scene.
    SandboxScene.add( %asteroid );  
   }
   %asteroid.schedule(5000, createNew); 
  
}

function Aster::createNew(){
   for(%i=0;%i<2;%i++)
   {
   // Create the sprite.
    %asteroid = new Sprite(Aster);

    %asteroid.setBodyType( kinematic );
       
    // Set the position.
    %asteroid.Position = "80" SPC getRandom(-30,30);

    // Set the size.  
    %randomsize = getRandom(5,10);
    %asteroid.Size = %randomsize;      

    
    // Set to the frontmost layer.
    %asteroid.SceneLayer = 1;

    //Sets the collision shape to a circle with a radius of 1.5 units
    %asteroid.createCircleCollisionShape( (%randomsize*0.85) / 2);

    //This function determines how bouncy our asteroids will be if collisions occur
    //values between 0.0 and 1.0 should be used in most situations
    %asteroid.setDefaultRestitution(getRandom(0.5,1.1));

    //This sets the horizontal speed of our Asteroids between 15 and 35 towards the right side of the screen
    //Negative values would send them to the left instead
    %asteroid.setLinearVelocity(getRandom(-5,-15),0);

    //This will make the Asteroids rotate automatically
    %asteroid.setAngularVelocity(getRandom(5,25));

    //Here we assign all created Asteroids to SceneGroup 20. More on this in Chapter 11.
    %asteroid.SceneGroup = 20;

    %asteroid.Image = "BoatModule:Asteroid";

   //You will notice that the asset file for ToyAssets:Asteroids defines 4 different images
   //in one single file. setImageFrame chooses from one of these images to add variety.
    %asteroid.setImageFrame(getRandom(0,3));
    // Add the sprite to the scene.
    SandboxScene.add( %asteroid );  
   }
}