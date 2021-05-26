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
		public const string INPUT_ENTITLED_USERS_VIEW = "inputEntitledUsersView";
		public const string RESET_MEDIA_REPURPOSING_PROCESS = "resetMediaRepurposingProcess";
		#endregion

		#region Private Fields
		private int _InputMetadataProfileId = Int32.MinValue;
		private IList<KeyValue> _InputMetadata;
		private int _OutputMetadataProfileId = Int32.MinValue;
		private IList<KeyValue> _OutputMetadata;
		private string _InputUserId = null;
		private string _InputEntitledUsersEdit = null;
		private string _InputEntitledUsersPublish = null;
		private string _InputEntitledUsersView = null;
		private bool? _ResetMediaRepurposingProcess = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int InputMetadataProfileId
		{
			get { return _InputMetadataProfileId; }
			set 
			{ 
				_InputMetadataProfileId = value;
				OnPropertyChanged("InputMetadataProfileId");
			}
		}
		[JsonProperty]
		public IList<KeyValue> InputMetadata
		{
			get { return _InputMetadata; }
			set 
			{ 
				_InputMetadata = value;
				OnPropertyChanged("InputMetadata");
			}
		}
		[JsonProperty]
		public int OutputMetadataProfileId
		{
			get { return _OutputMetadataProfileId; }
			set 
			{ 
				_OutputMetadataProfileId = value;
				OnPropertyChanged("OutputMetadataProfileId");
			}
		}
		[JsonProperty]
		public IList<KeyValue> OutputMetadata
		{
			get { return _OutputMetadata; }
			set 
			{ 
				_OutputMetadata = value;
				OnPropertyChanged("OutputMetadata");
			}
		}
		[JsonProperty]
		public string InputUserId
		{
			get { return _InputUserId; }
			set 
			{ 
				_InputUserId = value;
				OnPropertyChanged("InputUserId");
			}
		}
		[JsonProperty]
		public string InputEntitledUsersEdit
		{
			get { return _InputEntitledUsersEdit; }
			set 
			{ 
				_InputEntitledUsersEdit = value;
				OnPropertyChanged("InputEntitledUsersEdit");
			}
		}
		[JsonProperty]
		public string InputEntitledUsersPublish
		{
			get { return _InputEntitledUsersPublish; }
			set 
			{ 
				_InputEntitledUsersPublish = value;
				OnPropertyChanged("InputEntitledUsersPublish");
			}
		}
		[JsonProperty]
		public string InputEntitledUsersView
		{
			get { return _InputEntitledUsersView; }
			set 
			{ 
				_InputEntitledUsersView = value;
				OnPropertyChanged("InputEntitledUsersView");
			}
		}
		[JsonProperty]
		public bool? ResetMediaRepurposingProcess
		{
			get { return _ResetMediaRepurposingProcess; }
			set 
			{ 
				_ResetMediaRepurposingProcess = value;
				OnPropertyChanged("ResetMediaRepurposingProcess");
			}
		}
		#endregion

		#region CTor
		public ModifyEntryObjectTask()
		{
		}

		public ModifyEntryObjectTask(JToken node) : base(node)
		{
			if(node["inputMetadataProfileId"] != null)
			{
				this._InputMetadataProfileId = ParseInt(node["inputMetadataProfileId"].Value<string>());
			}
			if(node["inputMetadata"] != null)
			{
				this._InputMetadata = new List<KeyValue>();
				foreach(var arrayNode in node["inputMetadata"].Children())
				{
					this._InputMetadata.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
			if(node["outputMetadataProfileId"] != null)
			{
				this._OutputMetadataProfileId = ParseInt(node["outputMetadataProfileId"].Value<string>());
			}
			if(node["outputMetadata"] != null)
			{
				this._OutputMetadata = new List<KeyValue>();
				foreach(var arrayNode in node["outputMetadata"].Children())
				{
					this._OutputMetadata.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
			if(node["inputUserId"] != null)
			{
				this._InputUserId = node["inputUserId"].Value<string>();
			}
			if(node["inputEntitledUsersEdit"] != null)
			{
				this._InputEntitledUsersEdit = node["inputEntitledUsersEdit"].Value<string>();
			}
			if(node["inputEntitledUsersPublish"] != null)
			{
				this._InputEntitledUsersPublish = node["inputEntitledUsersPublish"].Value<string>();
			}
			if(node["inputEntitledUsersView"] != null)
			{
				this._InputEntitledUsersView = node["inputEntitledUsersView"].Value<string>();
			}
			if(node["resetMediaRepurposingProcess"] != null)
			{
				this._ResetMediaRepurposingProcess = ParseBool(node["resetMediaRepurposingProcess"].Value<string>());
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
			kparams.AddIfNotNull("inputEntitledUsersView", this._InputEntitledUsersView);
			kparams.AddIfNotNull("resetMediaRepurposingProcess", this._ResetMediaRepurposingProcess);
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
				case INPUT_ENTITLED_USERS_VIEW:
					return "InputEntitledUsersView";
				case RESET_MEDIA_REPURPOSING_PROCESS:
					return "ResetMediaRepurposingProcess";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

