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
		}
		public float Percent
		{
			get { return _Percent; }
		}
		public int PackageBW
		{
			get { return _PackageBW; }
		}
		public float UsageGB
		{
			get { return _UsageGB; }
		}
		public int ReachedLimitDate
		{
			get { return _ReachedLimitDate; }
		}
		public string UsageGraph
		{
			get { return _UsageGraph; }
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
						this._HostingGB = ParseFloat(txt);
						continue;
					case "Percent":
						this._Percent = ParseFloat(txt);
						continue;
					case "packageBW":
						this._PackageBW = ParseInt(txt);
						continue;
					case "usageGB":
						this._UsageGB = ParseFloat(txt);
						continue;
					case "reachedLimitDate":
						this._ReachedLimitDate = ParseInt(txt);
						continue;
					case "usageGraph":
						this._UsageGraph = txt;
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
			kparams.AddIfNotNull("hostingGB", this._HostingGB);
			kparams.AddIfNotNull("Percent", this._Percent);
			kparams.AddIfNotNull("packageBW", this._PackageBW);
			kparams.AddIfNotNull("usageGB", this._UsageGB);
			kparams.AddIfNotNull("reachedLimitDate", this._ReachedLimitDate);
			kparams.AddIfNotNull("usageGraph", this._UsageGraph);
			return kparams;
		}
		#endregion
	}
}

