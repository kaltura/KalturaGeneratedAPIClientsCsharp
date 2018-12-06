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
	public class ESearchCaptionItemData : ESearchItemData
	{
		#region Constants
		public const string LINE = "line";
		public const string STARTS_AT = "startsAt";
		public const string ENDS_AT = "endsAt";
		public const string LANGUAGE = "language";
		public const string CAPTION_ASSET_ID = "captionAssetId";
		public const string LABEL = "label";
		#endregion

		#region Private Fields
		private string _Line = null;
		private int _StartsAt = Int32.MinValue;
		private int _EndsAt = Int32.MinValue;
		private string _Language = null;
		private string _CaptionAssetId = null;
		private string _Label = null;
		#endregion

		#region Properties
		public string Line
		{
			get { return _Line; }
			set 
			{ 
				_Line = value;
				OnPropertyChanged("Line");
			}
		}
		public int StartsAt
		{
			get { return _StartsAt; }
			set 
			{ 
				_StartsAt = value;
				OnPropertyChanged("StartsAt");
			}
		}
		public int EndsAt
		{
			get { return _EndsAt; }
			set 
			{ 
				_EndsAt = value;
				OnPropertyChanged("EndsAt");
			}
		}
		public string Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		public string CaptionAssetId
		{
			get { return _CaptionAssetId; }
			set 
			{ 
				_CaptionAssetId = value;
				OnPropertyChanged("CaptionAssetId");
			}
		}
		public string Label
		{
			get { return _Label; }
			set 
			{ 
				_Label = value;
				OnPropertyChanged("Label");
			}
		}
		#endregion

		#region CTor
		public ESearchCaptionItemData()
		{
		}

		public ESearchCaptionItemData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "line":
						this._Line = propertyNode.InnerText;
						continue;
					case "startsAt":
						this._StartsAt = ParseInt(propertyNode.InnerText);
						continue;
					case "endsAt":
						this._EndsAt = ParseInt(propertyNode.InnerText);
						continue;
					case "language":
						this._Language = propertyNode.InnerText;
						continue;
					case "captionAssetId":
						this._CaptionAssetId = propertyNode.InnerText;
						continue;
					case "label":
						this._Label = propertyNode.InnerText;
						continue;
				}
			}
		}

		public ESearchCaptionItemData(IDictionary<string,object> data) : base(data)
		{
			    this._Line = data.TryGetValueSafe<string>("line");
			    this._StartsAt = data.TryGetValueSafe<int>("startsAt");
			    this._EndsAt = data.TryGetValueSafe<int>("endsAt");
			    this._Language = data.TryGetValueSafe<string>("language");
			    this._CaptionAssetId = data.TryGetValueSafe<string>("captionAssetId");
			    this._Label = data.TryGetValueSafe<string>("label");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaESearchCaptionItemData");
			kparams.AddIfNotNull("line", this._Line);
			kparams.AddIfNotNull("startsAt", this._StartsAt);
			kparams.AddIfNotNull("endsAt", this._EndsAt);
			kparams.AddIfNotNull("language", this._Language);
			kparams.AddIfNotNull("captionAssetId", this._CaptionAssetId);
			kparams.AddIfNotNull("label", this._Label);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case LINE:
					return "Line";
				case STARTS_AT:
					return "StartsAt";
				case ENDS_AT:
					return "EndsAt";
				case LANGUAGE:
					return "Language";
				case CAPTION_ASSET_ID:
					return "CaptionAssetId";
				case LABEL:
					return "Label";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

