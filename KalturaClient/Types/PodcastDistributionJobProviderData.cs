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
	public class PodcastDistributionJobProviderData : DistributionJobProviderData
	{
		#region Constants
		public const string XML = "xml";
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		public const string DISTRIBUTION_PROFILE_ID = "distributionProfileId";
		#endregion

		#region Private Fields
		private string _Xml = null;
		private int _MetadataProfileId = Int32.MinValue;
		private int _DistributionProfileId = Int32.MinValue;
		#endregion

		#region Properties
		public string Xml
		{
			get { return _Xml; }
			set 
			{ 
				_Xml = value;
				OnPropertyChanged("Xml");
			}
		}
		public int MetadataProfileId
		{
			get { return _MetadataProfileId; }
			set 
			{ 
				_MetadataProfileId = value;
				OnPropertyChanged("MetadataProfileId");
			}
		}
		public int DistributionProfileId
		{
			get { return _DistributionProfileId; }
			set 
			{ 
				_DistributionProfileId = value;
				OnPropertyChanged("DistributionProfileId");
			}
		}
		#endregion

		#region CTor
		public PodcastDistributionJobProviderData()
		{
		}

		public PodcastDistributionJobProviderData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "xml":
						this._Xml = propertyNode.InnerText;
						continue;
					case "metadataProfileId":
						this._MetadataProfileId = ParseInt(propertyNode.InnerText);
						continue;
					case "distributionProfileId":
						this._DistributionProfileId = ParseInt(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaPodcastDistributionJobProviderData");
			kparams.AddIfNotNull("xml", this._Xml);
			kparams.AddIfNotNull("metadataProfileId", this._MetadataProfileId);
			kparams.AddIfNotNull("distributionProfileId", this._DistributionProfileId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case XML:
					return "Xml";
				case METADATA_PROFILE_ID:
					return "MetadataProfileId";
				case DISTRIBUTION_PROFILE_ID:
					return "DistributionProfileId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

