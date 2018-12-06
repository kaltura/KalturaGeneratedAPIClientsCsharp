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
	public class DistributionJobData : JobData
	{
		#region Constants
		public const string DISTRIBUTION_PROFILE_ID = "distributionProfileId";
		public const string DISTRIBUTION_PROFILE = "distributionProfile";
		public const string ENTRY_DISTRIBUTION_ID = "entryDistributionId";
		public const string ENTRY_DISTRIBUTION = "entryDistribution";
		public const string REMOTE_ID = "remoteId";
		public const string PROVIDER_TYPE = "providerType";
		public const string PROVIDER_DATA = "providerData";
		public const string RESULTS = "results";
		public const string SENT_DATA = "sentData";
		public const string MEDIA_FILES = "mediaFiles";
		#endregion

		#region Private Fields
		private int _DistributionProfileId = Int32.MinValue;
		private DistributionProfile _DistributionProfile;
		private int _EntryDistributionId = Int32.MinValue;
		private EntryDistribution _EntryDistribution;
		private string _RemoteId = null;
		private DistributionProviderType _ProviderType = null;
		private DistributionJobProviderData _ProviderData;
		private string _Results = null;
		private string _SentData = null;
		private IList<DistributionRemoteMediaFile> _MediaFiles;
		#endregion

		#region Properties
		public int DistributionProfileId
		{
			get { return _DistributionProfileId; }
			set 
			{ 
				_DistributionProfileId = value;
				OnPropertyChanged("DistributionProfileId");
			}
		}
		public DistributionProfile DistributionProfile
		{
			get { return _DistributionProfile; }
			set 
			{ 
				_DistributionProfile = value;
				OnPropertyChanged("DistributionProfile");
			}
		}
		public int EntryDistributionId
		{
			get { return _EntryDistributionId; }
			set 
			{ 
				_EntryDistributionId = value;
				OnPropertyChanged("EntryDistributionId");
			}
		}
		public EntryDistribution EntryDistribution
		{
			get { return _EntryDistribution; }
			set 
			{ 
				_EntryDistribution = value;
				OnPropertyChanged("EntryDistribution");
			}
		}
		public string RemoteId
		{
			get { return _RemoteId; }
			set 
			{ 
				_RemoteId = value;
				OnPropertyChanged("RemoteId");
			}
		}
		public DistributionProviderType ProviderType
		{
			get { return _ProviderType; }
			set 
			{ 
				_ProviderType = value;
				OnPropertyChanged("ProviderType");
			}
		}
		public DistributionJobProviderData ProviderData
		{
			get { return _ProviderData; }
			set 
			{ 
				_ProviderData = value;
				OnPropertyChanged("ProviderData");
			}
		}
		public string Results
		{
			get { return _Results; }
			set 
			{ 
				_Results = value;
				OnPropertyChanged("Results");
			}
		}
		public string SentData
		{
			get { return _SentData; }
			set 
			{ 
				_SentData = value;
				OnPropertyChanged("SentData");
			}
		}
		public IList<DistributionRemoteMediaFile> MediaFiles
		{
			get { return _MediaFiles; }
			set 
			{ 
				_MediaFiles = value;
				OnPropertyChanged("MediaFiles");
			}
		}
		#endregion

		#region CTor
		public DistributionJobData()
		{
		}

		public DistributionJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "distributionProfileId":
						this._DistributionProfileId = ParseInt(propertyNode.InnerText);
						continue;
					case "distributionProfile":
						this._DistributionProfile = ObjectFactory.Create<DistributionProfile>(propertyNode);
						continue;
					case "entryDistributionId":
						this._EntryDistributionId = ParseInt(propertyNode.InnerText);
						continue;
					case "entryDistribution":
						this._EntryDistribution = ObjectFactory.Create<EntryDistribution>(propertyNode);
						continue;
					case "remoteId":
						this._RemoteId = propertyNode.InnerText;
						continue;
					case "providerType":
						this._ProviderType = (DistributionProviderType)StringEnum.Parse(typeof(DistributionProviderType), propertyNode.InnerText);
						continue;
					case "providerData":
						this._ProviderData = ObjectFactory.Create<DistributionJobProviderData>(propertyNode);
						continue;
					case "results":
						this._Results = propertyNode.InnerText;
						continue;
					case "sentData":
						this._SentData = propertyNode.InnerText;
						continue;
					case "mediaFiles":
						this._MediaFiles = new List<DistributionRemoteMediaFile>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._MediaFiles.Add(ObjectFactory.Create<DistributionRemoteMediaFile>(arrayNode));
						}
						continue;
				}
			}
		}

		public DistributionJobData(IDictionary<string,object> data) : base(data)
		{
			    this._DistributionProfileId = data.TryGetValueSafe<int>("distributionProfileId");
			    this._DistributionProfile = ObjectFactory.Create<DistributionProfile>(data.TryGetValueSafe<IDictionary<string,object>>("distributionProfile"));
			    this._EntryDistributionId = data.TryGetValueSafe<int>("entryDistributionId");
			    this._EntryDistribution = ObjectFactory.Create<EntryDistribution>(data.TryGetValueSafe<IDictionary<string,object>>("entryDistribution"));
			    this._RemoteId = data.TryGetValueSafe<string>("remoteId");
			    this._ProviderType = (DistributionProviderType)StringEnum.Parse(typeof(DistributionProviderType), data.TryGetValueSafe<string>("providerType"));
			    this._ProviderData = ObjectFactory.Create<DistributionJobProviderData>(data.TryGetValueSafe<IDictionary<string,object>>("providerData"));
			    this._Results = data.TryGetValueSafe<string>("results");
			    this._SentData = data.TryGetValueSafe<string>("sentData");
			    this._MediaFiles = new List<DistributionRemoteMediaFile>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("mediaFiles", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._MediaFiles.Add(ObjectFactory.Create<DistributionRemoteMediaFile>((IDictionary<string,object>)dataDictionary));
			    }
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDistributionJobData");
			kparams.AddIfNotNull("distributionProfileId", this._DistributionProfileId);
			kparams.AddIfNotNull("distributionProfile", this._DistributionProfile);
			kparams.AddIfNotNull("entryDistributionId", this._EntryDistributionId);
			kparams.AddIfNotNull("entryDistribution", this._EntryDistribution);
			kparams.AddIfNotNull("remoteId", this._RemoteId);
			kparams.AddIfNotNull("providerType", this._ProviderType);
			kparams.AddIfNotNull("providerData", this._ProviderData);
			kparams.AddIfNotNull("results", this._Results);
			kparams.AddIfNotNull("sentData", this._SentData);
			kparams.AddIfNotNull("mediaFiles", this._MediaFiles);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DISTRIBUTION_PROFILE_ID:
					return "DistributionProfileId";
				case DISTRIBUTION_PROFILE:
					return "DistributionProfile";
				case ENTRY_DISTRIBUTION_ID:
					return "EntryDistributionId";
				case ENTRY_DISTRIBUTION:
					return "EntryDistribution";
				case REMOTE_ID:
					return "RemoteId";
				case PROVIDER_TYPE:
					return "ProviderType";
				case PROVIDER_DATA:
					return "ProviderData";
				case RESULTS:
					return "Results";
				case SENT_DATA:
					return "SentData";
				case MEDIA_FILES:
					return "MediaFiles";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

