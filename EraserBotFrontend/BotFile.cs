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
using System.IO;
using System.Windows.Forms;

namespace EraserBotFrontend
{
    class BotFile
    {
        // stores the bots  and their attributes contained within bots.cfg
        List<Bot> bots = new List<Bot>();

        // stores the teams as read from bots.cfg
        List<Team> teams = new List<Team>();

        // the current line being read. When this is NULL, the parser
        // will assume it has reached the end of the file and bail.
        string line;

        // buffer used when reading a chunk of data.
        int startPosition;

        /// <summary>
        /// Default constructor, does nothing
        /// </summary>
        public BotFile()
        {
            
        }

        /// <summary>
        /// Parses the bot file, storing bots and bot team data in the appropriate structures.
        /// </summary>
        /// <param name="path">Absolute path to the bot configuration file</param>
        /// <returns>Array containing the bots stored in the bot file</returns>
        public BotFileOutput ParseFile(string path)
        {
            // This code is rough but it does the trick. It could do with some stress
            // testing.

            bool insideBotSection = false;
            bool insideTeamSection = false;

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    //string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        line.Trim();

                        if (line.Length > 0)
                        {
                            if (line[0] != '#') // # are comments
                            {
                                startPosition = 0;

                                if (line[0] == '[')
                                {
                                    int start = line.IndexOf("[");
                                    int finish = line.IndexOf("]");

                                    string subString = line.Substring(start + 1, finish - 1);
                                    subString = subString.ToLower();

                                    // determine which section the file pointer is currently
                                    // entering. Kinda redundant - it's probably better
                                    // to just go ahead and parse the especified section, instead
                                    // of waiting for the next iteration of the loop. But whatever.
                                    if (subString == "bots")
                                    {
                                        insideBotSection = true;
                                        insideTeamSection = false;
                                    }
                                    else if (subString == "teams")
                                    {
                                        insideTeamSection = true;
                                        insideBotSection = false;
                                    }
                                    else
                                    {
                                        insideBotSection = false;
                                        insideTeamSection = false;
                                    }
                                }

                                else if (insideBotSection)
                                {

                                    //StringBuilder sb = new StringBuilder();
                                    Bot parsedBot = new Bot("", "", 0, 0, 0, FavouriteWeapon.BFG,
                                        false, false, 0);

                                    parsedBot.Name = RetrieveNextString();
                                    parsedBot.ModelAndSkin = RetrieveNextString();
                                    parsedBot.FiringAccuracy = (uint)RetrieveNextInteger(0);
                                    parsedBot.Aggressiveness = (uint)RetrieveNextInteger(0);
                                    parsedBot.CombatSkills = (uint)RetrieveNextInteger(0);
                                    parsedBot.FavouredWeapon = (FavouriteWeapon)RetrieveNextInteger(0);
                                    parsedBot.IsQuadFreak = Convert.ToBoolean(RetrieveNextInteger(0));
                                    parsedBot.IsCamper = Convert.ToBoolean(RetrieveNextInteger(0));
                                    parsedBot.Ping = (uint)RetrieveNextInteger(0);

                                    bots.Add(parsedBot);
                                }
                                else if (insideTeamSection)
                                {
                                    Team parsedTeam = new Team("", "", "", null);

                                    parsedTeam.Name = RetrieveNextString();
                                    parsedTeam.Abbreviation = RetrieveNextString();
                                    parsedTeam.SkinAndModel = RetrieveNextString();
                                    parsedTeam.Members = RetrieveStringCollection();

                                    teams.Add(parsedTeam);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message + e.StackTrace);
                StringBuilder sb = new StringBuilder();
                sb.Append(e.Message + Environment.NewLine);
                sb.Append(e.StackTrace + Environment.NewLine);

                throw new Exception(sb.ToString());

            }

            BotFileOutput output = new BotFileOutput(bots, teams);

            return output;
        }

        

        /// <summary>
        /// Retrieves the nearest legally formatted integer from the bot file. A legally formatted
        /// integer is one that is surrounded by whitespace, and not inside a comment block or
        /// formatted string. 
        /// </summary>
        /// <param name="defaultValue">The value to return if no legal integer is found.
        /// </param>
        /// <returns>The integer nearest to startPosition, else the specified defaultValue.
        /// </returns>
        private int RetrieveNextInteger(int defaultValue)
        {
            //string numSection = line.Substring(startPosition);
            int retVal = defaultValue;

            // a value of false indicates a number was not encountered
            bool numParsed = false; 

            StringBuilder sb = new StringBuilder();

            for (int i = startPosition + 1; i < line.Length; i++)
            {
                if(Char.IsWhiteSpace(line[i]))
                {
                    // true indicates a number is being parsed. Whitespace is treated as a delimiter
                    // in this case.
                    if (numParsed) 
                    {
                        startPosition = i;
                        break;
                    }
                }
                    

                else if (Char.IsDigit(line[i]))
                {
                    numParsed = true;
                    sb.Append(line[i]);
                }
                else
                {
                    // encountered an illegal character, use a safe value
                    //retVal = 0;
                    startPosition = i;
                    break;
                }
            }

            // conversion kludge. If you don't do this, the ASCII value of the 
            // number is returned, not the actual number.
            try
            {
                //string c = Convert.ToString(retVal);
                Int32.TryParse(sb.ToString(), out retVal);
            }
            catch
            {
                //DebugConsole.Print(e.Message);
            }
      
            return retVal;
        }

        /// <summary>
        /// Reads a string from the file containing bot information. For the method
        /// to regard data as a string, it must be encased within double quotes. Example:
        /// "a string" 'not a string' nor is this a string. If the string is not delimited,
        /// an empty string is returned. Currently, the only data that's applicable for the
        /// use of this function is the name of the bot and the formatted string containing
        /// the bots model and skin.
        /// </summary>
        /// <returns>Returns the parsed string on success and an empty string on failure</returns>
        private string RetrieveNextString()
        {
            StringBuilder sb = new StringBuilder();
            bool foundStringDelimiter = false;
            int stringDelimiterPosition = -1;

            int start = line.IndexOf("\"", startPosition);
            
            // Bug fix. If IndexOf can't find anything from startPosition onwards,
            // it'll continue its search from the beginning of the string. In the case of
            // RetrieveNextString, this is bad because once it's reached the end of the string
            // I want it to stop, not resume from the start.
            if (start < startPosition)
            {
                return null;
            }

            if (start != -1)
            {
                for (int i = start + 1; i < line.Length; i++)
                {
                    if (line[i] == '\"')
                    {
                        foundStringDelimiter = true;
                        stringDelimiterPosition = i;
                        break;
                    }
                }

                if (foundStringDelimiter)
                {
                    for (int i = start + 1; i < stringDelimiterPosition; i++)
                    {
                        sb.Append(line[i]);
                    }
                }
            }

            startPosition = stringDelimiterPosition + 1;
            return sb.ToString();
        }

        /// <summary>
        /// Retrieves one or more strings containing within '[' and ']'. Used for reading the members
        /// of a team.
        /// </summary>
        /// <returns>An string array containing the parsed strings</returns>
        private string[] RetrieveStringCollection()
        {
            List<string> parsedMembers = new List<string>();

            int start = line.IndexOf("[", startPosition);
            if (start != -1)
            {
                for (int i = start + 1; i < line.Length; i++)
                {
                    if (line[i] == ']')
                    {
                        break;
                    }
                    else
                    {
                        string buffer = RetrieveNextString();
                        if (buffer != null)
                        {
                            parsedMembers.Add(buffer);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            return parsedMembers.ToArray();
        }
    }
}
