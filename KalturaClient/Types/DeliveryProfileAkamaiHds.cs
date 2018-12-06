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
	public class DeliveryProfileAkamaiHds : DeliveryProfile
	{
		#region Constants
		public const string SUPPORT_CLIPPING = "supportClipping";
		#endregion

		#region Private Fields
		private bool? _SupportClipping = null;
		#endregion

		#region Properties
		public bool? SupportClipping
		{
			get { return _SupportClipping; }
			set 
			{ 
				_SupportClipping = value;
				OnPropertyChanged("SupportClipping");
			}
		}
		#endregion

		#region CTor
		public DeliveryProfileAkamaiHds()
		{
		}

		public DeliveryProfileAkamaiHds(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "supportClipping":
						this._SupportClipping = ParseBool(propertyNode.InnerText);
						continue;
				}
			}
		}

		public DeliveryProfileAkamaiHds(IDictionary<string,object> data) : base(data)
		{
			    this._SupportClipping = data.TryGetValueSafe<bool>("supportClipping");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDeliveryProfileAkamaiHds");
			kparams.AddIfNotNull("supportClipping", this._SupportClipping);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SUPPORT_CLIPPING:
					return "SupportClipping";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

