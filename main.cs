//-----------------------------------------------------------------------------
function BoatModule::create( %this )
{
    // exec("./scripts/scenewindow.cs");
    // exec("./scripts/scene.cs");
    exec("./scripts/mainplane.cs");
    exec("./scripts/ocean.cs");
    exec("./scripts/sky.cs");
    exec("./scripts/mainScroller.cs");
    exec("./scripts/ButtonBehavior.cs");
    exec("./scripts/MusicBehavior.cs");

    echo("Hello World!");

    // createSceneWindow();
    // createScene();
    // mySceneWindow.setScene(SandboxScene);
    // SandboxScene.setDebugOn("collision", "position", "aabb");
    // Set the scene gravity.
    SandboxScene.setGravity(0, -9.8);


    BoatModule.MainPlane = createMainPlane();
    BoatModule.isTouchDown = false;

    // Setup default values.
    BoatModule.Music = "BoatModule:titleMusic";
    %music = alxPlay("BoatModule:PlaneAudio");

    %play = TamlRead("./objects/PlayButton.taml");
    SandboxScene.add(%play);

     // Turn on input events for scene objects.
    SandboxWindow.setUseObjectInputEvents(true);

	createBackground();   
    createFarScroller();
    createNear1Scroller();
    createNear2Scroller();
    createNear3Scroller();
    createNear4Scroller();
    createNear5Scroller();
	createGroundScroller();
    createFarSky1Scroller();
    createFarSky2Scroller();
    // createOcean();
    // createSky();
}

function BoatModule::destroy( %this )
{
    alxStopAll();
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