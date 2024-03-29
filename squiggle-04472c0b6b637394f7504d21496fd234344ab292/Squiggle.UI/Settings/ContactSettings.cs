﻿using Squiggle.Utilities.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Squiggle.UI.Settings
{
    class ContactSettings : ISettingsGroup
    {
        public ContactListSortField ContactListSortField { get; set; }
        public ContactListView ContactListView { get; set; }
        public ContactGroups ContactGroups { get; set; }
        public bool GroupContacts { get; set; }
        public bool ShowOfflineContatcs { get; set; }

        public ContactSettings()
        {
            ContactGroups = new ContactGroups();
        }

        public void ReadFrom(Properties.Settings settings, ConfigReader reader)
        {
            ContactListSortField = settings.ContactListSortField;
            GroupContacts = settings.GroupContacts;
            ContactGroups = settings.Groups ?? new ContactGroups();
            ShowOfflineContatcs = settings.ShowOfflineContatcs;
            ContactListView = settings.ContactListView;
        }

        public void WriteTo(Properties.Settings settings, ConfigReader reader)
        {
            settings.ContactListSortField = ContactListSortField;
            settings.GroupContacts = GroupContacts;
            settings.Groups = ContactGroups;
            settings.ShowOfflineContatcs = ShowOfflineContatcs;
            settings.ContactListView = ContactListView;
        }
    }
}
