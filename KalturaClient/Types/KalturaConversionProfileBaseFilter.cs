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
	public class KalturaConversionProfileBaseFilter : KalturaRelatedFilter
	{
		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private KalturaConversionProfileStatus _StatusEqual = null;
		private string _StatusIn = null;
		private KalturaConversionProfileType _TypeEqual = null;
		private string _TypeIn = null;
		private string _NameEqual = null;
		private string _SystemNameEqual = null;
		private string _SystemNameIn = null;
		private string _TagsMultiLikeOr = null;
		private string _TagsMultiLikeAnd = null;
		private string _DefaultEntryIdEqual = null;
		private string _DefaultEntryIdIn = null;
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
		public KalturaConversionProfileStatus StatusEqual
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
		public KalturaConversionProfileType TypeEqual
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
		public string NameEqual
		{
			get { return _NameEqual; }
			set 
			{ 
				_NameEqual = value;
				OnPropertyChanged("NameEqual");
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
		public string DefaultEntryIdEqual
		{
			get { return _DefaultEntryIdEqual; }
			set 
			{ 
				_DefaultEntryIdEqual = value;
				OnPropertyChanged("DefaultEntryIdEqual");
			}
		}
		public string DefaultEntryIdIn
		{
			get { return _DefaultEntryIdIn; }
			set 
			{ 
				_DefaultEntryIdIn = value;
				OnPropertyChanged("DefaultEntryIdIn");
			}
		}
		#endregion

		#region CTor
		public KalturaConversionProfileBaseFilter()
		{
		}

		public KalturaConversionProfileBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idEqual":
						this._IdEqual = ParseInt(txt);
						continue;
					case "idIn":
						this._IdIn = txt;
						continue;
					case "statusEqual":
						this._StatusEqual = (KalturaConversionProfileStatus)KalturaStringEnum.Parse(typeof(KalturaConversionProfileStatus), txt);
						continue;
					case "statusIn":
						this._StatusIn = txt;
						continue;
					case "typeEqual":
						this._TypeEqual = (KalturaConversionProfileType)KalturaStringEnum.Parse(typeof(KalturaConversionProfileType), txt);
						continue;
					case "typeIn":
						this._TypeIn = txt;
						continue;
					case "nameEqual":
						this._NameEqual = txt;
						continue;
					case "systemNameEqual":
						this._SystemNameEqual = txt;
						continue;
					case "systemNameIn":
						this._SystemNameIn = txt;
						continue;
					case "tagsMultiLikeOr":
						this._TagsMultiLikeOr = txt;
						continue;
					case "tagsMultiLikeAnd":
						this._TagsMultiLikeAnd = txt;
						continue;
					case "defaultEntryIdEqual":
						this._DefaultEntryIdEqual = txt;
						continue;
					case "defaultEntryIdIn":
						this._DefaultEntryIdIn = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaConversionProfileBaseFilter");
			kparams.AddIfNotNull("idEqual", this.IdEqual);
			kparams.AddIfNotNull("idIn", this.IdIn);
			kparams.AddIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddIfNotNull("statusIn", this.StatusIn);
			kparams.AddIfNotNull("typeEqual", this.TypeEqual);
			kparams.AddIfNotNull("typeIn", this.TypeIn);
			kparams.AddIfNotNull("nameEqual", this.NameEqual);
			kparams.AddIfNotNull("systemNameEqual", this.SystemNameEqual);
			kparams.AddIfNotNull("systemNameIn", this.SystemNameIn);
			kparams.AddIfNotNull("tagsMultiLikeOr", this.TagsMultiLikeOr);
			kparams.AddIfNotNull("tagsMultiLikeAnd", this.TagsMultiLikeAnd);
			kparams.AddIfNotNull("defaultEntryIdEqual", this.DefaultEntryIdEqual);
			kparams.AddIfNotNull("defaultEntryIdIn", this.DefaultEntryIdIn);
			return kparams;
		}
		#endregion
	}
}

