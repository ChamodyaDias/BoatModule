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
    exec("./scripts/asteroids.cs");

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
    createAsteroids(4);

    schedule(100,0,createAsteroids,2);
    // createOcean();
    // createSky();
        //Title
    $Score = new TextSprite()
     {
    Scene = SandboxScene;
    Font = "ToyAssets:TrajanProFont";
    FontSize = 6.5;
    Text = "0";
    Position = "0 30";
    Size = "90 7";
    OverflowModeX = "visible";
    TextAlignment = "center";
    BlendColor = "0.2 0.5 1 1";
    BodyType = static;
};

    $NumScore = 0;

    BoatModule.Init_controls();  
}

function BoatModule::destroy( %this )
{
    alxStopAll();
    // destroySceneWindow();
}

function BoatModule::onTouchDown(%this, %touchID, %worldPosition)
{
    // createAsteroids(2);
    echo("clicked!");
    BoatModule.createBullet();
    // BoatModule.LiftUpPlane(%this);
}

function BoatModule::onTouchUp(%this, %touchID, %worldPosition)
{
    // echo("click released");
    // BoatModule.StopLiftUpPlane(%this);
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

function BoatModule::Init_controls(%this)
{
    //Create our new ActionMap
    new ActionMap(shipcontrols);

    // Press "a" to execute "PlayerShip::turnleft();"
    // Release "a" to execute "PlayerShip::stopturn();"
    shipcontrols.bindCmd(keyboard, "w", "BoatModule.LiftUpPlane();", "BoatModule.StopLiftUpPlane();");
    shipcontrols.bindCmd(keyboard, "a", "BoatModule.createBullet();", "BoatModule.createBullet();");

    //Push our ActionMap on top of the stack
    shipcontrols.push();
}

function BoatModule::createBullet(%this)
{
    exec("./scripts/Bullet.cs");
    %bulletPos = BoatModule.MainPlane.getPosition();
    %bulletPos.x =%bulletPos.x + 10;
    createBullet(%bulletPos, 100);
}

