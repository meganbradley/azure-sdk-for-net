﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.Storage.Common;

namespace Azure.Storage.DataMovement.Tests
{
    internal class TransferManagerFactory
    {
        private TransferManagerOptions _options;

        public TransferManagerFactory(TransferManagerOptions options)
        {
            Argument.CheckNotNull(options, nameof(options));
            Argument.CheckNotNull(options.CheckpointerOptions, nameof(options.CheckpointerOptions));
            _options = options;
        }

        public TransferManager BuildTransferManager(List<TransferOperation> transfers = default)
        {
            if (transfers != default)
            {
                // populate checkpointer
                Argument.AssertNotNullOrWhiteSpace(_options.CheckpointerOptions.CheckpointerPath, nameof(transfers));
                LocalTransferCheckpointerFactory checkpointerFactory = new LocalTransferCheckpointerFactory(_options.CheckpointerOptions.CheckpointerPath);
                checkpointerFactory.BuildCheckpointer(transfers);
            }
            TransferManager transferManager = new TransferManager(_options);

            return transferManager;
        }
    }
}
