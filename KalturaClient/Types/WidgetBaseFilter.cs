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
	public class WidgetBaseFilter : Filter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string SOURCE_WIDGET_ID_EQUAL = "sourceWidgetIdEqual";
		public const string ROOT_WIDGET_ID_EQUAL = "rootWidgetIdEqual";
		public const string PARTNER_ID_EQUAL = "partnerIdEqual";
		public const string ENTRY_ID_EQUAL = "entryIdEqual";
		public const string UI_CONF_ID_EQUAL = "uiConfIdEqual";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		public const string PARTNER_DATA_LIKE = "partnerDataLike";
		#endregion

		#region Private Fields
		private string _IdEqual = null;
		private string _IdIn = null;
		private string _SourceWidgetIdEqual = null;
		private string _RootWidgetIdEqual = null;
		private int _PartnerIdEqual = Int32.MinValue;
		private string _EntryIdEqual = null;
		private int _UiConfIdEqual = Int32.MinValue;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private string _PartnerDataLike = null;
		#endregion

		#region Properties
		public string IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
			}
		}
		public string SourceWidgetIdEqual
		{
			get { return _SourceWidgetIdEqual; }
			set 
			{ 
				_SourceWidgetIdEqual = value;
				OnPropertyChanged("SourceWidgetIdEqual");
			}
		}
		public string RootWidgetIdEqual
		{
			get { return _RootWidgetIdEqual; }
			set 
			{ 
				_RootWidgetIdEqual = value;
				OnPropertyChanged("RootWidgetIdEqual");
			}
		}
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		public string EntryIdEqual
		{
			get { return _EntryIdEqual; }
			set 
			{ 
				_EntryIdEqual = value;
				OnPropertyChanged("EntryIdEqual");
			}
		}
		public int UiConfIdEqual
		{
			get { return _UiConfIdEqual; }
			set 
			{ 
				_UiConfIdEqual = value;
				OnPropertyChanged("UiConfIdEqual");
			}
		}
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		public string PartnerDataLike
		{
			get { return _PartnerDataLike; }
			set 
			{ 
				_PartnerDataLike = value;
				OnPropertyChanged("PartnerDataLike");
			}
		}
		#endregion

		#region CTor
		public WidgetBaseFilter()
		{
		}

		public WidgetBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "idEqual":
						this._IdEqual = propertyNode.InnerText;
						continue;
					case "idIn":
						this._IdIn = propertyNode.InnerText;
						continue;
					case "sourceWidgetIdEqual":
						this._SourceWidgetIdEqual = propertyNode.InnerText;
						continue;
					case "rootWidgetIdEqual":
						this._RootWidgetIdEqual = propertyNode.InnerText;
						continue;
					case "partnerIdEqual":
						this._PartnerIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "entryIdEqual":
						this._EntryIdEqual = propertyNode.InnerText;
						continue;
					case "uiConfIdEqual":
						this._UiConfIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAtGreaterThanOrEqual":
						this._CreatedAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAtLessThanOrEqual":
						this._CreatedAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this._UpdatedAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAtLessThanOrEqual":
						this._UpdatedAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerDataLike":
						this._PartnerDataLike = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaWidgetBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("sourceWidgetIdEqual", this._SourceWidgetIdEqual);
			kparams.AddIfNotNull("rootWidgetIdEqual", this._RootWidgetIdEqual);
			kparams.AddIfNotNull("partnerIdEqual", this._PartnerIdEqual);
			kparams.AddIfNotNull("entryIdEqual", this._EntryIdEqual);
			kparams.AddIfNotNull("uiConfIdEqual", this._UiConfIdEqual);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("partnerDataLike", this._PartnerDataLike);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_EQUAL:
					return "IdEqual";
				case ID_IN:
					return "IdIn";
				case SOURCE_WIDGET_ID_EQUAL:
					return "SourceWidgetIdEqual";
				case ROOT_WIDGET_ID_EQUAL:
					return "RootWidgetIdEqual";
				case PARTNER_ID_EQUAL:
					return "PartnerIdEqual";
				case ENTRY_ID_EQUAL:
					return "EntryIdEqual";
				case UI_CONF_ID_EQUAL:
					return "UiConfIdEqual";
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case UPDATED_AT_GREATER_THAN_OR_EQUAL:
					return "UpdatedAtGreaterThanOrEqual";
				case UPDATED_AT_LESS_THAN_OR_EQUAL:
					return "UpdatedAtLessThanOrEqual";
				case PARTNER_DATA_LIKE:
					return "PartnerDataLike";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

