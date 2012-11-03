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
using EraserBotFrontend.Properties;
using System.Configuration;

namespace EraserBotFrontend.Paths
{
    static class Quake2Paths
    {
        /// <summary>
        /// Directory containing the Quake2 game. The path is retrieved from App.config,
        /// so when EBF is first installed, this will be an empty string. Setting the path
        /// will automatically save the path to app.config
        /// </summary>
        public static string Root
        {
            get
            {
                return Settings.Default.Quake2Path;
            }
            set
            {
                Settings.Default.Quake2Path = value;
                Settings.Default.Save();
            }
        }

        /// <summary>
        /// Path to the Quake2 application. A default installation of Quake 2 will point
        /// to C:/quake2/quake2.exe
        /// </summary>
        public static string Quake2Exe
        {
            get
            {
                return Root + "\\quake2.exe";
            }
        }

        /// <summary>
        /// Directory containing all the game related data files such as *.paks, directories
        /// for player models and custom maps. Typically C://quake2/baseq2/
        /// </summary>
        public static string BaseQ2
        {
            get
            {
                return Root + "//baseq2//";
            }
        }

        /// <summary>
        /// Directory containing the player models, typically C://quake2/baseq2/players
        /// </summary>
        public static string Player
        {
            get
            {
                return BaseQ2 + "//players//";
            }
        }
    }
}
