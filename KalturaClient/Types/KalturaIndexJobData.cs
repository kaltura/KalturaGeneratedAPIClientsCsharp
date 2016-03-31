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
	public class KalturaIndexJobData : KalturaJobData
	{
		#region Private Fields
		private KalturaFilter _Filter;
		private int _LastIndexId = Int32.MinValue;
		private bool? _ShouldUpdate = null;
		#endregion

		#region Properties
		public KalturaFilter Filter
		{
			get { return _Filter; }
			set 
			{ 
				_Filter = value;
				OnPropertyChanged("Filter");
			}
		}
		public int LastIndexId
		{
			get { return _LastIndexId; }
			set 
			{ 
				_LastIndexId = value;
				OnPropertyChanged("LastIndexId");
			}
		}
		public bool? ShouldUpdate
		{
			get { return _ShouldUpdate; }
			set 
			{ 
				_ShouldUpdate = value;
				OnPropertyChanged("ShouldUpdate");
			}
		}
		#endregion

		#region CTor
		public KalturaIndexJobData()
		{
		}

		public KalturaIndexJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "filter":
						this.Filter = (KalturaFilter)KalturaObjectFactory.Create(propertyNode, "KalturaFilter");
						continue;
					case "lastIndexId":
						this.LastIndexId = ParseInt(txt);
						continue;
					case "shouldUpdate":
						this.ShouldUpdate = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaIndexJobData");
			kparams.AddIfNotNull("filter", this.Filter);
			kparams.AddIfNotNull("lastIndexId", this.LastIndexId);
			kparams.AddIfNotNull("shouldUpdate", this.ShouldUpdate);
			return kparams;
		}
		#endregion
	}
}

