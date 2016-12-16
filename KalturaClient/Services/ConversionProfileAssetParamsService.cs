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
	public class ConversionProfileAssetParamsListRequestBuilder : RequestBuilder<ListResponse<ConversionProfileAssetParams>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public ConversionProfileAssetParamsFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public ConversionProfileAssetParamsListRequestBuilder()
			: base("conversionprofileassetparams", "list")
		{
		}

		public ConversionProfileAssetParamsListRequestBuilder(ConversionProfileAssetParamsFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<ConversionProfileAssetParams>>(result);
		}
	}

	public class ConversionProfileAssetParamsUpdateRequestBuilder : RequestBuilder<ConversionProfileAssetParams>
	{
		#region Constants
		public const string CONVERSION_PROFILE_ID = "conversionProfileId";
		public const string ASSET_PARAMS_ID = "assetParamsId";
		public const string CONVERSION_PROFILE_ASSET_PARAMS = "conversionProfileAssetParams";
		#endregion

		public int ConversionProfileId
		{
			set;
			get;
		}
		public int AssetParamsId
		{
			set;
			get;
		}
		public ConversionProfileAssetParams ConversionProfileAssetParams
		{
			set;
			get;
		}

		public ConversionProfileAssetParamsUpdateRequestBuilder()
			: base("conversionprofileassetparams", "update")
		{
		}

		public ConversionProfileAssetParamsUpdateRequestBuilder(int conversionProfileId, int assetParamsId, ConversionProfileAssetParams conversionProfileAssetParams)
			: this()
		{
			this.ConversionProfileId = conversionProfileId;
			this.AssetParamsId = assetParamsId;
			this.ConversionProfileAssetParams = conversionProfileAssetParams;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("conversionProfileId"))
				kparams.AddIfNotNull("conversionProfileId", ConversionProfileId);
			if (!isMapped("assetParamsId"))
				kparams.AddIfNotNull("assetParamsId", AssetParamsId);
			if (!isMapped("conversionProfileAssetParams"))
				kparams.AddIfNotNull("conversionProfileAssetParams", ConversionProfileAssetParams);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ConversionProfileAssetParams>(result);
		}
	}


	public class ConversionProfileAssetParamsService
	{
		private ConversionProfileAssetParamsService()
		{
		}

		public static ConversionProfileAssetParamsListRequestBuilder List(ConversionProfileAssetParamsFilter filter = null, FilterPager pager = null)
		{
			return new ConversionProfileAssetParamsListRequestBuilder(filter, pager);
		}

		public static ConversionProfileAssetParamsUpdateRequestBuilder Update(int conversionProfileId, int assetParamsId, ConversionProfileAssetParams conversionProfileAssetParams)
		{
			return new ConversionProfileAssetParamsUpdateRequestBuilder(conversionProfileId, assetParamsId, conversionProfileAssetParams);
		}
	}
}
