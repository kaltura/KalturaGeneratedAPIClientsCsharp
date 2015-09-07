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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaPartnerUsage : KalturaObjectBase
	{
		#region Private Fields
		private float _HostingGB = Single.MinValue;
		private float _Percent = Single.MinValue;
		private int _PackageBW = Int32.MinValue;
		private float _UsageGB = Single.MinValue;
		private int _ReachedLimitDate = Int32.MinValue;
		private string _UsageGraph = null;
		#endregion

		#region Properties
		public float HostingGB
		{
			get { return _HostingGB; }
			set 
			{ 
				_HostingGB = value;
				OnPropertyChanged("HostingGB");
			}
		}
		public float Percent
		{
			get { return _Percent; }
			set 
			{ 
				_Percent = value;
				OnPropertyChanged("Percent");
			}
		}
		public int PackageBW
		{
			get { return _PackageBW; }
			set 
			{ 
				_PackageBW = value;
				OnPropertyChanged("PackageBW");
			}
		}
		public float UsageGB
		{
			get { return _UsageGB; }
			set 
			{ 
				_UsageGB = value;
				OnPropertyChanged("UsageGB");
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
		public string UsageGraph
		{
			get { return _UsageGraph; }
			set 
			{ 
				_UsageGraph = value;
				OnPropertyChanged("UsageGraph");
			}
		}
		#endregion

		#region CTor
		public KalturaPartnerUsage()
		{
		}

		public KalturaPartnerUsage(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "hostingGB":
						this.HostingGB = ParseFloat(txt);
						continue;
					case "Percent":
						this.Percent = ParseFloat(txt);
						continue;
					case "packageBW":
						this.PackageBW = ParseInt(txt);
						continue;
					case "usageGB":
						this.UsageGB = ParseFloat(txt);
						continue;
					case "reachedLimitDate":
						this.ReachedLimitDate = ParseInt(txt);
						continue;
					case "usageGraph":
						this.UsageGraph = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaPartnerUsage");
			kparams.AddIfNotNull("hostingGB", this.HostingGB);
			kparams.AddIfNotNull("Percent", this.Percent);
			kparams.AddIfNotNull("packageBW", this.PackageBW);
			kparams.AddIfNotNull("usageGB", this.UsageGB);
			kparams.AddIfNotNull("reachedLimitDate", this.ReachedLimitDate);
			kparams.AddIfNotNull("usageGraph", this.UsageGraph);
			return kparams;
		}
		#endregion
	}
}

