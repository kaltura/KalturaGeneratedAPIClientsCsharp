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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class SipEntryServerNode : EntryServerNode
	{
		#region Constants
		public const string SIP_ROOM_ID = "sipRoomId";
		public const string SIP_PRIMARY_ADP_ID = "sipPrimaryAdpId";
		public const string SIP_SECONDARY_ADP_ID = "sipSecondaryAdpId";
		#endregion

		#region Private Fields
		private string _SipRoomId = null;
		private string _SipPrimaryAdpId = null;
		private string _SipSecondaryAdpId = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use SipRoomIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SipRoomId
		{
			get { return _SipRoomId; }
			private set 
			{ 
				_SipRoomId = value;
				OnPropertyChanged("SipRoomId");
			}
		}
		/// <summary>
		/// Use SipPrimaryAdpIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SipPrimaryAdpId
		{
			get { return _SipPrimaryAdpId; }
			private set 
			{ 
				_SipPrimaryAdpId = value;
				OnPropertyChanged("SipPrimaryAdpId");
			}
		}
		/// <summary>
		/// Use SipSecondaryAdpIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SipSecondaryAdpId
		{
			get { return _SipSecondaryAdpId; }
			private set 
			{ 
				_SipSecondaryAdpId = value;
				OnPropertyChanged("SipSecondaryAdpId");
			}
		}
		#endregion

		#region CTor
		public SipEntryServerNode()
		{
		}

		public SipEntryServerNode(JToken node) : base(node)
		{
			if(node["sipRoomId"] != null)
			{
				this._SipRoomId = node["sipRoomId"].Value<string>();
			}
			if(node["sipPrimaryAdpId"] != null)
			{
				this._SipPrimaryAdpId = node["sipPrimaryAdpId"].Value<string>();
			}
			if(node["sipSecondaryAdpId"] != null)
			{
				this._SipSecondaryAdpId = node["sipSecondaryAdpId"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSipEntryServerNode");
			kparams.AddIfNotNull("sipRoomId", this._SipRoomId);
			kparams.AddIfNotNull("sipPrimaryAdpId", this._SipPrimaryAdpId);
			kparams.AddIfNotNull("sipSecondaryAdpId", this._SipSecondaryAdpId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SIP_ROOM_ID:
					return "SipRoomId";
				case SIP_PRIMARY_ADP_ID:
					return "SipPrimaryAdpId";
				case SIP_SECONDARY_ADP_ID:
					return "SipSecondaryAdpId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

