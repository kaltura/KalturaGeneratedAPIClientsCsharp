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
	public class KalturaVirusScanProfile : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private KalturaVirusScanProfileStatus _Status = (KalturaVirusScanProfileStatus)Int32.MinValue;
		private KalturaVirusScanEngineType _EngineType = null;
		private KalturaBaseEntryFilter _EntryFilter;
		private KalturaVirusFoundAction _ActionIfInfected = (KalturaVirusFoundAction)Int32.MinValue;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
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
		public KalturaVirusScanProfileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public KalturaVirusScanEngineType EngineType
		{
			get { return _EngineType; }
			set 
			{ 
				_EngineType = value;
				OnPropertyChanged("EngineType");
			}
		}
		public KalturaBaseEntryFilter EntryFilter
		{
			get { return _EntryFilter; }
			set 
			{ 
				_EntryFilter = value;
				OnPropertyChanged("EntryFilter");
			}
		}
		public KalturaVirusFoundAction ActionIfInfected
		{
			get { return _ActionIfInfected; }
			set 
			{ 
				_ActionIfInfected = value;
				OnPropertyChanged("ActionIfInfected");
			}
		}
		#endregion

		#region CTor
		public KalturaVirusScanProfile()
		{
		}

		public KalturaVirusScanProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(txt);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "name":
						this._Name = txt;
						continue;
					case "status":
						this._Status = (KalturaVirusScanProfileStatus)ParseEnum(typeof(KalturaVirusScanProfileStatus), txt);
						continue;
					case "engineType":
						this._EngineType = (KalturaVirusScanEngineType)KalturaStringEnum.Parse(typeof(KalturaVirusScanEngineType), txt);
						continue;
					case "entryFilter":
						this._EntryFilter = (KalturaBaseEntryFilter)KalturaObjectFactory.Create(propertyNode, "KalturaBaseEntryFilter");
						continue;
					case "actionIfInfected":
						this._ActionIfInfected = (KalturaVirusFoundAction)ParseEnum(typeof(KalturaVirusFoundAction), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaVirusScanProfile");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("engineType", this._EngineType);
			kparams.AddIfNotNull("entryFilter", this._EntryFilter);
			kparams.AddIfNotNull("actionIfInfected", this._ActionIfInfected);
			return kparams;
		}
		#endregion
	}
}

