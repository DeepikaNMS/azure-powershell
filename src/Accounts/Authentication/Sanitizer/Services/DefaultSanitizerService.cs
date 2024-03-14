﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Security.Utilities;

using System.Collections.Generic;

namespace Microsoft.Azure.Commands.Common.Authentication.Sanitizer.Services
{

    internal class DefaultSanitizerService : ISanitizerService
    {
        private SecretMasker secretMasker =
            new SecretMasker(WellKnownRegexPatterns.HighConfidenceMicrosoftSecurityModels,
                             generateSha256Hashes: true);

        public string SanitizedValue => "******";

        public Dictionary<string, IEnumerable<string>> IgnoredProperties => BuildIgnoredProperties();

        private Dictionary<string, IEnumerable<string>> BuildIgnoredProperties()
        {
            /*
             * This dictionary is used to store the properties that should be ignored during sanitization.
             * The key is the full name of the object type that contains the properties to be ignored.
             * The value is the list of property names that should be ignored.
             */
            return new Dictionary<string, IEnumerable<string>>
            {
                // Skip lazy load properties
                { "Microsoft.Azure.Commands.Management.Storage.Models.PSStorageAccount", new[] { "Context" } },
                { "Microsoft.WindowsAzure.Commands.Common.Storage.ResourceModel.AzureStorageContainer", new[] { "CloudBlobContainer", "Permission" } },
                { "Microsoft.WindowsAzure.Commands.Common.Storage.ResourceModel.AzureStorageBlob", new[] { "BlobProperties" } }
            };
        }

        public bool TrySanitizeData(string data, out string sanitizedData)
        {
            if (!string.IsNullOrWhiteSpace(data))
            {
                sanitizedData = this.secretMasker.MaskSecrets(data);
                return !object.ReferenceEquals(data, sanitizedData);
            }

            sanitizedData = string.Empty;
            return false;
        }
    }
}
