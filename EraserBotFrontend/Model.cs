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

namespace EraserBotFrontend
{
    /// <summary>
    /// Represents an installed model and all its available skins. The Model class is only 
    /// used in conjunction with the mesh renderer.
    /// </summary>
    class Model
    {
        string modelName;
        List<string> skins = new List<string>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelName"></param>
        /// <param name="modelSkins"></param>
        public Model(string modelName, string[] modelSkins)
        {
            this.modelName = modelName;
            skins.AddRange(modelSkins);
        }

        /// <summary>
        /// Filename of the model, minus the file extension.
        /// </summary>
        public string Name
        {
            get { return modelName; }
            set { modelName = value; }
        }

        /// <summary>
        /// string array containing the names of all installed skins available for the model. 
        /// </summary>
        public string[] Skins
        {
            get { return skins.ToArray(); }
            set { skins.AddRange(value); }
        }
    }
}
