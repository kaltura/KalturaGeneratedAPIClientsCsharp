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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaServerNodeBaseFilter : KalturaFilter
	{
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
		private KalturaServerNodeStatus _StatusEqual = (KalturaServerNodeStatus)Int32.MinValue;
		private string _StatusIn = null;
		private KalturaServerNodeType _TypeEqual = null;
		private string _TypeIn = null;
		private string _TagsLike = null;
		private string _TagsMultiLikeOr = null;
		private string _TagsMultiLikeAnd = null;
		private int _DcEqual = Int32.MinValue;
		private string _DcIn = null;
		private int _ParentIdEqual = Int32.MinValue;
		private string _ParentIdIn = null;
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
		public int HeartbeatTimeGreaterThanOrEqual
		{
			get { return _HeartbeatTimeGreaterThanOrEqual; }
			set 
			{ 
				_HeartbeatTimeGreaterThanOrEqual = value;
				OnPropertyChanged("HeartbeatTimeGreaterThanOrEqual");
			}
		}
		public int HeartbeatTimeLessThanOrEqual
		{
			get { return _HeartbeatTimeLessThanOrEqual; }
			set 
			{ 
				_HeartbeatTimeLessThanOrEqual = value;
				OnPropertyChanged("HeartbeatTimeLessThanOrEqual");
			}
		}
		public string NameEqual
		{
			get { return _NameEqual; }
			set 
			{ 
				_NameEqual = value;
				OnPropertyChanged("NameEqual");
			}
		}
		public string NameIn
		{
			get { return _NameIn; }
			set 
			{ 
				_NameIn = value;
				OnPropertyChanged("NameIn");
			}
		}
		public string SystemNameEqual
		{
			get { return _SystemNameEqual; }
			set 
			{ 
				_SystemNameEqual = value;
				OnPropertyChanged("SystemNameEqual");
			}
		}
		public string SystemNameIn
		{
			get { return _SystemNameIn; }
			set 
			{ 
				_SystemNameIn = value;
				OnPropertyChanged("SystemNameIn");
			}
		}
		public string HostNameLike
		{
			get { return _HostNameLike; }
			set 
			{ 
				_HostNameLike = value;
				OnPropertyChanged("HostNameLike");
			}
		}
		public string HostNameMultiLikeOr
		{
			get { return _HostNameMultiLikeOr; }
			set 
			{ 
				_HostNameMultiLikeOr = value;
				OnPropertyChanged("HostNameMultiLikeOr");
			}
		}
		public string HostNameMultiLikeAnd
		{
			get { return _HostNameMultiLikeAnd; }
			set 
			{ 
				_HostNameMultiLikeAnd = value;
				OnPropertyChanged("HostNameMultiLikeAnd");
			}
		}
		public KalturaServerNodeStatus StatusEqual
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
		public KalturaServerNodeType TypeEqual
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
		public int DcEqual
		{
			get { return _DcEqual; }
			set 
			{ 
				_DcEqual = value;
				OnPropertyChanged("DcEqual");
			}
		}
		public string DcIn
		{
			get { return _DcIn; }
			set 
			{ 
				_DcIn = value;
				OnPropertyChanged("DcIn");
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
		#endregion

		#region CTor
		public KalturaServerNodeBaseFilter()
		{
		}

		public KalturaServerNodeBaseFilter(XmlElement node) : base(node)
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
					case "heartbeatTimeGreaterThanOrEqual":
						this.HeartbeatTimeGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "heartbeatTimeLessThanOrEqual":
						this.HeartbeatTimeLessThanOrEqual = ParseInt(txt);
						continue;
					case "nameEqual":
						this.NameEqual = txt;
						continue;
					case "nameIn":
						this.NameIn = txt;
						continue;
					case "systemNameEqual":
						this.SystemNameEqual = txt;
						continue;
					case "systemNameIn":
						this.SystemNameIn = txt;
						continue;
					case "hostNameLike":
						this.HostNameLike = txt;
						continue;
					case "hostNameMultiLikeOr":
						this.HostNameMultiLikeOr = txt;
						continue;
					case "hostNameMultiLikeAnd":
						this.HostNameMultiLikeAnd = txt;
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaServerNodeStatus)ParseEnum(typeof(KalturaServerNodeStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
					case "typeEqual":
						this.TypeEqual = (KalturaServerNodeType)KalturaStringEnum.Parse(typeof(KalturaServerNodeType), txt);
						continue;
					case "typeIn":
						this.TypeIn = txt;
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
					case "dcEqual":
						this.DcEqual = ParseInt(txt);
						continue;
					case "dcIn":
						this.DcIn = txt;
						continue;
					case "parentIdEqual":
						this.ParentIdEqual = ParseInt(txt);
						continue;
					case "parentIdIn":
						this.ParentIdIn = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaServerNodeBaseFilter");
			kparams.AddIfNotNull("idEqual", this.IdEqual);
			kparams.AddIfNotNull("idIn", this.IdIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("heartbeatTimeGreaterThanOrEqual", this.HeartbeatTimeGreaterThanOrEqual);
			kparams.AddIfNotNull("heartbeatTimeLessThanOrEqual", this.HeartbeatTimeLessThanOrEqual);
			kparams.AddIfNotNull("nameEqual", this.NameEqual);
			kparams.AddIfNotNull("nameIn", this.NameIn);
			kparams.AddIfNotNull("systemNameEqual", this.SystemNameEqual);
			kparams.AddIfNotNull("systemNameIn", this.SystemNameIn);
			kparams.AddIfNotNull("hostNameLike", this.HostNameLike);
			kparams.AddIfNotNull("hostNameMultiLikeOr", this.HostNameMultiLikeOr);
			kparams.AddIfNotNull("hostNameMultiLikeAnd", this.HostNameMultiLikeAnd);
			kparams.AddIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddIfNotNull("statusIn", this.StatusIn);
			kparams.AddIfNotNull("typeEqual", this.TypeEqual);
			kparams.AddIfNotNull("typeIn", this.TypeIn);
			kparams.AddIfNotNull("tagsLike", this.TagsLike);
			kparams.AddIfNotNull("tagsMultiLikeOr", this.TagsMultiLikeOr);
			kparams.AddIfNotNull("tagsMultiLikeAnd", this.TagsMultiLikeAnd);
			kparams.AddIfNotNull("dcEqual", this.DcEqual);
			kparams.AddIfNotNull("dcIn", this.DcIn);
			kparams.AddIfNotNull("parentIdEqual", this.ParentIdEqual);
			kparams.AddIfNotNull("parentIdIn", this.ParentIdIn);
			return kparams;
		}
		#endregion
	}
}

