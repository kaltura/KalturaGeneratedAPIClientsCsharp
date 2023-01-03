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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class ZoomIntegrationSetting : IntegrationSetting
	{
		#region Constants
		public const string ZOOM_CATEGORY = "zoomCategory";
		public const string ENABLE_RECORDING_UPLOAD = "enableRecordingUpload";
		public const string ZOOM_USER_MATCHING_MODE = "zoomUserMatchingMode";
		public const string ZOOM_USER_POSTFIX = "zoomUserPostfix";
		public const string ZOOM_WEBINAR_CATEGORY = "zoomWebinarCategory";
		public const string ENABLE_WEBINAR_UPLOADS = "enableWebinarUploads";
		public const string JWT_TOKEN = "jwtToken";
		public const string ENABLE_ZOOM_TRANSCRIPTION = "enableZoomTranscription";
		public const string ZOOM_ACCOUNT_DESCRIPTION = "zoomAccountDescription";
		public const string OPT_OUT_GROUP_NAMES = "optOutGroupNames";
		public const string OPT_IN_GROUP_NAMES = "optInGroupNames";
		public const string GROUP_PARTICIPATION_TYPE = "groupParticipationType";
		#endregion

		#region Private Fields
		private string _ZoomCategory = null;
		private NullableBoolean _EnableRecordingUpload = (NullableBoolean)Int32.MinValue;
		private ZoomUsersMatching _ZoomUserMatchingMode = (ZoomUsersMatching)Int32.MinValue;
		private string _ZoomUserPostfix = null;
		private string _ZoomWebinarCategory = null;
		private NullableBoolean _EnableWebinarUploads = (NullableBoolean)Int32.MinValue;
		private string _JwtToken = null;
		private NullableBoolean _EnableZoomTranscription = (NullableBoolean)Int32.MinValue;
		private string _ZoomAccountDescription = null;
		private string _OptOutGroupNames = null;
		private string _OptInGroupNames = null;
		private ZoomGroupParticipationType _GroupParticipationType = (ZoomGroupParticipationType)Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use ZoomCategoryAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use EnableRecordingUploadAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use ZoomUserMatchingModeAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use ZoomUserPostfixAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use ZoomWebinarCategoryAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use EnableWebinarUploadsAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use JwtTokenAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use EnableZoomTranscriptionAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use ZoomAccountDescriptionAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use OptOutGroupNamesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string OptOutGroupNames
		{
			get { return _OptOutGroupNames; }
			set 
			{ 
				_OptOutGroupNames = value;
				OnPropertyChanged("OptOutGroupNames");
			}
		}
		/// <summary>
		/// Use OptInGroupNamesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string OptInGroupNames
		{
			get { return _OptInGroupNames; }
			set 
			{ 
				_OptInGroupNames = value;
				OnPropertyChanged("OptInGroupNames");
			}
		}
		/// <summary>
		/// Use GroupParticipationTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ZoomGroupParticipationType GroupParticipationType
		{
			get { return _GroupParticipationType; }
			set 
			{ 
				_GroupParticipationType = value;
				OnPropertyChanged("GroupParticipationType");
			}
		}
		#endregion

		#region CTor
		public ZoomIntegrationSetting()
		{
		}

		public ZoomIntegrationSetting(JToken node) : base(node)
		{
			if(node["zoomCategory"] != null)
			{
				this._ZoomCategory = node["zoomCategory"].Value<string>();
			}
			if(node["enableRecordingUpload"] != null)
			{
				this._EnableRecordingUpload = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["enableRecordingUpload"].Value<string>());
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
			if(node["jwtToken"] != null)
			{
				this._JwtToken = node["jwtToken"].Value<string>();
			}
			if(node["enableZoomTranscription"] != null)
			{
				this._EnableZoomTranscription = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["enableZoomTranscription"].Value<string>());
			}
			if(node["zoomAccountDescription"] != null)
			{
				this._ZoomAccountDescription = node["zoomAccountDescription"].Value<string>();
			}
			if(node["optOutGroupNames"] != null)
			{
				this._OptOutGroupNames = node["optOutGroupNames"].Value<string>();
			}
			if(node["optInGroupNames"] != null)
			{
				this._OptInGroupNames = node["optInGroupNames"].Value<string>();
			}
			if(node["groupParticipationType"] != null)
			{
				this._GroupParticipationType = (ZoomGroupParticipationType)ParseEnum(typeof(ZoomGroupParticipationType), node["groupParticipationType"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaZoomIntegrationSetting");
			kparams.AddIfNotNull("zoomCategory", this._ZoomCategory);
			kparams.AddIfNotNull("enableRecordingUpload", this._EnableRecordingUpload);
			kparams.AddIfNotNull("zoomUserMatchingMode", this._ZoomUserMatchingMode);
			kparams.AddIfNotNull("zoomUserPostfix", this._ZoomUserPostfix);
			kparams.AddIfNotNull("zoomWebinarCategory", this._ZoomWebinarCategory);
			kparams.AddIfNotNull("enableWebinarUploads", this._EnableWebinarUploads);
			kparams.AddIfNotNull("jwtToken", this._JwtToken);
			kparams.AddIfNotNull("enableZoomTranscription", this._EnableZoomTranscription);
			kparams.AddIfNotNull("zoomAccountDescription", this._ZoomAccountDescription);
			kparams.AddIfNotNull("optOutGroupNames", this._OptOutGroupNames);
			kparams.AddIfNotNull("optInGroupNames", this._OptInGroupNames);
			kparams.AddIfNotNull("groupParticipationType", this._GroupParticipationType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ZOOM_CATEGORY:
					return "ZoomCategory";
				case ENABLE_RECORDING_UPLOAD:
					return "EnableRecordingUpload";
				case ZOOM_USER_MATCHING_MODE:
					return "ZoomUserMatchingMode";
				case ZOOM_USER_POSTFIX:
					return "ZoomUserPostfix";
				case ZOOM_WEBINAR_CATEGORY:
					return "ZoomWebinarCategory";
				case ENABLE_WEBINAR_UPLOADS:
					return "EnableWebinarUploads";
				case JWT_TOKEN:
					return "JwtToken";
				case ENABLE_ZOOM_TRANSCRIPTION:
					return "EnableZoomTranscription";
				case ZOOM_ACCOUNT_DESCRIPTION:
					return "ZoomAccountDescription";
				case OPT_OUT_GROUP_NAMES:
					return "OptOutGroupNames";
				case OPT_IN_GROUP_NAMES:
					return "OptInGroupNames";
				case GROUP_PARTICIPATION_TYPE:
					return "GroupParticipationType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

