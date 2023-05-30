﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telnyx.net.Entities;
using Telnyx.net.Entities.NumberOrderDocuments;

namespace Telnyx.net.Services.PhoneNumbers.NumberOrderDocuments
{
    public class NumberOrderDocumentService : Service<NumberOrderDocument>
    {
        public NumberOrderDocumentService()
            : base(null) { }

        public NumberOrderDocumentService(string apiKey)
            : base(apiKey) { }
        public override string BasePath => "/number_order_documents";

        public async Task<TelnyxList<NumberOrderDocument>> ListNumberOrderDocumentsAsync(NumberOrderDocumentListOptions options, RequestOptions reqOpts = null, CancellationToken ct = default)
        {
            return await this.ListEntitiesAsync(options, reqOpts, ct);
        }
        public TelnyxList<NumberOrderDocument> ListNumberOrderDocuments(NumberOrderDocumentListOptions options, RequestOptions reqOpts = null)
        {
            return this.ListEntities(options, reqOpts);
        }

        public NumberOrderDocument CreateumberOrderDocument(NumberOrderDocumentCreateOptions sendOptions, RequestOptions requestOptions = null)
        {
            return this.CreateEntity(sendOptions, requestOptions);
        }

        public async Task<NumberOrderDocument> CreateumberOrderDocumentAsync(NumberOrderDocumentCreateOptions sendOptions, RequestOptions requestOptions = null, CancellationToken ct = default)
        {
            return await this.CreateEntityAsync(sendOptions, requestOptions, ct).ConfigureAwait(false);
        }

        public async Task<NumberOrderDocument> UpdateNumberOrderDocumentAsync(string id, NumberOrderDocumentUpdateOptions updateOptions, RequestOptions reqOps = null, CancellationToken ct = default)
        {
            return await this.UpgradeEntityAsync(id, updateOptions, reqOps, ct);
        }
        public NumberOrderDocument UpdateNumberOrderDocument(string id, NumberOrderDocumentUpdateOptions updateOptions, RequestOptions reqOps = null)
        {
            return this.UpgradeEntity(id, updateOptions, reqOps);
        }
    }
}
