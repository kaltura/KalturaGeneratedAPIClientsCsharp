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
	public class GenericXsltSyndicationFeed : GenericSyndicationFeed
	{
		#region Constants
		public const string XSLT = "xslt";
		public const string ITEM_XPATHS_TO_EXTEND = "itemXpathsToExtend";
		#endregion

		#region Private Fields
		private string _Xslt = null;
		private IList<ExtendingItemMrssParameter> _ItemXpathsToExtend;
		#endregion

		#region Properties
		public string Xslt
		{
			get { return _Xslt; }
			set 
			{ 
				_Xslt = value;
				OnPropertyChanged("Xslt");
			}
		}
		public IList<ExtendingItemMrssParameter> ItemXpathsToExtend
		{
			get { return _ItemXpathsToExtend; }
			set 
			{ 
				_ItemXpathsToExtend = value;
				OnPropertyChanged("ItemXpathsToExtend");
			}
		}
		#endregion

		#region CTor
		public GenericXsltSyndicationFeed()
		{
		}

		public GenericXsltSyndicationFeed(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "xslt":
						this._Xslt = propertyNode.InnerText;
						continue;
					case "itemXpathsToExtend":
						this._ItemXpathsToExtend = new List<ExtendingItemMrssParameter>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._ItemXpathsToExtend.Add(ObjectFactory.Create<ExtendingItemMrssParameter>(arrayNode));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaGenericXsltSyndicationFeed");
			kparams.AddIfNotNull("xslt", this._Xslt);
			kparams.AddIfNotNull("itemXpathsToExtend", this._ItemXpathsToExtend);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case XSLT:
					return "Xslt";
				case ITEM_XPATHS_TO_EXTEND:
					return "ItemXpathsToExtend";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

