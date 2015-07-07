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
	public class KalturaUserEntryBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private string _IdNotIn = null;
		private string _EntryIdEqual = null;
		private string _EntryIdIn = null;
		private string _EntryIdNotIn = null;
		private int _UserIdEqual = Int32.MinValue;
		private string _UserIdIn = null;
		private string _UserIdNotIn = null;
		private KalturaUserEntryStatus _StatusEqual = null;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private KalturaUserEntryType _TypeEqual = null;
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
		public string EntryIdEqual
		{
			get { return _EntryIdEqual; }
			set 
			{ 
				_EntryIdEqual = value;
				OnPropertyChanged("EntryIdEqual");
			}
		}
		public string EntryIdIn
		{
			get { return _EntryIdIn; }
			set 
			{ 
				_EntryIdIn = value;
				OnPropertyChanged("EntryIdIn");
			}
		}
		public string EntryIdNotIn
		{
			get { return _EntryIdNotIn; }
			set 
			{ 
				_EntryIdNotIn = value;
				OnPropertyChanged("EntryIdNotIn");
			}
		}
		public int UserIdEqual
		{
			get { return _UserIdEqual; }
			set 
			{ 
				_UserIdEqual = value;
				OnPropertyChanged("UserIdEqual");
			}
		}
		public string UserIdIn
		{
			get { return _UserIdIn; }
			set 
			{ 
				_UserIdIn = value;
				OnPropertyChanged("UserIdIn");
			}
		}
		public string UserIdNotIn
		{
			get { return _UserIdNotIn; }
			set 
			{ 
				_UserIdNotIn = value;
				OnPropertyChanged("UserIdNotIn");
			}
		}
		public KalturaUserEntryStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
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
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
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
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		public KalturaUserEntryType TypeEqual
		{
			get { return _TypeEqual; }
			set 
			{ 
				_TypeEqual = value;
				OnPropertyChanged("TypeEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaUserEntryBaseFilter()
		{
		}

		public KalturaUserEntryBaseFilter(XmlElement node) : base(node)
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
					case "entryIdEqual":
						this.EntryIdEqual = txt;
						continue;
					case "entryIdIn":
						this.EntryIdIn = txt;
						continue;
					case "entryIdNotIn":
						this.EntryIdNotIn = txt;
						continue;
					case "userIdEqual":
						this.UserIdEqual = ParseInt(txt);
						continue;
					case "userIdIn":
						this.UserIdIn = txt;
						continue;
					case "userIdNotIn":
						this.UserIdNotIn = txt;
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaUserEntryStatus)KalturaStringEnum.Parse(typeof(KalturaUserEntryStatus), txt);
						continue;
					case "createdAtLessThanOrEqual":
						this.CreatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "createdAtGreaterThanOrEqual":
						this.CreatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtLessThanOrEqual":
						this.UpdatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this.UpdatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "typeEqual":
						this.TypeEqual = (KalturaUserEntryType)KalturaStringEnum.Parse(typeof(KalturaUserEntryType), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaUserEntryBaseFilter");
			kparams.AddIntIfNotNull("idEqual", this.IdEqual);
			kparams.AddStringIfNotNull("idIn", this.IdIn);
			kparams.AddStringIfNotNull("idNotIn", this.IdNotIn);
			kparams.AddStringIfNotNull("entryIdEqual", this.EntryIdEqual);
			kparams.AddStringIfNotNull("entryIdIn", this.EntryIdIn);
			kparams.AddStringIfNotNull("entryIdNotIn", this.EntryIdNotIn);
			kparams.AddIntIfNotNull("userIdEqual", this.UserIdEqual);
			kparams.AddStringIfNotNull("userIdIn", this.UserIdIn);
			kparams.AddStringIfNotNull("userIdNotIn", this.UserIdNotIn);
			kparams.AddStringEnumIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddIntIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddStringEnumIfNotNull("typeEqual", this.TypeEqual);
			return kparams;
		}
		#endregion
	}
}

