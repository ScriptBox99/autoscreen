﻿//-----------------------------------------------------------------------
// <copyright file="ScheduleCollection.cs" company="Gavin Kendall">
//     Copyright (c) 2008-2021 Gavin Kendall
// </copyright>
// <author>Gavin Kendall</author>
// <summary>A collection of schedules.</summary>
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <https://www.gnu.org/licenses/>.
//-----------------------------------------------------------------------
using System;
using System.Text;
using System.Xml;

namespace AutoScreenCapture
{
    /// <summary>
    /// A collection class to store and manage Schedule objects.
    /// </summary>
    public class ScheduleCollection : CollectionTemplate<Schedule>
    {
        private const string XML_FILE_INDENT_CHARS = "   ";
        private const string XML_FILE_SCHEDULE_NODE = "schedule";
        private const string XML_FILE_SCHEDULES_NODE = "schedules";
        private const string XML_FILE_ROOT_NODE = "autoscreen";

        private const string SCHEDULE_NAME = "name";
        private const string SCHEDULE_ENABLE = "enable";
        private const string SCHEDULE_MODE_ONETIME = "mode_onetime";
        private const string SCHEDULE_MODE_PERIOD = "mode_period";
        private const string SCHEDULE_CAPTUREAT = "captureat";
        private const string SCHEDULE_STARTAT = "startat";
        private const string SCHEDULE_STOPAT = "stopat";
        private const string SCHEDULE_SCREEN_CAPTURE_INTERVAL = "screen_capture_interval";
        private const string SCHEDULE_MONDAY = "monday";
        private const string SCHEDULE_TUESDAY = "tuesday";
        private const string SCHEDULE_WEDNESDAY = "wednesday";
        private const string SCHEDULE_THURSDAY = "thursday";
        private const string SCHEDULE_FRIDAY = "friday";
        private const string SCHEDULE_SATURDAY = "saturday";
        private const string SCHEDULE_SUNDAY = "sunday";
        private const string SCHEDULE_NOTES = "notes";

        private readonly string SCHEDULE_XPATH;

        /// <summary>
        /// The name of the "special schedule" that's used when commands are given from the command line
        /// or the old schedule is imported from an old version of Auto Screen Capture (anything before 2.3).
        /// </summary>
        public string SpecialScheduleName { get; private set; }

        private string AppCodename { get; set; }
        private string AppVersion { get; set; }

        /// <summary>
        /// The empty constructor for the schedule collection.
        /// </summary>
        public ScheduleCollection()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("/");
            sb.Append(XML_FILE_ROOT_NODE);
            sb.Append("/");
            sb.Append(XML_FILE_SCHEDULES_NODE);
            sb.Append("/");
            sb.Append(XML_FILE_SCHEDULE_NODE);

            SCHEDULE_XPATH = sb.ToString();

            SpecialScheduleName = "Special Schedule";
        }

        /// <summary>
        /// Loads the image schedules from the schedules.xml file.
        /// </summary>
        public bool LoadXmlFileAndAddSchedules(Config config, FileSystem fileSystem, Log log)
        {
            try
            {
                if (fileSystem.FileExists(fileSystem.SchedulesFile))
                {
                    log.WriteDebugMessage("Schedules file \"" + fileSystem.SchedulesFile + "\" found. Attempting to load XML document");

                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(fileSystem.SchedulesFile);

                    log.WriteDebugMessage("XML document loaded");

                    AppVersion = xDoc.SelectSingleNode("/autoscreen").Attributes["app:version"]?.Value;
                    AppCodename = xDoc.SelectSingleNode("/autoscreen").Attributes["app:codename"]?.Value;

                    XmlNodeList xSchedules = xDoc.SelectNodes(SCHEDULE_XPATH);

                    foreach (XmlNode xSchedule in xSchedules)
                    {
                        Schedule schedule = new Schedule();
                        XmlNodeReader xReader = new XmlNodeReader(xSchedule);

                        while (xReader.Read())
                        {
                            if (xReader.IsStartElement() && !xReader.IsEmptyElement)
                            {
                                switch (xReader.Name)
                                {
                                    case SCHEDULE_NAME:
                                        xReader.Read();
                                        schedule.Name = xReader.Value;
                                        break;

                                    case SCHEDULE_ENABLE:
                                    case "active": // Any version older than 2.3.7.0 used "active" instead of "enable".
                                        xReader.Read();
                                        schedule.Enable = Convert.ToBoolean(xReader.Value);
                                        break;

                                    case SCHEDULE_MODE_ONETIME:
                                        xReader.Read();
                                        schedule.ModeOneTime = Convert.ToBoolean(xReader.Value);
                                        break;

                                    case SCHEDULE_MODE_PERIOD:
                                        xReader.Read();
                                        schedule.ModePeriod = Convert.ToBoolean(xReader.Value);
                                        break;

                                    case SCHEDULE_CAPTUREAT:
                                        xReader.Read();
                                        schedule.CaptureAt = Convert.ToDateTime(xReader.Value);
                                        break;

                                    case SCHEDULE_STARTAT:
                                        xReader.Read();
                                        schedule.StartAt = Convert.ToDateTime(xReader.Value);
                                        break;

                                    case SCHEDULE_STOPAT:
                                        xReader.Read();
                                        schedule.StopAt = Convert.ToDateTime(xReader.Value);
                                        break;

                                    case SCHEDULE_SCREEN_CAPTURE_INTERVAL:
                                        xReader.Read();
                                        schedule.ScreenCaptureInterval = Convert.ToInt32(xReader.Value);
                                        break;

                                    case SCHEDULE_MONDAY:
                                        xReader.Read();
                                        schedule.Monday = Convert.ToBoolean(xReader.Value);
                                        break;

                                    case SCHEDULE_TUESDAY:
                                        xReader.Read();
                                        schedule.Tuesday = Convert.ToBoolean(xReader.Value);
                                        break;

                                    case SCHEDULE_WEDNESDAY:
                                        xReader.Read();
                                        schedule.Wednesday = Convert.ToBoolean(xReader.Value);
                                        break;

                                    case SCHEDULE_THURSDAY:
                                        xReader.Read();
                                        schedule.Thursday = Convert.ToBoolean(xReader.Value);
                                        break;

                                    case SCHEDULE_FRIDAY:
                                        xReader.Read();
                                        schedule.Friday = Convert.ToBoolean(xReader.Value);
                                        break;

                                    case SCHEDULE_SATURDAY:
                                        xReader.Read();
                                        schedule.Saturday = Convert.ToBoolean(xReader.Value);
                                        break;

                                    case SCHEDULE_SUNDAY:
                                        xReader.Read();
                                        schedule.Sunday = Convert.ToBoolean(xReader.Value);
                                        break;

                                    case SCHEDULE_NOTES:
                                        xReader.Read();
                                        schedule.Notes = xReader.Value;
                                        break;
                                }
                            }
                        }

                        xReader.Close();

                        // Change the data for each Schedule that's being loaded if we've detected that
                        // the XML document is from an older version of the application.
                        if (config.Settings.VersionManager.IsOldAppVersion(config.Settings, AppCodename, AppVersion))
                        {
                            log.WriteDebugMessage("An old version of the schedules.xml file was detected. Attempting upgrade to new schema.");

                            Version v2300 = config.Settings.VersionManager.Versions.Get("Boombayah", "2.3.0.0");
                            Version v2319 = config.Settings.VersionManager.Versions.Get("Boombayah", "2.3.1.9");
                            Version configVersion = config.Settings.VersionManager.Versions.Get(AppCodename, AppVersion);

                            if (v2300 != null && configVersion != null && configVersion.VersionNumber < v2300.VersionNumber)
                            {
                                log.WriteDebugMessage("Dalek 2.2.4.6 or older detected");

                                // This is a new property for Schedule that was introduced in 2.3.0.0
                                // so any version before 2.3.0.0 needs to have it during an upgrade.
                                schedule.Enable = true;
                            }

                            if (v2319 != null && configVersion != null && configVersion.VersionNumber < v2319.VersionNumber)
                            {
                                log.WriteDebugMessage("Boombayah 2.3.1.8 or older detected");

                                // A new property for Schedule introduced in 2.3.1.9
                                schedule.ScreenCaptureInterval = Convert.ToInt32(config.Settings.User.GetByKey("ScreenCaptureInterval", config.Settings.DefaultSettings.ScreenCaptureInterval).Value);
                            }
                        }

                        if (!string.IsNullOrEmpty(schedule.Name))
                        {
                            Add(schedule);
                        }
                    }

                    if (config.Settings.VersionManager.IsOldAppVersion(config.Settings, AppCodename, AppVersion))
                    {
                        log.WriteDebugMessage("Schedules file detected as an old version");
                        SaveToXmlFile(config.Settings, fileSystem, log);
                    }
                }
                /*
                else
                {
                    log.WriteDebugMessage("WARNING: Unable to load schedules");

                    // If we can't find the schedules.xml file we'll need to have a "Special Schedule" schedule created to be compatible with old commands like -startat and -stopat.
                    log.WriteDebugMessage("Creating default Special Schedule for use with command line arguments such as -startat and -stopat");

                    DateTime dtNow = DateTime.Now;

                    Schedule specialSchedule = new Schedule()
                    {
                        Name = SpecialScheduleName,
                        Active = false,
                        ModeOneTime = true,
                        ModePeriod = false,
                        CaptureAt = dtNow,
                        StartAt = dtNow,
                        StopAt = dtNow,
                        ScreenCaptureInterval = config.Settings.DefaultSettings.ScreenCaptureInterval,
                        Notes = "This schedule is used for the command line arguments -captureat, -startat, and -stopat."
                    };

                    if (config.Settings.VersionManager != null && config.Settings.VersionManager.OldUserSettings != null)
                    {
                        // If we're importing the schedule settings from a previous version of Auto Screen Capture we'll need to update the "Special Schedule" and enable it.
                        SettingCollection oldUserSettings = config.Settings.VersionManager.OldUserSettings;

                        bool captureStartAt = Convert.ToBoolean(oldUserSettings.GetByKey("BoolCaptureStartAt", config.Settings.DefaultSettings.BoolCaptureStartAt).Value);
                        bool captureStopAt = Convert.ToBoolean(oldUserSettings.GetByKey("BoolCaptureStopAt", config.Settings.DefaultSettings.BoolCaptureStopAt).Value);

                        DateTime dtStartAt = Convert.ToDateTime(oldUserSettings.GetByKey("DateTimeCaptureStartAt", config.Settings.DefaultSettings.DateTimeCaptureStartAt).Value);
                        DateTime dtStopAt = Convert.ToDateTime(oldUserSettings.GetByKey("DateTimeCaptureStopAt", config.Settings.DefaultSettings.DateTimeCaptureStopAt).Value);

                        // Days
                        bool captureOnTheseDays = Convert.ToBoolean(oldUserSettings.GetByKey("BoolCaptureOnTheseDays", config.Settings.DefaultSettings.BoolCaptureOnTheseDays).Value);
                        bool sunday = Convert.ToBoolean(oldUserSettings.GetByKey("BoolCaptureOnSunday", config.Settings.DefaultSettings.BoolCaptureOnSunday).Value);
                        bool monday = Convert.ToBoolean(oldUserSettings.GetByKey("BoolCaptureOnMonday", config.Settings.DefaultSettings.BoolCaptureOnMonday).Value);
                        bool tuesday = Convert.ToBoolean(oldUserSettings.GetByKey("BoolCaptureOnTuesday", config.Settings.DefaultSettings.BoolCaptureOnTuesday).Value);
                        bool wednesday = Convert.ToBoolean(oldUserSettings.GetByKey("BoolCaptureOnWednesday", config.Settings.DefaultSettings.BoolCaptureOnWednesday).Value);
                        bool thursday = Convert.ToBoolean(oldUserSettings.GetByKey("BoolCaptureOnThursday", config.Settings.DefaultSettings.BoolCaptureOnThursday).Value);
                        bool friday = Convert.ToBoolean(oldUserSettings.GetByKey("BoolCaptureOnFriday", config.Settings.DefaultSettings.BoolCaptureOnFriday).Value);
                        bool saturday = Convert.ToBoolean(oldUserSettings.GetByKey("BoolCaptureOnSaturday", config.Settings.DefaultSettings.BoolCaptureOnSaturday).Value);

                        specialSchedule.ModeOneTime = false;
                        specialSchedule.ModePeriod = true;

                        if (captureStartAt)
                        {
                            specialSchedule.Active = true;
                            specialSchedule.StartAt = dtStartAt;
                        }

                        if (captureStopAt)
                        {
                            specialSchedule.Active = true;
                            specialSchedule.StopAt = dtStopAt;
                        }

                        if (captureOnTheseDays)
                        {
                            specialSchedule.Sunday = sunday;
                            specialSchedule.Monday = monday;
                            specialSchedule.Tuesday = tuesday;
                            specialSchedule.Wednesday = wednesday;
                            specialSchedule.Thursday = thursday;
                            specialSchedule.Friday = friday;
                            specialSchedule.Saturday = saturday;
                        }
                    }

                    Add(specialSchedule);

                    SaveToXmlFile(config.Settings, fileSystem, log);
                }
                */

                return true;
            }
            catch (Exception ex)
            {
                log.WriteExceptionMessage("ScheduleCollection::LoadXmlFileAndAddSchedules", ex);

                return false;
            }
        }

        /// <summary>
        /// Saves the image schedules in the collection to the schedules.xml file.
        /// </summary>
        public bool SaveToXmlFile(Settings settings, FileSystem fileSystem, Log log)
        {
            try
            {
                XmlWriterSettings xSettings = new XmlWriterSettings
                {
                    Indent = true,
                    CloseOutput = true,
                    CheckCharacters = true,
                    Encoding = Encoding.UTF8,
                    NewLineChars = Environment.NewLine,
                    IndentChars = XML_FILE_INDENT_CHARS,
                    NewLineHandling = NewLineHandling.Entitize,
                    ConformanceLevel = ConformanceLevel.Document
                };

                if (string.IsNullOrEmpty(fileSystem.SchedulesFile))
                {
                    fileSystem.SchedulesFile = fileSystem.DefaultSchedulesFile;

                    fileSystem.AppendToFile(fileSystem.ConfigFile, "\nSchedulesFile=" + fileSystem.SchedulesFile);
                }

                if (fileSystem.FileExists(fileSystem.SchedulesFile))
                {
                    fileSystem.DeleteFile(fileSystem.SchedulesFile);
                }

                using (XmlWriter xWriter = XmlWriter.Create(fileSystem.SchedulesFile, xSettings))
                {
                    xWriter.WriteStartDocument();
                    xWriter.WriteStartElement(XML_FILE_ROOT_NODE);
                    xWriter.WriteAttributeString("app", "version", XML_FILE_ROOT_NODE, settings.ApplicationVersion);
                    xWriter.WriteAttributeString("app", "codename", XML_FILE_ROOT_NODE, settings.ApplicationCodename);
                    xWriter.WriteStartElement(XML_FILE_SCHEDULES_NODE);

                    foreach (Schedule schedule in base.Collection)
                    {
                        xWriter.WriteStartElement(XML_FILE_SCHEDULE_NODE);

                        xWriter.WriteElementString(SCHEDULE_ENABLE, schedule.Enable.ToString());
                        xWriter.WriteElementString(SCHEDULE_NAME, schedule.Name);
                        xWriter.WriteElementString(SCHEDULE_MODE_ONETIME, schedule.ModeOneTime.ToString());
                        xWriter.WriteElementString(SCHEDULE_MODE_PERIOD, schedule.ModePeriod.ToString());
                        xWriter.WriteElementString(SCHEDULE_CAPTUREAT, schedule.CaptureAt.ToString());
                        xWriter.WriteElementString(SCHEDULE_STARTAT, schedule.StartAt.ToString());
                        xWriter.WriteElementString(SCHEDULE_STOPAT, schedule.StopAt.ToString());
                        xWriter.WriteElementString(SCHEDULE_SCREEN_CAPTURE_INTERVAL, schedule.ScreenCaptureInterval.ToString());
                        xWriter.WriteElementString(SCHEDULE_MONDAY, schedule.Monday.ToString());
                        xWriter.WriteElementString(SCHEDULE_TUESDAY, schedule.Tuesday.ToString());
                        xWriter.WriteElementString(SCHEDULE_WEDNESDAY, schedule.Wednesday.ToString());
                        xWriter.WriteElementString(SCHEDULE_THURSDAY, schedule.Thursday.ToString());
                        xWriter.WriteElementString(SCHEDULE_FRIDAY, schedule.Friday.ToString());
                        xWriter.WriteElementString(SCHEDULE_SATURDAY, schedule.Saturday.ToString());
                        xWriter.WriteElementString(SCHEDULE_SUNDAY, schedule.Sunday.ToString());
                        xWriter.WriteElementString(SCHEDULE_NOTES, schedule.Notes);

                        xWriter.WriteEndElement();
                    }

                    xWriter.WriteEndElement();
                    xWriter.WriteEndElement();
                    xWriter.WriteEndDocument();

                    xWriter.Flush();
                    xWriter.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                log.WriteExceptionMessage("ScheduleCollection::SaveToXmlFile", ex);

                return false;
            }
        }
    }
}