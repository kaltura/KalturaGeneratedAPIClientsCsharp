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
	public class KalturaUserFilter : KalturaUserBaseFilter
	{
		#region Private Fields
		private string _IdOrScreenNameStartsWith = null;
		private string _IdEqual = null;
		private string _IdIn = null;
		private KalturaNullableBoolean _LoginEnabledEqual = (KalturaNullableBoolean)Int32.MinValue;
		private string _RoleIdEqual = null;
		private string _RoleIdsEqual = null;
		private string _RoleIdsIn = null;
		private string _FirstNameOrLastNameStartsWith = null;
		private string _PermissionNamesMultiLikeOr = null;
		private string _PermissionNamesMultiLikeAnd = null;
		private KalturaUserOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public string IdOrScreenNameStartsWith
		{
			get { return _IdOrScreenNameStartsWith; }
			set 
			{ 
				_IdOrScreenNameStartsWith = value;
				OnPropertyChanged("IdOrScreenNameStartsWith");
			}
		}
		public string IdEqual
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
		public KalturaNullableBoolean LoginEnabledEqual
		{
			get { return _LoginEnabledEqual; }
			set 
			{ 
				_LoginEnabledEqual = value;
				OnPropertyChanged("LoginEnabledEqual");
			}
		}
		public string RoleIdEqual
		{
			get { return _RoleIdEqual; }
			set 
			{ 
				_RoleIdEqual = value;
				OnPropertyChanged("RoleIdEqual");
			}
		}
		public string RoleIdsEqual
		{
			get { return _RoleIdsEqual; }
			set 
			{ 
				_RoleIdsEqual = value;
				OnPropertyChanged("RoleIdsEqual");
			}
		}
		public string RoleIdsIn
		{
			get { return _RoleIdsIn; }
			set 
			{ 
				_RoleIdsIn = value;
				OnPropertyChanged("RoleIdsIn");
			}
		}
		public string FirstNameOrLastNameStartsWith
		{
			get { return _FirstNameOrLastNameStartsWith; }
			set 
			{ 
				_FirstNameOrLastNameStartsWith = value;
				OnPropertyChanged("FirstNameOrLastNameStartsWith");
			}
		}
		public string PermissionNamesMultiLikeOr
		{
			get { return _PermissionNamesMultiLikeOr; }
			set 
			{ 
				_PermissionNamesMultiLikeOr = value;
				OnPropertyChanged("PermissionNamesMultiLikeOr");
			}
		}
		public string PermissionNamesMultiLikeAnd
		{
			get { return _PermissionNamesMultiLikeAnd; }
			set 
			{ 
				_PermissionNamesMultiLikeAnd = value;
				OnPropertyChanged("PermissionNamesMultiLikeAnd");
			}
		}
		public new KalturaUserOrderBy OrderBy
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
		public KalturaUserFilter()
		{
		}

		public KalturaUserFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idOrScreenNameStartsWith":
						this.IdOrScreenNameStartsWith = txt;
						continue;
					case "idEqual":
						this.IdEqual = txt;
						continue;
					case "idIn":
						this.IdIn = txt;
						continue;
					case "loginEnabledEqual":
						this.LoginEnabledEqual = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "roleIdEqual":
						this.RoleIdEqual = txt;
						continue;
					case "roleIdsEqual":
						this.RoleIdsEqual = txt;
						continue;
					case "roleIdsIn":
						this.RoleIdsIn = txt;
						continue;
					case "firstNameOrLastNameStartsWith":
						this.FirstNameOrLastNameStartsWith = txt;
						continue;
					case "permissionNamesMultiLikeOr":
						this.PermissionNamesMultiLikeOr = txt;
						continue;
					case "permissionNamesMultiLikeAnd":
						this.PermissionNamesMultiLikeAnd = txt;
						continue;
					case "orderBy":
						this.OrderBy = (KalturaUserOrderBy)KalturaStringEnum.Parse(typeof(KalturaUserOrderBy), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaUserFilter");
			kparams.AddIfNotNull("idOrScreenNameStartsWith", this.IdOrScreenNameStartsWith);
			kparams.AddIfNotNull("idEqual", this.IdEqual);
			kparams.AddIfNotNull("idIn", this.IdIn);
			kparams.AddIfNotNull("loginEnabledEqual", this.LoginEnabledEqual);
			kparams.AddIfNotNull("roleIdEqual", this.RoleIdEqual);
			kparams.AddIfNotNull("roleIdsEqual", this.RoleIdsEqual);
			kparams.AddIfNotNull("roleIdsIn", this.RoleIdsIn);
			kparams.AddIfNotNull("firstNameOrLastNameStartsWith", this.FirstNameOrLastNameStartsWith);
			kparams.AddIfNotNull("permissionNamesMultiLikeOr", this.PermissionNamesMultiLikeOr);
			kparams.AddIfNotNull("permissionNamesMultiLikeAnd", this.PermissionNamesMultiLikeAnd);
			kparams.AddIfNotNull("orderBy", this.OrderBy);
			return kparams;
		}
		#endregion
	}
}

