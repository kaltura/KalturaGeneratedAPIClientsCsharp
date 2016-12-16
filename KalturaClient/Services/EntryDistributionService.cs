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
// Copyright (C) 2006-2016  Kaltura Inc.
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
	public class EntryDistributionAddRequestBuilder : RequestBuilder<EntryDistribution>
	{
		#region Constants
		public const string ENTRY_DISTRIBUTION = "entryDistribution";
		#endregion

		public EntryDistribution EntryDistribution
		{
			set;
			get;
		}

		public EntryDistributionAddRequestBuilder()
			: base("contentdistribution_entrydistribution", "add")
		{
		}

		public EntryDistributionAddRequestBuilder(EntryDistribution entryDistribution)
			: this()
		{
			this.EntryDistribution = entryDistribution;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryDistribution"))
				kparams.AddIfNotNull("entryDistribution", EntryDistribution);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<EntryDistribution>(result);
		}
	}

	public class EntryDistributionGetRequestBuilder : RequestBuilder<EntryDistribution>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public EntryDistributionGetRequestBuilder()
			: base("contentdistribution_entrydistribution", "get")
		{
		}

		public EntryDistributionGetRequestBuilder(int id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<EntryDistribution>(result);
		}
	}

	public class EntryDistributionValidateRequestBuilder : RequestBuilder<EntryDistribution>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public EntryDistributionValidateRequestBuilder()
			: base("contentdistribution_entrydistribution", "validate")
		{
		}

		public EntryDistributionValidateRequestBuilder(int id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<EntryDistribution>(result);
		}
	}

	public class EntryDistributionUpdateRequestBuilder : RequestBuilder<EntryDistribution>
	{
		#region Constants
		public const string ID = "id";
		public const string ENTRY_DISTRIBUTION = "entryDistribution";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public EntryDistribution EntryDistribution
		{
			set;
			get;
		}

		public EntryDistributionUpdateRequestBuilder()
			: base("contentdistribution_entrydistribution", "update")
		{
		}

		public EntryDistributionUpdateRequestBuilder(int id, EntryDistribution entryDistribution)
			: this()
		{
			this.Id = id;
			this.EntryDistribution = entryDistribution;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("entryDistribution"))
				kparams.AddIfNotNull("entryDistribution", EntryDistribution);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<EntryDistribution>(result);
		}
	}

	public class EntryDistributionDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public EntryDistributionDeleteRequestBuilder()
			: base("contentdistribution_entrydistribution", "delete")
		{
		}

		public EntryDistributionDeleteRequestBuilder(int id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
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

	public class EntryDistributionListRequestBuilder : RequestBuilder<ListResponse<EntryDistribution>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public EntryDistributionFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public EntryDistributionListRequestBuilder()
			: base("contentdistribution_entrydistribution", "list")
		{
		}

		public EntryDistributionListRequestBuilder(EntryDistributionFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<EntryDistribution>>(result);
		}
	}

	public class EntryDistributionSubmitAddRequestBuilder : RequestBuilder<EntryDistribution>
	{
		#region Constants
		public const string ID = "id";
		public const string SUBMIT_WHEN_READY = "submitWhenReady";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public bool SubmitWhenReady
		{
			set;
			get;
		}

		public EntryDistributionSubmitAddRequestBuilder()
			: base("contentdistribution_entrydistribution", "submitAdd")
		{
		}

		public EntryDistributionSubmitAddRequestBuilder(int id, bool submitWhenReady)
			: this()
		{
			this.Id = id;
			this.SubmitWhenReady = submitWhenReady;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("submitWhenReady"))
				kparams.AddIfNotNull("submitWhenReady", SubmitWhenReady);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<EntryDistribution>(result);
		}
	}

	public class EntryDistributionSubmitUpdateRequestBuilder : RequestBuilder<EntryDistribution>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public EntryDistributionSubmitUpdateRequestBuilder()
			: base("contentdistribution_entrydistribution", "submitUpdate")
		{
		}

		public EntryDistributionSubmitUpdateRequestBuilder(int id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<EntryDistribution>(result);
		}
	}

	public class EntryDistributionSubmitFetchReportRequestBuilder : RequestBuilder<EntryDistribution>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public EntryDistributionSubmitFetchReportRequestBuilder()
			: base("contentdistribution_entrydistribution", "submitFetchReport")
		{
		}

		public EntryDistributionSubmitFetchReportRequestBuilder(int id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<EntryDistribution>(result);
		}
	}

	public class EntryDistributionSubmitDeleteRequestBuilder : RequestBuilder<EntryDistribution>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public EntryDistributionSubmitDeleteRequestBuilder()
			: base("contentdistribution_entrydistribution", "submitDelete")
		{
		}

		public EntryDistributionSubmitDeleteRequestBuilder(int id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<EntryDistribution>(result);
		}
	}

	public class EntryDistributionRetrySubmitRequestBuilder : RequestBuilder<EntryDistribution>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public EntryDistributionRetrySubmitRequestBuilder()
			: base("contentdistribution_entrydistribution", "retrySubmit")
		{
		}

		public EntryDistributionRetrySubmitRequestBuilder(int id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<EntryDistribution>(result);
		}
	}


	public class EntryDistributionService
	{
		private EntryDistributionService()
		{
		}

		public static EntryDistributionAddRequestBuilder Add(EntryDistribution entryDistribution)
		{
			return new EntryDistributionAddRequestBuilder(entryDistribution);
		}

		public static EntryDistributionGetRequestBuilder Get(int id)
		{
			return new EntryDistributionGetRequestBuilder(id);
		}

		public static EntryDistributionValidateRequestBuilder Validate(int id)
		{
			return new EntryDistributionValidateRequestBuilder(id);
		}

		public static EntryDistributionUpdateRequestBuilder Update(int id, EntryDistribution entryDistribution)
		{
			return new EntryDistributionUpdateRequestBuilder(id, entryDistribution);
		}

		public static EntryDistributionDeleteRequestBuilder Delete(int id)
		{
			return new EntryDistributionDeleteRequestBuilder(id);
		}

		public static EntryDistributionListRequestBuilder List(EntryDistributionFilter filter = null, FilterPager pager = null)
		{
			return new EntryDistributionListRequestBuilder(filter, pager);
		}

		public static EntryDistributionSubmitAddRequestBuilder SubmitAdd(int id, bool submitWhenReady = false)
		{
			return new EntryDistributionSubmitAddRequestBuilder(id, submitWhenReady);
		}

		public static EntryDistributionSubmitUpdateRequestBuilder SubmitUpdate(int id)
		{
			return new EntryDistributionSubmitUpdateRequestBuilder(id);
		}

		public static EntryDistributionSubmitFetchReportRequestBuilder SubmitFetchReport(int id)
		{
			return new EntryDistributionSubmitFetchReportRequestBuilder(id);
		}

		public static EntryDistributionSubmitDeleteRequestBuilder SubmitDelete(int id)
		{
			return new EntryDistributionSubmitDeleteRequestBuilder(id);
		}

		public static EntryDistributionRetrySubmitRequestBuilder RetrySubmit(int id)
		{
			return new EntryDistributionRetrySubmitRequestBuilder(id);
		}
	}
}
