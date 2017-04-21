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
// Copyright (C) 2006-2017  Kaltura Inc.
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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class VirusScanProfile : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string PARTNER_ID = "partnerId";
		public const string NAME = "name";
		public const string STATUS = "status";
		public const string ENGINE_TYPE = "engineType";
		public const string ENTRY_FILTER = "entryFilter";
		public const string ACTION_IF_INFECTED = "actionIfInfected";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private VirusScanProfileStatus _Status = (VirusScanProfileStatus)Int32.MinValue;
		private VirusScanEngineType _EngineType = null;
		private BaseEntryFilter _EntryFilter;
		private VirusFoundAction _ActionIfInfected = (VirusFoundAction)Int32.MinValue;
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
		public VirusScanProfileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public VirusScanEngineType EngineType
		{
			get { return _EngineType; }
			set 
			{ 
				_EngineType = value;
				OnPropertyChanged("EngineType");
			}
		}
		public BaseEntryFilter EntryFilter
		{
			get { return _EntryFilter; }
			set 
			{ 
				_EntryFilter = value;
				OnPropertyChanged("EntryFilter");
			}
		}
		public VirusFoundAction ActionIfInfected
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
		public VirusScanProfile()
		{
		}

		public VirusScanProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "status":
						this._Status = (VirusScanProfileStatus)ParseEnum(typeof(VirusScanProfileStatus), propertyNode.InnerText);
						continue;
					case "engineType":
						this._EngineType = (VirusScanEngineType)StringEnum.Parse(typeof(VirusScanEngineType), propertyNode.InnerText);
						continue;
					case "entryFilter":
						this._EntryFilter = ObjectFactory.Create<BaseEntryFilter>(propertyNode);
						continue;
					case "actionIfInfected":
						this._ActionIfInfected = (VirusFoundAction)ParseEnum(typeof(VirusFoundAction), propertyNode.InnerText);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
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
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case PARTNER_ID:
					return "PartnerId";
				case NAME:
					return "Name";
				case STATUS:
					return "Status";
				case ENGINE_TYPE:
					return "EngineType";
				case ENTRY_FILTER:
					return "EntryFilter";
				case ACTION_IF_INFECTED:
					return "ActionIfInfected";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

