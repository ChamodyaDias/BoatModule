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


    createMainPlane();
    // createOcean();
    // createSky();
}

function BoatModule::destroy( %this )
{
    // destroySceneWindow();
}