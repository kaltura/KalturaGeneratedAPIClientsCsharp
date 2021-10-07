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
	public class IntegrationSetting : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string STATUS = "status";
		public const string DEFAULT_USER_ID = "defaultUserId";
		public const string ACCOUNT_ID = "accountId";
		public const string CREATE_USER_IF_NOT_EXIST = "createUserIfNotExist";
		public const string CONVERSION_PROFILE_ID = "conversionProfileId";
		public const string HANDLE_PARTICIPANTS_MODE = "handleParticipantsMode";
		public const string DELETION_POLICY = "deletionPolicy";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string PARTNER_ID = "partnerId";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private VendorIntegrationStatus _Status = (VendorIntegrationStatus)Int32.MinValue;
		private string _DefaultUserId = null;
		private string _AccountId = null;
		private NullableBoolean _CreateUserIfNotExist = (NullableBoolean)Int32.MinValue;
		private int _ConversionProfileId = Int32.MinValue;
		private HandleParticipantsMode _HandleParticipantsMode = (HandleParticipantsMode)Int32.MinValue;
		private NullableBoolean _DeletionPolicy = (NullableBoolean)Int32.MinValue;
		private string _CreatedAt = null;
		private string _UpdatedAt = null;
		private int _PartnerId = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public VendorIntegrationStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use DefaultUserIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DefaultUserId
		{
			get { return _DefaultUserId; }
			set 
			{ 
				_DefaultUserId = value;
				OnPropertyChanged("DefaultUserId");
			}
		}
		/// <summary>
		/// Use AccountIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AccountId
		{
			get { return _AccountId; }
			private set 
			{ 
				_AccountId = value;
				OnPropertyChanged("AccountId");
			}
		}
		/// <summary>
		/// Use CreateUserIfNotExistAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean CreateUserIfNotExist
		{
			get { return _CreateUserIfNotExist; }
			set 
			{ 
				_CreateUserIfNotExist = value;
				OnPropertyChanged("CreateUserIfNotExist");
			}
		}
		/// <summary>
		/// Use ConversionProfileIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ConversionProfileId
		{
			get { return _ConversionProfileId; }
			set 
			{ 
				_ConversionProfileId = value;
				OnPropertyChanged("ConversionProfileId");
			}
		}
		/// <summary>
		/// Use HandleParticipantsModeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public HandleParticipantsMode HandleParticipantsMode
		{
			get { return _HandleParticipantsMode; }
			set 
			{ 
				_HandleParticipantsMode = value;
				OnPropertyChanged("HandleParticipantsMode");
			}
		}
		/// <summary>
		/// Use DeletionPolicyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean DeletionPolicy
		{
			get { return _DeletionPolicy; }
			set 
			{ 
				_DeletionPolicy = value;
				OnPropertyChanged("DeletionPolicy");
			}
		}
		/// <summary>
		/// Use CreatedAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CreatedAt
		{
			get { return _CreatedAt; }
			private set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		/// <summary>
		/// Use UpdatedAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UpdatedAt
		{
			get { return _UpdatedAt; }
			private set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		/// <summary>
		/// Use PartnerIdAsDouble property instead
		/// </summary>
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
		#endregion

		#region CTor
		public IntegrationSetting()
		{
		}

		public IntegrationSetting(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (VendorIntegrationStatus)ParseEnum(typeof(VendorIntegrationStatus), node["status"].Value<string>());
			}
			if(node["defaultUserId"] != null)
			{
				this._DefaultUserId = node["defaultUserId"].Value<string>();
			}
			if(node["accountId"] != null)
			{
				this._AccountId = node["accountId"].Value<string>();
			}
			if(node["createUserIfNotExist"] != null)
			{
				this._CreateUserIfNotExist = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["createUserIfNotExist"].Value<string>());
			}
			if(node["conversionProfileId"] != null)
			{
				this._ConversionProfileId = ParseInt(node["conversionProfileId"].Value<string>());
			}
			if(node["handleParticipantsMode"] != null)
			{
				this._HandleParticipantsMode = (HandleParticipantsMode)ParseEnum(typeof(HandleParticipantsMode), node["handleParticipantsMode"].Value<string>());
			}
			if(node["deletionPolicy"] != null)
			{
				this._DeletionPolicy = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["deletionPolicy"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = node["createdAt"].Value<string>();
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = node["updatedAt"].Value<string>();
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaIntegrationSetting");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("defaultUserId", this._DefaultUserId);
			kparams.AddIfNotNull("accountId", this._AccountId);
			kparams.AddIfNotNull("createUserIfNotExist", this._CreateUserIfNotExist);
			kparams.AddIfNotNull("conversionProfileId", this._ConversionProfileId);
			kparams.AddIfNotNull("handleParticipantsMode", this._HandleParticipantsMode);
			kparams.AddIfNotNull("deletionPolicy", this._DeletionPolicy);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case STATUS:
					return "Status";
				case DEFAULT_USER_ID:
					return "DefaultUserId";
				case ACCOUNT_ID:
					return "AccountId";
				case CREATE_USER_IF_NOT_EXIST:
					return "CreateUserIfNotExist";
				case CONVERSION_PROFILE_ID:
					return "ConversionProfileId";
				case HANDLE_PARTICIPANTS_MODE:
					return "HandleParticipantsMode";
				case DELETION_POLICY:
					return "DeletionPolicy";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case PARTNER_ID:
					return "PartnerId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

