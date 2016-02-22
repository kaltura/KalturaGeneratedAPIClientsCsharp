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
	public class KalturaPartnerStatistics : KalturaObjectBase
	{
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
			set 
			{ 
				_PackageBandwidthAndStorage = value;
				OnPropertyChanged("PackageBandwidthAndStorage");
			}
		}
		public float Hosting
		{
			get { return _Hosting; }
			set 
			{ 
				_Hosting = value;
				OnPropertyChanged("Hosting");
			}
		}
		public float Bandwidth
		{
			get { return _Bandwidth; }
			set 
			{ 
				_Bandwidth = value;
				OnPropertyChanged("Bandwidth");
			}
		}
		public int Usage
		{
			get { return _Usage; }
			set 
			{ 
				_Usage = value;
				OnPropertyChanged("Usage");
			}
		}
		public float UsagePercent
		{
			get { return _UsagePercent; }
			set 
			{ 
				_UsagePercent = value;
				OnPropertyChanged("UsagePercent");
			}
		}
		public int ReachedLimitDate
		{
			get { return _ReachedLimitDate; }
			set 
			{ 
				_ReachedLimitDate = value;
				OnPropertyChanged("ReachedLimitDate");
			}
		}
		#endregion

		#region CTor
		public KalturaPartnerStatistics()
		{
		}

		public KalturaPartnerStatistics(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "packageBandwidthAndStorage":
						this.PackageBandwidthAndStorage = ParseInt(txt);
						continue;
					case "hosting":
						this.Hosting = ParseFloat(txt);
						continue;
					case "bandwidth":
						this.Bandwidth = ParseFloat(txt);
						continue;
					case "usage":
						this.Usage = ParseInt(txt);
						continue;
					case "usagePercent":
						this.UsagePercent = ParseFloat(txt);
						continue;
					case "reachedLimitDate":
						this.ReachedLimitDate = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaPartnerStatistics");
			kparams.AddIfNotNull("packageBandwidthAndStorage", this.PackageBandwidthAndStorage);
			kparams.AddIfNotNull("hosting", this.Hosting);
			kparams.AddIfNotNull("bandwidth", this.Bandwidth);
			kparams.AddIfNotNull("usage", this.Usage);
			kparams.AddIfNotNull("usagePercent", this.UsagePercent);
			kparams.AddIfNotNull("reachedLimitDate", this.ReachedLimitDate);
			return kparams;
		}
		#endregion
	}
}

