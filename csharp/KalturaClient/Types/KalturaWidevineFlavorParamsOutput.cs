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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public class KalturaWidevineFlavorParamsOutput : KalturaFlavorParamsOutput
	{
		#region Private Fields
		private int _WidevineDistributionStartDate = Int32.MinValue;
		private int _WidevineDistributionEndDate = Int32.MinValue;
		#endregion

		#region Properties
		public int WidevineDistributionStartDate
		{
			get { return _WidevineDistributionStartDate; }
			set 
			{ 
				_WidevineDistributionStartDate = value;
				OnPropertyChanged("WidevineDistributionStartDate");
			}
		}
		public int WidevineDistributionEndDate
		{
			get { return _WidevineDistributionEndDate; }
			set 
			{ 
				_WidevineDistributionEndDate = value;
				OnPropertyChanged("WidevineDistributionEndDate");
			}
		}
		#endregion

		#region CTor
		public KalturaWidevineFlavorParamsOutput()
		{
		}

		public KalturaWidevineFlavorParamsOutput(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "widevineDistributionStartDate":
						this.WidevineDistributionStartDate = ParseInt(txt);
						continue;
					case "widevineDistributionEndDate":
						this.WidevineDistributionEndDate = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaWidevineFlavorParamsOutput");
			kparams.AddIntIfNotNull("widevineDistributionStartDate", this.WidevineDistributionStartDate);
			kparams.AddIntIfNotNull("widevineDistributionEndDate", this.WidevineDistributionEndDate);
			return kparams;
		}
		#endregion
	}
}

