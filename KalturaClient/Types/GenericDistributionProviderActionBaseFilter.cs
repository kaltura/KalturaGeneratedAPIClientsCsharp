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
	public class GenericDistributionProviderActionBaseFilter : Filter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		public const string GENERIC_DISTRIBUTION_PROVIDER_ID_EQUAL = "genericDistributionProviderIdEqual";
		public const string GENERIC_DISTRIBUTION_PROVIDER_ID_IN = "genericDistributionProviderIdIn";
		public const string ACTION_EQUAL = "actionEqual";
		public const string ACTION_IN = "actionIn";
		#endregion

		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _GenericDistributionProviderIdEqual = Int32.MinValue;
		private string _GenericDistributionProviderIdIn = null;
		private DistributionAction _ActionEqual = (DistributionAction)Int32.MinValue;
		private string _ActionIn = null;
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
		public int GenericDistributionProviderIdEqual
		{
			get { return _GenericDistributionProviderIdEqual; }
			set 
			{ 
				_GenericDistributionProviderIdEqual = value;
				OnPropertyChanged("GenericDistributionProviderIdEqual");
			}
		}
		public string GenericDistributionProviderIdIn
		{
			get { return _GenericDistributionProviderIdIn; }
			set 
			{ 
				_GenericDistributionProviderIdIn = value;
				OnPropertyChanged("GenericDistributionProviderIdIn");
			}
		}
		public DistributionAction ActionEqual
		{
			get { return _ActionEqual; }
			set 
			{ 
				_ActionEqual = value;
				OnPropertyChanged("ActionEqual");
			}
		}
		public string ActionIn
		{
			get { return _ActionIn; }
			set 
			{ 
				_ActionIn = value;
				OnPropertyChanged("ActionIn");
			}
		}
		#endregion

		#region CTor
		public GenericDistributionProviderActionBaseFilter()
		{
		}

		public GenericDistributionProviderActionBaseFilter(XmlElement node) : base(node)
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
					case "updatedAtGreaterThanOrEqual":
						this._UpdatedAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAtLessThanOrEqual":
						this._UpdatedAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "genericDistributionProviderIdEqual":
						this._GenericDistributionProviderIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "genericDistributionProviderIdIn":
						this._GenericDistributionProviderIdIn = propertyNode.InnerText;
						continue;
					case "actionEqual":
						this._ActionEqual = (DistributionAction)ParseEnum(typeof(DistributionAction), propertyNode.InnerText);
						continue;
					case "actionIn":
						this._ActionIn = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaGenericDistributionProviderActionBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("genericDistributionProviderIdEqual", this._GenericDistributionProviderIdEqual);
			kparams.AddIfNotNull("genericDistributionProviderIdIn", this._GenericDistributionProviderIdIn);
			kparams.AddIfNotNull("actionEqual", this._ActionEqual);
			kparams.AddIfNotNull("actionIn", this._ActionIn);
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
				case UPDATED_AT_GREATER_THAN_OR_EQUAL:
					return "UpdatedAtGreaterThanOrEqual";
				case UPDATED_AT_LESS_THAN_OR_EQUAL:
					return "UpdatedAtLessThanOrEqual";
				case GENERIC_DISTRIBUTION_PROVIDER_ID_EQUAL:
					return "GenericDistributionProviderIdEqual";
				case GENERIC_DISTRIBUTION_PROVIDER_ID_IN:
					return "GenericDistributionProviderIdIn";
				case ACTION_EQUAL:
					return "ActionEqual";
				case ACTION_IN:
					return "ActionIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

