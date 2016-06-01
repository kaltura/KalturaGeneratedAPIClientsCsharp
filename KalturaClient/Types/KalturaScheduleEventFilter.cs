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
	public class KalturaScheduleEventFilter : KalturaScheduleEventBaseFilter
	{
		#region Private Fields
		private string _ResourceIdsLike = null;
		private string _ResourceIdsMultiLikeOr = null;
		private string _ResourceIdsMultiLikeAnd = null;
		private string _ParentResourceIdsLike = null;
		private string _ParentResourceIdsMultiLikeOr = null;
		private string _ParentResourceIdsMultiLikeAnd = null;
		private string _TemplateEntryCategoriesIdsMultiLikeAnd = null;
		private string _TemplateEntryCategoriesIdsMultiLikeOr = null;
		private string _TemplateEntryCategoriesIdsLike = null;
		private string _SystemNamesMultiLikeOr = null;
		private string _SystemNamesMultiLikeAnd = null;
		private string _SystemNamesLike = null;
		private KalturaScheduleEventOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public string ResourceIdsLike
		{
			get { return _ResourceIdsLike; }
			set 
			{ 
				_ResourceIdsLike = value;
				OnPropertyChanged("ResourceIdsLike");
			}
		}
		public string ResourceIdsMultiLikeOr
		{
			get { return _ResourceIdsMultiLikeOr; }
			set 
			{ 
				_ResourceIdsMultiLikeOr = value;
				OnPropertyChanged("ResourceIdsMultiLikeOr");
			}
		}
		public string ResourceIdsMultiLikeAnd
		{
			get { return _ResourceIdsMultiLikeAnd; }
			set 
			{ 
				_ResourceIdsMultiLikeAnd = value;
				OnPropertyChanged("ResourceIdsMultiLikeAnd");
			}
		}
		public string ParentResourceIdsLike
		{
			get { return _ParentResourceIdsLike; }
			set 
			{ 
				_ParentResourceIdsLike = value;
				OnPropertyChanged("ParentResourceIdsLike");
			}
		}
		public string ParentResourceIdsMultiLikeOr
		{
			get { return _ParentResourceIdsMultiLikeOr; }
			set 
			{ 
				_ParentResourceIdsMultiLikeOr = value;
				OnPropertyChanged("ParentResourceIdsMultiLikeOr");
			}
		}
		public string ParentResourceIdsMultiLikeAnd
		{
			get { return _ParentResourceIdsMultiLikeAnd; }
			set 
			{ 
				_ParentResourceIdsMultiLikeAnd = value;
				OnPropertyChanged("ParentResourceIdsMultiLikeAnd");
			}
		}
		public string TemplateEntryCategoriesIdsMultiLikeAnd
		{
			get { return _TemplateEntryCategoriesIdsMultiLikeAnd; }
			set 
			{ 
				_TemplateEntryCategoriesIdsMultiLikeAnd = value;
				OnPropertyChanged("TemplateEntryCategoriesIdsMultiLikeAnd");
			}
		}
		public string TemplateEntryCategoriesIdsMultiLikeOr
		{
			get { return _TemplateEntryCategoriesIdsMultiLikeOr; }
			set 
			{ 
				_TemplateEntryCategoriesIdsMultiLikeOr = value;
				OnPropertyChanged("TemplateEntryCategoriesIdsMultiLikeOr");
			}
		}
		public string TemplateEntryCategoriesIdsLike
		{
			get { return _TemplateEntryCategoriesIdsLike; }
			set 
			{ 
				_TemplateEntryCategoriesIdsLike = value;
				OnPropertyChanged("TemplateEntryCategoriesIdsLike");
			}
		}
		public string SystemNamesMultiLikeOr
		{
			get { return _SystemNamesMultiLikeOr; }
			set 
			{ 
				_SystemNamesMultiLikeOr = value;
				OnPropertyChanged("SystemNamesMultiLikeOr");
			}
		}
		public string SystemNamesMultiLikeAnd
		{
			get { return _SystemNamesMultiLikeAnd; }
			set 
			{ 
				_SystemNamesMultiLikeAnd = value;
				OnPropertyChanged("SystemNamesMultiLikeAnd");
			}
		}
		public string SystemNamesLike
		{
			get { return _SystemNamesLike; }
			set 
			{ 
				_SystemNamesLike = value;
				OnPropertyChanged("SystemNamesLike");
			}
		}
		public new KalturaScheduleEventOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public KalturaScheduleEventFilter()
		{
		}

		public KalturaScheduleEventFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "resourceIdsLike":
						this.ResourceIdsLike = txt;
						continue;
					case "resourceIdsMultiLikeOr":
						this.ResourceIdsMultiLikeOr = txt;
						continue;
					case "resourceIdsMultiLikeAnd":
						this.ResourceIdsMultiLikeAnd = txt;
						continue;
					case "parentResourceIdsLike":
						this.ParentResourceIdsLike = txt;
						continue;
					case "parentResourceIdsMultiLikeOr":
						this.ParentResourceIdsMultiLikeOr = txt;
						continue;
					case "parentResourceIdsMultiLikeAnd":
						this.ParentResourceIdsMultiLikeAnd = txt;
						continue;
					case "templateEntryCategoriesIdsMultiLikeAnd":
						this.TemplateEntryCategoriesIdsMultiLikeAnd = txt;
						continue;
					case "templateEntryCategoriesIdsMultiLikeOr":
						this.TemplateEntryCategoriesIdsMultiLikeOr = txt;
						continue;
					case "templateEntryCategoriesIdsLike":
						this.TemplateEntryCategoriesIdsLike = txt;
						continue;
					case "systemNamesMultiLikeOr":
						this.SystemNamesMultiLikeOr = txt;
						continue;
					case "systemNamesMultiLikeAnd":
						this.SystemNamesMultiLikeAnd = txt;
						continue;
					case "systemNamesLike":
						this.SystemNamesLike = txt;
						continue;
					case "orderBy":
						this.OrderBy = (KalturaScheduleEventOrderBy)KalturaStringEnum.Parse(typeof(KalturaScheduleEventOrderBy), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaScheduleEventFilter");
			kparams.AddIfNotNull("resourceIdsLike", this.ResourceIdsLike);
			kparams.AddIfNotNull("resourceIdsMultiLikeOr", this.ResourceIdsMultiLikeOr);
			kparams.AddIfNotNull("resourceIdsMultiLikeAnd", this.ResourceIdsMultiLikeAnd);
			kparams.AddIfNotNull("parentResourceIdsLike", this.ParentResourceIdsLike);
			kparams.AddIfNotNull("parentResourceIdsMultiLikeOr", this.ParentResourceIdsMultiLikeOr);
			kparams.AddIfNotNull("parentResourceIdsMultiLikeAnd", this.ParentResourceIdsMultiLikeAnd);
			kparams.AddIfNotNull("templateEntryCategoriesIdsMultiLikeAnd", this.TemplateEntryCategoriesIdsMultiLikeAnd);
			kparams.AddIfNotNull("templateEntryCategoriesIdsMultiLikeOr", this.TemplateEntryCategoriesIdsMultiLikeOr);
			kparams.AddIfNotNull("templateEntryCategoriesIdsLike", this.TemplateEntryCategoriesIdsLike);
			kparams.AddIfNotNull("systemNamesMultiLikeOr", this.SystemNamesMultiLikeOr);
			kparams.AddIfNotNull("systemNamesMultiLikeAnd", this.SystemNamesMultiLikeAnd);
			kparams.AddIfNotNull("systemNamesLike", this.SystemNamesLike);
			kparams.AddIfNotNull("orderBy", this.OrderBy);
			return kparams;
		}
		#endregion
	}
}

