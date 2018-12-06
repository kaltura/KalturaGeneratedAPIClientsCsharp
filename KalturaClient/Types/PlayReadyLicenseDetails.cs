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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class PlayReadyLicenseDetails : ObjectBase
	{
		#region Constants
		public const string POLICY = "policy";
		public const string BEGIN_DATE = "beginDate";
		public const string EXPIRATION_DATE = "expirationDate";
		public const string REMOVAL_DATE = "removalDate";
		#endregion

		#region Private Fields
		private PlayReadyPolicy _Policy;
		private int _BeginDate = Int32.MinValue;
		private int _ExpirationDate = Int32.MinValue;
		private int _RemovalDate = Int32.MinValue;
		#endregion

		#region Properties
		public PlayReadyPolicy Policy
		{
			get { return _Policy; }
			set 
			{ 
				_Policy = value;
				OnPropertyChanged("Policy");
			}
		}
		public int BeginDate
		{
			get { return _BeginDate; }
			set 
			{ 
				_BeginDate = value;
				OnPropertyChanged("BeginDate");
			}
		}
		public int ExpirationDate
		{
			get { return _ExpirationDate; }
			set 
			{ 
				_ExpirationDate = value;
				OnPropertyChanged("ExpirationDate");
			}
		}
		public int RemovalDate
		{
			get { return _RemovalDate; }
			set 
			{ 
				_RemovalDate = value;
				OnPropertyChanged("RemovalDate");
			}
		}
		#endregion

		#region CTor
		public PlayReadyLicenseDetails()
		{
		}

		public PlayReadyLicenseDetails(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "policy":
						this._Policy = ObjectFactory.Create<PlayReadyPolicy>(propertyNode);
						continue;
					case "beginDate":
						this._BeginDate = ParseInt(propertyNode.InnerText);
						continue;
					case "expirationDate":
						this._ExpirationDate = ParseInt(propertyNode.InnerText);
						continue;
					case "removalDate":
						this._RemovalDate = ParseInt(propertyNode.InnerText);
						continue;
				}
			}
		}

		public PlayReadyLicenseDetails(IDictionary<string,object> data) : base(data)
		{
			    this._Policy = ObjectFactory.Create<PlayReadyPolicy>(data.TryGetValueSafe<IDictionary<string,object>>("policy"));
			    this._BeginDate = data.TryGetValueSafe<int>("beginDate");
			    this._ExpirationDate = data.TryGetValueSafe<int>("expirationDate");
			    this._RemovalDate = data.TryGetValueSafe<int>("removalDate");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPlayReadyLicenseDetails");
			kparams.AddIfNotNull("policy", this._Policy);
			kparams.AddIfNotNull("beginDate", this._BeginDate);
			kparams.AddIfNotNull("expirationDate", this._ExpirationDate);
			kparams.AddIfNotNull("removalDate", this._RemovalDate);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case POLICY:
					return "Policy";
				case BEGIN_DATE:
					return "BeginDate";
				case EXPIRATION_DATE:
					return "ExpirationDate";
				case REMOVAL_DATE:
					return "RemovalDate";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

