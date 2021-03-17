﻿using System.Threading;
using System.Threading.Tasks;
using Telnyx.net.Entities;

namespace Telnyx.net.Services.Calls.ConferenceCommands.ConferenceRecording
{
    public class ConferenceRecordingService : Service<TelnyxApiResponse>
    {
        public ConferenceRecordingService()
            : base(null)
        {
        }

        public ConferenceRecordingService(string apiKey)
            : base(apiKey)
        {
        }

        public override string BasePath => "/conferences";

        private string stopURI => "/actions/record_stop";

        private string startURI => "/actions/record_start";

        public TelnyxApiResponse Start(string id, RecordStartOptions startOptions, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(id, this.startURI, startOptions, requestOptions);
        }

        public async Task<TelnyxApiResponse> StartAsync(string id, RecordStartOptions startOptions, RequestOptions requestOptions = null, CancellationToken ct = default)
        {
            return await this.CreateEntityAsync(id, this.startURI, startOptions, requestOptions, ct);
        }

        public TelnyxApiResponse Stop(string id, RecordStopOptions stopOptions, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(id, this.stopURI, stopOptions, requestOptions);
        }

        public async Task<TelnyxApiResponse> StopAsync(string id, RecordStopOptions stopOptions, RequestOptions requestOptions = null, CancellationToken ct = default)
        {
            return await this.CreateEntityAsync(id, this.stopURI, stopOptions, requestOptions, ct);
        }
    }
}
