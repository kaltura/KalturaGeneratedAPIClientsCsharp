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
	public class Asset : BaseAssetInfo
	{
		#region Constants
		public const string METAS = "metas";
		public const string TAGS = "tags";
		public const string START_DATE = "startDate";
		public const string END_DATE = "endDate";
		public const string ENABLE_CDVR = "enableCdvr";
		public const string ENABLE_CATCH_UP = "enableCatchUp";
		public const string ENABLE_START_OVER = "enableStartOver";
		public const string ENABLE_TRICK_PLAY = "enableTrickPlay";
		#endregion

		#region Private Fields
		private IDictionary<string, Value> _Metas;
		private IDictionary<string, StringValueArray> _Tags;
		private long _StartDate = long.MinValue;
		private long _EndDate = long.MinValue;
		private bool? _EnableCdvr = null;
		private bool? _EnableCatchUp = null;
		private bool? _EnableStartOver = null;
		private bool? _EnableTrickPlay = null;
		#endregion

		#region Properties
		public IDictionary<string, Value> Metas
		{
			get { return _Metas; }
			set 
			{ 
				_Metas = value;
				OnPropertyChanged("Metas");
			}
		}
		public IDictionary<string, StringValueArray> Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		public long StartDate
		{
			get { return _StartDate; }
			set 
			{ 
				_StartDate = value;
				OnPropertyChanged("StartDate");
			}
		}
		public long EndDate
		{
			get { return _EndDate; }
			set 
			{ 
				_EndDate = value;
				OnPropertyChanged("EndDate");
			}
		}
		public bool? EnableCdvr
		{
			get { return _EnableCdvr; }
			set 
			{ 
				_EnableCdvr = value;
				OnPropertyChanged("EnableCdvr");
			}
		}
		public bool? EnableCatchUp
		{
			get { return _EnableCatchUp; }
			set 
			{ 
				_EnableCatchUp = value;
				OnPropertyChanged("EnableCatchUp");
			}
		}
		public bool? EnableStartOver
		{
			get { return _EnableStartOver; }
			set 
			{ 
				_EnableStartOver = value;
				OnPropertyChanged("EnableStartOver");
			}
		}
		public bool? EnableTrickPlay
		{
			get { return _EnableTrickPlay; }
			set 
			{ 
				_EnableTrickPlay = value;
				OnPropertyChanged("EnableTrickPlay");
			}
		}
		#endregion

		#region CTor
		public Asset()
		{
		}

		public Asset(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "metas":
						{
							string key;
							this._Metas = new Dictionary<string, Value>();
							foreach(XmlElement arrayNode in propertyNode.ChildNodes)
							{
								key = arrayNode["itemKey"].InnerText;;
								this._Metas[key] = ObjectFactory.Create<Value>(arrayNode);
							}
						}
						continue;
					case "tags":
						{
							string key;
							this._Tags = new Dictionary<string, StringValueArray>();
							foreach(XmlElement arrayNode in propertyNode.ChildNodes)
							{
								key = arrayNode["itemKey"].InnerText;;
								this._Tags[key] = ObjectFactory.Create<StringValueArray>(arrayNode);
							}
						}
						continue;
					case "startDate":
						this._StartDate = ParseLong(propertyNode.InnerText);
						continue;
					case "endDate":
						this._EndDate = ParseLong(propertyNode.InnerText);
						continue;
					case "enableCdvr":
						this._EnableCdvr = ParseBool(propertyNode.InnerText);
						continue;
					case "enableCatchUp":
						this._EnableCatchUp = ParseBool(propertyNode.InnerText);
						continue;
					case "enableStartOver":
						this._EnableStartOver = ParseBool(propertyNode.InnerText);
						continue;
					case "enableTrickPlay":
						this._EnableTrickPlay = ParseBool(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaAsset");
			kparams.AddIfNotNull("metas", this._Metas);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("startDate", this._StartDate);
			kparams.AddIfNotNull("endDate", this._EndDate);
			kparams.AddIfNotNull("enableCdvr", this._EnableCdvr);
			kparams.AddIfNotNull("enableCatchUp", this._EnableCatchUp);
			kparams.AddIfNotNull("enableStartOver", this._EnableStartOver);
			kparams.AddIfNotNull("enableTrickPlay", this._EnableTrickPlay);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case METAS:
					return "Metas";
				case TAGS:
					return "Tags";
				case START_DATE:
					return "StartDate";
				case END_DATE:
					return "EndDate";
				case ENABLE_CDVR:
					return "EnableCdvr";
				case ENABLE_CATCH_UP:
					return "EnableCatchUp";
				case ENABLE_START_OVER:
					return "EnableStartOver";
				case ENABLE_TRICK_PLAY:
					return "EnableTrickPlay";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

