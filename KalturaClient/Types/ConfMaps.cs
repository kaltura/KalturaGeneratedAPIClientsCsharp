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
	public class ConfMaps : ObjectBase
	{
		#region Constants
		public const string NAME = "name";
		public const string CONTENT = "content";
		public const string RAW_DATA = "rawData";
		public const string USER_ID = "userId";
		public const string IS_EDITABLE = "isEditable";
		public const string CREATED_AT = "createdAt";
		public const string RELATED_HOST = "relatedHost";
		public const string VERSION = "version";
		public const string SOURCE_LOCATION = "sourceLocation";
		public const string REMARKS = "remarks";
		public const string STATUS = "status";
		#endregion

		#region Private Fields
		private string _Name = null;
		private string _Content = null;
		private string _RawData = null;
		private string _UserId = null;
		private bool? _IsEditable = null;
		private int _CreatedAt = Int32.MinValue;
		private string _RelatedHost = null;
		private int _Version = Int32.MinValue;
		private ConfMapsSourceLocation _SourceLocation = null;
		private string _Remarks = null;
		private ConfMapsStatus _Status = (ConfMapsStatus)Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		[JsonProperty]
		public string Content
		{
			get { return _Content; }
			set 
			{ 
				_Content = value;
				OnPropertyChanged("Content");
			}
		}
		[JsonProperty]
		public string RawData
		{
			get { return _RawData; }
			set 
			{ 
				_RawData = value;
				OnPropertyChanged("RawData");
			}
		}
		[JsonProperty]
		public string UserId
		{
			get { return _UserId; }
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		[JsonProperty]
		public bool? IsEditable
		{
			get { return _IsEditable; }
			private set 
			{ 
				_IsEditable = value;
				OnPropertyChanged("IsEditable");
			}
		}
		[JsonProperty]
		public int CreatedAt
		{
			get { return _CreatedAt; }
			private set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		[JsonProperty]
		public string RelatedHost
		{
			get { return _RelatedHost; }
			set 
			{ 
				_RelatedHost = value;
				OnPropertyChanged("RelatedHost");
			}
		}
		[JsonProperty]
		public int Version
		{
			get { return _Version; }
			private set 
			{ 
				_Version = value;
				OnPropertyChanged("Version");
			}
		}
		[JsonProperty]
		public ConfMapsSourceLocation SourceLocation
		{
			get { return _SourceLocation; }
			set 
			{ 
				_SourceLocation = value;
				OnPropertyChanged("SourceLocation");
			}
		}
		[JsonProperty]
		public string Remarks
		{
			get { return _Remarks; }
			set 
			{ 
				_Remarks = value;
				OnPropertyChanged("Remarks");
			}
		}
		[JsonProperty]
		public ConfMapsStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		#endregion

		#region CTor
		public ConfMaps()
		{
		}

		public ConfMaps(JToken node) : base(node)
		{
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["content"] != null)
			{
				this._Content = node["content"].Value<string>();
			}
			if(node["rawData"] != null)
			{
				this._RawData = node["rawData"].Value<string>();
			}
			if(node["userId"] != null)
			{
				this._UserId = node["userId"].Value<string>();
			}
			if(node["isEditable"] != null)
			{
				this._IsEditable = ParseBool(node["isEditable"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["relatedHost"] != null)
			{
				this._RelatedHost = node["relatedHost"].Value<string>();
			}
			if(node["version"] != null)
			{
				this._Version = ParseInt(node["version"].Value<string>());
			}
			if(node["sourceLocation"] != null)
			{
				this._SourceLocation = (ConfMapsSourceLocation)StringEnum.Parse(typeof(ConfMapsSourceLocation), node["sourceLocation"].Value<string>());
			}
			if(node["remarks"] != null)
			{
				this._Remarks = node["remarks"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = (ConfMapsStatus)ParseEnum(typeof(ConfMapsStatus), node["status"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaConfMaps");
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("content", this._Content);
			kparams.AddIfNotNull("rawData", this._RawData);
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("isEditable", this._IsEditable);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("relatedHost", this._RelatedHost);
			kparams.AddIfNotNull("version", this._Version);
			kparams.AddIfNotNull("sourceLocation", this._SourceLocation);
			kparams.AddIfNotNull("remarks", this._Remarks);
			kparams.AddIfNotNull("status", this._Status);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case NAME:
					return "Name";
				case CONTENT:
					return "Content";
				case RAW_DATA:
					return "RawData";
				case USER_ID:
					return "UserId";
				case IS_EDITABLE:
					return "IsEditable";
				case CREATED_AT:
					return "CreatedAt";
				case RELATED_HOST:
					return "RelatedHost";
				case VERSION:
					return "Version";
				case SOURCE_LOCATION:
					return "SourceLocation";
				case REMARKS:
					return "Remarks";
				case STATUS:
					return "Status";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

