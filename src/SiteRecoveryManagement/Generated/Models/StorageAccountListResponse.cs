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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.SiteRecovery.Models;

namespace Microsoft.WindowsAzure.Management.SiteRecovery.Models
{
    /// <summary>
    /// The List Storage Accounts operation response.
    /// </summary>
    public partial class StorageAccountListResponse : AzureOperationResponse, IEnumerable<StorageAccountListResponse.StorageAccount>
    {
        private IList<StorageAccountListResponse.StorageAccount> _storageAccounts;
        
        /// <summary>
        /// Optional. The requested storage accounts.
        /// </summary>
        public IList<StorageAccountListResponse.StorageAccount> StorageAccounts
        {
            get { return this._storageAccounts; }
            set { this._storageAccounts = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the StorageAccountListResponse class.
        /// </summary>
        public StorageAccountListResponse()
        {
            this.StorageAccounts = new LazyList<StorageAccountListResponse.StorageAccount>();
        }
        
        /// <summary>
        /// Gets the sequence of StorageAccounts.
        /// </summary>
        public IEnumerator<StorageAccountListResponse.StorageAccount> GetEnumerator()
        {
            return this.StorageAccounts.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of StorageAccounts.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// A Storage Service associated with your subscription.
        /// </summary>
        public partial class StorageAccount
        {
            private string _name;
            
            /// <summary>
            /// Optional. The name of the storage account. This name is the DNS
            /// prefix name and can be used to access blobs, queues, and
            /// tables in the storage account. For example, if the service
            /// name is MyStorageAccount, you could access the blob containers
            /// by calling:
            /// http://MyStorageAccount.blob.core.windows.net/mycontainer/.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            private StorageAccountListResponse.StorageAccountProperties _properties;
            
            /// <summary>
            /// Optional. Details about the storage account.
            /// </summary>
            public StorageAccountListResponse.StorageAccountProperties Properties
            {
                get { return this._properties; }
                set { this._properties = value; }
            }
            
            private Uri _uri;
            
            /// <summary>
            /// Optional. The Service Management API request URI used to
            /// perform Get Storage Account Properties requests against the
            /// storage account.
            /// </summary>
            public Uri Uri
            {
                get { return this._uri; }
                set { this._uri = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the StorageAccount class.
            /// </summary>
            public StorageAccount()
            {
            }
        }
        
        /// <summary>
        /// Details about a storage account.
        /// </summary>
        public partial class StorageAccountProperties
        {
            private string _affinityGroup;
            
            /// <summary>
            /// Optional. The affinity group with which this storage account is
            /// associated.
            /// </summary>
            public string AffinityGroup
            {
                get { return this._affinityGroup; }
                set { this._affinityGroup = value; }
            }
            
            private string _description;
            
            /// <summary>
            /// Optional. The user-supplied description of the storage account.
            /// </summary>
            public string Description
            {
                get { return this._description; }
                set { this._description = value; }
            }
            
            private string _location;
            
            /// <summary>
            /// Optional. The geo-location specified when the storage account
            /// was created. This property is only returned if the storage
            /// account is not associated with an affinity group.
            /// </summary>
            public string Location
            {
                get { return this._location; }
                set { this._location = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the StorageAccountProperties
            /// class.
            /// </summary>
            public StorageAccountProperties()
            {
            }
        }
    }
}
