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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class FtpDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string PROTOCOL = "protocol";
		public const string HOST = "host";
		public const string PORT = "port";
		public const string BASE_PATH = "basePath";
		public const string USERNAME = "username";
		public const string PASSWORD = "password";
		public const string PASSPHRASE = "passphrase";
		public const string SFTP_PUBLIC_KEY = "sftpPublicKey";
		public const string SFTP_PRIVATE_KEY = "sftpPrivateKey";
		public const string DISABLE_METADATA = "disableMetadata";
		public const string METADATA_XSLT = "metadataXslt";
		public const string METADATA_FILENAME_XSLT = "metadataFilenameXslt";
		public const string FLAVOR_ASSET_FILENAME_XSLT = "flavorAssetFilenameXslt";
		public const string THUMBNAIL_ASSET_FILENAME_XSLT = "thumbnailAssetFilenameXslt";
		public const string ASSET_FILENAME_XSLT = "assetFilenameXslt";
		public const string ASPERA_PUBLIC_KEY = "asperaPublicKey";
		public const string ASPERA_PRIVATE_KEY = "asperaPrivateKey";
		public const string SEND_METADATA_AFTER_ASSETS = "sendMetadataAfterAssets";
		#endregion

		#region Private Fields
		private DistributionProtocol _Protocol = (DistributionProtocol)Int32.MinValue;
		private string _Host = null;
		private int _Port = Int32.MinValue;
		private string _BasePath = null;
		private string _Username = null;
		private string _Password = null;
		private string _Passphrase = null;
		private string _SftpPublicKey = null;
		private string _SftpPrivateKey = null;
		private bool? _DisableMetadata = null;
		private string _MetadataXslt = null;
		private string _MetadataFilenameXslt = null;
		private string _FlavorAssetFilenameXslt = null;
		private string _ThumbnailAssetFilenameXslt = null;
		private string _AssetFilenameXslt = null;
		private string _AsperaPublicKey = null;
		private string _AsperaPrivateKey = null;
		private bool? _SendMetadataAfterAssets = null;
		#endregion

		#region Properties
		[JsonProperty]
		public DistributionProtocol Protocol
		{
			get { return _Protocol; }
			set 
			{ 
				_Protocol = value;
				OnPropertyChanged("Protocol");
			}
		}
		[JsonProperty]
		public string Host
		{
			get { return _Host; }
			set 
			{ 
				_Host = value;
				OnPropertyChanged("Host");
			}
		}
		[JsonProperty]
		public int Port
		{
			get { return _Port; }
			set 
			{ 
				_Port = value;
				OnPropertyChanged("Port");
			}
		}
		[JsonProperty]
		public string BasePath
		{
			get { return _BasePath; }
			set 
			{ 
				_BasePath = value;
				OnPropertyChanged("BasePath");
			}
		}
		[JsonProperty]
		public string Username
		{
			get { return _Username; }
			set 
			{ 
				_Username = value;
				OnPropertyChanged("Username");
			}
		}
		[JsonProperty]
		public string Password
		{
			get { return _Password; }
			set 
			{ 
				_Password = value;
				OnPropertyChanged("Password");
			}
		}
		[JsonProperty]
		public string Passphrase
		{
			get { return _Passphrase; }
			set 
			{ 
				_Passphrase = value;
				OnPropertyChanged("Passphrase");
			}
		}
		[JsonProperty]
		public string SftpPublicKey
		{
			get { return _SftpPublicKey; }
			set 
			{ 
				_SftpPublicKey = value;
				OnPropertyChanged("SftpPublicKey");
			}
		}
		[JsonProperty]
		public string SftpPrivateKey
		{
			get { return _SftpPrivateKey; }
			set 
			{ 
				_SftpPrivateKey = value;
				OnPropertyChanged("SftpPrivateKey");
			}
		}
		[JsonProperty]
		public bool? DisableMetadata
		{
			get { return _DisableMetadata; }
			set 
			{ 
				_DisableMetadata = value;
				OnPropertyChanged("DisableMetadata");
			}
		}
		[JsonProperty]
		public string MetadataXslt
		{
			get { return _MetadataXslt; }
			set 
			{ 
				_MetadataXslt = value;
				OnPropertyChanged("MetadataXslt");
			}
		}
		[JsonProperty]
		public string MetadataFilenameXslt
		{
			get { return _MetadataFilenameXslt; }
			set 
			{ 
				_MetadataFilenameXslt = value;
				OnPropertyChanged("MetadataFilenameXslt");
			}
		}
		[JsonProperty]
		public string FlavorAssetFilenameXslt
		{
			get { return _FlavorAssetFilenameXslt; }
			set 
			{ 
				_FlavorAssetFilenameXslt = value;
				OnPropertyChanged("FlavorAssetFilenameXslt");
			}
		}
		[JsonProperty]
		public string ThumbnailAssetFilenameXslt
		{
			get { return _ThumbnailAssetFilenameXslt; }
			set 
			{ 
				_ThumbnailAssetFilenameXslt = value;
				OnPropertyChanged("ThumbnailAssetFilenameXslt");
			}
		}
		[JsonProperty]
		public string AssetFilenameXslt
		{
			get { return _AssetFilenameXslt; }
			set 
			{ 
				_AssetFilenameXslt = value;
				OnPropertyChanged("AssetFilenameXslt");
			}
		}
		[JsonProperty]
		public string AsperaPublicKey
		{
			get { return _AsperaPublicKey; }
			set 
			{ 
				_AsperaPublicKey = value;
				OnPropertyChanged("AsperaPublicKey");
			}
		}
		[JsonProperty]
		public string AsperaPrivateKey
		{
			get { return _AsperaPrivateKey; }
			set 
			{ 
				_AsperaPrivateKey = value;
				OnPropertyChanged("AsperaPrivateKey");
			}
		}
		[JsonProperty]
		public bool? SendMetadataAfterAssets
		{
			get { return _SendMetadataAfterAssets; }
			set 
			{ 
				_SendMetadataAfterAssets = value;
				OnPropertyChanged("SendMetadataAfterAssets");
			}
		}
		#endregion

		#region CTor
		public FtpDistributionProfile()
		{
		}

		public FtpDistributionProfile(JToken node) : base(node)
		{
			if(node["protocol"] != null)
			{
				this._Protocol = (DistributionProtocol)ParseEnum(typeof(DistributionProtocol), node["protocol"].Value<string>());
			}
			if(node["host"] != null)
			{
				this._Host = node["host"].Value<string>();
			}
			if(node["port"] != null)
			{
				this._Port = ParseInt(node["port"].Value<string>());
			}
			if(node["basePath"] != null)
			{
				this._BasePath = node["basePath"].Value<string>();
			}
			if(node["username"] != null)
			{
				this._Username = node["username"].Value<string>();
			}
			if(node["password"] != null)
			{
				this._Password = node["password"].Value<string>();
			}
			if(node["passphrase"] != null)
			{
				this._Passphrase = node["passphrase"].Value<string>();
			}
			if(node["sftpPublicKey"] != null)
			{
				this._SftpPublicKey = node["sftpPublicKey"].Value<string>();
			}
			if(node["sftpPrivateKey"] != null)
			{
				this._SftpPrivateKey = node["sftpPrivateKey"].Value<string>();
			}
			if(node["disableMetadata"] != null)
			{
				this._DisableMetadata = ParseBool(node["disableMetadata"].Value<string>());
			}
			if(node["metadataXslt"] != null)
			{
				this._MetadataXslt = node["metadataXslt"].Value<string>();
			}
			if(node["metadataFilenameXslt"] != null)
			{
				this._MetadataFilenameXslt = node["metadataFilenameXslt"].Value<string>();
			}
			if(node["flavorAssetFilenameXslt"] != null)
			{
				this._FlavorAssetFilenameXslt = node["flavorAssetFilenameXslt"].Value<string>();
			}
			if(node["thumbnailAssetFilenameXslt"] != null)
			{
				this._ThumbnailAssetFilenameXslt = node["thumbnailAssetFilenameXslt"].Value<string>();
			}
			if(node["assetFilenameXslt"] != null)
			{
				this._AssetFilenameXslt = node["assetFilenameXslt"].Value<string>();
			}
			if(node["asperaPublicKey"] != null)
			{
				this._AsperaPublicKey = node["asperaPublicKey"].Value<string>();
			}
			if(node["asperaPrivateKey"] != null)
			{
				this._AsperaPrivateKey = node["asperaPrivateKey"].Value<string>();
			}
			if(node["sendMetadataAfterAssets"] != null)
			{
				this._SendMetadataAfterAssets = ParseBool(node["sendMetadataAfterAssets"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFtpDistributionProfile");
			kparams.AddIfNotNull("protocol", this._Protocol);
			kparams.AddIfNotNull("host", this._Host);
			kparams.AddIfNotNull("port", this._Port);
			kparams.AddIfNotNull("basePath", this._BasePath);
			kparams.AddIfNotNull("username", this._Username);
			kparams.AddIfNotNull("password", this._Password);
			kparams.AddIfNotNull("passphrase", this._Passphrase);
			kparams.AddIfNotNull("sftpPublicKey", this._SftpPublicKey);
			kparams.AddIfNotNull("sftpPrivateKey", this._SftpPrivateKey);
			kparams.AddIfNotNull("disableMetadata", this._DisableMetadata);
			kparams.AddIfNotNull("metadataXslt", this._MetadataXslt);
			kparams.AddIfNotNull("metadataFilenameXslt", this._MetadataFilenameXslt);
			kparams.AddIfNotNull("flavorAssetFilenameXslt", this._FlavorAssetFilenameXslt);
			kparams.AddIfNotNull("thumbnailAssetFilenameXslt", this._ThumbnailAssetFilenameXslt);
			kparams.AddIfNotNull("assetFilenameXslt", this._AssetFilenameXslt);
			kparams.AddIfNotNull("asperaPublicKey", this._AsperaPublicKey);
			kparams.AddIfNotNull("asperaPrivateKey", this._AsperaPrivateKey);
			kparams.AddIfNotNull("sendMetadataAfterAssets", this._SendMetadataAfterAssets);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PROTOCOL:
					return "Protocol";
				case HOST:
					return "Host";
				case PORT:
					return "Port";
				case BASE_PATH:
					return "BasePath";
				case USERNAME:
					return "Username";
				case PASSWORD:
					return "Password";
				case PASSPHRASE:
					return "Passphrase";
				case SFTP_PUBLIC_KEY:
					return "SftpPublicKey";
				case SFTP_PRIVATE_KEY:
					return "SftpPrivateKey";
				case DISABLE_METADATA:
					return "DisableMetadata";
				case METADATA_XSLT:
					return "MetadataXslt";
				case METADATA_FILENAME_XSLT:
					return "MetadataFilenameXslt";
				case FLAVOR_ASSET_FILENAME_XSLT:
					return "FlavorAssetFilenameXslt";
				case THUMBNAIL_ASSET_FILENAME_XSLT:
					return "ThumbnailAssetFilenameXslt";
				case ASSET_FILENAME_XSLT:
					return "AssetFilenameXslt";
				case ASPERA_PUBLIC_KEY:
					return "AsperaPublicKey";
				case ASPERA_PRIVATE_KEY:
					return "AsperaPrivateKey";
				case SEND_METADATA_AFTER_ASSETS:
					return "SendMetadataAfterAssets";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

