// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class EntryContext : Context
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string FOLLOW_ENTRY_REDIRECT = "followEntryRedirect";
		#endregion

		#region Private Fields
		private string _EntryId = null;
		private NullableBoolean _FollowEntryRedirect = (NullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use EntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		/// <summary>
		/// Use FollowEntryRedirectAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean FollowEntryRedirect
		{
			get { return _FollowEntryRedirect; }
			set 
			{ 
				_FollowEntryRedirect = value;
				OnPropertyChanged("FollowEntryRedirect");
			}
		}
		#endregion

		#region CTor
		public EntryContext()
		{
		}

		public EntryContext(JToken node) : base(node)
		{
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["followEntryRedirect"] != null)
			{
				this._FollowEntryRedirect = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["followEntryRedirect"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEntryContext");
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("followEntryRedirect", this._FollowEntryRedirect);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ENTRY_ID:
					return "EntryId";
				case FOLLOW_ENTRY_REDIRECT:
					return "FollowEntryRedirect";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

