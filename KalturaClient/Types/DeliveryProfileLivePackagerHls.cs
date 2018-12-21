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
using Kaltura.Enums;
using Kaltura.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class DeliveryProfileLivePackagerHls : DeliveryProfileLivePackager
	{
		#region Constants
		public const string DISABLE_EXTRA_ATTRIBUTES = "disableExtraAttributes";
		public const string FORCE_PROXY = "forceProxy";
		#endregion

		#region Private Fields
		private bool? _DisableExtraAttributes = null;
		private bool? _ForceProxy = null;
		#endregion

		#region Properties
		[JsonProperty]
		public bool? DisableExtraAttributes
		{
			get { return _DisableExtraAttributes; }
			set 
			{ 
				_DisableExtraAttributes = value;
				OnPropertyChanged("DisableExtraAttributes");
			}
		}
		[JsonProperty]
		public bool? ForceProxy
		{
			get { return _ForceProxy; }
			set 
			{ 
				_ForceProxy = value;
				OnPropertyChanged("ForceProxy");
			}
		}
		#endregion

		#region CTor
		public DeliveryProfileLivePackagerHls()
		{
		}

		public DeliveryProfileLivePackagerHls(JToken node) : base(node)
		{
			if(node["disableExtraAttributes"] != null)
			{
				this._DisableExtraAttributes = ParseBool(node["disableExtraAttributes"].Value<string>());
			}
			if(node["forceProxy"] != null)
			{
				this._ForceProxy = ParseBool(node["forceProxy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDeliveryProfileLivePackagerHls");
			kparams.AddIfNotNull("disableExtraAttributes", this._DisableExtraAttributes);
			kparams.AddIfNotNull("forceProxy", this._ForceProxy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DISABLE_EXTRA_ATTRIBUTES:
					return "DisableExtraAttributes";
				case FORCE_PROXY:
					return "ForceProxy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

