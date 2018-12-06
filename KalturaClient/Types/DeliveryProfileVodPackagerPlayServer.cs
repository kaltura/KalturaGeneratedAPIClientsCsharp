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
	public class DeliveryProfileVodPackagerPlayServer : DeliveryProfile
	{
		#region Constants
		public const string AD_STITCHING_ENABLED = "adStitchingEnabled";
		#endregion

		#region Private Fields
		private bool? _AdStitchingEnabled = null;
		#endregion

		#region Properties
		public bool? AdStitchingEnabled
		{
			get { return _AdStitchingEnabled; }
			set 
			{ 
				_AdStitchingEnabled = value;
				OnPropertyChanged("AdStitchingEnabled");
			}
		}
		#endregion

		#region CTor
		public DeliveryProfileVodPackagerPlayServer()
		{
		}

		public DeliveryProfileVodPackagerPlayServer(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "adStitchingEnabled":
						this._AdStitchingEnabled = ParseBool(propertyNode.InnerText);
						continue;
				}
			}
		}

		public DeliveryProfileVodPackagerPlayServer(IDictionary<string,object> data) : base(data)
		{
			    this._AdStitchingEnabled = data.TryGetValueSafe<bool>("adStitchingEnabled");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDeliveryProfileVodPackagerPlayServer");
			kparams.AddIfNotNull("adStitchingEnabled", this._AdStitchingEnabled);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case AD_STITCHING_ENABLED:
					return "AdStitchingEnabled";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

