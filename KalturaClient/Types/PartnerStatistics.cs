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
	public class PartnerStatistics : ObjectBase
	{
		#region Constants
		public const string PACKAGE_BANDWIDTH_AND_STORAGE = "packageBandwidthAndStorage";
		public const string HOSTING = "hosting";
		public const string BANDWIDTH = "bandwidth";
		public const string USAGE = "usage";
		public const string USAGE_PERCENT = "usagePercent";
		public const string REACHED_LIMIT_DATE = "reachedLimitDate";
		#endregion

		#region Private Fields
		private int _PackageBandwidthAndStorage = Int32.MinValue;
		private float _Hosting = Single.MinValue;
		private float _Bandwidth = Single.MinValue;
		private int _Usage = Int32.MinValue;
		private float _UsagePercent = Single.MinValue;
		private int _ReachedLimitDate = Int32.MinValue;
		#endregion

		#region Properties
		public int PackageBandwidthAndStorage
		{
			get { return _PackageBandwidthAndStorage; }
		}
		public float Hosting
		{
			get { return _Hosting; }
		}
		public float Bandwidth
		{
			get { return _Bandwidth; }
		}
		public int Usage
		{
			get { return _Usage; }
		}
		public float UsagePercent
		{
			get { return _UsagePercent; }
		}
		public int ReachedLimitDate
		{
			get { return _ReachedLimitDate; }
		}
		#endregion

		#region CTor
		public PartnerStatistics()
		{
		}

		public PartnerStatistics(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "packageBandwidthAndStorage":
						this._PackageBandwidthAndStorage = ParseInt(propertyNode.InnerText);
						continue;
					case "hosting":
						this._Hosting = ParseFloat(propertyNode.InnerText);
						continue;
					case "bandwidth":
						this._Bandwidth = ParseFloat(propertyNode.InnerText);
						continue;
					case "usage":
						this._Usage = ParseInt(propertyNode.InnerText);
						continue;
					case "usagePercent":
						this._UsagePercent = ParseFloat(propertyNode.InnerText);
						continue;
					case "reachedLimitDate":
						this._ReachedLimitDate = ParseInt(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaPartnerStatistics");
			kparams.AddIfNotNull("packageBandwidthAndStorage", this._PackageBandwidthAndStorage);
			kparams.AddIfNotNull("hosting", this._Hosting);
			kparams.AddIfNotNull("bandwidth", this._Bandwidth);
			kparams.AddIfNotNull("usage", this._Usage);
			kparams.AddIfNotNull("usagePercent", this._UsagePercent);
			kparams.AddIfNotNull("reachedLimitDate", this._ReachedLimitDate);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PACKAGE_BANDWIDTH_AND_STORAGE:
					return "PackageBandwidthAndStorage";
				case HOSTING:
					return "Hosting";
				case BANDWIDTH:
					return "Bandwidth";
				case USAGE:
					return "Usage";
				case USAGE_PERCENT:
					return "UsagePercent";
				case REACHED_LIMIT_DATE:
					return "ReachedLimitDate";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

