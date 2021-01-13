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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class BusinessProcessNotificationTemplate : EventNotificationTemplate
	{
		#region Constants
		public const string SERVER_ID = "serverId";
		public const string PROCESS_ID = "processId";
		public const string MAIN_OBJECT_CODE = "mainObjectCode";
		#endregion

		#region Private Fields
		private int _ServerId = Int32.MinValue;
		private string _ProcessId = null;
		private string _MainObjectCode = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int ServerId
		{
			get { return _ServerId; }
			set 
			{ 
				_ServerId = value;
				OnPropertyChanged("ServerId");
			}
		}
		[JsonProperty]
		public string ProcessId
		{
			get { return _ProcessId; }
			set 
			{ 
				_ProcessId = value;
				OnPropertyChanged("ProcessId");
			}
		}
		[JsonProperty]
		public string MainObjectCode
		{
			get { return _MainObjectCode; }
			set 
			{ 
				_MainObjectCode = value;
				OnPropertyChanged("MainObjectCode");
			}
		}
		#endregion

		#region CTor
		public BusinessProcessNotificationTemplate()
		{
		}

		public BusinessProcessNotificationTemplate(JToken node) : base(node)
		{
			if(node["serverId"] != null)
			{
				this._ServerId = ParseInt(node["serverId"].Value<string>());
			}
			if(node["processId"] != null)
			{
				this._ProcessId = node["processId"].Value<string>();
			}
			if(node["mainObjectCode"] != null)
			{
				this._MainObjectCode = node["mainObjectCode"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBusinessProcessNotificationTemplate");
			kparams.AddIfNotNull("serverId", this._ServerId);
			kparams.AddIfNotNull("processId", this._ProcessId);
			kparams.AddIfNotNull("mainObjectCode", this._MainObjectCode);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SERVER_ID:
					return "ServerId";
				case PROCESS_ID:
					return "ProcessId";
				case MAIN_OBJECT_CODE:
					return "MainObjectCode";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

