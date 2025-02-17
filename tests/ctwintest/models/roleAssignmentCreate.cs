// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace ctwintest.IntegrationTests.Models
{
    public class RoleAssignmentCreate
    {
        public string ObjectId { get; set; }
        public string ObjectIdType { get; set; }
        public string Path { get; set; }
        public string RoleId { get; set; }
        public string TenantId { get; set; }
    }
}