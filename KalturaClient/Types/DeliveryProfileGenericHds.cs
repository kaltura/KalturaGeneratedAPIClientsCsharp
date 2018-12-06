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
	public class DeliveryProfileGenericHds : DeliveryProfile
	{
		#region Constants
		public const string PATTERN = "pattern";
		public const string RENDERER_CLASS = "rendererClass";
		#endregion

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
		public DeliveryProfileGenericHds()
		{
		}

		public DeliveryProfileGenericHds(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "pattern":
						this._Pattern = propertyNode.InnerText;
						continue;
					case "rendererClass":
						this._RendererClass = propertyNode.InnerText;
						continue;
				}
			}
		}

		public DeliveryProfileGenericHds(IDictionary<string,object> data) : base(data)
		{
			    this._Pattern = data.TryGetValueSafe<string>("pattern");
			    this._RendererClass = data.TryGetValueSafe<string>("rendererClass");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDeliveryProfileGenericHds");
			kparams.AddIfNotNull("pattern", this._Pattern);
			kparams.AddIfNotNull("rendererClass", this._RendererClass);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PATTERN:
					return "Pattern";
				case RENDERER_CLASS:
					return "RendererClass";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

