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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class StartWidgetSessionResponse : ObjectBase
	{
		#region Constants
		public const string PARTNER_ID = "partnerId";
		public const string KS = "ks";
		public const string USER_ID = "userId";
		#endregion

		#region Private Fields
		private int _PartnerId = Int32.MinValue;
		private string _Ks = null;
		private string _UserId = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int PartnerId
		{
			get { return _PartnerId; }
			private set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		[JsonProperty]
		public string Ks
		{
			get { return _Ks; }
			private set 
			{ 
				_Ks = value;
				OnPropertyChanged("Ks");
			}
		}
		[JsonProperty]
		public string UserId
		{
			get { return _UserId; }
			private set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		#endregion

		#region CTor
		public StartWidgetSessionResponse()
		{
		}

		public StartWidgetSessionResponse(JToken node) : base(node)
		{
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["ks"] != null)
			{
				this._Ks = node["ks"].Value<string>();
			}
			if(node["userId"] != null)
			{
				this._UserId = node["userId"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaStartWidgetSessionResponse");
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("ks", this._Ks);
			kparams.AddIfNotNull("userId", this._UserId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARTNER_ID:
					return "PartnerId";
				case KS:
					return "Ks";
				case USER_ID:
					return "UserId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

