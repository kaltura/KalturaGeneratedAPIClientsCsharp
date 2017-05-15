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
		public DistributionProtocol Protocol
		{
			get { return _Protocol; }
			set 
			{ 
				_Protocol = value;
				OnPropertyChanged("Protocol");
			}
		}
		public string Host
		{
			get { return _Host; }
			set 
			{ 
				_Host = value;
				OnPropertyChanged("Host");
			}
		}
		public int Port
		{
			get { return _Port; }
			set 
			{ 
				_Port = value;
				OnPropertyChanged("Port");
			}
		}
		public string BasePath
		{
			get { return _BasePath; }
			set 
			{ 
				_BasePath = value;
				OnPropertyChanged("BasePath");
			}
		}
		public string Username
		{
			get { return _Username; }
			set 
			{ 
				_Username = value;
				OnPropertyChanged("Username");
			}
		}
		public string Password
		{
			get { return _Password; }
			set 
			{ 
				_Password = value;
				OnPropertyChanged("Password");
			}
		}
		public string Passphrase
		{
			get { return _Passphrase; }
			set 
			{ 
				_Passphrase = value;
				OnPropertyChanged("Passphrase");
			}
		}
		public string SftpPublicKey
		{
			get { return _SftpPublicKey; }
			set 
			{ 
				_SftpPublicKey = value;
				OnPropertyChanged("SftpPublicKey");
			}
		}
		public string SftpPrivateKey
		{
			get { return _SftpPrivateKey; }
			set 
			{ 
				_SftpPrivateKey = value;
				OnPropertyChanged("SftpPrivateKey");
			}
		}
		public bool? DisableMetadata
		{
			get { return _DisableMetadata; }
			set 
			{ 
				_DisableMetadata = value;
				OnPropertyChanged("DisableMetadata");
			}
		}
		public string MetadataXslt
		{
			get { return _MetadataXslt; }
			set 
			{ 
				_MetadataXslt = value;
				OnPropertyChanged("MetadataXslt");
			}
		}
		public string MetadataFilenameXslt
		{
			get { return _MetadataFilenameXslt; }
			set 
			{ 
				_MetadataFilenameXslt = value;
				OnPropertyChanged("MetadataFilenameXslt");
			}
		}
		public string FlavorAssetFilenameXslt
		{
			get { return _FlavorAssetFilenameXslt; }
			set 
			{ 
				_FlavorAssetFilenameXslt = value;
				OnPropertyChanged("FlavorAssetFilenameXslt");
			}
		}
		public string ThumbnailAssetFilenameXslt
		{
			get { return _ThumbnailAssetFilenameXslt; }
			set 
			{ 
				_ThumbnailAssetFilenameXslt = value;
				OnPropertyChanged("ThumbnailAssetFilenameXslt");
			}
		}
		public string AssetFilenameXslt
		{
			get { return _AssetFilenameXslt; }
			set 
			{ 
				_AssetFilenameXslt = value;
				OnPropertyChanged("AssetFilenameXslt");
			}
		}
		public string AsperaPublicKey
		{
			get { return _AsperaPublicKey; }
			set 
			{ 
				_AsperaPublicKey = value;
				OnPropertyChanged("AsperaPublicKey");
			}
		}
		public string AsperaPrivateKey
		{
			get { return _AsperaPrivateKey; }
			set 
			{ 
				_AsperaPrivateKey = value;
				OnPropertyChanged("AsperaPrivateKey");
			}
		}
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

		public FtpDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "protocol":
						this._Protocol = (DistributionProtocol)ParseEnum(typeof(DistributionProtocol), propertyNode.InnerText);
						continue;
					case "host":
						this._Host = propertyNode.InnerText;
						continue;
					case "port":
						this._Port = ParseInt(propertyNode.InnerText);
						continue;
					case "basePath":
						this._BasePath = propertyNode.InnerText;
						continue;
					case "username":
						this._Username = propertyNode.InnerText;
						continue;
					case "password":
						this._Password = propertyNode.InnerText;
						continue;
					case "passphrase":
						this._Passphrase = propertyNode.InnerText;
						continue;
					case "sftpPublicKey":
						this._SftpPublicKey = propertyNode.InnerText;
						continue;
					case "sftpPrivateKey":
						this._SftpPrivateKey = propertyNode.InnerText;
						continue;
					case "disableMetadata":
						this._DisableMetadata = ParseBool(propertyNode.InnerText);
						continue;
					case "metadataXslt":
						this._MetadataXslt = propertyNode.InnerText;
						continue;
					case "metadataFilenameXslt":
						this._MetadataFilenameXslt = propertyNode.InnerText;
						continue;
					case "flavorAssetFilenameXslt":
						this._FlavorAssetFilenameXslt = propertyNode.InnerText;
						continue;
					case "thumbnailAssetFilenameXslt":
						this._ThumbnailAssetFilenameXslt = propertyNode.InnerText;
						continue;
					case "assetFilenameXslt":
						this._AssetFilenameXslt = propertyNode.InnerText;
						continue;
					case "asperaPublicKey":
						this._AsperaPublicKey = propertyNode.InnerText;
						continue;
					case "asperaPrivateKey":
						this._AsperaPrivateKey = propertyNode.InnerText;
						continue;
					case "sendMetadataAfterAssets":
						this._SendMetadataAfterAssets = ParseBool(propertyNode.InnerText);
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

