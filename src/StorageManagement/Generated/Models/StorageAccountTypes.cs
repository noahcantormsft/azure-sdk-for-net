// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.WindowsAzure.Management.Storage.Models
{
    /// <summary>
    /// Specifies whether the account supports locally-redundant storage,
    /// geo-redundant storage, zone-redundant storage, or read access
    /// geo-redundant storage. Possible values are:'Standard_LRS',
    /// 'Standard_ZRS', 'Standard_GRS', and 'Standard_RAGRS'.
    /// </summary>
    public static partial class StorageAccountTypes
    {
        public const string StandardLRS = "Standard_LRS";
        
        public const string StandardZRS = "Standard_ZRS";
        
        public const string StandardGRS = "Standard_GRS";
        
        public const string StandardRAGRS = "Standard_RAGRS";
    }
}
