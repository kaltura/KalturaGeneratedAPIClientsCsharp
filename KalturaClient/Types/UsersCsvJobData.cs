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
		public UserFilter Filter
		{
			get { return _Filter; }
			set 
			{ 
				_Filter = value;
				OnPropertyChanged("Filter");
			}
		}
		public int MetadataProfileId
		{
			get { return _MetadataProfileId; }
			set 
			{ 
				_MetadataProfileId = value;
				OnPropertyChanged("MetadataProfileId");
			}
		}
		public IList<CsvAdditionalFieldInfo> AdditionalFields
		{
			get { return _AdditionalFields; }
			set 
			{ 
				_AdditionalFields = value;
				OnPropertyChanged("AdditionalFields");
			}
		}
		public string UserName
		{
			get { return _UserName; }
			set 
			{ 
				_UserName = value;
				OnPropertyChanged("UserName");
			}
		}
		public string UserMail
		{
			get { return _UserMail; }
			set 
			{ 
				_UserMail = value;
				OnPropertyChanged("UserMail");
			}
		}
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

		public UsersCsvJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "filter":
						this._Filter = ObjectFactory.Create<UserFilter>(propertyNode);
						continue;
					case "metadataProfileId":
						this._MetadataProfileId = ParseInt(propertyNode.InnerText);
						continue;
					case "additionalFields":
						this._AdditionalFields = new List<CsvAdditionalFieldInfo>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._AdditionalFields.Add(ObjectFactory.Create<CsvAdditionalFieldInfo>(arrayNode));
						}
						continue;
					case "userName":
						this._UserName = propertyNode.InnerText;
						continue;
					case "userMail":
						this._UserMail = propertyNode.InnerText;
						continue;
					case "outputPath":
						this._OutputPath = propertyNode.InnerText;
						continue;
				}
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

