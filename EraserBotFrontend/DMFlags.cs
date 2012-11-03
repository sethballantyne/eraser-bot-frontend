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

namespace EraserBotFrontend
{
    /// <summary>
    /// Bit flags that describe the properties of a Quake II DM Session. Most of the 
    /// flags in DMFlags are not used by EBF, but are present anyway for
    /// completeness.
    /// </summary>
    [FlagsAttribute]
    enum DMFlags
    {
        NoHealth  = 1,
        NoPowerups = 2,
        WeaponsStay = 4,
        NoFallingDamage = 8,
        InstantPowerups = 16,
        SameMap = 32,
        TeamsBySkin = 64,
        TeamsByModel = 128,
        NoFriendlyFire = 256,
        SpawnFarthest = 512,
        ForceRespawn = 1024,
        NoArmour = 2048,
        AllowExit = 4096,
        InfiniteAmmo = 8192,
        QuadDrop = 16384,
        FixedFOV = 32768,
        CTFForcedJoin = 131072,
        ArmourProtect = 262144,
        CTFNoTechPowerups = 524288
    }
}