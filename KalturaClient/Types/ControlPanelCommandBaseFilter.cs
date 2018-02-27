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
	public class ControlPanelCommandBaseFilter : Filter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string CREATED_BY_ID_EQUAL = "createdByIdEqual";
		public const string TYPE_EQUAL = "typeEqual";
		public const string TYPE_IN = "typeIn";
		public const string TARGET_TYPE_EQUAL = "targetTypeEqual";
		public const string TARGET_TYPE_IN = "targetTypeIn";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		#endregion

		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _CreatedByIdEqual = Int32.MinValue;
		private ControlPanelCommandType _TypeEqual = (ControlPanelCommandType)Int32.MinValue;
		private string _TypeIn = null;
		private ControlPanelCommandTargetType _TargetTypeEqual = (ControlPanelCommandTargetType)Int32.MinValue;
		private string _TargetTypeIn = null;
		private ControlPanelCommandStatus _StatusEqual = (ControlPanelCommandStatus)Int32.MinValue;
		private string _StatusIn = null;
		#endregion

		#region Properties
		public int IdEqual
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
		public int CreatedByIdEqual
		{
			get { return _CreatedByIdEqual; }
			set 
			{ 
				_CreatedByIdEqual = value;
				OnPropertyChanged("CreatedByIdEqual");
			}
		}
		public ControlPanelCommandType TypeEqual
		{
			get { return _TypeEqual; }
			set 
			{ 
				_TypeEqual = value;
				OnPropertyChanged("TypeEqual");
			}
		}
		public string TypeIn
		{
			get { return _TypeIn; }
			set 
			{ 
				_TypeIn = value;
				OnPropertyChanged("TypeIn");
			}
		}
		public ControlPanelCommandTargetType TargetTypeEqual
		{
			get { return _TargetTypeEqual; }
			set 
			{ 
				_TargetTypeEqual = value;
				OnPropertyChanged("TargetTypeEqual");
			}
		}
		public string TargetTypeIn
		{
			get { return _TargetTypeIn; }
			set 
			{ 
				_TargetTypeIn = value;
				OnPropertyChanged("TargetTypeIn");
			}
		}
		public ControlPanelCommandStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		#endregion

		#region CTor
		public ControlPanelCommandBaseFilter()
		{
		}

		public ControlPanelCommandBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "idEqual":
						this._IdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "idIn":
						this._IdIn = propertyNode.InnerText;
						continue;
					case "createdAtGreaterThanOrEqual":
						this._CreatedAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAtLessThanOrEqual":
						this._CreatedAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "createdByIdEqual":
						this._CreatedByIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "typeEqual":
						this._TypeEqual = (ControlPanelCommandType)ParseEnum(typeof(ControlPanelCommandType), propertyNode.InnerText);
						continue;
					case "typeIn":
						this._TypeIn = propertyNode.InnerText;
						continue;
					case "targetTypeEqual":
						this._TargetTypeEqual = (ControlPanelCommandTargetType)ParseEnum(typeof(ControlPanelCommandTargetType), propertyNode.InnerText);
						continue;
					case "targetTypeIn":
						this._TargetTypeIn = propertyNode.InnerText;
						continue;
					case "statusEqual":
						this._StatusEqual = (ControlPanelCommandStatus)ParseEnum(typeof(ControlPanelCommandStatus), propertyNode.InnerText);
						continue;
					case "statusIn":
						this._StatusIn = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaControlPanelCommandBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("createdByIdEqual", this._CreatedByIdEqual);
			kparams.AddIfNotNull("typeEqual", this._TypeEqual);
			kparams.AddIfNotNull("typeIn", this._TypeIn);
			kparams.AddIfNotNull("targetTypeEqual", this._TargetTypeEqual);
			kparams.AddIfNotNull("targetTypeIn", this._TargetTypeIn);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
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
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case CREATED_BY_ID_EQUAL:
					return "CreatedByIdEqual";
				case TYPE_EQUAL:
					return "TypeEqual";
				case TYPE_IN:
					return "TypeIn";
				case TARGET_TYPE_EQUAL:
					return "TargetTypeEqual";
				case TARGET_TYPE_IN:
					return "TargetTypeIn";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

