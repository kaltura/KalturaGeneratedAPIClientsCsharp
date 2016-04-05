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
	public class KalturaEntryServerNodeBaseFilter : KalturaRelatedFilter
	{
		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private string _IdNotIn = null;
		private string _EntryIdEqual = null;
		private string _EntryIdIn = null;
		private string _EntryIdNotIn = null;
		private int _ServerNodeIdEqual = Int32.MinValue;
		private string _ServerNodeIdIn = null;
		private string _ServerNodeIdNotIn = null;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private KalturaEntryServerNodeStatus _StatusEqual = (KalturaEntryServerNodeStatus)Int32.MinValue;
		private KalturaEntryServerNodeStatus _StatusIn = (KalturaEntryServerNodeStatus)Int32.MinValue;
		private KalturaEntryServerNodeType _ServerTypeEqual = null;
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
		public int ServerNodeIdEqual
		{
			get { return _ServerNodeIdEqual; }
			set 
			{ 
				_ServerNodeIdEqual = value;
				OnPropertyChanged("ServerNodeIdEqual");
			}
		}
		public string ServerNodeIdIn
		{
			get { return _ServerNodeIdIn; }
			set 
			{ 
				_ServerNodeIdIn = value;
				OnPropertyChanged("ServerNodeIdIn");
			}
		}
		public string ServerNodeIdNotIn
		{
			get { return _ServerNodeIdNotIn; }
			set 
			{ 
				_ServerNodeIdNotIn = value;
				OnPropertyChanged("ServerNodeIdNotIn");
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
		public KalturaEntryServerNodeStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public KalturaEntryServerNodeStatus StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		public KalturaEntryServerNodeType ServerTypeEqual
		{
			get { return _ServerTypeEqual; }
			set 
			{ 
				_ServerTypeEqual = value;
				OnPropertyChanged("ServerTypeEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaEntryServerNodeBaseFilter()
		{
		}

		public KalturaEntryServerNodeBaseFilter(XmlElement node) : base(node)
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
					case "serverNodeIdEqual":
						this.ServerNodeIdEqual = ParseInt(txt);
						continue;
					case "serverNodeIdIn":
						this.ServerNodeIdIn = txt;
						continue;
					case "serverNodeIdNotIn":
						this.ServerNodeIdNotIn = txt;
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
					case "statusEqual":
						this.StatusEqual = (KalturaEntryServerNodeStatus)ParseEnum(typeof(KalturaEntryServerNodeStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = (KalturaEntryServerNodeStatus)ParseEnum(typeof(KalturaEntryServerNodeStatus), txt);
						continue;
					case "serverTypeEqual":
						this.ServerTypeEqual = (KalturaEntryServerNodeType)KalturaStringEnum.Parse(typeof(KalturaEntryServerNodeType), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaEntryServerNodeBaseFilter");
			kparams.AddIfNotNull("idEqual", this.IdEqual);
			kparams.AddIfNotNull("idIn", this.IdIn);
			kparams.AddIfNotNull("idNotIn", this.IdNotIn);
			kparams.AddIfNotNull("entryIdEqual", this.EntryIdEqual);
			kparams.AddIfNotNull("entryIdIn", this.EntryIdIn);
			kparams.AddIfNotNull("entryIdNotIn", this.EntryIdNotIn);
			kparams.AddIfNotNull("serverNodeIdEqual", this.ServerNodeIdEqual);
			kparams.AddIfNotNull("serverNodeIdIn", this.ServerNodeIdIn);
			kparams.AddIfNotNull("serverNodeIdNotIn", this.ServerNodeIdNotIn);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddIfNotNull("statusIn", this.StatusIn);
			kparams.AddIfNotNull("serverTypeEqual", this.ServerTypeEqual);
			return kparams;
		}
		#endregion
	}
}

