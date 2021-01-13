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
	public class ModerationFlag : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string USER_ID = "userId";
		public const string MODERATION_OBJECT_TYPE = "moderationObjectType";
		public const string FLAGGED_ENTRY_ID = "flaggedEntryId";
		public const string FLAGGED_USER_ID = "flaggedUserId";
		public const string STATUS = "status";
		public const string COMMENTS = "comments";
		public const string FLAG_TYPE = "flagType";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _UserId = null;
		private ModerationObjectType _ModerationObjectType = null;
		private string _FlaggedEntryId = null;
		private string _FlaggedUserId = null;
		private ModerationFlagStatus _Status = null;
		private string _Comments = null;
		private ModerationFlagType _FlagType = (ModerationFlagType)Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
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
		public string UserId
		{
			get { return _UserId; }
			private set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		[JsonProperty]
		public ModerationObjectType ModerationObjectType
		{
			get { return _ModerationObjectType; }
			private set 
			{ 
				_ModerationObjectType = value;
				OnPropertyChanged("ModerationObjectType");
			}
		}
		[JsonProperty]
		public string FlaggedEntryId
		{
			get { return _FlaggedEntryId; }
			set 
			{ 
				_FlaggedEntryId = value;
				OnPropertyChanged("FlaggedEntryId");
			}
		}
		[JsonProperty]
		public string FlaggedUserId
		{
			get { return _FlaggedUserId; }
			set 
			{ 
				_FlaggedUserId = value;
				OnPropertyChanged("FlaggedUserId");
			}
		}
		[JsonProperty]
		public ModerationFlagStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		[JsonProperty]
		public string Comments
		{
			get { return _Comments; }
			set 
			{ 
				_Comments = value;
				OnPropertyChanged("Comments");
			}
		}
		[JsonProperty]
		public ModerationFlagType FlagType
		{
			get { return _FlagType; }
			set 
			{ 
				_FlagType = value;
				OnPropertyChanged("FlagType");
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
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			private set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		#endregion

		#region CTor
		public ModerationFlag()
		{
		}

		public ModerationFlag(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["userId"] != null)
			{
				this._UserId = node["userId"].Value<string>();
			}
			if(node["moderationObjectType"] != null)
			{
				this._ModerationObjectType = (ModerationObjectType)StringEnum.Parse(typeof(ModerationObjectType), node["moderationObjectType"].Value<string>());
			}
			if(node["flaggedEntryId"] != null)
			{
				this._FlaggedEntryId = node["flaggedEntryId"].Value<string>();
			}
			if(node["flaggedUserId"] != null)
			{
				this._FlaggedUserId = node["flaggedUserId"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = (ModerationFlagStatus)StringEnum.Parse(typeof(ModerationFlagStatus), node["status"].Value<string>());
			}
			if(node["comments"] != null)
			{
				this._Comments = node["comments"].Value<string>();
			}
			if(node["flagType"] != null)
			{
				this._FlagType = (ModerationFlagType)ParseEnum(typeof(ModerationFlagType), node["flagType"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaModerationFlag");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("moderationObjectType", this._ModerationObjectType);
			kparams.AddIfNotNull("flaggedEntryId", this._FlaggedEntryId);
			kparams.AddIfNotNull("flaggedUserId", this._FlaggedUserId);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("comments", this._Comments);
			kparams.AddIfNotNull("flagType", this._FlagType);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case PARTNER_ID:
					return "PartnerId";
				case USER_ID:
					return "UserId";
				case MODERATION_OBJECT_TYPE:
					return "ModerationObjectType";
				case FLAGGED_ENTRY_ID:
					return "FlaggedEntryId";
				case FLAGGED_USER_ID:
					return "FlaggedUserId";
				case STATUS:
					return "Status";
				case COMMENTS:
					return "Comments";
				case FLAG_TYPE:
					return "FlagType";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

