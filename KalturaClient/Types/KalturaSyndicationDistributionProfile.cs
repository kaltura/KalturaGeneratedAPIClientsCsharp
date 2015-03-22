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
	public class KalturaSyndicationDistributionProfile : KalturaDistributionProfile
	{
		#region Private Fields
		private string _Xsl = null;
		private string _FeedId = null;
		#endregion

		#region Properties
		public string Xsl
		{
			get { return _Xsl; }
			set 
			{ 
				_Xsl = value;
				OnPropertyChanged("Xsl");
			}
		}
		public string FeedId
		{
			get { return _FeedId; }
			set 
			{ 
				_FeedId = value;
				OnPropertyChanged("FeedId");
			}
		}
		#endregion

		#region CTor
		public KalturaSyndicationDistributionProfile()
		{
		}

		public KalturaSyndicationDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "xsl":
						this.Xsl = txt;
						continue;
					case "feedId":
						this.FeedId = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaSyndicationDistributionProfile");
			kparams.AddStringIfNotNull("xsl", this.Xsl);
			kparams.AddStringIfNotNull("feedId", this.FeedId);
			return kparams;
		}
		#endregion
	}
}

