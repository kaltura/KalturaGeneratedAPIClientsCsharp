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

namespace Kaltura
{
	public class KalturaScheduleEventBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private string _IdNotIn = null;
		private int _ParentIdEqual = Int32.MinValue;
		private string _ParentIdIn = null;
		private string _ParentIdNotIn = null;
		private KalturaScheduleEventStatus _StatusEqual = (KalturaScheduleEventStatus)Int32.MinValue;
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
		private KalturaScheduleEventRecurrenceType _RecurrenceTypeEqual = (KalturaScheduleEventRecurrenceType)Int32.MinValue;
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
		public string IdNotIn
		{
			get { return _IdNotIn; }
			set 
			{ 
				_IdNotIn = value;
				OnPropertyChanged("IdNotIn");
			}
		}
		public int ParentIdEqual
		{
			get { return _ParentIdEqual; }
			set 
			{ 
				_ParentIdEqual = value;
				OnPropertyChanged("ParentIdEqual");
			}
		}
		public string ParentIdIn
		{
			get { return _ParentIdIn; }
			set 
			{ 
				_ParentIdIn = value;
				OnPropertyChanged("ParentIdIn");
			}
		}
		public string ParentIdNotIn
		{
			get { return _ParentIdNotIn; }
			set 
			{ 
				_ParentIdNotIn = value;
				OnPropertyChanged("ParentIdNotIn");
			}
		}
		public KalturaScheduleEventStatus StatusEqual
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
		public int StartDateGreaterThanOrEqual
		{
			get { return _StartDateGreaterThanOrEqual; }
			set 
			{ 
				_StartDateGreaterThanOrEqual = value;
				OnPropertyChanged("StartDateGreaterThanOrEqual");
			}
		}
		public int StartDateLessThanOrEqual
		{
			get { return _StartDateLessThanOrEqual; }
			set 
			{ 
				_StartDateLessThanOrEqual = value;
				OnPropertyChanged("StartDateLessThanOrEqual");
			}
		}
		public int EndDateGreaterThanOrEqual
		{
			get { return _EndDateGreaterThanOrEqual; }
			set 
			{ 
				_EndDateGreaterThanOrEqual = value;
				OnPropertyChanged("EndDateGreaterThanOrEqual");
			}
		}
		public int EndDateLessThanOrEqual
		{
			get { return _EndDateLessThanOrEqual; }
			set 
			{ 
				_EndDateLessThanOrEqual = value;
				OnPropertyChanged("EndDateLessThanOrEqual");
			}
		}
		public string ReferenceIdEqual
		{
			get { return _ReferenceIdEqual; }
			set 
			{ 
				_ReferenceIdEqual = value;
				OnPropertyChanged("ReferenceIdEqual");
			}
		}
		public string ReferenceIdIn
		{
			get { return _ReferenceIdIn; }
			set 
			{ 
				_ReferenceIdIn = value;
				OnPropertyChanged("ReferenceIdIn");
			}
		}
		public string OwnerIdEqual
		{
			get { return _OwnerIdEqual; }
			set 
			{ 
				_OwnerIdEqual = value;
				OnPropertyChanged("OwnerIdEqual");
			}
		}
		public string OwnerIdIn
		{
			get { return _OwnerIdIn; }
			set 
			{ 
				_OwnerIdIn = value;
				OnPropertyChanged("OwnerIdIn");
			}
		}
		public int PriorityEqual
		{
			get { return _PriorityEqual; }
			set 
			{ 
				_PriorityEqual = value;
				OnPropertyChanged("PriorityEqual");
			}
		}
		public string PriorityIn
		{
			get { return _PriorityIn; }
			set 
			{ 
				_PriorityIn = value;
				OnPropertyChanged("PriorityIn");
			}
		}
		public int PriorityGreaterThanOrEqual
		{
			get { return _PriorityGreaterThanOrEqual; }
			set 
			{ 
				_PriorityGreaterThanOrEqual = value;
				OnPropertyChanged("PriorityGreaterThanOrEqual");
			}
		}
		public int PriorityLessThanOrEqual
		{
			get { return _PriorityLessThanOrEqual; }
			set 
			{ 
				_PriorityLessThanOrEqual = value;
				OnPropertyChanged("PriorityLessThanOrEqual");
			}
		}
		public KalturaScheduleEventRecurrenceType RecurrenceTypeEqual
		{
			get { return _RecurrenceTypeEqual; }
			set 
			{ 
				_RecurrenceTypeEqual = value;
				OnPropertyChanged("RecurrenceTypeEqual");
			}
		}
		public string RecurrenceTypeIn
		{
			get { return _RecurrenceTypeIn; }
			set 
			{ 
				_RecurrenceTypeIn = value;
				OnPropertyChanged("RecurrenceTypeIn");
			}
		}
		public string TagsLike
		{
			get { return _TagsLike; }
			set 
			{ 
				_TagsLike = value;
				OnPropertyChanged("TagsLike");
			}
		}
		public string TagsMultiLikeOr
		{
			get { return _TagsMultiLikeOr; }
			set 
			{ 
				_TagsMultiLikeOr = value;
				OnPropertyChanged("TagsMultiLikeOr");
			}
		}
		public string TagsMultiLikeAnd
		{
			get { return _TagsMultiLikeAnd; }
			set 
			{ 
				_TagsMultiLikeAnd = value;
				OnPropertyChanged("TagsMultiLikeAnd");
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
		#endregion

		#region CTor
		public KalturaScheduleEventBaseFilter()
		{
		}

		public KalturaScheduleEventBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idEqual":
						this.IdEqual = ParseInt(txt);
						continue;
					case "idIn":
						this.IdIn = txt;
						continue;
					case "idNotIn":
						this.IdNotIn = txt;
						continue;
					case "parentIdEqual":
						this.ParentIdEqual = ParseInt(txt);
						continue;
					case "parentIdIn":
						this.ParentIdIn = txt;
						continue;
					case "parentIdNotIn":
						this.ParentIdNotIn = txt;
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaScheduleEventStatus)ParseEnum(typeof(KalturaScheduleEventStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
					case "startDateGreaterThanOrEqual":
						this.StartDateGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "startDateLessThanOrEqual":
						this.StartDateLessThanOrEqual = ParseInt(txt);
						continue;
					case "endDateGreaterThanOrEqual":
						this.EndDateGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "endDateLessThanOrEqual":
						this.EndDateLessThanOrEqual = ParseInt(txt);
						continue;
					case "referenceIdEqual":
						this.ReferenceIdEqual = txt;
						continue;
					case "referenceIdIn":
						this.ReferenceIdIn = txt;
						continue;
					case "ownerIdEqual":
						this.OwnerIdEqual = txt;
						continue;
					case "ownerIdIn":
						this.OwnerIdIn = txt;
						continue;
					case "priorityEqual":
						this.PriorityEqual = ParseInt(txt);
						continue;
					case "priorityIn":
						this.PriorityIn = txt;
						continue;
					case "priorityGreaterThanOrEqual":
						this.PriorityGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "priorityLessThanOrEqual":
						this.PriorityLessThanOrEqual = ParseInt(txt);
						continue;
					case "recurrenceTypeEqual":
						this.RecurrenceTypeEqual = (KalturaScheduleEventRecurrenceType)ParseEnum(typeof(KalturaScheduleEventRecurrenceType), txt);
						continue;
					case "recurrenceTypeIn":
						this.RecurrenceTypeIn = txt;
						continue;
					case "tagsLike":
						this.TagsLike = txt;
						continue;
					case "tagsMultiLikeOr":
						this.TagsMultiLikeOr = txt;
						continue;
					case "tagsMultiLikeAnd":
						this.TagsMultiLikeAnd = txt;
						continue;
					case "createdAtGreaterThanOrEqual":
						this.CreatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "createdAtLessThanOrEqual":
						this.CreatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this.UpdatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtLessThanOrEqual":
						this.UpdatedAtLessThanOrEqual = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaScheduleEventBaseFilter");
			kparams.AddIfNotNull("idEqual", this.IdEqual);
			kparams.AddIfNotNull("idIn", this.IdIn);
			kparams.AddIfNotNull("idNotIn", this.IdNotIn);
			kparams.AddIfNotNull("parentIdEqual", this.ParentIdEqual);
			kparams.AddIfNotNull("parentIdIn", this.ParentIdIn);
			kparams.AddIfNotNull("parentIdNotIn", this.ParentIdNotIn);
			kparams.AddIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddIfNotNull("statusIn", this.StatusIn);
			kparams.AddIfNotNull("startDateGreaterThanOrEqual", this.StartDateGreaterThanOrEqual);
			kparams.AddIfNotNull("startDateLessThanOrEqual", this.StartDateLessThanOrEqual);
			kparams.AddIfNotNull("endDateGreaterThanOrEqual", this.EndDateGreaterThanOrEqual);
			kparams.AddIfNotNull("endDateLessThanOrEqual", this.EndDateLessThanOrEqual);
			kparams.AddIfNotNull("referenceIdEqual", this.ReferenceIdEqual);
			kparams.AddIfNotNull("referenceIdIn", this.ReferenceIdIn);
			kparams.AddIfNotNull("ownerIdEqual", this.OwnerIdEqual);
			kparams.AddIfNotNull("ownerIdIn", this.OwnerIdIn);
			kparams.AddIfNotNull("priorityEqual", this.PriorityEqual);
			kparams.AddIfNotNull("priorityIn", this.PriorityIn);
			kparams.AddIfNotNull("priorityGreaterThanOrEqual", this.PriorityGreaterThanOrEqual);
			kparams.AddIfNotNull("priorityLessThanOrEqual", this.PriorityLessThanOrEqual);
			kparams.AddIfNotNull("recurrenceTypeEqual", this.RecurrenceTypeEqual);
			kparams.AddIfNotNull("recurrenceTypeIn", this.RecurrenceTypeIn);
			kparams.AddIfNotNull("tagsLike", this.TagsLike);
			kparams.AddIfNotNull("tagsMultiLikeOr", this.TagsMultiLikeOr);
			kparams.AddIfNotNull("tagsMultiLikeAnd", this.TagsMultiLikeAnd);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			return kparams;
		}
		#endregion
	}
}

