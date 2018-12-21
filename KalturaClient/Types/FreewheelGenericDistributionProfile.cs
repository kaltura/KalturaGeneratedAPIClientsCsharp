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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class FreewheelGenericDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string APIKEY = "apikey";
		public const string EMAIL = "email";
		public const string SFTP_PASS = "sftpPass";
		public const string SFTP_LOGIN = "sftpLogin";
		public const string CONTENT_OWNER = "contentOwner";
		public const string UPSTREAM_VIDEO_ID = "upstreamVideoId";
		public const string UPSTREAM_NETWORK_NAME = "upstreamNetworkName";
		public const string UPSTREAM_NETWORK_ID = "upstreamNetworkId";
		public const string CATEGORY_ID = "categoryId";
		public const string REPLACE_GROUP = "replaceGroup";
		public const string REPLACE_AIR_DATES = "replaceAirDates";
		#endregion

		#region Private Fields
		private string _Apikey = null;
		private string _Email = null;
		private string _SftpPass = null;
		private string _SftpLogin = null;
		private string _ContentOwner = null;
		private string _UpstreamVideoId = null;
		private string _UpstreamNetworkName = null;
		private string _UpstreamNetworkId = null;
		private string _CategoryId = null;
		private bool? _ReplaceGroup = null;
		private bool? _ReplaceAirDates = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string Apikey
		{
			get { return _Apikey; }
			set 
			{ 
				_Apikey = value;
				OnPropertyChanged("Apikey");
			}
		}
		[JsonProperty]
		public string Email
		{
			get { return _Email; }
			set 
			{ 
				_Email = value;
				OnPropertyChanged("Email");
			}
		}
		[JsonProperty]
		public string SftpPass
		{
			get { return _SftpPass; }
			set 
			{ 
				_SftpPass = value;
				OnPropertyChanged("SftpPass");
			}
		}
		[JsonProperty]
		public string SftpLogin
		{
			get { return _SftpLogin; }
			set 
			{ 
				_SftpLogin = value;
				OnPropertyChanged("SftpLogin");
			}
		}
		[JsonProperty]
		public string ContentOwner
		{
			get { return _ContentOwner; }
			set 
			{ 
				_ContentOwner = value;
				OnPropertyChanged("ContentOwner");
			}
		}
		[JsonProperty]
		public string UpstreamVideoId
		{
			get { return _UpstreamVideoId; }
			set 
			{ 
				_UpstreamVideoId = value;
				OnPropertyChanged("UpstreamVideoId");
			}
		}
		[JsonProperty]
		public string UpstreamNetworkName
		{
			get { return _UpstreamNetworkName; }
			set 
			{ 
				_UpstreamNetworkName = value;
				OnPropertyChanged("UpstreamNetworkName");
			}
		}
		[JsonProperty]
		public string UpstreamNetworkId
		{
			get { return _UpstreamNetworkId; }
			set 
			{ 
				_UpstreamNetworkId = value;
				OnPropertyChanged("UpstreamNetworkId");
			}
		}
		[JsonProperty]
		public string CategoryId
		{
			get { return _CategoryId; }
			set 
			{ 
				_CategoryId = value;
				OnPropertyChanged("CategoryId");
			}
		}
		[JsonProperty]
		public bool? ReplaceGroup
		{
			get { return _ReplaceGroup; }
			set 
			{ 
				_ReplaceGroup = value;
				OnPropertyChanged("ReplaceGroup");
			}
		}
		[JsonProperty]
		public bool? ReplaceAirDates
		{
			get { return _ReplaceAirDates; }
			set 
			{ 
				_ReplaceAirDates = value;
				OnPropertyChanged("ReplaceAirDates");
			}
		}
		#endregion

		#region CTor
		public FreewheelGenericDistributionProfile()
		{
		}

		public FreewheelGenericDistributionProfile(JToken node) : base(node)
		{
			if(node["apikey"] != null)
			{
				this._Apikey = node["apikey"].Value<string>();
			}
			if(node["email"] != null)
			{
				this._Email = node["email"].Value<string>();
			}
			if(node["sftpPass"] != null)
			{
				this._SftpPass = node["sftpPass"].Value<string>();
			}
			if(node["sftpLogin"] != null)
			{
				this._SftpLogin = node["sftpLogin"].Value<string>();
			}
			if(node["contentOwner"] != null)
			{
				this._ContentOwner = node["contentOwner"].Value<string>();
			}
			if(node["upstreamVideoId"] != null)
			{
				this._UpstreamVideoId = node["upstreamVideoId"].Value<string>();
			}
			if(node["upstreamNetworkName"] != null)
			{
				this._UpstreamNetworkName = node["upstreamNetworkName"].Value<string>();
			}
			if(node["upstreamNetworkId"] != null)
			{
				this._UpstreamNetworkId = node["upstreamNetworkId"].Value<string>();
			}
			if(node["categoryId"] != null)
			{
				this._CategoryId = node["categoryId"].Value<string>();
			}
			if(node["replaceGroup"] != null)
			{
				this._ReplaceGroup = ParseBool(node["replaceGroup"].Value<string>());
			}
			if(node["replaceAirDates"] != null)
			{
				this._ReplaceAirDates = ParseBool(node["replaceAirDates"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFreewheelGenericDistributionProfile");
			kparams.AddIfNotNull("apikey", this._Apikey);
			kparams.AddIfNotNull("email", this._Email);
			kparams.AddIfNotNull("sftpPass", this._SftpPass);
			kparams.AddIfNotNull("sftpLogin", this._SftpLogin);
			kparams.AddIfNotNull("contentOwner", this._ContentOwner);
			kparams.AddIfNotNull("upstreamVideoId", this._UpstreamVideoId);
			kparams.AddIfNotNull("upstreamNetworkName", this._UpstreamNetworkName);
			kparams.AddIfNotNull("upstreamNetworkId", this._UpstreamNetworkId);
			kparams.AddIfNotNull("categoryId", this._CategoryId);
			kparams.AddIfNotNull("replaceGroup", this._ReplaceGroup);
			kparams.AddIfNotNull("replaceAirDates", this._ReplaceAirDates);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case APIKEY:
					return "Apikey";
				case EMAIL:
					return "Email";
				case SFTP_PASS:
					return "SftpPass";
				case SFTP_LOGIN:
					return "SftpLogin";
				case CONTENT_OWNER:
					return "ContentOwner";
				case UPSTREAM_VIDEO_ID:
					return "UpstreamVideoId";
				case UPSTREAM_NETWORK_NAME:
					return "UpstreamNetworkName";
				case UPSTREAM_NETWORK_ID:
					return "UpstreamNetworkId";
				case CATEGORY_ID:
					return "CategoryId";
				case REPLACE_GROUP:
					return "ReplaceGroup";
				case REPLACE_AIR_DATES:
					return "ReplaceAirDates";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

