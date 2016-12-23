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
// Copyright (C) 2006-2016  Kaltura Inc.
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
	public class ModifyEntryObjectTask : ObjectTask
	{
		#region Constants
		public const string INPUT_METADATA_PROFILE_ID = "inputMetadataProfileId";
		public const string INPUT_METADATA = "inputMetadata";
		public const string OUTPUT_METADATA_PROFILE_ID = "outputMetadataProfileId";
		public const string OUTPUT_METADATA = "outputMetadata";
		public const string INPUT_USER_ID = "inputUserId";
		public const string INPUT_ENTITLED_USERS_EDIT = "inputEntitledUsersEdit";
		public const string INPUT_ENTITLED_USERS_PUBLISH = "inputEntitledUsersPublish";
		#endregion

		#region Private Fields
		private int _InputMetadataProfileId = Int32.MinValue;
		private IList<KeyValue> _InputMetadata;
		private int _OutputMetadataProfileId = Int32.MinValue;
		private IList<KeyValue> _OutputMetadata;
		private string _InputUserId = null;
		private string _InputEntitledUsersEdit = null;
		private string _InputEntitledUsersPublish = null;
		#endregion

		#region Properties
		public int InputMetadataProfileId
		{
			get { return _InputMetadataProfileId; }
			set 
			{ 
				_InputMetadataProfileId = value;
				OnPropertyChanged("InputMetadataProfileId");
			}
		}
		public IList<KeyValue> InputMetadata
		{
			get { return _InputMetadata; }
			set 
			{ 
				_InputMetadata = value;
				OnPropertyChanged("InputMetadata");
			}
		}
		public int OutputMetadataProfileId
		{
			get { return _OutputMetadataProfileId; }
			set 
			{ 
				_OutputMetadataProfileId = value;
				OnPropertyChanged("OutputMetadataProfileId");
			}
		}
		public IList<KeyValue> OutputMetadata
		{
			get { return _OutputMetadata; }
			set 
			{ 
				_OutputMetadata = value;
				OnPropertyChanged("OutputMetadata");
			}
		}
		public string InputUserId
		{
			get { return _InputUserId; }
			set 
			{ 
				_InputUserId = value;
				OnPropertyChanged("InputUserId");
			}
		}
		public string InputEntitledUsersEdit
		{
			get { return _InputEntitledUsersEdit; }
			set 
			{ 
				_InputEntitledUsersEdit = value;
				OnPropertyChanged("InputEntitledUsersEdit");
			}
		}
		public string InputEntitledUsersPublish
		{
			get { return _InputEntitledUsersPublish; }
			set 
			{ 
				_InputEntitledUsersPublish = value;
				OnPropertyChanged("InputEntitledUsersPublish");
			}
		}
		#endregion

		#region CTor
		public ModifyEntryObjectTask()
		{
		}

		public ModifyEntryObjectTask(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "inputMetadataProfileId":
						this._InputMetadataProfileId = ParseInt(propertyNode.InnerText);
						continue;
					case "inputMetadata":
						this._InputMetadata = new List<KeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._InputMetadata.Add(ObjectFactory.Create<KeyValue>(arrayNode));
						}
						continue;
					case "outputMetadataProfileId":
						this._OutputMetadataProfileId = ParseInt(propertyNode.InnerText);
						continue;
					case "outputMetadata":
						this._OutputMetadata = new List<KeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._OutputMetadata.Add(ObjectFactory.Create<KeyValue>(arrayNode));
						}
						continue;
					case "inputUserId":
						this._InputUserId = propertyNode.InnerText;
						continue;
					case "inputEntitledUsersEdit":
						this._InputEntitledUsersEdit = propertyNode.InnerText;
						continue;
					case "inputEntitledUsersPublish":
						this._InputEntitledUsersPublish = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaModifyEntryObjectTask");
			kparams.AddIfNotNull("inputMetadataProfileId", this._InputMetadataProfileId);
			kparams.AddIfNotNull("inputMetadata", this._InputMetadata);
			kparams.AddIfNotNull("outputMetadataProfileId", this._OutputMetadataProfileId);
			kparams.AddIfNotNull("outputMetadata", this._OutputMetadata);
			kparams.AddIfNotNull("inputUserId", this._InputUserId);
			kparams.AddIfNotNull("inputEntitledUsersEdit", this._InputEntitledUsersEdit);
			kparams.AddIfNotNull("inputEntitledUsersPublish", this._InputEntitledUsersPublish);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case INPUT_METADATA_PROFILE_ID:
					return "InputMetadataProfileId";
				case INPUT_METADATA:
					return "InputMetadata";
				case OUTPUT_METADATA_PROFILE_ID:
					return "OutputMetadataProfileId";
				case OUTPUT_METADATA:
					return "OutputMetadata";
				case INPUT_USER_ID:
					return "InputUserId";
				case INPUT_ENTITLED_USERS_EDIT:
					return "InputEntitledUsersEdit";
				case INPUT_ENTITLED_USERS_PUBLISH:
					return "InputEntitledUsersPublish";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

