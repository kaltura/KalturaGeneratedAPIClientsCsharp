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
	public class KalturaDeliveryProfileGenericHds : KalturaDeliveryProfile
	{
		#region Private Fields
		private string _Pattern = null;
		private string _RendererClass = null;
		#endregion

		#region Properties
		public string Pattern
		{
			get { return _Pattern; }
			set 
			{ 
				_Pattern = value;
				OnPropertyChanged("Pattern");
			}
		}
		public string RendererClass
		{
			get { return _RendererClass; }
			set 
			{ 
				_RendererClass = value;
				OnPropertyChanged("RendererClass");
			}
		}
		#endregion

		#region CTor
		public KalturaDeliveryProfileGenericHds()
		{
		}

		public KalturaDeliveryProfileGenericHds(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "pattern":
						this._Pattern = txt;
						continue;
					case "rendererClass":
						this._RendererClass = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaDeliveryProfileGenericHds");
			kparams.AddIfNotNull("pattern", this.Pattern);
			kparams.AddIfNotNull("rendererClass", this.RendererClass);
			return kparams;
		}
		#endregion
	}
}

