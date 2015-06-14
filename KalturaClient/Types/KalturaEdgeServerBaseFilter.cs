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
	public class KalturaEdgeServerBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private string _NameEqual = null;
		private string _NameIn = null;
		private string _SystemNameEqual = null;
		private string _SystemNameIn = null;
		private KalturaEdgeServerStatus _StatusEqual = (KalturaEdgeServerStatus)Int32.MinValue;
		private string _StatusIn = null;
		private string _TagsLike = null;
		private string _TagsMultiLikeOr = null;
		private string _TagsMultiLikeAnd = null;
		private string _HostNameLike = null;
		private string _HostNameMultiLikeOr = null;
		private string _HostNameMultiLikeAnd = null;
		private string _PlaybackHostNameLike = null;
		private string _PlaybackHostNameMultiLikeOr = null;
		private string _PlaybackHostNameMultiLikeAnd = null;
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
		public KalturaEdgeServerStatus StatusEqual
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
		public string PlaybackHostNameLike
		{
			get { return _PlaybackHostNameLike; }
			set 
			{ 
				_PlaybackHostNameLike = value;
				OnPropertyChanged("PlaybackHostNameLike");
			}
		}
		public string PlaybackHostNameMultiLikeOr
		{
			get { return _PlaybackHostNameMultiLikeOr; }
			set 
			{ 
				_PlaybackHostNameMultiLikeOr = value;
				OnPropertyChanged("PlaybackHostNameMultiLikeOr");
			}
		}
		public string PlaybackHostNameMultiLikeAnd
		{
			get { return _PlaybackHostNameMultiLikeAnd; }
			set 
			{ 
				_PlaybackHostNameMultiLikeAnd = value;
				OnPropertyChanged("PlaybackHostNameMultiLikeAnd");
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
		public KalturaEdgeServerBaseFilter()
		{
		}

		public KalturaEdgeServerBaseFilter(XmlElement node) : base(node)
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
					case "statusEqual":
						this.StatusEqual = (KalturaEdgeServerStatus)ParseEnum(typeof(KalturaEdgeServerStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
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
					case "hostNameLike":
						this.HostNameLike = txt;
						continue;
					case "hostNameMultiLikeOr":
						this.HostNameMultiLikeOr = txt;
						continue;
					case "hostNameMultiLikeAnd":
						this.HostNameMultiLikeAnd = txt;
						continue;
					case "playbackHostNameLike":
						this.PlaybackHostNameLike = txt;
						continue;
					case "playbackHostNameMultiLikeOr":
						this.PlaybackHostNameMultiLikeOr = txt;
						continue;
					case "playbackHostNameMultiLikeAnd":
						this.PlaybackHostNameMultiLikeAnd = txt;
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
			kparams.AddReplace("objectType", "KalturaEdgeServerBaseFilter");
			kparams.AddIntIfNotNull("idEqual", this.IdEqual);
			kparams.AddStringIfNotNull("idIn", this.IdIn);
			kparams.AddIntIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			kparams.AddStringIfNotNull("nameEqual", this.NameEqual);
			kparams.AddStringIfNotNull("nameIn", this.NameIn);
			kparams.AddStringIfNotNull("systemNameEqual", this.SystemNameEqual);
			kparams.AddStringIfNotNull("systemNameIn", this.SystemNameIn);
			kparams.AddEnumIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddStringIfNotNull("statusIn", this.StatusIn);
			kparams.AddStringIfNotNull("tagsLike", this.TagsLike);
			kparams.AddStringIfNotNull("tagsMultiLikeOr", this.TagsMultiLikeOr);
			kparams.AddStringIfNotNull("tagsMultiLikeAnd", this.TagsMultiLikeAnd);
			kparams.AddStringIfNotNull("hostNameLike", this.HostNameLike);
			kparams.AddStringIfNotNull("hostNameMultiLikeOr", this.HostNameMultiLikeOr);
			kparams.AddStringIfNotNull("hostNameMultiLikeAnd", this.HostNameMultiLikeAnd);
			kparams.AddStringIfNotNull("playbackHostNameLike", this.PlaybackHostNameLike);
			kparams.AddStringIfNotNull("playbackHostNameMultiLikeOr", this.PlaybackHostNameMultiLikeOr);
			kparams.AddStringIfNotNull("playbackHostNameMultiLikeAnd", this.PlaybackHostNameMultiLikeAnd);
			kparams.AddIntIfNotNull("parentIdEqual", this.ParentIdEqual);
			kparams.AddStringIfNotNull("parentIdIn", this.ParentIdIn);
			return kparams;
		}
		#endregion
	}
}

