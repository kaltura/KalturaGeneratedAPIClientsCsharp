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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class ScheduleEventBaseFilter : RelatedFilter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string ID_NOT_IN = "idNotIn";
		public const string PARENT_ID_EQUAL = "parentIdEqual";
		public const string PARENT_ID_IN = "parentIdIn";
		public const string PARENT_ID_NOT_IN = "parentIdNotIn";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string START_DATE_GREATER_THAN_OR_EQUAL = "startDateGreaterThanOrEqual";
		public const string START_DATE_LESS_THAN_OR_EQUAL = "startDateLessThanOrEqual";
		public const string END_DATE_GREATER_THAN_OR_EQUAL = "endDateGreaterThanOrEqual";
		public const string END_DATE_LESS_THAN_OR_EQUAL = "endDateLessThanOrEqual";
		public const string REFERENCE_ID_EQUAL = "referenceIdEqual";
		public const string REFERENCE_ID_IN = "referenceIdIn";
		public const string OWNER_ID_EQUAL = "ownerIdEqual";
		public const string OWNER_ID_IN = "ownerIdIn";
		public const string PRIORITY_EQUAL = "priorityEqual";
		public const string PRIORITY_IN = "priorityIn";
		public const string PRIORITY_GREATER_THAN_OR_EQUAL = "priorityGreaterThanOrEqual";
		public const string PRIORITY_LESS_THAN_OR_EQUAL = "priorityLessThanOrEqual";
		public const string RECURRENCE_TYPE_EQUAL = "recurrenceTypeEqual";
		public const string RECURRENCE_TYPE_IN = "recurrenceTypeIn";
		public const string TAGS_LIKE = "tagsLike";
		public const string TAGS_MULTI_LIKE_OR = "tagsMultiLikeOr";
		public const string TAGS_MULTI_LIKE_AND = "tagsMultiLikeAnd";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		#endregion

		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private string _IdNotIn = null;
		private int _ParentIdEqual = Int32.MinValue;
		private string _ParentIdIn = null;
		private string _ParentIdNotIn = null;
		private ScheduleEventStatus _StatusEqual = (ScheduleEventStatus)Int32.MinValue;
		private string _StatusIn = null;
		private int _StartDateGreaterThanOrEqual = Int32.MinValue;
		private int _StartDateLessThanOrEqual = Int32.MinValue;
		private int _EndDateGreaterThanOrEqual = Int32.MinValue;
		private int _EndDateLessThanOrEqual = Int32.MinValue;
		private string _ReferenceIdEqual = null;
		private string _ReferenceIdIn = null;
		private string _OwnerIdEqual = null;
		private string _OwnerIdIn = null;
		private int _PriorityEqual = Int32.MinValue;
		private string _PriorityIn = null;
		private int _PriorityGreaterThanOrEqual = Int32.MinValue;
		private int _PriorityLessThanOrEqual = Int32.MinValue;
		private ScheduleEventRecurrenceType _RecurrenceTypeEqual = (ScheduleEventRecurrenceType)Int32.MinValue;
		private string _RecurrenceTypeIn = null;
		private string _TagsLike = null;
		private string _TagsMultiLikeOr = null;
		private string _TagsMultiLikeAnd = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdEqualAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use IdInAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use IdNotInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string IdNotIn
		{
			get { return _IdNotIn; }
			set 
			{ 
				_IdNotIn = value;
				OnPropertyChanged("IdNotIn");
			}
		}
		/// <summary>
		/// Use ParentIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ParentIdEqual
		{
			get { return _ParentIdEqual; }
			set 
			{ 
				_ParentIdEqual = value;
				OnPropertyChanged("ParentIdEqual");
			}
		}
		/// <summary>
		/// Use ParentIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ParentIdIn
		{
			get { return _ParentIdIn; }
			set 
			{ 
				_ParentIdIn = value;
				OnPropertyChanged("ParentIdIn");
			}
		}
		/// <summary>
		/// Use ParentIdNotInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ParentIdNotIn
		{
			get { return _ParentIdNotIn; }
			set 
			{ 
				_ParentIdNotIn = value;
				OnPropertyChanged("ParentIdNotIn");
			}
		}
		/// <summary>
		/// Use StatusEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ScheduleEventStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		/// <summary>
		/// Use StatusInAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use StartDateGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int StartDateGreaterThanOrEqual
		{
			get { return _StartDateGreaterThanOrEqual; }
			set 
			{ 
				_StartDateGreaterThanOrEqual = value;
				OnPropertyChanged("StartDateGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use StartDateLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int StartDateLessThanOrEqual
		{
			get { return _StartDateLessThanOrEqual; }
			set 
			{ 
				_StartDateLessThanOrEqual = value;
				OnPropertyChanged("StartDateLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use EndDateGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int EndDateGreaterThanOrEqual
		{
			get { return _EndDateGreaterThanOrEqual; }
			set 
			{ 
				_EndDateGreaterThanOrEqual = value;
				OnPropertyChanged("EndDateGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use EndDateLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int EndDateLessThanOrEqual
		{
			get { return _EndDateLessThanOrEqual; }
			set 
			{ 
				_EndDateLessThanOrEqual = value;
				OnPropertyChanged("EndDateLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use ReferenceIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ReferenceIdEqual
		{
			get { return _ReferenceIdEqual; }
			set 
			{ 
				_ReferenceIdEqual = value;
				OnPropertyChanged("ReferenceIdEqual");
			}
		}
		/// <summary>
		/// Use ReferenceIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ReferenceIdIn
		{
			get { return _ReferenceIdIn; }
			set 
			{ 
				_ReferenceIdIn = value;
				OnPropertyChanged("ReferenceIdIn");
			}
		}
		/// <summary>
		/// Use OwnerIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string OwnerIdEqual
		{
			get { return _OwnerIdEqual; }
			set 
			{ 
				_OwnerIdEqual = value;
				OnPropertyChanged("OwnerIdEqual");
			}
		}
		/// <summary>
		/// Use OwnerIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string OwnerIdIn
		{
			get { return _OwnerIdIn; }
			set 
			{ 
				_OwnerIdIn = value;
				OnPropertyChanged("OwnerIdIn");
			}
		}
		/// <summary>
		/// Use PriorityEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PriorityEqual
		{
			get { return _PriorityEqual; }
			set 
			{ 
				_PriorityEqual = value;
				OnPropertyChanged("PriorityEqual");
			}
		}
		/// <summary>
		/// Use PriorityInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PriorityIn
		{
			get { return _PriorityIn; }
			set 
			{ 
				_PriorityIn = value;
				OnPropertyChanged("PriorityIn");
			}
		}
		/// <summary>
		/// Use PriorityGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PriorityGreaterThanOrEqual
		{
			get { return _PriorityGreaterThanOrEqual; }
			set 
			{ 
				_PriorityGreaterThanOrEqual = value;
				OnPropertyChanged("PriorityGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use PriorityLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PriorityLessThanOrEqual
		{
			get { return _PriorityLessThanOrEqual; }
			set 
			{ 
				_PriorityLessThanOrEqual = value;
				OnPropertyChanged("PriorityLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use RecurrenceTypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ScheduleEventRecurrenceType RecurrenceTypeEqual
		{
			get { return _RecurrenceTypeEqual; }
			set 
			{ 
				_RecurrenceTypeEqual = value;
				OnPropertyChanged("RecurrenceTypeEqual");
			}
		}
		/// <summary>
		/// Use RecurrenceTypeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RecurrenceTypeIn
		{
			get { return _RecurrenceTypeIn; }
			set 
			{ 
				_RecurrenceTypeIn = value;
				OnPropertyChanged("RecurrenceTypeIn");
			}
		}
		/// <summary>
		/// Use TagsLikeAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use TagsMultiLikeOrAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use TagsMultiLikeAndAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use CreatedAtGreaterThanOrEqualAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use CreatedAtLessThanOrEqualAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use UpdatedAtGreaterThanOrEqualAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use UpdatedAtLessThanOrEqualAsDouble property instead
		/// </summary>
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
		#endregion

		#region CTor
		public ScheduleEventBaseFilter()
		{
		}

		public ScheduleEventBaseFilter(JToken node) : base(node)
		{
			if(node["idEqual"] != null)
			{
				this._IdEqual = ParseInt(node["idEqual"].Value<string>());
			}
			if(node["idIn"] != null)
			{
				this._IdIn = node["idIn"].Value<string>();
			}
			if(node["idNotIn"] != null)
			{
				this._IdNotIn = node["idNotIn"].Value<string>();
			}
			if(node["parentIdEqual"] != null)
			{
				this._ParentIdEqual = ParseInt(node["parentIdEqual"].Value<string>());
			}
			if(node["parentIdIn"] != null)
			{
				this._ParentIdIn = node["parentIdIn"].Value<string>();
			}
			if(node["parentIdNotIn"] != null)
			{
				this._ParentIdNotIn = node["parentIdNotIn"].Value<string>();
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (ScheduleEventStatus)ParseEnum(typeof(ScheduleEventStatus), node["statusEqual"].Value<string>());
			}
			if(node["statusIn"] != null)
			{
				this._StatusIn = node["statusIn"].Value<string>();
			}
			if(node["startDateGreaterThanOrEqual"] != null)
			{
				this._StartDateGreaterThanOrEqual = ParseInt(node["startDateGreaterThanOrEqual"].Value<string>());
			}
			if(node["startDateLessThanOrEqual"] != null)
			{
				this._StartDateLessThanOrEqual = ParseInt(node["startDateLessThanOrEqual"].Value<string>());
			}
			if(node["endDateGreaterThanOrEqual"] != null)
			{
				this._EndDateGreaterThanOrEqual = ParseInt(node["endDateGreaterThanOrEqual"].Value<string>());
			}
			if(node["endDateLessThanOrEqual"] != null)
			{
				this._EndDateLessThanOrEqual = ParseInt(node["endDateLessThanOrEqual"].Value<string>());
			}
			if(node["referenceIdEqual"] != null)
			{
				this._ReferenceIdEqual = node["referenceIdEqual"].Value<string>();
			}
			if(node["referenceIdIn"] != null)
			{
				this._ReferenceIdIn = node["referenceIdIn"].Value<string>();
			}
			if(node["ownerIdEqual"] != null)
			{
				this._OwnerIdEqual = node["ownerIdEqual"].Value<string>();
			}
			if(node["ownerIdIn"] != null)
			{
				this._OwnerIdIn = node["ownerIdIn"].Value<string>();
			}
			if(node["priorityEqual"] != null)
			{
				this._PriorityEqual = ParseInt(node["priorityEqual"].Value<string>());
			}
			if(node["priorityIn"] != null)
			{
				this._PriorityIn = node["priorityIn"].Value<string>();
			}
			if(node["priorityGreaterThanOrEqual"] != null)
			{
				this._PriorityGreaterThanOrEqual = ParseInt(node["priorityGreaterThanOrEqual"].Value<string>());
			}
			if(node["priorityLessThanOrEqual"] != null)
			{
				this._PriorityLessThanOrEqual = ParseInt(node["priorityLessThanOrEqual"].Value<string>());
			}
			if(node["recurrenceTypeEqual"] != null)
			{
				this._RecurrenceTypeEqual = (ScheduleEventRecurrenceType)ParseEnum(typeof(ScheduleEventRecurrenceType), node["recurrenceTypeEqual"].Value<string>());
			}
			if(node["recurrenceTypeIn"] != null)
			{
				this._RecurrenceTypeIn = node["recurrenceTypeIn"].Value<string>();
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
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaScheduleEventBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("idNotIn", this._IdNotIn);
			kparams.AddIfNotNull("parentIdEqual", this._ParentIdEqual);
			kparams.AddIfNotNull("parentIdIn", this._ParentIdIn);
			kparams.AddIfNotNull("parentIdNotIn", this._ParentIdNotIn);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("startDateGreaterThanOrEqual", this._StartDateGreaterThanOrEqual);
			kparams.AddIfNotNull("startDateLessThanOrEqual", this._StartDateLessThanOrEqual);
			kparams.AddIfNotNull("endDateGreaterThanOrEqual", this._EndDateGreaterThanOrEqual);
			kparams.AddIfNotNull("endDateLessThanOrEqual", this._EndDateLessThanOrEqual);
			kparams.AddIfNotNull("referenceIdEqual", this._ReferenceIdEqual);
			kparams.AddIfNotNull("referenceIdIn", this._ReferenceIdIn);
			kparams.AddIfNotNull("ownerIdEqual", this._OwnerIdEqual);
			kparams.AddIfNotNull("ownerIdIn", this._OwnerIdIn);
			kparams.AddIfNotNull("priorityEqual", this._PriorityEqual);
			kparams.AddIfNotNull("priorityIn", this._PriorityIn);
			kparams.AddIfNotNull("priorityGreaterThanOrEqual", this._PriorityGreaterThanOrEqual);
			kparams.AddIfNotNull("priorityLessThanOrEqual", this._PriorityLessThanOrEqual);
			kparams.AddIfNotNull("recurrenceTypeEqual", this._RecurrenceTypeEqual);
			kparams.AddIfNotNull("recurrenceTypeIn", this._RecurrenceTypeIn);
			kparams.AddIfNotNull("tagsLike", this._TagsLike);
			kparams.AddIfNotNull("tagsMultiLikeOr", this._TagsMultiLikeOr);
			kparams.AddIfNotNull("tagsMultiLikeAnd", this._TagsMultiLikeAnd);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
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
				case ID_NOT_IN:
					return "IdNotIn";
				case PARENT_ID_EQUAL:
					return "ParentIdEqual";
				case PARENT_ID_IN:
					return "ParentIdIn";
				case PARENT_ID_NOT_IN:
					return "ParentIdNotIn";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case START_DATE_GREATER_THAN_OR_EQUAL:
					return "StartDateGreaterThanOrEqual";
				case START_DATE_LESS_THAN_OR_EQUAL:
					return "StartDateLessThanOrEqual";
				case END_DATE_GREATER_THAN_OR_EQUAL:
					return "EndDateGreaterThanOrEqual";
				case END_DATE_LESS_THAN_OR_EQUAL:
					return "EndDateLessThanOrEqual";
				case REFERENCE_ID_EQUAL:
					return "ReferenceIdEqual";
				case REFERENCE_ID_IN:
					return "ReferenceIdIn";
				case OWNER_ID_EQUAL:
					return "OwnerIdEqual";
				case OWNER_ID_IN:
					return "OwnerIdIn";
				case PRIORITY_EQUAL:
					return "PriorityEqual";
				case PRIORITY_IN:
					return "PriorityIn";
				case PRIORITY_GREATER_THAN_OR_EQUAL:
					return "PriorityGreaterThanOrEqual";
				case PRIORITY_LESS_THAN_OR_EQUAL:
					return "PriorityLessThanOrEqual";
				case RECURRENCE_TYPE_EQUAL:
					return "RecurrenceTypeEqual";
				case RECURRENCE_TYPE_IN:
					return "RecurrenceTypeIn";
				case TAGS_LIKE:
					return "TagsLike";
				case TAGS_MULTI_LIKE_OR:
					return "TagsMultiLikeOr";
				case TAGS_MULTI_LIKE_AND:
					return "TagsMultiLikeAnd";
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case UPDATED_AT_GREATER_THAN_OR_EQUAL:
					return "UpdatedAtGreaterThanOrEqual";
				case UPDATED_AT_LESS_THAN_OR_EQUAL:
					return "UpdatedAtLessThanOrEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

