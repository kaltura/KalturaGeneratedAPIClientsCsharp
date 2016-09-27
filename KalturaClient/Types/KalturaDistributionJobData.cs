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
// Copyright (C) 2006-2016  Kaltura Inc.
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
	public class KalturaDistributionJobData : KalturaJobData
	{
		#region Private Fields
		private int _DistributionProfileId = Int32.MinValue;
		private KalturaDistributionProfile _DistributionProfile;
		private int _EntryDistributionId = Int32.MinValue;
		private KalturaEntryDistribution _EntryDistribution;
		private string _RemoteId = null;
		private KalturaDistributionProviderType _ProviderType = null;
		private KalturaDistributionJobProviderData _ProviderData;
		private string _Results = null;
		private string _SentData = null;
		private IList<KalturaDistributionRemoteMediaFile> _MediaFiles;
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
		public KalturaDistributionProfile DistributionProfile
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
		public KalturaEntryDistribution EntryDistribution
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
		public KalturaDistributionProviderType ProviderType
		{
			get { return _ProviderType; }
			set 
			{ 
				_ProviderType = value;
				OnPropertyChanged("ProviderType");
			}
		}
		public KalturaDistributionJobProviderData ProviderData
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
		public new IList<KalturaDistributionRemoteMediaFile> MediaFiles
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
		public KalturaDistributionJobData()
		{
		}

		public KalturaDistributionJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "distributionProfileId":
						this._DistributionProfileId = ParseInt(txt);
						continue;
					case "distributionProfile":
						this._DistributionProfile = (KalturaDistributionProfile)KalturaObjectFactory.Create(propertyNode, "KalturaDistributionProfile");
						continue;
					case "entryDistributionId":
						this._EntryDistributionId = ParseInt(txt);
						continue;
					case "entryDistribution":
						this._EntryDistribution = (KalturaEntryDistribution)KalturaObjectFactory.Create(propertyNode, "KalturaEntryDistribution");
						continue;
					case "remoteId":
						this._RemoteId = txt;
						continue;
					case "providerType":
						this._ProviderType = (KalturaDistributionProviderType)KalturaStringEnum.Parse(typeof(KalturaDistributionProviderType), txt);
						continue;
					case "providerData":
						this._ProviderData = (KalturaDistributionJobProviderData)KalturaObjectFactory.Create(propertyNode, "KalturaDistributionJobProviderData");
						continue;
					case "results":
						this._Results = txt;
						continue;
					case "sentData":
						this._SentData = txt;
						continue;
					case "mediaFiles":
						this._MediaFiles = new List<KalturaDistributionRemoteMediaFile>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._MediaFiles.Add((KalturaDistributionRemoteMediaFile)KalturaObjectFactory.Create(arrayNode, "KalturaDistributionRemoteMediaFile"));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
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
		#endregion
	}
}

