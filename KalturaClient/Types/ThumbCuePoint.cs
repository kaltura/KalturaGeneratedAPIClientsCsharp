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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class ThumbCuePoint : CuePoint
	{
		#region Constants
		public const string ASSET_ID = "assetId";
		public const string DESCRIPTION = "description";
		public const string TITLE = "title";
		public const string SUB_TYPE = "subType";
		#endregion

		#region Private Fields
		private string _AssetId = null;
		private string _Description = null;
		private string _Title = null;
		private ThumbCuePointSubType _SubType = (ThumbCuePointSubType)Int32.MinValue;
		#endregion

		#region Properties
		public string AssetId
		{
			get { return _AssetId; }
			set 
			{ 
				_AssetId = value;
				OnPropertyChanged("AssetId");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public string Title
		{
			get { return _Title; }
			set 
			{ 
				_Title = value;
				OnPropertyChanged("Title");
			}
		}
		public ThumbCuePointSubType SubType
		{
			get { return _SubType; }
			set 
			{ 
				_SubType = value;
				OnPropertyChanged("SubType");
			}
		}
		#endregion

		#region CTor
		public ThumbCuePoint()
		{
		}

		public ThumbCuePoint(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "assetId":
						this._AssetId = txt;
						continue;
					case "description":
						this._Description = txt;
						continue;
					case "title":
						this._Title = txt;
						continue;
					case "subType":
						this._SubType = (ThumbCuePointSubType)ParseEnum(typeof(ThumbCuePointSubType), txt);
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
				kparams.AddReplace("objectType", "KalturaThumbCuePoint");
			kparams.AddIfNotNull("assetId", this._AssetId);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("title", this._Title);
			kparams.AddIfNotNull("subType", this._SubType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ASSET_ID:
					return "AssetId";
				case DESCRIPTION:
					return "Description";
				case TITLE:
					return "Title";
				case SUB_TYPE:
					return "SubType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

