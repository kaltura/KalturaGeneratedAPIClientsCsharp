// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2021  Kaltura Inc.
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class EntryServerNodeBaseFilter : Filter
	{
		#region Constants
		public const string ENTRY_ID_EQUAL = "entryIdEqual";
		public const string ENTRY_ID_IN = "entryIdIn";
		public const string SERVER_NODE_ID_EQUAL = "serverNodeIdEqual";
		public const string SERVER_NODE_ID_IN = "serverNodeIdIn";
		public const string SERVER_NODE_ID_NOT_IN = "serverNodeIdNotIn";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string SERVER_TYPE_EQUAL = "serverTypeEqual";
		public const string SERVER_TYPE_IN = "serverTypeIn";
		public const string SERVER_TYPE_NOT_IN = "serverTypeNotIn";
		#endregion

		#region Private Fields
		private string _EntryIdEqual = null;
		private string _EntryIdIn = null;
		private int _ServerNodeIdEqual = Int32.MinValue;
		private string _ServerNodeIdIn = null;
		private string _ServerNodeIdNotIn = null;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private EntryServerNodeStatus _StatusEqual = (EntryServerNodeStatus)Int32.MinValue;
		private string _StatusIn = null;
		private EntryServerNodeType _ServerTypeEqual = null;
		private string _ServerTypeIn = null;
		private string _ServerTypeNotIn = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string EntryIdEqual
		{
			get { return _EntryIdEqual; }
			set 
			{ 
				_EntryIdEqual = value;
				OnPropertyChanged("EntryIdEqual");
			}
		}
		[JsonProperty]
		public string EntryIdIn
		{
			get { return _EntryIdIn; }
			set 
			{ 
				_EntryIdIn = value;
				OnPropertyChanged("EntryIdIn");
			}
		}
		[JsonProperty]
		public int ServerNodeIdEqual
		{
			get { return _ServerNodeIdEqual; }
			set 
			{ 
				_ServerNodeIdEqual = value;
				OnPropertyChanged("ServerNodeIdEqual");
			}
		}
		[JsonProperty]
		public string ServerNodeIdIn
		{
			get { return _ServerNodeIdIn; }
			set 
			{ 
				_ServerNodeIdIn = value;
				OnPropertyChanged("ServerNodeIdIn");
			}
		}
		[JsonProperty]
		public string ServerNodeIdNotIn
		{
			get { return _ServerNodeIdNotIn; }
			set 
			{ 
				_ServerNodeIdNotIn = value;
				OnPropertyChanged("ServerNodeIdNotIn");
			}
		}
		[JsonProperty]
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		[JsonProperty]
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		[JsonProperty]
		public EntryServerNodeStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		[JsonProperty]
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		[JsonProperty]
		public EntryServerNodeType ServerTypeEqual
		{
			get { return _ServerTypeEqual; }
			set 
			{ 
				_ServerTypeEqual = value;
				OnPropertyChanged("ServerTypeEqual");
			}
		}
		[JsonProperty]
		public string ServerTypeIn
		{
			get { return _ServerTypeIn; }
			set 
			{ 
				_ServerTypeIn = value;
				OnPropertyChanged("ServerTypeIn");
			}
		}
		[JsonProperty]
		public string ServerTypeNotIn
		{
			get { return _ServerTypeNotIn; }
			set 
			{ 
				_ServerTypeNotIn = value;
				OnPropertyChanged("ServerTypeNotIn");
			}
		}
		#endregion

		#region CTor
		public EntryServerNodeBaseFilter()
		{
		}

		public EntryServerNodeBaseFilter(JToken node) : base(node)
		{
			if(node["entryIdEqual"] != null)
			{
				this._EntryIdEqual = node["entryIdEqual"].Value<string>();
			}
			if(node["entryIdIn"] != null)
			{
				this._EntryIdIn = node["entryIdIn"].Value<string>();
			}
			if(node["serverNodeIdEqual"] != null)
			{
				this._ServerNodeIdEqual = ParseInt(node["serverNodeIdEqual"].Value<string>());
			}
			if(node["serverNodeIdIn"] != null)
			{
				this._ServerNodeIdIn = node["serverNodeIdIn"].Value<string>();
			}
			if(node["serverNodeIdNotIn"] != null)
			{
				this._ServerNodeIdNotIn = node["serverNodeIdNotIn"].Value<string>();
			}
			if(node["createdAtLessThanOrEqual"] != null)
			{
				this._CreatedAtLessThanOrEqual = ParseInt(node["createdAtLessThanOrEqual"].Value<string>());
			}
			if(node["createdAtGreaterThanOrEqual"] != null)
			{
				this._CreatedAtGreaterThanOrEqual = ParseInt(node["createdAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["updatedAtGreaterThanOrEqual"] != null)
			{
				this._UpdatedAtGreaterThanOrEqual = ParseInt(node["updatedAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["updatedAtLessThanOrEqual"] != null)
			{
				this._UpdatedAtLessThanOrEqual = ParseInt(node["updatedAtLessThanOrEqual"].Value<string>());
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (EntryServerNodeStatus)ParseEnum(typeof(EntryServerNodeStatus), node["statusEqual"].Value<string>());
			}
			if(node["statusIn"] != null)
			{
				this._StatusIn = node["statusIn"].Value<string>();
			}
			if(node["serverTypeEqual"] != null)
			{
				this._ServerTypeEqual = (EntryServerNodeType)StringEnum.Parse(typeof(EntryServerNodeType), node["serverTypeEqual"].Value<string>());
			}
			if(node["serverTypeIn"] != null)
			{
				this._ServerTypeIn = node["serverTypeIn"].Value<string>();
			}
			if(node["serverTypeNotIn"] != null)
			{
				this._ServerTypeNotIn = node["serverTypeNotIn"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEntryServerNodeBaseFilter");
			kparams.AddIfNotNull("entryIdEqual", this._EntryIdEqual);
			kparams.AddIfNotNull("entryIdIn", this._EntryIdIn);
			kparams.AddIfNotNull("serverNodeIdEqual", this._ServerNodeIdEqual);
			kparams.AddIfNotNull("serverNodeIdIn", this._ServerNodeIdIn);
			kparams.AddIfNotNull("serverNodeIdNotIn", this._ServerNodeIdNotIn);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("serverTypeEqual", this._ServerTypeEqual);
			kparams.AddIfNotNull("serverTypeIn", this._ServerTypeIn);
			kparams.AddIfNotNull("serverTypeNotIn", this._ServerTypeNotIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ENTRY_ID_EQUAL:
					return "EntryIdEqual";
				case ENTRY_ID_IN:
					return "EntryIdIn";
				case SERVER_NODE_ID_EQUAL:
					return "ServerNodeIdEqual";
				case SERVER_NODE_ID_IN:
					return "ServerNodeIdIn";
				case SERVER_NODE_ID_NOT_IN:
					return "ServerNodeIdNotIn";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case UPDATED_AT_GREATER_THAN_OR_EQUAL:
					return "UpdatedAtGreaterThanOrEqual";
				case UPDATED_AT_LESS_THAN_OR_EQUAL:
					return "UpdatedAtLessThanOrEqual";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case SERVER_TYPE_EQUAL:
					return "ServerTypeEqual";
				case SERVER_TYPE_IN:
					return "ServerTypeIn";
				case SERVER_TYPE_NOT_IN:
					return "ServerTypeNotIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

