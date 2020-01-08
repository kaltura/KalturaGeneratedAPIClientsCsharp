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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class ServerNodeBaseFilter : Filter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		public const string HEARTBEAT_TIME_GREATER_THAN_OR_EQUAL = "heartbeatTimeGreaterThanOrEqual";
		public const string HEARTBEAT_TIME_LESS_THAN_OR_EQUAL = "heartbeatTimeLessThanOrEqual";
		public const string NAME_EQUAL = "nameEqual";
		public const string NAME_IN = "nameIn";
		public const string SYSTEM_NAME_EQUAL = "systemNameEqual";
		public const string SYSTEM_NAME_IN = "systemNameIn";
		public const string HOST_NAME_LIKE = "hostNameLike";
		public const string HOST_NAME_MULTI_LIKE_OR = "hostNameMultiLikeOr";
		public const string HOST_NAME_MULTI_LIKE_AND = "hostNameMultiLikeAnd";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string TYPE_EQUAL = "typeEqual";
		public const string TYPE_IN = "typeIn";
		public const string TAGS_LIKE = "tagsLike";
		public const string TAGS_MULTI_LIKE_OR = "tagsMultiLikeOr";
		public const string TAGS_MULTI_LIKE_AND = "tagsMultiLikeAnd";
		public const string DC_EQUAL = "dcEqual";
		public const string DC_IN = "dcIn";
		public const string PARENT_ID_LIKE = "parentIdLike";
		public const string PARENT_ID_MULTI_LIKE_OR = "parentIdMultiLikeOr";
		public const string PARENT_ID_MULTI_LIKE_AND = "parentIdMultiLikeAnd";
		public const string ENVIRONMENT_EQUAL = "environmentEqual";
		public const string ENVIRONMENT_IN = "environmentIn";
		#endregion

		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _HeartbeatTimeGreaterThanOrEqual = Int32.MinValue;
		private int _HeartbeatTimeLessThanOrEqual = Int32.MinValue;
		private string _NameEqual = null;
		private string _NameIn = null;
		private string _SystemNameEqual = null;
		private string _SystemNameIn = null;
		private string _HostNameLike = null;
		private string _HostNameMultiLikeOr = null;
		private string _HostNameMultiLikeAnd = null;
		private ServerNodeStatus _StatusEqual = (ServerNodeStatus)Int32.MinValue;
		private string _StatusIn = null;
		private ServerNodeType _TypeEqual = null;
		private string _TypeIn = null;
		private string _TagsLike = null;
		private string _TagsMultiLikeOr = null;
		private string _TagsMultiLikeAnd = null;
		private int _DcEqual = Int32.MinValue;
		private string _DcIn = null;
		private string _ParentIdLike = null;
		private string _ParentIdMultiLikeOr = null;
		private string _ParentIdMultiLikeAnd = null;
		private string _EnvironmentEqual = null;
		private string _EnvironmentIn = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		[JsonProperty]
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
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
		public int HeartbeatTimeGreaterThanOrEqual
		{
			get { return _HeartbeatTimeGreaterThanOrEqual; }
			set 
			{ 
				_HeartbeatTimeGreaterThanOrEqual = value;
				OnPropertyChanged("HeartbeatTimeGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int HeartbeatTimeLessThanOrEqual
		{
			get { return _HeartbeatTimeLessThanOrEqual; }
			set 
			{ 
				_HeartbeatTimeLessThanOrEqual = value;
				OnPropertyChanged("HeartbeatTimeLessThanOrEqual");
			}
		}
		[JsonProperty]
		public string NameEqual
		{
			get { return _NameEqual; }
			set 
			{ 
				_NameEqual = value;
				OnPropertyChanged("NameEqual");
			}
		}
		[JsonProperty]
		public string NameIn
		{
			get { return _NameIn; }
			set 
			{ 
				_NameIn = value;
				OnPropertyChanged("NameIn");
			}
		}
		[JsonProperty]
		public string SystemNameEqual
		{
			get { return _SystemNameEqual; }
			set 
			{ 
				_SystemNameEqual = value;
				OnPropertyChanged("SystemNameEqual");
			}
		}
		[JsonProperty]
		public string SystemNameIn
		{
			get { return _SystemNameIn; }
			set 
			{ 
				_SystemNameIn = value;
				OnPropertyChanged("SystemNameIn");
			}
		}
		[JsonProperty]
		public string HostNameLike
		{
			get { return _HostNameLike; }
			set 
			{ 
				_HostNameLike = value;
				OnPropertyChanged("HostNameLike");
			}
		}
		[JsonProperty]
		public string HostNameMultiLikeOr
		{
			get { return _HostNameMultiLikeOr; }
			set 
			{ 
				_HostNameMultiLikeOr = value;
				OnPropertyChanged("HostNameMultiLikeOr");
			}
		}
		[JsonProperty]
		public string HostNameMultiLikeAnd
		{
			get { return _HostNameMultiLikeAnd; }
			set 
			{ 
				_HostNameMultiLikeAnd = value;
				OnPropertyChanged("HostNameMultiLikeAnd");
			}
		}
		[JsonProperty]
		public ServerNodeStatus StatusEqual
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
		public ServerNodeType TypeEqual
		{
			get { return _TypeEqual; }
			set 
			{ 
				_TypeEqual = value;
				OnPropertyChanged("TypeEqual");
			}
		}
		[JsonProperty]
		public string TypeIn
		{
			get { return _TypeIn; }
			set 
			{ 
				_TypeIn = value;
				OnPropertyChanged("TypeIn");
			}
		}
		[JsonProperty]
		public string TagsLike
		{
			get { return _TagsLike; }
			set 
			{ 
				_TagsLike = value;
				OnPropertyChanged("TagsLike");
			}
		}
		[JsonProperty]
		public string TagsMultiLikeOr
		{
			get { return _TagsMultiLikeOr; }
			set 
			{ 
				_TagsMultiLikeOr = value;
				OnPropertyChanged("TagsMultiLikeOr");
			}
		}
		[JsonProperty]
		public string TagsMultiLikeAnd
		{
			get { return _TagsMultiLikeAnd; }
			set 
			{ 
				_TagsMultiLikeAnd = value;
				OnPropertyChanged("TagsMultiLikeAnd");
			}
		}
		[JsonProperty]
		public int DcEqual
		{
			get { return _DcEqual; }
			set 
			{ 
				_DcEqual = value;
				OnPropertyChanged("DcEqual");
			}
		}
		[JsonProperty]
		public string DcIn
		{
			get { return _DcIn; }
			set 
			{ 
				_DcIn = value;
				OnPropertyChanged("DcIn");
			}
		}
		[JsonProperty]
		public string ParentIdLike
		{
			get { return _ParentIdLike; }
			set 
			{ 
				_ParentIdLike = value;
				OnPropertyChanged("ParentIdLike");
			}
		}
		[JsonProperty]
		public string ParentIdMultiLikeOr
		{
			get { return _ParentIdMultiLikeOr; }
			set 
			{ 
				_ParentIdMultiLikeOr = value;
				OnPropertyChanged("ParentIdMultiLikeOr");
			}
		}
		[JsonProperty]
		public string ParentIdMultiLikeAnd
		{
			get { return _ParentIdMultiLikeAnd; }
			set 
			{ 
				_ParentIdMultiLikeAnd = value;
				OnPropertyChanged("ParentIdMultiLikeAnd");
			}
		}
		[JsonProperty]
		public string EnvironmentEqual
		{
			get { return _EnvironmentEqual; }
			set 
			{ 
				_EnvironmentEqual = value;
				OnPropertyChanged("EnvironmentEqual");
			}
		}
		[JsonProperty]
		public string EnvironmentIn
		{
			get { return _EnvironmentIn; }
			set 
			{ 
				_EnvironmentIn = value;
				OnPropertyChanged("EnvironmentIn");
			}
		}
		#endregion

		#region CTor
		public ServerNodeBaseFilter()
		{
		}

		public ServerNodeBaseFilter(JToken node) : base(node)
		{
			if(node["idEqual"] != null)
			{
				this._IdEqual = ParseInt(node["idEqual"].Value<string>());
			}
			if(node["idIn"] != null)
			{
				this._IdIn = node["idIn"].Value<string>();
			}
			if(node["createdAtGreaterThanOrEqual"] != null)
			{
				this._CreatedAtGreaterThanOrEqual = ParseInt(node["createdAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["createdAtLessThanOrEqual"] != null)
			{
				this._CreatedAtLessThanOrEqual = ParseInt(node["createdAtLessThanOrEqual"].Value<string>());
			}
			if(node["updatedAtGreaterThanOrEqual"] != null)
			{
				this._UpdatedAtGreaterThanOrEqual = ParseInt(node["updatedAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["updatedAtLessThanOrEqual"] != null)
			{
				this._UpdatedAtLessThanOrEqual = ParseInt(node["updatedAtLessThanOrEqual"].Value<string>());
			}
			if(node["heartbeatTimeGreaterThanOrEqual"] != null)
			{
				this._HeartbeatTimeGreaterThanOrEqual = ParseInt(node["heartbeatTimeGreaterThanOrEqual"].Value<string>());
			}
			if(node["heartbeatTimeLessThanOrEqual"] != null)
			{
				this._HeartbeatTimeLessThanOrEqual = ParseInt(node["heartbeatTimeLessThanOrEqual"].Value<string>());
			}
			if(node["nameEqual"] != null)
			{
				this._NameEqual = node["nameEqual"].Value<string>();
			}
			if(node["nameIn"] != null)
			{
				this._NameIn = node["nameIn"].Value<string>();
			}
			if(node["systemNameEqual"] != null)
			{
				this._SystemNameEqual = node["systemNameEqual"].Value<string>();
			}
			if(node["systemNameIn"] != null)
			{
				this._SystemNameIn = node["systemNameIn"].Value<string>();
			}
			if(node["hostNameLike"] != null)
			{
				this._HostNameLike = node["hostNameLike"].Value<string>();
			}
			if(node["hostNameMultiLikeOr"] != null)
			{
				this._HostNameMultiLikeOr = node["hostNameMultiLikeOr"].Value<string>();
			}
			if(node["hostNameMultiLikeAnd"] != null)
			{
				this._HostNameMultiLikeAnd = node["hostNameMultiLikeAnd"].Value<string>();
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (ServerNodeStatus)ParseEnum(typeof(ServerNodeStatus), node["statusEqual"].Value<string>());
			}
			if(node["statusIn"] != null)
			{
				this._StatusIn = node["statusIn"].Value<string>();
			}
			if(node["typeEqual"] != null)
			{
				this._TypeEqual = (ServerNodeType)StringEnum.Parse(typeof(ServerNodeType), node["typeEqual"].Value<string>());
			}
			if(node["typeIn"] != null)
			{
				this._TypeIn = node["typeIn"].Value<string>();
			}
			if(node["tagsLike"] != null)
			{
				this._TagsLike = node["tagsLike"].Value<string>();
			}
			if(node["tagsMultiLikeOr"] != null)
			{
				this._TagsMultiLikeOr = node["tagsMultiLikeOr"].Value<string>();
			}
			if(node["tagsMultiLikeAnd"] != null)
			{
				this._TagsMultiLikeAnd = node["tagsMultiLikeAnd"].Value<string>();
			}
			if(node["dcEqual"] != null)
			{
				this._DcEqual = ParseInt(node["dcEqual"].Value<string>());
			}
			if(node["dcIn"] != null)
			{
				this._DcIn = node["dcIn"].Value<string>();
			}
			if(node["parentIdLike"] != null)
			{
				this._ParentIdLike = node["parentIdLike"].Value<string>();
			}
			if(node["parentIdMultiLikeOr"] != null)
			{
				this._ParentIdMultiLikeOr = node["parentIdMultiLikeOr"].Value<string>();
			}
			if(node["parentIdMultiLikeAnd"] != null)
			{
				this._ParentIdMultiLikeAnd = node["parentIdMultiLikeAnd"].Value<string>();
			}
			if(node["environmentEqual"] != null)
			{
				this._EnvironmentEqual = node["environmentEqual"].Value<string>();
			}
			if(node["environmentIn"] != null)
			{
				this._EnvironmentIn = node["environmentIn"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaServerNodeBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("heartbeatTimeGreaterThanOrEqual", this._HeartbeatTimeGreaterThanOrEqual);
			kparams.AddIfNotNull("heartbeatTimeLessThanOrEqual", this._HeartbeatTimeLessThanOrEqual);
			kparams.AddIfNotNull("nameEqual", this._NameEqual);
			kparams.AddIfNotNull("nameIn", this._NameIn);
			kparams.AddIfNotNull("systemNameEqual", this._SystemNameEqual);
			kparams.AddIfNotNull("systemNameIn", this._SystemNameIn);
			kparams.AddIfNotNull("hostNameLike", this._HostNameLike);
			kparams.AddIfNotNull("hostNameMultiLikeOr", this._HostNameMultiLikeOr);
			kparams.AddIfNotNull("hostNameMultiLikeAnd", this._HostNameMultiLikeAnd);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("typeEqual", this._TypeEqual);
			kparams.AddIfNotNull("typeIn", this._TypeIn);
			kparams.AddIfNotNull("tagsLike", this._TagsLike);
			kparams.AddIfNotNull("tagsMultiLikeOr", this._TagsMultiLikeOr);
			kparams.AddIfNotNull("tagsMultiLikeAnd", this._TagsMultiLikeAnd);
			kparams.AddIfNotNull("dcEqual", this._DcEqual);
			kparams.AddIfNotNull("dcIn", this._DcIn);
			kparams.AddIfNotNull("parentIdLike", this._ParentIdLike);
			kparams.AddIfNotNull("parentIdMultiLikeOr", this._ParentIdMultiLikeOr);
			kparams.AddIfNotNull("parentIdMultiLikeAnd", this._ParentIdMultiLikeAnd);
			kparams.AddIfNotNull("environmentEqual", this._EnvironmentEqual);
			kparams.AddIfNotNull("environmentIn", this._EnvironmentIn);
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
				case HEARTBEAT_TIME_GREATER_THAN_OR_EQUAL:
					return "HeartbeatTimeGreaterThanOrEqual";
				case HEARTBEAT_TIME_LESS_THAN_OR_EQUAL:
					return "HeartbeatTimeLessThanOrEqual";
				case NAME_EQUAL:
					return "NameEqual";
				case NAME_IN:
					return "NameIn";
				case SYSTEM_NAME_EQUAL:
					return "SystemNameEqual";
				case SYSTEM_NAME_IN:
					return "SystemNameIn";
				case HOST_NAME_LIKE:
					return "HostNameLike";
				case HOST_NAME_MULTI_LIKE_OR:
					return "HostNameMultiLikeOr";
				case HOST_NAME_MULTI_LIKE_AND:
					return "HostNameMultiLikeAnd";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case TYPE_EQUAL:
					return "TypeEqual";
				case TYPE_IN:
					return "TypeIn";
				case TAGS_LIKE:
					return "TagsLike";
				case TAGS_MULTI_LIKE_OR:
					return "TagsMultiLikeOr";
				case TAGS_MULTI_LIKE_AND:
					return "TagsMultiLikeAnd";
				case DC_EQUAL:
					return "DcEqual";
				case DC_IN:
					return "DcIn";
				case PARENT_ID_LIKE:
					return "ParentIdLike";
				case PARENT_ID_MULTI_LIKE_OR:
					return "ParentIdMultiLikeOr";
				case PARENT_ID_MULTI_LIKE_AND:
					return "ParentIdMultiLikeAnd";
				case ENVIRONMENT_EQUAL:
					return "EnvironmentEqual";
				case ENVIRONMENT_IN:
					return "EnvironmentIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

