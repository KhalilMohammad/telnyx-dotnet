﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telnyx.net.Entities;
using Telnyx.net.Entities.Notifications.NotificationsEvents;

namespace Telnyx.net.Services.Notifications.NotificationsEvents
{
    public class NotificationsEventService : Service<NotificationsEvent>
    {
        public override string BasePath => "/notification_events";
        public async Task<TelnyxList<NotificationsEvent>> ListNotificationsEventsConditionsAsync(RequestOptions reqOpts = null, CancellationToken ct = default)
        {
            return await this.ListEntitiesAsync(null, reqOpts, ct);
        }

        public TelnyxList<NotificationsEvent> ListNotificationsEventsConditions(RequestOptions reqOpts = null)
        {
            return this.ListEntities(null, reqOpts);
        }
    }
}
