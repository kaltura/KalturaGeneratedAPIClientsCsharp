// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platfroms allow them to do with
// text.
//
// Copyright (C) 2006-2017  Kaltura Inc.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// @ignore
// ===================================================================================================
using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;

namespace Kaltura.Services
{
	public class EntitlementCancelRequestBuilder : StandaloneRequestBuilder<bool>
	{
		#region Constants
		public const string ASSET_ID = "assetId";
		public const string TRANSACTION_TYPE = "transactionType";
		#endregion

		public int AssetId
		{
			set;
			get;
		}
		public TransactionType TransactionType
		{
			set;
			get;
		}

		public EntitlementCancelRequestBuilder()
			: base("entitlement", "cancel")
		{
		}

		public EntitlementCancelRequestBuilder(int assetId, TransactionType transactionType)
			: this()
		{
			this.AssetId = assetId;
			this.TransactionType = transactionType;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("assetId"))
				kparams.AddIfNotNull("assetId", AssetId);
			if (!isMapped("transactionType"))
				kparams.AddIfNotNull("transactionType", TransactionType);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			if (result.InnerText.Equals("1") || result.InnerText.ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class EntitlementCancelRenewalRequestBuilder : StandaloneRequestBuilder<object>
	{
		#region Constants
		public const string SUBSCRIPTION_ID = "subscriptionId";
		#endregion

		public string SubscriptionId
		{
			set;
			get;
		}

		public EntitlementCancelRenewalRequestBuilder()
			: base("entitlement", "cancelRenewal")
		{
		}

		public EntitlementCancelRenewalRequestBuilder(string subscriptionId)
			: this()
		{
			this.SubscriptionId = subscriptionId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("subscriptionId"))
				kparams.AddIfNotNull("subscriptionId", SubscriptionId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return null;
		}
	}

	public class EntitlementExternalReconcileRequestBuilder : StandaloneRequestBuilder<bool>
	{
		#region Constants
		#endregion


		public EntitlementExternalReconcileRequestBuilder()
			: base("entitlement", "externalReconcile")
		{
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			if (result.InnerText.Equals("1") || result.InnerText.ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class EntitlementForceCancelRequestBuilder : StandaloneRequestBuilder<bool>
	{
		#region Constants
		public const string ASSET_ID = "assetId";
		public const string TRANSACTION_TYPE = "transactionType";
		#endregion

		public int AssetId
		{
			set;
			get;
		}
		public TransactionType TransactionType
		{
			set;
			get;
		}

		public EntitlementForceCancelRequestBuilder()
			: base("entitlement", "forceCancel")
		{
		}

		public EntitlementForceCancelRequestBuilder(int assetId, TransactionType transactionType)
			: this()
		{
			this.AssetId = assetId;
			this.TransactionType = transactionType;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("assetId"))
				kparams.AddIfNotNull("assetId", AssetId);
			if (!isMapped("transactionType"))
				kparams.AddIfNotNull("transactionType", TransactionType);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			if (result.InnerText.Equals("1") || result.InnerText.ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class EntitlementGrantRequestBuilder : StandaloneRequestBuilder<bool>
	{
		#region Constants
		public const string PRODUCT_ID = "productId";
		public const string PRODUCT_TYPE = "productType";
		public const string HISTORY = "history";
		public const string CONTENT_ID = "contentId";
		#endregion

		public int ProductId
		{
			set;
			get;
		}
		public TransactionType ProductType
		{
			set;
			get;
		}
		public bool History
		{
			set;
			get;
		}
		public int ContentId
		{
			set;
			get;
		}

		public EntitlementGrantRequestBuilder()
			: base("entitlement", "grant")
		{
		}

		public EntitlementGrantRequestBuilder(int productId, TransactionType productType, bool history, int contentId)
			: this()
		{
			this.ProductId = productId;
			this.ProductType = productType;
			this.History = history;
			this.ContentId = contentId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("productId"))
				kparams.AddIfNotNull("productId", ProductId);
			if (!isMapped("productType"))
				kparams.AddIfNotNull("productType", ProductType);
			if (!isMapped("history"))
				kparams.AddIfNotNull("history", History);
			if (!isMapped("contentId"))
				kparams.AddIfNotNull("contentId", ContentId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			if (result.InnerText.Equals("1") || result.InnerText.ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class EntitlementListRequestBuilder : StandaloneRequestBuilder<ListResponse<Entitlement>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public EntitlementFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public EntitlementListRequestBuilder()
			: base("entitlement", "list")
		{
		}

		public EntitlementListRequestBuilder(EntitlementFilter filter, FilterPager pager)
			: this()
		{
			this.Filter = filter;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ListResponse<Entitlement>>(result);
		}
	}


	public class EntitlementService
	{
		private EntitlementService()
		{
		}

		public static EntitlementCancelRequestBuilder Cancel(int assetId, TransactionType transactionType)
		{
			return new EntitlementCancelRequestBuilder(assetId, transactionType);
		}

		public static EntitlementCancelRenewalRequestBuilder CancelRenewal(string subscriptionId)
		{
			return new EntitlementCancelRenewalRequestBuilder(subscriptionId);
		}

		public static EntitlementExternalReconcileRequestBuilder ExternalReconcile()
		{
			return new EntitlementExternalReconcileRequestBuilder();
		}

		public static EntitlementForceCancelRequestBuilder ForceCancel(int assetId, TransactionType transactionType)
		{
			return new EntitlementForceCancelRequestBuilder(assetId, transactionType);
		}

		public static EntitlementGrantRequestBuilder Grant(int productId, TransactionType productType, bool history, int contentId = 0)
		{
			return new EntitlementGrantRequestBuilder(productId, productType, history, contentId);
		}

		public static EntitlementListRequestBuilder List(EntitlementFilter filter, FilterPager pager = null)
		{
			return new EntitlementListRequestBuilder(filter, pager);
		}
	}
}
