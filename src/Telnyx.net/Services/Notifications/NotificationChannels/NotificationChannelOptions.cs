﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telnyx.net.Entities.Enum.Notification.NotificationChannels;

namespace Telnyx.net.Services.Notifications.NotificationChannels
{
    public class NotificationChannelOptions : BaseOptions
    {
        /// <summary>
        /// The destination associated with the channel type.
        /// </summary>
        [JsonProperty("channel_destination")]
        public string ChannelDestination { get; set; }

        /// <summary>
        /// A Channel Type ID.
        /// </summary>
        [JsonProperty("channel_type_id")]
        public ChannelType ChannelTypeId { get; set; }

        /// <summary>
        /// A UUID reference to the associated Notification Profile.
        /// </summary>
        [JsonProperty("notification_profile_id")]
        public string NotificationProfileId { get; set; }
    }
}
