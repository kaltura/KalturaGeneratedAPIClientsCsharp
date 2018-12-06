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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class AsperaGetFaspUrlRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string FLAVOR_ASSET_ID = "flavorAssetId";
		#endregion

		public string FlavorAssetId
		{
			set;
			get;
		}

		public AsperaGetFaspUrlRequestBuilder()
			: base("aspera_aspera", "getFaspUrl")
		{
		}

		public AsperaGetFaspUrlRequestBuilder(string flavorAssetId)
			: this()
		{
			this.FlavorAssetId = flavorAssetId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("flavorAssetId"))
				kparams.AddIfNotNull("flavorAssetId", FlavorAssetId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return result.InnerText;
		}
		public override object DeserializeObject(object result)
		{
			return (string)result;
		}
	}


	public class AsperaService
	{
		private AsperaService()
		{
		}

		public static AsperaGetFaspUrlRequestBuilder GetFaspUrl(string flavorAssetId)
		{
			return new AsperaGetFaspUrlRequestBuilder(flavorAssetId);
		}
	}
}
