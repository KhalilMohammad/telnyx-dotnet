﻿using System.Threading.Tasks;
using Telnyx;
using Telnyx.net.Entities;
using Telnyx.net.Services.PhoneNumbers;
using Xunit;
using System.Threading;
using Telnyx.net.Entities.Notifications;
using System.Net.Mime;
using Telnyx.net.Entities.NumberPortouts;
using System;
using System.Collections.Generic;
using Telnyx.net.Services.PhoneNumbers.NumberBackgroundJobs;

namespace TelnyxTests.Services.Notifications.Notifications.UpdateABatchOfNumberss

{
    /// <summary>
    /// Test class for UpdateABatchOfNumbersTest.
    /// </summary>
    public class UpdateABatchOfNumbersTest : BaseTelnyxTest
    {
        private readonly NumberBackgroundJobService service;
        private readonly UpdateABatchOfNumbersOptions UpdateABatchOfNumbersOptions;
        private readonly RequestOptions requestOptions;
        private readonly BaseOptions baseOptions;
        private const string Id = "6a09cdc3-8948-47f0-aa62-74ac943d6c58";

        public UpdateABatchOfNumbersTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new NumberBackgroundJobService();
            this.baseOptions = new BaseOptions();
            this.requestOptions = new RequestOptions();
            this.UpdateABatchOfNumbersOptions = new UpdateABatchOfNumbersOptions()
            {
                PhoneNumber = {},
                BillingGroupId = "dc8e4d67-33a0-4cbb-af74-7b58f05bd494",
                ConnectionId = "dc8e4d67-33a0-4cbb-af74-7b58f05bd494",
                CustomerReference = "customer-reference",
                ExternalPin = "123456",
                Tags = {},

            };
        }

        [Fact]
        public void Update()
        {
            var result = this.service.UpdateABatchOfNumbers(this.UpdateABatchOfNumbersOptions, this.requestOptions);
            Assert.NotNull(result);
            Assert.Equal(typeof(PhoneNumber), result.GetType());
        }

        [Fact]
        public async Task UpdateSync()
        {
            var cts = new CancellationTokenSource();
            var result = await this.service.UpdateABatchOfNumbersAsync(this.UpdateABatchOfNumbersOptions, this.requestOptions, cts.Token);
            Assert.NotNull(result);
            Assert.Equal(typeof(PhoneNumber), result.GetType());
        }
    }
}
