//-----------------------------------------------------------------------------
function BoatModule::create( %this )
{
    // exec("./scripts/scenewindow.cs");
    // exec("./scripts/scene.cs");
    exec("./scripts/mainplane.cs");
    exec("./scripts/ocean.cs");
    exec("./scripts/sky.cs");
    exec("./scripts/mainScroller.cs");

    echo("Hello World!");

    // createSceneWindow();
    // createScene();
    // mySceneWindow.setScene(SandboxScene);
    SandboxScene.setDebugOn("collision", "position", "aabb");
    // Set the scene gravity.
    SandboxScene.setGravity(0, -9.8);


    BoatModule.MainPlane = createMainPlane();
    BoatModule.isTouchDown = false;

    BoatModule.Music = "BoatModule:PlaneAudio";

    createBackground();
    createFarScroller();
    createNearScroller();
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
    BoatModule.LiftUpPlane(%this);
}

function BoatModule::onTouchUp(%this, %touchID, %worldPosition)
{
    echo("click released");
    BoatModule.StopLiftUpPlane(%this);
}


function BoatModule::LiftUpPlane(%this)
{
    BoatModule.MainPlane.setLinearVelocity(0, 10);
     %this.thrustschedule = %this.schedule(100, LiftUpPlane);
}

function BoatModule::StopLiftUpPlane(%this)
{
    BoatModule.MainPlane.setLinearDamping(0.8);
    cancel(%this.thrustschedule);
}