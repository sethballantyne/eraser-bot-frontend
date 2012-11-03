
/*Copyright (c) 2011 Seth Ballantyne <seth.ballantyne@gmail.com>
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
    /// Used to represent the properties of a single bot (computer controlled player)
    /// </summary>
    public class Bot
    {
        //--------------------------------------------------------------
        // Variables
        //--------------------------------------------------------------
        
        // Bots name as it appears in the player list
        string name;

        // specially formatted string containing the name of the model and skin
        // the bot is to use
        string modelAndSkin;

        // how accurate the bot is when firing. The value has to be within a range
        // of 1 (very poor) to 5 (very good)
        uint firingAccuracy;

        // How aggressive the bot is when attacking, 
        // again within a range of 1 (blouse) to 5 (extremely aggressive)
        uint aggressiveness;

        // Determines the strategy used by the bot when fighting. A low value
        // indicates the bot will stand still while shooting, high score indicates
        // the bot will jump, strafe etc. Value must be in a range of 1 - 5.
        uint combatSkills;

        // Which weapon the bot prefers to use. 
        // valid values are: 
        // 2 - Shotgun
        // 3 - Double barrel shotgun
        // 4 - machine gun
        // 5 - chain gun
        // 6 - grenage launcher
        // 7 - rocket launcher
        // 8 - Hyperblaster
        // 9 - Rail gun
        // 0 - BFG
        FavouriteWeapon favouriteWeapon;

        // determines whether the bot likes to hog the Quad damage. Valid values
        // are 1 (true) or 0 (false)
        bool quadFreak;

        // determines whether the bot camps. valid values are 1 (yes) or 0 (no)
        bool camper;

        // how much the bot lags, useful for simulating multiplayer sessions
        uint averagePing;

        //--------------------------------------------------------------
        // Constants
        //--------------------------------------------------------------

        // you really don't want to exceed or go below these ranges, so dont.
        const uint firingAccuracyMinValue = 1;
        const uint firingAccuracyMaxValue = 5;

        const uint aggressivenessMinValue = 1;
        const uint aggressivenessMaxValue = 5;

        const uint combatSkillsMinValue = 1;
        const uint combatSkillsMaxValue = 5;

        /// <summary>
        /// The no hassle way of creating an instance of Bot.
        /// </summary>
        /// <param name="name">the bots name as it will appear in-game</param>
        /// <param name="modelAndSkin">a formatted string containing the bots model and skin.
        /// values should be in the format model/skin, eg: male/howitzer</param>
        /// <param name="accuracy">how accurate the bot is when firing. Must be within a range
        /// of 1 to 5, 5 being the most accurate</param>
        /// <param name="aggressiveness">How aggressive the bot is when attacking. Must be within
        /// a range of 1 to 5, 5 being the most aggressive</param>
        /// <param name="combatSkills">Reflects the tactics used by the bot during combat. Must
        /// be within a range of 1 to 5, 5 being the most skilled.</param>
        /// <param name="favouriteWeapon">FavouriteWeapon enum describing the bots prefered
        /// weapon to use during combat. </param>
        /// <param name="quadFreak">boolean dictacting whether the bot will try to "hog" the 
        /// quad damage</param>
        /// <param name="camper">boolean value that decides whether the bot camps or not. True = camper,
        /// false = not a camper.</param>
        /// <param name="averagePing">the average network latency of the bot.Used for simulating
        /// lag, or the lack thereof.</param>
        public Bot(string name, string modelAndSkin, uint accuracy,
            uint aggressiveness, uint combatSkills, FavouriteWeapon favouriteWeapon,
            bool quadFreak, bool camper, uint averagePing)
        {
            this.name = name;
            this.modelAndSkin = modelAndSkin;
            this.aggressiveness = aggressiveness;
            this.combatSkills = combatSkills;
            this.favouriteWeapon = favouriteWeapon;
            this.quadFreak = quadFreak;
            this.camper = camper;
            this.averagePing = averagePing;
        }

        /// <summary>
        /// Gets or sets the bots name as it appears in the player list
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// Gets and sets a formatted string containing the bots model and skin name
        /// </summary>
        public string ModelAndSkin
        {
            get
            {
                return this.modelAndSkin;
            }
            set
            {
                this.modelAndSkin = value;
            }
        }

        /// <summary>
        /// Gets or sets the value indicating how accurate the bot is when
        /// firing a weapon. The value must be within 1 and 5; if an invalid value
        /// is passed, the value is set the nearest legal value.
        /// </summary>
        public uint FiringAccuracy
        {
            get
            {
                return this.firingAccuracy;
            }
            set
            {
                MakeWithinRange(firingAccuracyMinValue, firingAccuracyMaxValue,
                    ref value);

                this.firingAccuracy = value;
            }
        }
        /// <summary>
        /// Gets or sets the bots level of aggressiveness. Aggressiveness must be within
        /// a range of 1 - 5; if an invalid value is passed, the value is set
        /// to the nearest legal value.
        /// </summary>
        public uint Aggressiveness
        {
            get
            {
                return this.aggressiveness;
            }
            set
            {
                MakeWithinRange(aggressivenessMinValue, aggressivenessMaxValue,
                    ref value);

                this.aggressiveness = value;
            }
        }

        /// <summary>
        /// Gets or sets the bots combat skill. Combat skill reflects the tactics
        /// used by the bot when engaging another player - whether the bot jumps,
        /// strafes and moves around or just stands there shooting. A valid value
        /// is between 1 and 5. Any values below or above the accepted values
        /// are reset to their closest valid value.
        /// </summary>
        public uint CombatSkills
        {
            get
            {
                return this.combatSkills;
            }
            set
            {
                MakeWithinRange(combatSkillsMinValue, 
                    combatSkillsMaxValue, ref value);

                this.combatSkills = value;

            }
        }

        /// <summary>
        /// Gets or sets which weapon the bot prefers to use during combat. 
        /// </summary>
        public FavouriteWeapon FavouredWeapon
        {
            get
            {
                return this.favouriteWeapon;
            }
            set
            {
                this.favouriteWeapon = value;
            }
        }

        /// <summary>
        /// Determines whether or not the bot hovers around the Quad Damage during the 
        /// game.
        /// </summary>
        public bool IsQuadFreak
        {
            get
            {
                return this.quadFreak;
            }
            set
            {
                this.quadFreak = value;
            }
        }

        /// <summary>
        /// Determines whether or not the bot using camping as a tactic
        /// during the game.
        /// </summary>
        public bool IsCamper
        {
            get
            {
                return this.camper;
            }
            set
            {
                this.camper = value;
            }
        }

        /// <summary>
        /// Used to simulate the bots network latency. Higher the ping, 
        /// the less responsive and accurate it'll be and hence the easier to kill.
        /// </summary>
        public uint Ping
        {
            get
            {
                return this.averagePing;
            }
            set
            {
                if (value < 0)
                    value = 0;

                this.averagePing = value;
            }
        }
        /// <summary>
        /// Ensures value is within the range specified by minValue and minValue
        /// </summary>
        /// <param name="minValue">Minimum value within the range</param>
        /// <param name="maxValue">Maximum value within the range</param>
        /// <param name="value">The value that must be within the given range 
        /// specified by minValue and maxValue</param>
        private void MakeWithinRange(uint minValue, uint maxValue, ref uint value)
        {
            if (value < minValue)
                value = minValue;
            else if (value > maxValue)
                value = maxValue;
            
        }

        
    }
}
