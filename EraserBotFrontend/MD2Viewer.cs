/*
*Copyright (c) 2011 Seth Ballantyne <seth.ballantyne@gmail.com>
*
*Permission is hereby granted, free of charge, to any person obtaining a copy
*of this software and associated documentation files (the "Software"), to deal
*in the Software without restriction, including without limitation the rights
*to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
*copies of the Software, and to permit persons to whom the Software is
*furnished to do so, subject to the following conditions:
*
*The above copyright notice and this permission notice shall be included in
*all copies or substantial portions of the Software.
*
*THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
*IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
*FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
*AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
*LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
*OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
*THE SOFTWARE.
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using IrrlichtLime;
using IrrlichtLime.Core;
using IrrlichtLime.Video;
using IrrlichtLime.Scene;

namespace EraserBotFrontend
{
    /// <summary>
    /// Allows the rendering of skinned MD2 models to a specified control using 
    /// Irrlicht
    /// </summary>
    class MD2Viewer
    {
        // Control Irrlicht will render to
        Control renderingTo;

        IrrlichtDevice irrlichtDevice;
        SceneNode sceneNode = null;
        //ILightSceneNode light;
        Texture skinTexture = null;
        IrrlichtLime.Video.Color backgroundColour;
        string skin = null;
        string model = null;
        Vector3Df cameraPosition = new Vector3Df(35.0f, 0.0f, -25.0f);

        /// <summary>
        /// Initiates Irrlicht and prepares the scene for rendering
        /// </summary>
        /// <param name="renderTo">Control will display the model</param>
        public MD2Viewer(Control renderTo)
        {
            renderingTo = renderTo;

            
            Dimension2Di displayDimensions = new Dimension2Di(renderTo.ClientSize.Width,
                renderTo.ClientSize.Height);

            IrrlichtCreationParameters creationParams = new IrrlichtCreationParameters();
            creationParams.BitsPerPixel = 16;
            creationParams.DoubleBuffer = false;
            creationParams.DriverType = DriverType.Software;
            creationParams.WindowSize = new Dimension2Di(renderingTo.Width, renderingTo.Height);
            creationParams.WindowID = renderingTo.Handle;
            creationParams.Fullscreen = false;

            irrlichtDevice = IrrlichtDevice.CreateDevice(creationParams);

            ClearScene();

            backgroundColour = new Color(150, 150, 150, 0);
        }

        /// <summary>
        /// Draws the model. Not calling this results in the model not being visible...
        /// (no, really?!)
        /// </summary>
        public void Update()
        {
            irrlichtDevice.VideoDriver.BeginScene(true, true, backgroundColour);
            irrlichtDevice.SceneManager.DrawAll();
            irrlichtDevice.VideoDriver.EndScene();
        }

        /// <summary>
        /// Resets the display. This has to be called when as new model is loaded in,
        /// else your going to be rendering the model on top of the old one.
        /// </summary>
        private void ClearScene()
        {
            //Vector3D cameraPosition = new Vector3D(35, 0, -25);

            //irrlichtDevice.SceneManager.Clear();
            if (sceneNode != null)
            {
                sceneNode.Remove();
            }
            else
            {
                irrlichtDevice.SceneManager.AddCameraSceneNode(null, cameraPosition,
            new Vector3Df(), -1);
            }
            //irrlichtDevice.SceneManager.AddCameraSceneNode(null, cameraPosition,
            //new Vector3D(), -1);
        }

        /// <summary>
        /// Sets the skin to be attached to the model. You must call this after a call to
        /// the Model property, else it won't work. When loading a skin, you must pass
        /// the full path, not just the filename.
        /// </summary>
        public string Skin
        {
            set
            {
                //if (skinTexture != null)
                //{
                //    skinTexture.__dtor();
                //}

                skinTexture = irrlichtDevice.VideoDriver.GetTexture(value);
                sceneNode.SetMaterialTexture(0, skinTexture);
                
                sceneNode.SetMaterialFlag(MaterialFlag.Lighting, false);
                Update();

               
                skin = value;
            }
            get
            {
                return skin;
            }
        }

        /// <summary>
        /// Loads the specified model, or returns the path of the current model. When loading
        /// a new model, you must path the pass the absolute path, not just the filename.
        /// </summary>
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (sceneNode != null)
                {
                    sceneNode.Remove();
                }
                else
                {
                    irrlichtDevice.SceneManager.AddCameraSceneNode(null, cameraPosition,
                    new Vector3Df(), -1);
                }
                
                //ClearScene();
                sceneNode = irrlichtDevice.SceneManager.AddMeshSceneNode(
                    irrlichtDevice.SceneManager.GetMesh(value).GetMesh(0), null, 1);

                // excessive memory usage kludge.
                //animMesh.__dtor();
                //Update();
                
                model = value;
            }
        }
    }
}
