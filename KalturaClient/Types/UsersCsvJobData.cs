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
	public class UsersCsvJobData : JobData
	{
		#region Constants
		public const string FILTER = "filter";
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		public const string ADDITIONAL_FIELDS = "additionalFields";
		public const string USER_NAME = "userName";
		public const string USER_MAIL = "userMail";
		public const string OUTPUT_PATH = "outputPath";
		#endregion

		#region Private Fields
		private UserFilter _Filter;
		private int _MetadataProfileId = Int32.MinValue;
		private IList<CsvAdditionalFieldInfo> _AdditionalFields;
		private string _UserName = null;
		private string _UserMail = null;
		private string _OutputPath = null;
		#endregion

		#region Properties
		[JsonProperty]
		public UserFilter Filter
		{
			get { return _Filter; }
			set 
			{ 
				_Filter = value;
				OnPropertyChanged("Filter");
			}
		}
		[JsonProperty]
		public int MetadataProfileId
		{
			get { return _MetadataProfileId; }
			set 
			{ 
				_MetadataProfileId = value;
				OnPropertyChanged("MetadataProfileId");
			}
		}
		[JsonProperty]
		public IList<CsvAdditionalFieldInfo> AdditionalFields
		{
			get { return _AdditionalFields; }
			set 
			{ 
				_AdditionalFields = value;
				OnPropertyChanged("AdditionalFields");
			}
		}
		[JsonProperty]
		public string UserName
		{
			get { return _UserName; }
			set 
			{ 
				_UserName = value;
				OnPropertyChanged("UserName");
			}
		}
		[JsonProperty]
		public string UserMail
		{
			get { return _UserMail; }
			set 
			{ 
				_UserMail = value;
				OnPropertyChanged("UserMail");
			}
		}
		[JsonProperty]
		public string OutputPath
		{
			get { return _OutputPath; }
			set 
			{ 
				_OutputPath = value;
				OnPropertyChanged("OutputPath");
			}
		}
		#endregion

		#region CTor
		public UsersCsvJobData()
		{
		}

		public UsersCsvJobData(JToken node) : base(node)
		{
			if(node["filter"] != null)
			{
				this._Filter = ObjectFactory.Create<UserFilter>(node["filter"]);
			}
			if(node["metadataProfileId"] != null)
			{
				this._MetadataProfileId = ParseInt(node["metadataProfileId"].Value<string>());
			}
			if(node["additionalFields"] != null)
			{
				this._AdditionalFields = new List<CsvAdditionalFieldInfo>();
				foreach(var arrayNode in node["additionalFields"].Children())
				{
					this._AdditionalFields.Add(ObjectFactory.Create<CsvAdditionalFieldInfo>(arrayNode));
				}
			}
			if(node["userName"] != null)
			{
				this._UserName = node["userName"].Value<string>();
			}
			if(node["userMail"] != null)
			{
				this._UserMail = node["userMail"].Value<string>();
			}
			if(node["outputPath"] != null)
			{
				this._OutputPath = node["outputPath"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUsersCsvJobData");
			kparams.AddIfNotNull("filter", this._Filter);
			kparams.AddIfNotNull("metadataProfileId", this._MetadataProfileId);
			kparams.AddIfNotNull("additionalFields", this._AdditionalFields);
			kparams.AddIfNotNull("userName", this._UserName);
			kparams.AddIfNotNull("userMail", this._UserMail);
			kparams.AddIfNotNull("outputPath", this._OutputPath);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FILTER:
					return "Filter";
				case METADATA_PROFILE_ID:
					return "MetadataProfileId";
				case ADDITIONAL_FIELDS:
					return "AdditionalFields";
				case USER_NAME:
					return "UserName";
				case USER_MAIL:
					return "UserMail";
				case OUTPUT_PATH:
					return "OutputPath";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

