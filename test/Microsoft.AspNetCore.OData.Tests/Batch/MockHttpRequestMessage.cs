﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Net.Http;

namespace Microsoft.AspNetCore.OData.Test.Batch
{
    internal class MockHttpRequestMessage : HttpRequestMessage
    {
        public bool IsDisposed { get; set; }

        protected override void Dispose(bool disposing)
        {
            IsDisposed = true;
        }
    }
}