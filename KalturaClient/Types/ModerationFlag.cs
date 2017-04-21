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
// Copyright (C) 2006-2017  Kaltura Inc.
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
		public int Id
		{
			get { return _Id; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public string UserId
		{
			get { return _UserId; }
		}
		public ModerationObjectType ModerationObjectType
		{
			get { return _ModerationObjectType; }
		}
		public string FlaggedEntryId
		{
			get { return _FlaggedEntryId; }
			set 
			{ 
				_FlaggedEntryId = value;
				OnPropertyChanged("FlaggedEntryId");
			}
		}
		public string FlaggedUserId
		{
			get { return _FlaggedUserId; }
			set 
			{ 
				_FlaggedUserId = value;
				OnPropertyChanged("FlaggedUserId");
			}
		}
		public ModerationFlagStatus Status
		{
			get { return _Status; }
		}
		public string Comments
		{
			get { return _Comments; }
			set 
			{ 
				_Comments = value;
				OnPropertyChanged("Comments");
			}
		}
		public ModerationFlagType FlagType
		{
			get { return _FlagType; }
			set 
			{ 
				_FlagType = value;
				OnPropertyChanged("FlagType");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		#endregion

		#region CTor
		public ModerationFlag()
		{
		}

		public ModerationFlag(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "userId":
						this._UserId = propertyNode.InnerText;
						continue;
					case "moderationObjectType":
						this._ModerationObjectType = (ModerationObjectType)StringEnum.Parse(typeof(ModerationObjectType), propertyNode.InnerText);
						continue;
					case "flaggedEntryId":
						this._FlaggedEntryId = propertyNode.InnerText;
						continue;
					case "flaggedUserId":
						this._FlaggedUserId = propertyNode.InnerText;
						continue;
					case "status":
						this._Status = (ModerationFlagStatus)StringEnum.Parse(typeof(ModerationFlagStatus), propertyNode.InnerText);
						continue;
					case "comments":
						this._Comments = propertyNode.InnerText;
						continue;
					case "flagType":
						this._FlagType = (ModerationFlagType)ParseEnum(typeof(ModerationFlagType), propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
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

