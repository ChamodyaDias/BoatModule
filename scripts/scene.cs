function createScene()
{
    // Destroy the scene if it already exists.
    if ( isObject(myScene) )
        destroyScene();
    
    // Create the scene.
    new Scene(myScene);
    //Enable the debug visualization for "collision", "position" and "aabb"
    myScene.setDebugOn("collision", "position", "aabb");
    
}

function destroyScene()
{
    // Finish if no scene available.
    if ( !isObject(myScene) )
        return;

    // Delete the scene.
    myScene.delete();
}