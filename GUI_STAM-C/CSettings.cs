using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace GUI_STAM_C
{
    [XmlRoot(ElementName = "Settings")]
    public class Settings
    {
        [XmlElement(ElementName = "SkyrimPath")]
        public string SkyrimPath { get; set; }
        [XmlElement(ElementName = "NoReminder")]
        public bool NoReminder { get; set; }
        [XmlElement(ElementName = "NoReminderVersion")]
        public string NoReminderVersion { get; set; }
    }

}