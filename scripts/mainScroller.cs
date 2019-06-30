//-----------------------------------------------------------------------------
// Copyright (c) 2013 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

function create( %this )
{
    // Reset the toy.
    ScrollerToy.reset();
}

//-----------------------------------------------------------------------------

function destroy( %this )
{
}

//-----------------------------------------------------------------------------

function reset( %this )
{
    // Clear the scene.
    SandboxScene.clear();
    
    // Create some scrollers.
    %this.createBackground();   
    %this.createFarScroller();
    %this.createNear1Scroller();
    %this.createNear2Scroller();
    %this.createNear3Scroller();
    %this.createNear4Scroller();
    %this.createNear5Scroller();
    %this.createGroundScroller();
    %this.createFarSky1Scroller();
    %this.createFarSky2Scroller();
    
}

//-----------------------------------------------------------------------------

function createBackground()
{    
    // Create the sprite.
    %object = new Sprite();

    %object.setBodyType( static );
       
    // Always try to configure a scene-object prior to adding it to a scene for best performance.

    // Set the position.
    %object.Position = "0 0";

    // Set the size.        
    %object.Size = "100 100";
    
    // Set to the furthest background layer.
    %object.SceneLayer = 31;
    
    // Set an image.
    %object.Image = "BoatModule:jungleSky";
            
    // Add the sprite to the scene.
    SandboxScene.add( %object );    
}

//-----------------------------------------------------------------------------

function createFarScroller()
{    
    // Create the scroller.
    %object = new Scroller();
    
    // Note this scroller for the touch controls.
    ScrollerToy.FarScroller = %object;
    // Always try to configure a scene-object prior to adding it to a scene for best performance.

    // Set the position.
    %object.Position = "0 0";

    // Set the size.        
    %object.Size = "100 100";

    // Set to the furthest background layer.
    %object.SceneLayer = 30;
    
    // Set the scroller to use a static image.
    %object.Image = "BoatModule:TreeBackground6";
    
    // We don't really need to do this as the frame is set to zero by default.
    %object.Frame = 0;

    // Set the scroller moving in the X axis.
    %object.ScrollX = 1;
    
    // Set the scroller to only show half of the static image in the X axis.
    %object.RepeatX = 0.5;
        
    // Add the sprite to the scene.
    SandboxScene.add( %object );    
}

//-----------------------------------------------------------------------------

function createFarSky1Scroller()
{    
    // Create the scroller.
    %object = new Scroller();
    
    // Note this scroller for the touch controls.
    ScrollerToy.FarScroller = %object;
    // Always try to configure a scene-object prior to adding it to a scene for best performance.

    // Set the position.
    %object.Position = "0 0";

    // Set the size.        
    %object.Size = "100 100";

    // Set to the furthest background layer.
    %object.SceneLayer = 30;
    
    // Set the scroller to use a static image.
    %object.Image = "BoatModule:sky1";
    
    // We don't really need to do this as the frame is set to zero by default.
    %object.Frame = 0;

    // Set the scroller moving in the X axis.
    %object.ScrollX = 2;
    
    // Set the scroller to only show half of the static image in the X axis.
    %object.RepeatX = 0.5;
        
    // Add the sprite to the scene.
    SandboxScene.add( %object );    
}

//-----------------------------------------------------------------------------

function createFarSky2Scroller()
{    
    // Create the scroller.
    %object = new Scroller();
    
    // Note this scroller for the touch controls.
    ScrollerToy.FarScroller = %object;
    // Always try to configure a scene-object prior to adding it to a scene for best performance.

    // Set the position.
    %object.Position = "0 0";

    // Set the size.        
    %object.Size = "100 100";

    // Set to the furthest background layer.
    %object.SceneLayer = 31;
    
    // Set the scroller to use a static image.
    %object.Image = "BoatModule:sky2";
    
    // We don't really need to do this as the frame is set to zero by default.
    %object.Frame = 0;

    // Set the scroller moving in the X axis.
    %object.ScrollX = 1;
    
    // Set the scroller to only show half of the static image in the X axis.
    %object.RepeatX = 0.5;
        
    // Add the sprite to the scene.
    SandboxScene.add( %object );    
}

//-----------------------------------------------------------------------------

function createNear1Scroller()
{    
    // Create the scroller.
    %object = new Scroller();
    // Note this scroller for the touch controls.
    ScrollerToy.NearScroller = %object;    
    
    // Always try to configure a scene-object prior to adding it to a scene for best performance.

    // Set the position.
    %object.Position = "0 -5";

    // Set the size.        
    %object.Size = "100 100";
    
    // Set to the furthest background layer.
    %object.SceneLayer = 25;
    
    // Set the scroller to use a static image.
    %object.Image = "BoatModule:TreeBackground1";
    
    // We don't really need to do this as the frame is set to zero by default.
    %object.Frame = 0;
    
    // Set the scroller moving in the X axis.
    %object.ScrollX = 11;

    // Set the scroller to only show half of the static image in the X axis.
    %object.RepeatX = 0.5;
        
    // Add the sprite to the scene.
    SandboxScene.add( %object );    
}


//-----------------------------------------------------------------------------

function createNear2Scroller()
{    
    // Create the scroller.
    %object = new Scroller();
    // Note this scroller for the touch controls.
    ScrollerToy.NearScroller = %object;    
    
    // Always try to configure a scene-object prior to adding it to a scene for best performance.

    // Set the position.
    %object.Position = "0 0";

    // Set the size.        
    %object.Size = "100 100";
    
    // Set to the furthest background layer.
    %object.SceneLayer = 26;
    
    // Set the scroller to use a static image.
    %object.Image = "BoatModule:TreeBackground2";
    
    // We don't really need to do this as the frame is set to zero by default.
    %object.Frame = 0;
    
    // Set the scroller moving in the X axis.
    %object.ScrollX = 9;

    // Set the scroller to only show half of the static image in the X axis.
    %object.RepeatX = 0.5;
        
    // Add the sprite to the scene.
    SandboxScene.add( %object );    
}


//-----------------------------------------------------------------------------

function createNear3Scroller()
{    
    // Create the scroller.
    %object = new Scroller();
    // Note this scroller for the touch controls.
    ScrollerToy.NearScroller = %object;    
    
    // Always try to configure a scene-object prior to adding it to a scene for best performance.

    // Set the position.
    %object.Position = "0 0";

    // Set the size.        
    %object.Size = "100 100";
    
    // Set to the furthest background layer.
    %object.SceneLayer = 27;
    
    // Set the scroller to use a static image.
    %object.Image = "BoatModule:TreeBackground3";
    
    // We don't really need to do this as the frame is set to zero by default.
    %object.Frame = 0;
    
    // Set the scroller moving in the X axis.
    %object.ScrollX = 7;

    // Set the scroller to only show half of the static image in the X axis.
    %object.RepeatX = 0.5;
        
    // Add the sprite to the scene.
    SandboxScene.add( %object );    
}


//-----------------------------------------------------------------------------

function createNear4Scroller()
{    
    // Create the scroller.
    %object = new Scroller();
    // Note this scroller for the touch controls.
    ScrollerToy.NearScroller = %object;    
    
    // Always try to configure a scene-object prior to adding it to a scene for best performance.

    // Set the position.
    %object.Position = "0 0";

    // Set the size.        
    %object.Size = "100 100";
    
    // Set to the furthest background layer.
    %object.SceneLayer = 28;
    
    // Set the scroller to use a static image.
    %object.Image = "BoatModule:TreeBackground4";
    
    // We don't really need to do this as the frame is set to zero by default.
    %object.Frame = 0;
    
    // Set the scroller moving in the X axis.
    %object.ScrollX = 5;

    // Set the scroller to only show half of the static image in the X axis.
    %object.RepeatX = 0.5;
        
    // Add the sprite to the scene.
    SandboxScene.add( %object );    
}


//-----------------------------------------------------------------------------

function createNear5Scroller()
{    
    // Create the scroller.
    %object = new Scroller();
    // Note this scroller for the touch controls.
    ScrollerToy.NearScroller = %object;    
    
    // Always try to configure a scene-object prior to adding it to a scene for best performance.

    // Set the position.
    %object.Position = "0 0";

    // Set the size.        
    %object.Size = "100 100";
    
    // Set to the furthest background layer.
    %object.SceneLayer = 29;
    
    // Set the scroller to use a static image.
    %object.Image = "BoatModule:TreeBackground5";
    
    // We don't really need to do this as the frame is set to zero by default.
    %object.Frame = 0;
    
    // Set the scroller moving in the X axis.
    %object.ScrollX = 3;

    // Set the scroller to only show half of the static image in the X axis.
    %object.RepeatX = 0.5;
        
    // Add the sprite to the scene.
    SandboxScene.add( %object );    
}


//-----------------------------------------------------------------------------

function createGroundScroller()
{    
    // Create the scroller.
    %object = new Scroller();
    // Note this scroller for the touch controls.
    ScrollerToy.NearScroller = %object;    
    
    // Always try to configure a scene-object prior to adding it to a scene for best performance.

    // Set the position.
    %object.Position = "0 5";

    // Set the size.        
    %object.Size = "100 100";
    
    // Set to the furthest background layer.
    %object.SceneLayer = 28;
    
    // Set the scroller to use a static image.
    %object.Image = "BoatModule:ground";
    
    // We don't really need to do this as the frame is set to zero by default.
    %object.Frame = 0;
    
    // Set the scroller moving in the X axis.
    %object.ScrollX = 13;

    // Set the scroller to only show half of the static image in the X axis.
    %object.RepeatX = 0.5;
        
    // Add the sprite to the scene.
    SandboxScene.add( %object );    
}
