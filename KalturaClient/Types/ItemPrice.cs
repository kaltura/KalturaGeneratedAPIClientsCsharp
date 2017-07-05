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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class ItemPrice : ProductPrice
	{
		#region Constants
		public const string FILE_ID = "fileId";
		public const string PPV_PRICE_DETAILS = "ppvPriceDetails";
		#endregion

		#region Private Fields
		private int _FileId = Int32.MinValue;
		private IList<PPVItemPriceDetails> _PpvPriceDetails;
		#endregion

		#region Properties
		public int FileId
		{
			get { return _FileId; }
			set 
			{ 
				_FileId = value;
				OnPropertyChanged("FileId");
			}
		}
		public IList<PPVItemPriceDetails> PpvPriceDetails
		{
			get { return _PpvPriceDetails; }
			set 
			{ 
				_PpvPriceDetails = value;
				OnPropertyChanged("PpvPriceDetails");
			}
		}
		#endregion

		#region CTor
		public ItemPrice()
		{
		}

		public ItemPrice(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "fileId":
						this._FileId = ParseInt(propertyNode.InnerText);
						continue;
					case "ppvPriceDetails":
						this._PpvPriceDetails = new List<PPVItemPriceDetails>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._PpvPriceDetails.Add(ObjectFactory.Create<PPVItemPriceDetails>(arrayNode));
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
				kparams.AddReplace("objectType", "KalturaItemPrice");
			kparams.AddIfNotNull("fileId", this._FileId);
			kparams.AddIfNotNull("ppvPriceDetails", this._PpvPriceDetails);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FILE_ID:
					return "FileId";
				case PPV_PRICE_DETAILS:
					return "PpvPriceDetails";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

