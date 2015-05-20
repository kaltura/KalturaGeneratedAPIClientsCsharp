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
// Copyright (C) 2006-2015  Kaltura Inc.
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

namespace Kaltura
{
	public class KalturaModerationFlag : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _UserId = null;
		private KalturaModerationObjectType _ModerationObjectType = null;
		private string _FlaggedEntryId = null;
		private string _FlaggedUserId = null;
		private KalturaModerationFlagStatus _Status = null;
		private string _Comments = null;
		private KalturaModerationFlagType _FlagType = (KalturaModerationFlagType)Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public string UserId
		{
			get { return _UserId; }
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		public KalturaModerationObjectType ModerationObjectType
		{
			get { return _ModerationObjectType; }
			set 
			{ 
				_ModerationObjectType = value;
				OnPropertyChanged("ModerationObjectType");
			}
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
		public KalturaModerationFlagStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
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
		public KalturaModerationFlagType FlagType
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
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		#endregion

		#region CTor
		public KalturaModerationFlag()
		{
		}

		public KalturaModerationFlag(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "userId":
						this.UserId = txt;
						continue;
					case "moderationObjectType":
						this.ModerationObjectType = (KalturaModerationObjectType)KalturaStringEnum.Parse(typeof(KalturaModerationObjectType), txt);
						continue;
					case "flaggedEntryId":
						this.FlaggedEntryId = txt;
						continue;
					case "flaggedUserId":
						this.FlaggedUserId = txt;
						continue;
					case "status":
						this.Status = (KalturaModerationFlagStatus)KalturaStringEnum.Parse(typeof(KalturaModerationFlagStatus), txt);
						continue;
					case "comments":
						this.Comments = txt;
						continue;
					case "flagType":
						this.FlagType = (KalturaModerationFlagType)ParseEnum(typeof(KalturaModerationFlagType), txt);
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaModerationFlag");
			kparams.AddIntIfNotNull("id", this.Id);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddStringIfNotNull("userId", this.UserId);
			kparams.AddStringEnumIfNotNull("moderationObjectType", this.ModerationObjectType);
			kparams.AddStringIfNotNull("flaggedEntryId", this.FlaggedEntryId);
			kparams.AddStringIfNotNull("flaggedUserId", this.FlaggedUserId);
			kparams.AddStringEnumIfNotNull("status", this.Status);
			kparams.AddStringIfNotNull("comments", this.Comments);
			kparams.AddEnumIfNotNull("flagType", this.FlagType);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIntIfNotNull("updatedAt", this.UpdatedAt);
			return kparams;
		}
		#endregion
	}
}

