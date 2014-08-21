using Buddy.Common;
using Buddy.Common.Plugins;
using Buddy.Swtor;
using Buddy.Swtor.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using System.Xml;
using System.Xml.Serialization;

namespace Buddywing.Plugins
{
    public class BuddyLogger : IPlugin
    {
        #region Implementation of IEquatable<IPlugin>

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
        /// </returns>
        /// <param name="other">An object to compare with this object.</param>
        public bool Equals(IPlugin other)
        {
            return other.Name == Name;
        }

        #endregion

#region Static Vars
		
        private static Keys BLboundkey = Keys.F10;

 
	#endregion        
    
        #region Implementation of IPlugin

        public string Author { get { return "Rostol"; } }

        public Version Version { get { return new Version(0, 1); } }

        public string Name { get { return "BuddyLogger"; } }

        public string Description { get { return "Dumps a LOT of info to the log! search for *MEGADUMP* to find the sections dumped"; } }

        public Window DisplayWindow { get { return null; } }

        private DateTime LastChecked { get; set; }

        /// <summary> Executes the pulse action. This is called every "tick" of the bot. </summary>
        public void OnPulse()
        {
            // - DO nothing, we dont care about the pulses at all.
            // Don't run in combat.
            //  if (BuddyTor.Me.InCombat)
            //    return;

            // Only every 10s.
            //if(DateTime.Now.Subtract(LastChecked).TotalSeconds > 120)
            //{
            //   LastChecked = DateTime.Now;
            //   foreach (var o in BuddyTor.Me.InventoryEquipment)
            //   {
            //       if(o.Name.Contains("Credit Box") || o.Name.Contains("Credit Case"))
            //          o.Use();
            //  }
            //}
        }

        /// <summary> Executes the initialize action. This is called at initial bot startup. (When the bot itself is started, not when Start() is called) </summary>
        public void OnInitialize()
        {
            Hotkeys.RegisterHotkey("MEGADumpPlugin", () => { BuddyLogger.DumpObjects(); }, BLboundkey);
            Write("Dumper Enabled");
        }

        /// <summary> Executes the shutdown action. This is called when the bot is shutting down. (Not when Stop() is called) </summary>
        public void OnShutdown()
        {
        }

        /// <summary> Executes the enabled action. This is called when the user has enabled this specific plugin via the GUI. </summary>
        public void OnEnabled()
        {
            //Hotkeys.RegisterHotkey("MEGADump", () => { BuddyLogger.DumpObjects(); }, Keys.F10);
        }

        /// <summary> Executes the disabled action. This is called whent he user has disabled this specific plugin via the GUI. </summary>
        public void OnDisabled()
        {

        }

        #endregion

        public static void Write(string message)
        {
            Write(Colors.Green, message);
        }

        public static void Write(string message, params object[] args)
        {
            Write(Colors.Green, message, args);
        }

        public static void Write(Color clr, string message, params object[] args)
        {
            Logging.Write(clr, "[BuddyLogger] " + message, args);
        }
        public static void Write(Exception ex)
        {
            Write("## EX: " + ex.Message);
        }
        public static void WriteObject(TorObject O)
        {
            if (O != null)
            {
                try
                {
                    XmlSerializer xmlserializer = new XmlSerializer(typeof(TorObject));
                    StringWriter stringWriter = new StringWriter();
                    XmlWriter writer = XmlWriter.Create(stringWriter);

                    xmlserializer.Serialize(writer, O);

                    Write(stringWriter.ToString());

                    writer.Close();

                }
                catch (Exception ex)
                {
                    Write("EX: " + ex.ToString());
                }
            }
        }
        //public static void WriteObject(Buddy.Swtor.BuddyTor  O)
        //{
        //    if (O != null)
        //    {try
        //        {
        //            XmlSerializer xmlserializer = new XmlSerializer(typeof(Buddy.Swtor.BuddyTor));
        //            StringWriter stringWriter = new StringWriter();
        //            XmlWriter writer = XmlWriter.Create(stringWriter);

        //            xmlserializer.Serialize(writer, O);

        //            Write(stringWriter.ToString());

        //            writer.Close();

        //        }
        //    catch (Exception ex)
        //        {

        //        }
        //    }
        //}
        public static void DumpObjects()
        {            
            Write ("***** TAKING *MEGADUMP* *****");
            try {Write("****** CLIENT ------");
                 BuddyTor.Client.DebugDump(true, true, false);
                 Write("------ /CLIENT");}
            catch {};

            try
            {
                Write(" -- ME -- ");
                BuddyTor.Me.DebugDump(true, true, false);
            }

            catch { };

            try
            {
            Write("****** SHIP ------");
            BuddyTor.Ship.DebugDump(true, true, false);
            }

            catch { Write ("Only usable aboard your ship");};
            try
            {
            Write("****** DE-BUFF ------");
            BuddyTor.Me.Debuffs.DebugDump(true, true, false);
            }

            catch { };

            try
            {
            Write("****** BUFFS ------");
            BuddyTor.Me.Buffs.DebugDump(true, true, false);
                      }

            catch { }

            try
            {
                Write("****** CharacterOwnedVehicle ------");
                BuddyTor.Me.CharacterOwnedVehicle.DebugDump(true, true, false);
            }
            catch { }

            try
            {
                Write("****** Companion ------");
                BuddyTor.Me.Companion.DebugDump(true, true, false);
            }
            catch { };
            try
            {
                foreach (TorCharacter tn in BuddyTor.Me.EnemiesAttackers) tn.DebugDump (true,true,false);
            }
            catch { };
                
            Write("******* /ME ---------");
            /* 
            Write("****** BUFFS ------");
            Write(BuddyTor.Me.Buffs.ToReflectedString());
            Write("****** /BUFFS ------"); 
            Write("*******  ME.Companion ---------");
            try{Write(BuddyTor.Me.Companion.ToReflectedString());} 
            catch {};
            try { Write(" -- $$$ -- " + BuddyTor.Me.Currency.ToString()); }
            catch { };
            try { Write(" -- CurrentMissionBoardQuestCount -- " + BuddyTor.Me.CurrentMissionBoardQuestCount.ToString()); }
            catch { };
            try { Write(" -- CurrentTaxiTerminalID -- " + BuddyTor.Me.CurrentTaxiTerminalID.ToString()); }
            catch { };
            
            //Write("**      LOCATION: " + BuddyTor.Client.Position+"**          AREA: " + BuddyTor.Client.hea);

            //            Write("**          AREA: " + BuddyTor.Client.AreaName);
              
             */
        }
    }
}
