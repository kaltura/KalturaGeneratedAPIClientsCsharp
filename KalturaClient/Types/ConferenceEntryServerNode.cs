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
	public class ConferenceEntryServerNode : EntryServerNode
	{
		#region Constants
		public const string CONF_ROOM_STATUS = "confRoomStatus";
		public const string REGISTERED = "registered";
		#endregion

		#region Private Fields
		private ConferenceRoomStatus _ConfRoomStatus = (ConferenceRoomStatus)Int32.MinValue;
		private int _Registered = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use ConfRoomStatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ConferenceRoomStatus ConfRoomStatus
		{
			get { return _ConfRoomStatus; }
			private set 
			{ 
				_ConfRoomStatus = value;
				OnPropertyChanged("ConfRoomStatus");
			}
		}
		/// <summary>
		/// Use RegisteredAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Registered
		{
			get { return _Registered; }
			private set 
			{ 
				_Registered = value;
				OnPropertyChanged("Registered");
			}
		}
		#endregion

		#region CTor
		public ConferenceEntryServerNode()
		{
		}

		public ConferenceEntryServerNode(JToken node) : base(node)
		{
			if(node["confRoomStatus"] != null)
			{
				this._ConfRoomStatus = (ConferenceRoomStatus)ParseEnum(typeof(ConferenceRoomStatus), node["confRoomStatus"].Value<string>());
			}
			if(node["registered"] != null)
			{
				this._Registered = ParseInt(node["registered"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaConferenceEntryServerNode");
			kparams.AddIfNotNull("confRoomStatus", this._ConfRoomStatus);
			kparams.AddIfNotNull("registered", this._Registered);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CONF_ROOM_STATUS:
					return "ConfRoomStatus";
				case REGISTERED:
					return "Registered";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

