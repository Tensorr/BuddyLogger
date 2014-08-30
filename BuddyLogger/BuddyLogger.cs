using System.Collections;
using System.Linq.Expressions;
using System.Threading;
using System.Windows.Forms.VisualStyles;
using Buddy.Common;
using Buddy.Common.Plugins;
using Buddy.CommonBot.Profile;
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
using Buddywing;

namespace BuddyLogger
{


    public class BuddyLogger : IPlugin
    {
        

        #region Settings

        private static bool _megaDump = true;
        private static bool _MDParents = true;
        private static bool _MDFields = true;
        private static bool _MDMethods = true;

        
        private const bool Placeables = true;
        private const bool Vendors = true;
        private const bool Npcs = true;
        private const bool Equipment = true;
        private const bool Effects = true;
        private const bool Players = true;
        private const bool Abilities = true;
       
        private static bool _Companion = true;
        private frmSettings _newtempui;
        private const Keys BLboundkey = Keys.Delete;


        #endregion
        #region Settings Switches


        #endregion

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

    
    
        #region Implementation of IPlugin

        public string Author { get { return "Rostol"; } }

        public Version Version { get { return new Version(0, 1); } }

        public string Name { get { return "BuddyLogger"; } }

        public string Description { get { return "Dumps a LOT of info to the log! search for *MEGADUMP* to find the sections dumped"; } }

        public Window DisplayWindow { get { return null; } }

        private DateTime LastChecked { get; set; }

        public static bool MegaDump
        {
            get { return _megaDump; }
            set { _megaDump = value; }
        }

        public static bool MDParents
        {
            get { return _MDParents; }
            set { _MDParents = value; }
        }

        public static bool MDFields
        {
            get { return _MDFields; }
            set { _MDFields = value; }
        }

        public static bool MDMethods
        {
            get { return _MDMethods; }
            set { _MDMethods = value; }
        }

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
            LoadUI();

        }


        public void LoadUI()
        {
            if (_newtempui == null || _newtempui.IsDisposed || _newtempui.Disposing) _newtempui = new frmSettings();
            if (_newtempui != null || _newtempui.IsDisposed) _newtempui.ShowDialog();
        }
        
        public void DisplayDevWindow()
        {
            var thread = new Thread(new ThreadStart(DisplayFormThread));

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();

        }

        
        private void DisplayFormThread()
        {
            try
            {
                frmSettings objMain = new frmSettings();
                objMain.Show();
                objMain.Closed += (s, e) => System.Windows.Threading.Dispatcher.ExitAllFrames();

                System.Windows.Threading.Dispatcher.Run();
            }
            catch (Exception ex)
            {
                Write(ex);
            }
        }

        /// <summary> Executes the disabled action. This is called whent he user has disabled this specific plugin via the GUI. </summary>
        public void OnDisabled()
        {
            if (_newtempui != null || _newtempui.IsDisposed) _newtempui.Hide();

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

        /// <summary> Calls the actual Logging method of the bot. </summary>
        public static void Write(Color clr, string message, params object[] args)
        {
            Logging.Write(clr, "[BuddyLogger] " + message, args);
        }
        /// <summary> Writes an Exception to the log. </summary>
        public static void Write(Exception ex)
        {
            Write("!!##!!!!##!! EXCEPTION: ----------------------------------------------");
            Write("!!##  Message = {0}", ex.Message);
	        Write("!!##  Source = {0}", ex.Source);
	        Write("!!##  StackTrace = {0}", ex.StackTrace);
	        Write("!!##  TargetSite = {0}", ex.TargetSite);
            Write("!!##  HelpLink = {0}", ex.HelpLink);
            // Display the exception's data dictionary.
            //usage ex.data["Time"]=DateTime.Now; ex.data["Pizza"]="Yup";
	        foreach (DictionaryEntry pair in ex.Data)
	        {
                Write("!!## EX: {0} = {1}", pair.Key, pair.Value);
            }
            Write("!!##!!!!##!! /EXCEPTION -----------------------------------------------");
        }
        public static void WriteObject(TorObject O)
        {
            if (O == null) return;
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
                Write(ex);
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

        /// <summary> Dumps everything </summary>
        public static void DumpObjects()
        {
            // TODO 1- Add boolean toggles
            // TODO 2- Link to Settings window
            Write ("***** TAKING *MEGADUMP* *****");

            #region commented out OLD CODE - Rewrite
            //try {Write("****** CLIENT ------");
            //     BuddyTor.Client.DebugDump(false, true, false);
            //     Write("------ /CLIENT");}
            //catch {};

            //try
            //{
            //    Write(" -- ME -- ");
            //    BuddyTor.Me.DebugDump(false, true, false);
            //}

            //catch { };

            //try
            //{
            //Write("****** SHIP ------");
            //BuddyTor.Ship.DebugDump(false, true, false);
            //}

            //catch { Write ("Only usable aboard your ship");};
            //try
            //{
            //Write("****** DE-BUFF ------");
            //BuddyTor.Me.Debuffs.DebugDump(false, true, false);
            //}

            //catch { };

            //try
            //{
            //Write("****** BUFFS ------");
            //BuddyTor.Me.Buffs.DebugDump(false, true, false);
            //          }

            //catch { }

            //try
            //{
            //    Write("****** CharacterOwnedVehicle ------");
            //    BuddyTor.Me.CharacterOwnedVehicle.DebugDump(false, true, false);
            //}
            //catch { }

            //    Write("****** c ------");
            //    BuddyTor.Me.Companion.DebugDump(false, true, false);
            //if (_Companion)
            //{
            //    try
            //    {
            //        Write("**** Companion *****");
            //        foreach (TorVendor tx in ObjectManager.GetObjects<TorObject>().OrderBy(t => t.Distance))
            //        {
            //            Write("**** Vendors: " + tx.Name);
            //            Write("**** Typ    : " + tx.GetType().ToString());
            //            tx.DebugDump(false, true, false);
            //        }
            //        ;
            //    }
            //    catch (Exception ex){Write(ex);}
            //}

            //try
            //{
            //    Write("******* Questing");
            //    BuddyTor.Me.Questing.DebugDump(false, true, false);
            //}
            //catch { Write("Invalid or no Questing"); };
            //Write("******* /ME ---------");
            #endregion

            if (Placeables)
            {
                try
                {
                    Write("**** PLACEABLES *****");
                    foreach (TorPlaceable tx in ObjectManager.GetObjects<TorPlaceable>().OrderBy(tx => tx.Distance))
                    {                                                       
                        Write("**** PLAC : " + tx.Name);
                        Write("**** Typ  : " + tx.GetType().ToString());
                        Write("**** Pos  : " + tx.Position.ToString());
                        Write("**** Dist : " + tx.Distance);
                        if(_megaDump) tx.DebugDump(MDParents,MDFields,MDMethods);
                    };
                }
                catch (Exception ex) { Write(ex); }
            }

            if (Npcs)
            {
                try
                {
                    Write("**** NPC *****");
                    foreach (TorNpc tx in ObjectManager.GetObjects<TorNpc>().OrderBy(t => t.Distance))
                    {
                        Write("**** NPC: " + tx.Name);
                        Write("**** Typ  : " + tx.GetType().ToString());
                        Write("**** Pos  : " + tx.Position.ToString());
                        Write("**** Dist : " + tx.Distance);
                        if (_megaDump) tx.DebugDump(MDParents, MDFields, MDMethods);                   
                    };
                }
                catch (Exception ex) { Write(ex); }
            }
            
            if (Vendors)
            {
                try
                {
                    Write("**** Vendors *****");
                    foreach (TorVendor tx in ObjectManager.GetObjects<TorVendor>().OrderBy(t => t.Distance))
                    {
                        Write("**** Vendors: " + tx.Name);
                        Write("**** Typ  : " + tx.GetType().ToString());
                        Write("**** Pos  : " + tx.Position.ToString());
                        Write("**** Dist : " + tx.Distance);
                        if (_megaDump) tx.DebugDump(MDParents, MDFields, MDMethods);
                    };
                }
                catch (Exception ex) { Write(ex); }
            }
            if (Effects)
            {
                try
                {
                    Write("**** Effects *****");
                    foreach (TorEffect tx in ObjectManager.GetObjects<TorEffect>().OrderBy(t => t.Distance))
                    {
                        Write("**** Effects: " + tx.Name);
                        Write("**** Typ  : " + tx.GetType().ToString());
                        Write("**** Pos  : " + tx.Position.ToString());
                        Write("**** Dist : " + tx.Distance);
                        if (_megaDump) tx.DebugDump(MDParents, MDFields, MDMethods);
                    };
                }
                catch (Exception ex) { Write(ex); }
            }

            if (Equipment)
            {
               try
                {
                    Write(
                        "******* EQUIPMENT ************************************************************************************************************");
                        foreach (TorItem ti in BuddyTor.Me.InventoryEquipment)
                        {
                            Write("**** OBJ: " + ti.Name);
                            Write("**** Typ: " + ti.GetType().ToString());
                            ti.DebugDump(false,true,false);
                        }; 
                    Write("******* Bank  **   ");
                    BuddyTor.Me.InventoryBank.DebugDump(false, true, false);
                }
                catch (Exception ex) { Write(ex); }
            }

            Write("******* /Dump ---------");

            /* 
             * var theList = ObjectManager.GetObjects<TorObject>().OrderBy(t => t.Distance)
             * 
             * 
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
