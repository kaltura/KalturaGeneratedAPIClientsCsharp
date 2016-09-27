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
	public class KalturaCategoryUserProviderFilter : KalturaFilter
	{
		#region Private Fields
		private string _UserIdEqual = null;
		private string _UserIdIn = null;
		private KalturaCategoryUserStatus _StatusEqual = (KalturaCategoryUserStatus)Int32.MinValue;
		private string _StatusIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private KalturaUpdateMethodType _UpdateMethodEqual = (KalturaUpdateMethodType)Int32.MinValue;
		private string _UpdateMethodIn = null;
		private string _PermissionNamesMatchAnd = null;
		private string _PermissionNamesMatchOr = null;
		#endregion

		#region Properties
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
		#endregion

		#region CTor
		public KalturaCategoryUserProviderFilter()
		{
		}

		public KalturaCategoryUserProviderFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "userIdEqual":
						this._UserIdEqual = txt;
						continue;
					case "userIdIn":
						this._UserIdIn = txt;
						continue;
					case "statusEqual":
						this._StatusEqual = (KalturaCategoryUserStatus)ParseEnum(typeof(KalturaCategoryUserStatus), txt);
						continue;
					case "statusIn":
						this._StatusIn = txt;
						continue;
					case "createdAtGreaterThanOrEqual":
						this._CreatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "createdAtLessThanOrEqual":
						this._CreatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this._UpdatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtLessThanOrEqual":
						this._UpdatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "updateMethodEqual":
						this._UpdateMethodEqual = (KalturaUpdateMethodType)ParseEnum(typeof(KalturaUpdateMethodType), txt);
						continue;
					case "updateMethodIn":
						this._UpdateMethodIn = txt;
						continue;
					case "permissionNamesMatchAnd":
						this._PermissionNamesMatchAnd = txt;
						continue;
					case "permissionNamesMatchOr":
						this._PermissionNamesMatchOr = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaCategoryUserProviderFilter");
			kparams.AddIfNotNull("userIdEqual", this._UserIdEqual);
			kparams.AddIfNotNull("userIdIn", this._UserIdIn);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updateMethodEqual", this._UpdateMethodEqual);
			kparams.AddIfNotNull("updateMethodIn", this._UpdateMethodIn);
			kparams.AddIfNotNull("permissionNamesMatchAnd", this._PermissionNamesMatchAnd);
			kparams.AddIfNotNull("permissionNamesMatchOr", this._PermissionNamesMatchOr);
			return kparams;
		}
		#endregion
	}
}

