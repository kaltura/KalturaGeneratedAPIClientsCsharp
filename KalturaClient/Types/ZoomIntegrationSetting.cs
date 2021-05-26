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
	public class ZoomIntegrationSetting : ObjectBase
	{
		#region Constants
		public const string DEFAULT_USER_ID = "defaultUserId";
		public const string ZOOM_CATEGORY = "zoomCategory";
		public const string ACCOUNT_ID = "accountId";
		public const string ENABLE_RECORDING_UPLOAD = "enableRecordingUpload";
		public const string CREATE_USER_IF_NOT_EXIST = "createUserIfNotExist";
		public const string HANDLE_PARTICIPANTS_MODE = "handleParticipantsMode";
		public const string ZOOM_USER_MATCHING_MODE = "zoomUserMatchingMode";
		public const string ZOOM_USER_POSTFIX = "zoomUserPostfix";
		public const string ZOOM_WEBINAR_CATEGORY = "zoomWebinarCategory";
		public const string ENABLE_WEBINAR_UPLOADS = "enableWebinarUploads";
		public const string CONVERSION_PROFILE_ID = "conversionProfileId";
		public const string JWT_TOKEN = "jwtToken";
		public const string DELETION_POLICY = "deletionPolicy";
		public const string ENABLE_ZOOM_TRANSCRIPTION = "enableZoomTranscription";
		public const string ZOOM_ACCOUNT_DESCRIPTION = "zoomAccountDescription";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string ENABLE_MEETING_UPLOAD = "enableMeetingUpload";
		#endregion

		#region Private Fields
		private string _DefaultUserId = null;
		private string _ZoomCategory = null;
		private string _AccountId = null;
		private NullableBoolean _EnableRecordingUpload = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _CreateUserIfNotExist = (NullableBoolean)Int32.MinValue;
		private HandleParticipantsMode _HandleParticipantsMode = (HandleParticipantsMode)Int32.MinValue;
		private ZoomUsersMatching _ZoomUserMatchingMode = (ZoomUsersMatching)Int32.MinValue;
		private string _ZoomUserPostfix = null;
		private string _ZoomWebinarCategory = null;
		private NullableBoolean _EnableWebinarUploads = (NullableBoolean)Int32.MinValue;
		private int _ConversionProfileId = Int32.MinValue;
		private string _JwtToken = null;
		private NullableBoolean _DeletionPolicy = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _EnableZoomTranscription = (NullableBoolean)Int32.MinValue;
		private string _ZoomAccountDescription = null;
		private string _CreatedAt = null;
		private string _UpdatedAt = null;
		private NullableBoolean _EnableMeetingUpload = (NullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
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
		[JsonProperty]
		public string ZoomCategory
		{
			get { return _ZoomCategory; }
			set 
			{ 
				_ZoomCategory = value;
				OnPropertyChanged("ZoomCategory");
			}
		}
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
		[JsonProperty]
		public NullableBoolean EnableRecordingUpload
		{
			get { return _EnableRecordingUpload; }
			set 
			{ 
				_EnableRecordingUpload = value;
				OnPropertyChanged("EnableRecordingUpload");
			}
		}
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
		[JsonProperty]
		public ZoomUsersMatching ZoomUserMatchingMode
		{
			get { return _ZoomUserMatchingMode; }
			set 
			{ 
				_ZoomUserMatchingMode = value;
				OnPropertyChanged("ZoomUserMatchingMode");
			}
		}
		[JsonProperty]
		public string ZoomUserPostfix
		{
			get { return _ZoomUserPostfix; }
			set 
			{ 
				_ZoomUserPostfix = value;
				OnPropertyChanged("ZoomUserPostfix");
			}
		}
		[JsonProperty]
		public string ZoomWebinarCategory
		{
			get { return _ZoomWebinarCategory; }
			set 
			{ 
				_ZoomWebinarCategory = value;
				OnPropertyChanged("ZoomWebinarCategory");
			}
		}
		[JsonProperty]
		public NullableBoolean EnableWebinarUploads
		{
			get { return _EnableWebinarUploads; }
			set 
			{ 
				_EnableWebinarUploads = value;
				OnPropertyChanged("EnableWebinarUploads");
			}
		}
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
		[JsonProperty]
		public string JwtToken
		{
			get { return _JwtToken; }
			set 
			{ 
				_JwtToken = value;
				OnPropertyChanged("JwtToken");
			}
		}
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
		[JsonProperty]
		public NullableBoolean EnableZoomTranscription
		{
			get { return _EnableZoomTranscription; }
			set 
			{ 
				_EnableZoomTranscription = value;
				OnPropertyChanged("EnableZoomTranscription");
			}
		}
		[JsonProperty]
		public string ZoomAccountDescription
		{
			get { return _ZoomAccountDescription; }
			set 
			{ 
				_ZoomAccountDescription = value;
				OnPropertyChanged("ZoomAccountDescription");
			}
		}
		[JsonProperty]
		public string CreatedAt
		{
			get { return _CreatedAt; }
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		[JsonProperty]
		public string UpdatedAt
		{
			get { return _UpdatedAt; }
			set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		[JsonProperty]
		public NullableBoolean EnableMeetingUpload
		{
			get { return _EnableMeetingUpload; }
			set 
			{ 
				_EnableMeetingUpload = value;
				OnPropertyChanged("EnableMeetingUpload");
			}
		}
		#endregion

		#region CTor
		public ZoomIntegrationSetting()
		{
		}

		public ZoomIntegrationSetting(JToken node) : base(node)
		{
			if(node["defaultUserId"] != null)
			{
				this._DefaultUserId = node["defaultUserId"].Value<string>();
			}
			if(node["zoomCategory"] != null)
			{
				this._ZoomCategory = node["zoomCategory"].Value<string>();
			}
			if(node["accountId"] != null)
			{
				this._AccountId = node["accountId"].Value<string>();
			}
			if(node["enableRecordingUpload"] != null)
			{
				this._EnableRecordingUpload = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["enableRecordingUpload"].Value<string>());
			}
			if(node["createUserIfNotExist"] != null)
			{
				this._CreateUserIfNotExist = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["createUserIfNotExist"].Value<string>());
			}
			if(node["handleParticipantsMode"] != null)
			{
				this._HandleParticipantsMode = (HandleParticipantsMode)ParseEnum(typeof(HandleParticipantsMode), node["handleParticipantsMode"].Value<string>());
			}
			if(node["zoomUserMatchingMode"] != null)
			{
				this._ZoomUserMatchingMode = (ZoomUsersMatching)ParseEnum(typeof(ZoomUsersMatching), node["zoomUserMatchingMode"].Value<string>());
			}
			if(node["zoomUserPostfix"] != null)
			{
				this._ZoomUserPostfix = node["zoomUserPostfix"].Value<string>();
			}
			if(node["zoomWebinarCategory"] != null)
			{
				this._ZoomWebinarCategory = node["zoomWebinarCategory"].Value<string>();
			}
			if(node["enableWebinarUploads"] != null)
			{
				this._EnableWebinarUploads = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["enableWebinarUploads"].Value<string>());
			}
			if(node["conversionProfileId"] != null)
			{
				this._ConversionProfileId = ParseInt(node["conversionProfileId"].Value<string>());
			}
			if(node["jwtToken"] != null)
			{
				this._JwtToken = node["jwtToken"].Value<string>();
			}
			if(node["deletionPolicy"] != null)
			{
				this._DeletionPolicy = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["deletionPolicy"].Value<string>());
			}
			if(node["enableZoomTranscription"] != null)
			{
				this._EnableZoomTranscription = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["enableZoomTranscription"].Value<string>());
			}
			if(node["zoomAccountDescription"] != null)
			{
				this._ZoomAccountDescription = node["zoomAccountDescription"].Value<string>();
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = node["createdAt"].Value<string>();
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = node["updatedAt"].Value<string>();
			}
			if(node["enableMeetingUpload"] != null)
			{
				this._EnableMeetingUpload = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["enableMeetingUpload"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaZoomIntegrationSetting");
			kparams.AddIfNotNull("defaultUserId", this._DefaultUserId);
			kparams.AddIfNotNull("zoomCategory", this._ZoomCategory);
			kparams.AddIfNotNull("accountId", this._AccountId);
			kparams.AddIfNotNull("enableRecordingUpload", this._EnableRecordingUpload);
			kparams.AddIfNotNull("createUserIfNotExist", this._CreateUserIfNotExist);
			kparams.AddIfNotNull("handleParticipantsMode", this._HandleParticipantsMode);
			kparams.AddIfNotNull("zoomUserMatchingMode", this._ZoomUserMatchingMode);
			kparams.AddIfNotNull("zoomUserPostfix", this._ZoomUserPostfix);
			kparams.AddIfNotNull("zoomWebinarCategory", this._ZoomWebinarCategory);
			kparams.AddIfNotNull("enableWebinarUploads", this._EnableWebinarUploads);
			kparams.AddIfNotNull("conversionProfileId", this._ConversionProfileId);
			kparams.AddIfNotNull("jwtToken", this._JwtToken);
			kparams.AddIfNotNull("deletionPolicy", this._DeletionPolicy);
			kparams.AddIfNotNull("enableZoomTranscription", this._EnableZoomTranscription);
			kparams.AddIfNotNull("zoomAccountDescription", this._ZoomAccountDescription);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("enableMeetingUpload", this._EnableMeetingUpload);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DEFAULT_USER_ID:
					return "DefaultUserId";
				case ZOOM_CATEGORY:
					return "ZoomCategory";
				case ACCOUNT_ID:
					return "AccountId";
				case ENABLE_RECORDING_UPLOAD:
					return "EnableRecordingUpload";
				case CREATE_USER_IF_NOT_EXIST:
					return "CreateUserIfNotExist";
				case HANDLE_PARTICIPANTS_MODE:
					return "HandleParticipantsMode";
				case ZOOM_USER_MATCHING_MODE:
					return "ZoomUserMatchingMode";
				case ZOOM_USER_POSTFIX:
					return "ZoomUserPostfix";
				case ZOOM_WEBINAR_CATEGORY:
					return "ZoomWebinarCategory";
				case ENABLE_WEBINAR_UPLOADS:
					return "EnableWebinarUploads";
				case CONVERSION_PROFILE_ID:
					return "ConversionProfileId";
				case JWT_TOKEN:
					return "JwtToken";
				case DELETION_POLICY:
					return "DeletionPolicy";
				case ENABLE_ZOOM_TRANSCRIPTION:
					return "EnableZoomTranscription";
				case ZOOM_ACCOUNT_DESCRIPTION:
					return "ZoomAccountDescription";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case ENABLE_MEETING_UPLOAD:
					return "EnableMeetingUpload";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

