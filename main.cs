//-----------------------------------------------------------------------------
function BoatModule::create( %this )
{
    // exec("./scripts/scenewindow.cs");
    // exec("./scripts/scene.cs");
    exec("./scripts/mainplane.cs");
    exec("./scripts/ocean.cs");
    exec("./scripts/sky.cs");
    
    echo("Hello World!");

    // createSceneWindow();
    // createScene();
    // mySceneWindow.setScene(SandboxScene);
    SandboxScene.setDebugOn("collision", "position", "aabb");
    // Set the scene gravity.
    SandboxScene.setGravity( 0, -0.8 );


    BoatModule.MainPlane = createMainPlane();

    // createOcean();
    // createSky();
}

function BoatModule::destroy( %this )
{
    // destroySceneWindow();
}

function BoatModule::onTouchDown(%this, %touchID, %worldPosition)
{
    echo("clicked!");
    BoatModule.MainPlane.Position.y += "5";
}