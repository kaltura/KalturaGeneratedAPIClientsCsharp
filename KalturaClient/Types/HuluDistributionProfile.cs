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

namespace Kaltura.Types
{
	public class HuluDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string SFTP_HOST = "sftpHost";
		public const string SFTP_LOGIN = "sftpLogin";
		public const string SFTP_PASS = "sftpPass";
		public const string SERIES_CHANNEL = "seriesChannel";
		public const string SERIES_PRIMARY_CATEGORY = "seriesPrimaryCategory";
		public const string SERIES_ADDITIONAL_CATEGORIES = "seriesAdditionalCategories";
		public const string SEASON_NUMBER = "seasonNumber";
		public const string SEASON_SYNOPSIS = "seasonSynopsis";
		public const string SEASON_TUNE_IN_INFORMATION = "seasonTuneInInformation";
		public const string VIDEO_MEDIA_TYPE = "videoMediaType";
		public const string DISABLE_EPISODE_NUMBER_CUSTOM_VALIDATION = "disableEpisodeNumberCustomValidation";
		public const string PROTOCOL = "protocol";
		public const string ASPERA_HOST = "asperaHost";
		public const string ASPERA_LOGIN = "asperaLogin";
		public const string ASPERA_PASS = "asperaPass";
		public const string PORT = "port";
		public const string PASSPHRASE = "passphrase";
		public const string ASPERA_PUBLIC_KEY = "asperaPublicKey";
		public const string ASPERA_PRIVATE_KEY = "asperaPrivateKey";
		#endregion

		#region Private Fields
		private string _SftpHost = null;
		private string _SftpLogin = null;
		private string _SftpPass = null;
		private string _SeriesChannel = null;
		private string _SeriesPrimaryCategory = null;
		private IList<String> _SeriesAdditionalCategories;
		private string _SeasonNumber = null;
		private string _SeasonSynopsis = null;
		private string _SeasonTuneInInformation = null;
		private string _VideoMediaType = null;
		private bool? _DisableEpisodeNumberCustomValidation = null;
		private DistributionProtocol _Protocol = (DistributionProtocol)Int32.MinValue;
		private string _AsperaHost = null;
		private string _AsperaLogin = null;
		private string _AsperaPass = null;
		private int _Port = Int32.MinValue;
		private string _Passphrase = null;
		private string _AsperaPublicKey = null;
		private string _AsperaPrivateKey = null;
		#endregion

		#region Properties
		public string SftpHost
		{
			get { return _SftpHost; }
			set 
			{ 
				_SftpHost = value;
				OnPropertyChanged("SftpHost");
			}
		}
		public string SftpLogin
		{
			get { return _SftpLogin; }
			set 
			{ 
				_SftpLogin = value;
				OnPropertyChanged("SftpLogin");
			}
		}
		public string SftpPass
		{
			get { return _SftpPass; }
			set 
			{ 
				_SftpPass = value;
				OnPropertyChanged("SftpPass");
			}
		}
		public string SeriesChannel
		{
			get { return _SeriesChannel; }
			set 
			{ 
				_SeriesChannel = value;
				OnPropertyChanged("SeriesChannel");
			}
		}
		public string SeriesPrimaryCategory
		{
			get { return _SeriesPrimaryCategory; }
			set 
			{ 
				_SeriesPrimaryCategory = value;
				OnPropertyChanged("SeriesPrimaryCategory");
			}
		}
		public IList<String> SeriesAdditionalCategories
		{
			get { return _SeriesAdditionalCategories; }
			set 
			{ 
				_SeriesAdditionalCategories = value;
				OnPropertyChanged("SeriesAdditionalCategories");
			}
		}
		public string SeasonNumber
		{
			get { return _SeasonNumber; }
			set 
			{ 
				_SeasonNumber = value;
				OnPropertyChanged("SeasonNumber");
			}
		}
		public string SeasonSynopsis
		{
			get { return _SeasonSynopsis; }
			set 
			{ 
				_SeasonSynopsis = value;
				OnPropertyChanged("SeasonSynopsis");
			}
		}
		public string SeasonTuneInInformation
		{
			get { return _SeasonTuneInInformation; }
			set 
			{ 
				_SeasonTuneInInformation = value;
				OnPropertyChanged("SeasonTuneInInformation");
			}
		}
		public string VideoMediaType
		{
			get { return _VideoMediaType; }
			set 
			{ 
				_VideoMediaType = value;
				OnPropertyChanged("VideoMediaType");
			}
		}
		public bool? DisableEpisodeNumberCustomValidation
		{
			get { return _DisableEpisodeNumberCustomValidation; }
			set 
			{ 
				_DisableEpisodeNumberCustomValidation = value;
				OnPropertyChanged("DisableEpisodeNumberCustomValidation");
			}
		}
		public DistributionProtocol Protocol
		{
			get { return _Protocol; }
			set 
			{ 
				_Protocol = value;
				OnPropertyChanged("Protocol");
			}
		}
		public string AsperaHost
		{
			get { return _AsperaHost; }
			set 
			{ 
				_AsperaHost = value;
				OnPropertyChanged("AsperaHost");
			}
		}
		public string AsperaLogin
		{
			get { return _AsperaLogin; }
			set 
			{ 
				_AsperaLogin = value;
				OnPropertyChanged("AsperaLogin");
			}
		}
		public string AsperaPass
		{
			get { return _AsperaPass; }
			set 
			{ 
				_AsperaPass = value;
				OnPropertyChanged("AsperaPass");
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
		public string Passphrase
		{
			get { return _Passphrase; }
			set 
			{ 
				_Passphrase = value;
				OnPropertyChanged("Passphrase");
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
		#endregion

		#region CTor
		public HuluDistributionProfile()
		{
		}

		public HuluDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "sftpHost":
						this._SftpHost = propertyNode.InnerText;
						continue;
					case "sftpLogin":
						this._SftpLogin = propertyNode.InnerText;
						continue;
					case "sftpPass":
						this._SftpPass = propertyNode.InnerText;
						continue;
					case "seriesChannel":
						this._SeriesChannel = propertyNode.InnerText;
						continue;
					case "seriesPrimaryCategory":
						this._SeriesPrimaryCategory = propertyNode.InnerText;
						continue;
					case "seriesAdditionalCategories":
						this._SeriesAdditionalCategories = new List<String>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._SeriesAdditionalCategories.Add(ObjectFactory.Create<String>(arrayNode));
						}
						continue;
					case "seasonNumber":
						this._SeasonNumber = propertyNode.InnerText;
						continue;
					case "seasonSynopsis":
						this._SeasonSynopsis = propertyNode.InnerText;
						continue;
					case "seasonTuneInInformation":
						this._SeasonTuneInInformation = propertyNode.InnerText;
						continue;
					case "videoMediaType":
						this._VideoMediaType = propertyNode.InnerText;
						continue;
					case "disableEpisodeNumberCustomValidation":
						this._DisableEpisodeNumberCustomValidation = ParseBool(propertyNode.InnerText);
						continue;
					case "protocol":
						this._Protocol = (DistributionProtocol)ParseEnum(typeof(DistributionProtocol), propertyNode.InnerText);
						continue;
					case "asperaHost":
						this._AsperaHost = propertyNode.InnerText;
						continue;
					case "asperaLogin":
						this._AsperaLogin = propertyNode.InnerText;
						continue;
					case "asperaPass":
						this._AsperaPass = propertyNode.InnerText;
						continue;
					case "port":
						this._Port = ParseInt(propertyNode.InnerText);
						continue;
					case "passphrase":
						this._Passphrase = propertyNode.InnerText;
						continue;
					case "asperaPublicKey":
						this._AsperaPublicKey = propertyNode.InnerText;
						continue;
					case "asperaPrivateKey":
						this._AsperaPrivateKey = propertyNode.InnerText;
						continue;
				}
			}
		}

		public HuluDistributionProfile(IDictionary<string,object> data) : base(data)
		{
			    this._SftpHost = data.TryGetValueSafe<string>("sftpHost");
			    this._SftpLogin = data.TryGetValueSafe<string>("sftpLogin");
			    this._SftpPass = data.TryGetValueSafe<string>("sftpPass");
			    this._SeriesChannel = data.TryGetValueSafe<string>("seriesChannel");
			    this._SeriesPrimaryCategory = data.TryGetValueSafe<string>("seriesPrimaryCategory");
			    this._SeriesAdditionalCategories = new List<String>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("seriesAdditionalCategories", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._SeriesAdditionalCategories.Add(ObjectFactory.Create<String>((IDictionary<string,object>)dataDictionary));
			    }
			    this._SeasonNumber = data.TryGetValueSafe<string>("seasonNumber");
			    this._SeasonSynopsis = data.TryGetValueSafe<string>("seasonSynopsis");
			    this._SeasonTuneInInformation = data.TryGetValueSafe<string>("seasonTuneInInformation");
			    this._VideoMediaType = data.TryGetValueSafe<string>("videoMediaType");
			    this._DisableEpisodeNumberCustomValidation = data.TryGetValueSafe<bool>("disableEpisodeNumberCustomValidation");
			    this._Protocol = (DistributionProtocol)ParseEnum(typeof(DistributionProtocol), data.TryGetValueSafe<int>("protocol"));
			    this._AsperaHost = data.TryGetValueSafe<string>("asperaHost");
			    this._AsperaLogin = data.TryGetValueSafe<string>("asperaLogin");
			    this._AsperaPass = data.TryGetValueSafe<string>("asperaPass");
			    this._Port = data.TryGetValueSafe<int>("port");
			    this._Passphrase = data.TryGetValueSafe<string>("passphrase");
			    this._AsperaPublicKey = data.TryGetValueSafe<string>("asperaPublicKey");
			    this._AsperaPrivateKey = data.TryGetValueSafe<string>("asperaPrivateKey");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaHuluDistributionProfile");
			kparams.AddIfNotNull("sftpHost", this._SftpHost);
			kparams.AddIfNotNull("sftpLogin", this._SftpLogin);
			kparams.AddIfNotNull("sftpPass", this._SftpPass);
			kparams.AddIfNotNull("seriesChannel", this._SeriesChannel);
			kparams.AddIfNotNull("seriesPrimaryCategory", this._SeriesPrimaryCategory);
			kparams.AddIfNotNull("seriesAdditionalCategories", this._SeriesAdditionalCategories);
			kparams.AddIfNotNull("seasonNumber", this._SeasonNumber);
			kparams.AddIfNotNull("seasonSynopsis", this._SeasonSynopsis);
			kparams.AddIfNotNull("seasonTuneInInformation", this._SeasonTuneInInformation);
			kparams.AddIfNotNull("videoMediaType", this._VideoMediaType);
			kparams.AddIfNotNull("disableEpisodeNumberCustomValidation", this._DisableEpisodeNumberCustomValidation);
			kparams.AddIfNotNull("protocol", this._Protocol);
			kparams.AddIfNotNull("asperaHost", this._AsperaHost);
			kparams.AddIfNotNull("asperaLogin", this._AsperaLogin);
			kparams.AddIfNotNull("asperaPass", this._AsperaPass);
			kparams.AddIfNotNull("port", this._Port);
			kparams.AddIfNotNull("passphrase", this._Passphrase);
			kparams.AddIfNotNull("asperaPublicKey", this._AsperaPublicKey);
			kparams.AddIfNotNull("asperaPrivateKey", this._AsperaPrivateKey);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SFTP_HOST:
					return "SftpHost";
				case SFTP_LOGIN:
					return "SftpLogin";
				case SFTP_PASS:
					return "SftpPass";
				case SERIES_CHANNEL:
					return "SeriesChannel";
				case SERIES_PRIMARY_CATEGORY:
					return "SeriesPrimaryCategory";
				case SERIES_ADDITIONAL_CATEGORIES:
					return "SeriesAdditionalCategories";
				case SEASON_NUMBER:
					return "SeasonNumber";
				case SEASON_SYNOPSIS:
					return "SeasonSynopsis";
				case SEASON_TUNE_IN_INFORMATION:
					return "SeasonTuneInInformation";
				case VIDEO_MEDIA_TYPE:
					return "VideoMediaType";
				case DISABLE_EPISODE_NUMBER_CUSTOM_VALIDATION:
					return "DisableEpisodeNumberCustomValidation";
				case PROTOCOL:
					return "Protocol";
				case ASPERA_HOST:
					return "AsperaHost";
				case ASPERA_LOGIN:
					return "AsperaLogin";
				case ASPERA_PASS:
					return "AsperaPass";
				case PORT:
					return "Port";
				case PASSPHRASE:
					return "Passphrase";
				case ASPERA_PUBLIC_KEY:
					return "AsperaPublicKey";
				case ASPERA_PRIVATE_KEY:
					return "AsperaPrivateKey";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

