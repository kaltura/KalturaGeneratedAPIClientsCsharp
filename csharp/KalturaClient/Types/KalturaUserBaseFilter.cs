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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public class KalturaUserBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _PartnerIdEqual = Int32.MinValue;
		private string _ScreenNameLike = null;
		private string _ScreenNameStartsWith = null;
		private string _EmailLike = null;
		private string _EmailStartsWith = null;
		private string _TagsMultiLikeOr = null;
		private string _TagsMultiLikeAnd = null;
		private KalturaUserStatus _StatusEqual = (KalturaUserStatus)Int32.MinValue;
		private string _StatusIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private string _FirstNameStartsWith = null;
		private string _LastNameStartsWith = null;
		private KalturaNullableBoolean _IsAdminEqual = (KalturaNullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		public string ScreenNameLike
		{
			get { return _ScreenNameLike; }
			set 
			{ 
				_ScreenNameLike = value;
				OnPropertyChanged("ScreenNameLike");
			}
		}
		public string ScreenNameStartsWith
		{
			get { return _ScreenNameStartsWith; }
			set 
			{ 
				_ScreenNameStartsWith = value;
				OnPropertyChanged("ScreenNameStartsWith");
			}
		}
		public string EmailLike
		{
			get { return _EmailLike; }
			set 
			{ 
				_EmailLike = value;
				OnPropertyChanged("EmailLike");
			}
		}
		public string EmailStartsWith
		{
			get { return _EmailStartsWith; }
			set 
			{ 
				_EmailStartsWith = value;
				OnPropertyChanged("EmailStartsWith");
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
		public KalturaUserStatus StatusEqual
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
		public string FirstNameStartsWith
		{
			get { return _FirstNameStartsWith; }
			set 
			{ 
				_FirstNameStartsWith = value;
				OnPropertyChanged("FirstNameStartsWith");
			}
		}
		public string LastNameStartsWith
		{
			get { return _LastNameStartsWith; }
			set 
			{ 
				_LastNameStartsWith = value;
				OnPropertyChanged("LastNameStartsWith");
			}
		}
		public KalturaNullableBoolean IsAdminEqual
		{
			get { return _IsAdminEqual; }
			set 
			{ 
				_IsAdminEqual = value;
				OnPropertyChanged("IsAdminEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaUserBaseFilter()
		{
		}

		public KalturaUserBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "partnerIdEqual":
						this.PartnerIdEqual = ParseInt(txt);
						continue;
					case "screenNameLike":
						this.ScreenNameLike = txt;
						continue;
					case "screenNameStartsWith":
						this.ScreenNameStartsWith = txt;
						continue;
					case "emailLike":
						this.EmailLike = txt;
						continue;
					case "emailStartsWith":
						this.EmailStartsWith = txt;
						continue;
					case "tagsMultiLikeOr":
						this.TagsMultiLikeOr = txt;
						continue;
					case "tagsMultiLikeAnd":
						this.TagsMultiLikeAnd = txt;
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaUserStatus)ParseEnum(typeof(KalturaUserStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
					case "createdAtGreaterThanOrEqual":
						this.CreatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "createdAtLessThanOrEqual":
						this.CreatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "firstNameStartsWith":
						this.FirstNameStartsWith = txt;
						continue;
					case "lastNameStartsWith":
						this.LastNameStartsWith = txt;
						continue;
					case "isAdminEqual":
						this.IsAdminEqual = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaUserBaseFilter");
			kparams.AddIntIfNotNull("partnerIdEqual", this.PartnerIdEqual);
			kparams.AddStringIfNotNull("screenNameLike", this.ScreenNameLike);
			kparams.AddStringIfNotNull("screenNameStartsWith", this.ScreenNameStartsWith);
			kparams.AddStringIfNotNull("emailLike", this.EmailLike);
			kparams.AddStringIfNotNull("emailStartsWith", this.EmailStartsWith);
			kparams.AddStringIfNotNull("tagsMultiLikeOr", this.TagsMultiLikeOr);
			kparams.AddStringIfNotNull("tagsMultiLikeAnd", this.TagsMultiLikeAnd);
			kparams.AddEnumIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddStringIfNotNull("statusIn", this.StatusIn);
			kparams.AddIntIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddStringIfNotNull("firstNameStartsWith", this.FirstNameStartsWith);
			kparams.AddStringIfNotNull("lastNameStartsWith", this.LastNameStartsWith);
			kparams.AddEnumIfNotNull("isAdminEqual", this.IsAdminEqual);
			return kparams;
		}
		#endregion
	}
}

