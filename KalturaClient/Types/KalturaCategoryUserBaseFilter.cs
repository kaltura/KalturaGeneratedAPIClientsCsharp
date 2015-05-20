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
	public class KalturaCategoryUserBaseFilter : KalturaRelatedFilter
	{
		#region Private Fields
		private int _CategoryIdEqual = Int32.MinValue;
		private string _CategoryIdIn = null;
		private string _UserIdEqual = null;
		private string _UserIdIn = null;
		private KalturaCategoryUserPermissionLevel _PermissionLevelEqual = (KalturaCategoryUserPermissionLevel)Int32.MinValue;
		private string _PermissionLevelIn = null;
		private KalturaCategoryUserStatus _StatusEqual = (KalturaCategoryUserStatus)Int32.MinValue;
		private string _StatusIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private KalturaUpdateMethodType _UpdateMethodEqual = (KalturaUpdateMethodType)Int32.MinValue;
		private string _UpdateMethodIn = null;
		private string _CategoryFullIdsStartsWith = null;
		private string _CategoryFullIdsEqual = null;
		private string _PermissionNamesMatchAnd = null;
		private string _PermissionNamesMatchOr = null;
		private string _PermissionNamesNotContains = null;
		#endregion

		#region Properties
		public int CategoryIdEqual
		{
			get { return _CategoryIdEqual; }
			set 
			{ 
				_CategoryIdEqual = value;
				OnPropertyChanged("CategoryIdEqual");
			}
		}
		public string CategoryIdIn
		{
			get { return _CategoryIdIn; }
			set 
			{ 
				_CategoryIdIn = value;
				OnPropertyChanged("CategoryIdIn");
			}
		}
		public string UserIdEqual
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
		public KalturaCategoryUserPermissionLevel PermissionLevelEqual
		{
			get { return _PermissionLevelEqual; }
			set 
			{ 
				_PermissionLevelEqual = value;
				OnPropertyChanged("PermissionLevelEqual");
			}
		}
		public string PermissionLevelIn
		{
			get { return _PermissionLevelIn; }
			set 
			{ 
				_PermissionLevelIn = value;
				OnPropertyChanged("PermissionLevelIn");
			}
		}
		public KalturaCategoryUserStatus StatusEqual
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
		public KalturaUpdateMethodType UpdateMethodEqual
		{
			get { return _UpdateMethodEqual; }
			set 
			{ 
				_UpdateMethodEqual = value;
				OnPropertyChanged("UpdateMethodEqual");
			}
		}
		public string UpdateMethodIn
		{
			get { return _UpdateMethodIn; }
			set 
			{ 
				_UpdateMethodIn = value;
				OnPropertyChanged("UpdateMethodIn");
			}
		}
		public string CategoryFullIdsStartsWith
		{
			get { return _CategoryFullIdsStartsWith; }
			set 
			{ 
				_CategoryFullIdsStartsWith = value;
				OnPropertyChanged("CategoryFullIdsStartsWith");
			}
		}
		public string CategoryFullIdsEqual
		{
			get { return _CategoryFullIdsEqual; }
			set 
			{ 
				_CategoryFullIdsEqual = value;
				OnPropertyChanged("CategoryFullIdsEqual");
			}
		}
		public string PermissionNamesMatchAnd
		{
			get { return _PermissionNamesMatchAnd; }
			set 
			{ 
				_PermissionNamesMatchAnd = value;
				OnPropertyChanged("PermissionNamesMatchAnd");
			}
		}
		public string PermissionNamesMatchOr
		{
			get { return _PermissionNamesMatchOr; }
			set 
			{ 
				_PermissionNamesMatchOr = value;
				OnPropertyChanged("PermissionNamesMatchOr");
			}
		}
		public string PermissionNamesNotContains
		{
			get { return _PermissionNamesNotContains; }
			set 
			{ 
				_PermissionNamesNotContains = value;
				OnPropertyChanged("PermissionNamesNotContains");
			}
		}
		#endregion

		#region CTor
		public KalturaCategoryUserBaseFilter()
		{
		}

		public KalturaCategoryUserBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "categoryIdEqual":
						this.CategoryIdEqual = ParseInt(txt);
						continue;
					case "categoryIdIn":
						this.CategoryIdIn = txt;
						continue;
					case "userIdEqual":
						this.UserIdEqual = txt;
						continue;
					case "userIdIn":
						this.UserIdIn = txt;
						continue;
					case "permissionLevelEqual":
						this.PermissionLevelEqual = (KalturaCategoryUserPermissionLevel)ParseEnum(typeof(KalturaCategoryUserPermissionLevel), txt);
						continue;
					case "permissionLevelIn":
						this.PermissionLevelIn = txt;
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaCategoryUserStatus)ParseEnum(typeof(KalturaCategoryUserStatus), txt);
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
					case "updatedAtGreaterThanOrEqual":
						this.UpdatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtLessThanOrEqual":
						this.UpdatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "updateMethodEqual":
						this.UpdateMethodEqual = (KalturaUpdateMethodType)ParseEnum(typeof(KalturaUpdateMethodType), txt);
						continue;
					case "updateMethodIn":
						this.UpdateMethodIn = txt;
						continue;
					case "categoryFullIdsStartsWith":
						this.CategoryFullIdsStartsWith = txt;
						continue;
					case "categoryFullIdsEqual":
						this.CategoryFullIdsEqual = txt;
						continue;
					case "permissionNamesMatchAnd":
						this.PermissionNamesMatchAnd = txt;
						continue;
					case "permissionNamesMatchOr":
						this.PermissionNamesMatchOr = txt;
						continue;
					case "permissionNamesNotContains":
						this.PermissionNamesNotContains = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaCategoryUserBaseFilter");
			kparams.AddIntIfNotNull("categoryIdEqual", this.CategoryIdEqual);
			kparams.AddStringIfNotNull("categoryIdIn", this.CategoryIdIn);
			kparams.AddStringIfNotNull("userIdEqual", this.UserIdEqual);
			kparams.AddStringIfNotNull("userIdIn", this.UserIdIn);
			kparams.AddEnumIfNotNull("permissionLevelEqual", this.PermissionLevelEqual);
			kparams.AddStringIfNotNull("permissionLevelIn", this.PermissionLevelIn);
			kparams.AddEnumIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddStringIfNotNull("statusIn", this.StatusIn);
			kparams.AddIntIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			kparams.AddEnumIfNotNull("updateMethodEqual", this.UpdateMethodEqual);
			kparams.AddStringIfNotNull("updateMethodIn", this.UpdateMethodIn);
			kparams.AddStringIfNotNull("categoryFullIdsStartsWith", this.CategoryFullIdsStartsWith);
			kparams.AddStringIfNotNull("categoryFullIdsEqual", this.CategoryFullIdsEqual);
			kparams.AddStringIfNotNull("permissionNamesMatchAnd", this.PermissionNamesMatchAnd);
			kparams.AddStringIfNotNull("permissionNamesMatchOr", this.PermissionNamesMatchOr);
			kparams.AddStringIfNotNull("permissionNamesNotContains", this.PermissionNamesNotContains);
			return kparams;
		}
		#endregion
	}
}

