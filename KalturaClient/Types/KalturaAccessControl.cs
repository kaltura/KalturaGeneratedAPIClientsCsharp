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
	public class KalturaAccessControl : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private string _SystemName = null;
		private string _Description = null;
		private int _CreatedAt = Int32.MinValue;
		private KalturaNullableBoolean _IsDefault = (KalturaNullableBoolean)Int32.MinValue;
		private IList<KalturaBaseRestriction> _Restrictions;
		private bool? _ContainsUnsuportedRestrictions = null;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public KalturaNullableBoolean IsDefault
		{
			get { return _IsDefault; }
			set 
			{ 
				_IsDefault = value;
				OnPropertyChanged("IsDefault");
			}
		}
		public new IList<KalturaBaseRestriction> Restrictions
		{
			get { return _Restrictions; }
			set 
			{ 
				_Restrictions = value;
				OnPropertyChanged("Restrictions");
			}
		}
		public bool? ContainsUnsuportedRestrictions
		{
			get { return _ContainsUnsuportedRestrictions; }
		}
		#endregion

		#region CTor
		public KalturaAccessControl()
		{
		}

		public KalturaAccessControl(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(txt);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "name":
						this._Name = txt;
						continue;
					case "systemName":
						this._SystemName = txt;
						continue;
					case "description":
						this._Description = txt;
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "isDefault":
						this._IsDefault = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "restrictions":
						this._Restrictions = new List<KalturaBaseRestriction>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Restrictions.Add((KalturaBaseRestriction)KalturaObjectFactory.Create(arrayNode, "KalturaBaseRestriction"));
						}
						continue;
					case "containsUnsuportedRestrictions":
						this._ContainsUnsuportedRestrictions = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAccessControl");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("name", this.Name);
			kparams.AddIfNotNull("systemName", this.SystemName);
			kparams.AddIfNotNull("description", this.Description);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("isDefault", this.IsDefault);
			kparams.AddIfNotNull("restrictions", this.Restrictions);
			kparams.AddIfNotNull("containsUnsuportedRestrictions", this.ContainsUnsuportedRestrictions);
			return kparams;
		}
		#endregion
	}
}

