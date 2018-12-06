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
	public class FairplayEntryContextPluginData : PluginData
	{
		#region Constants
		public const string PUBLIC_CERTIFICATE = "publicCertificate";
		#endregion

		#region Private Fields
		private string _PublicCertificate = null;
		#endregion

		#region Properties
		public string PublicCertificate
		{
			get { return _PublicCertificate; }
			set 
			{ 
				_PublicCertificate = value;
				OnPropertyChanged("PublicCertificate");
			}
		}
		#endregion

		#region CTor
		public FairplayEntryContextPluginData()
		{
		}

		public FairplayEntryContextPluginData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "publicCertificate":
						this._PublicCertificate = propertyNode.InnerText;
						continue;
				}
			}
		}

		public FairplayEntryContextPluginData(IDictionary<string,object> data) : base(data)
		{
			    this._PublicCertificate = data.TryGetValueSafe<string>("publicCertificate");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFairplayEntryContextPluginData");
			kparams.AddIfNotNull("publicCertificate", this._PublicCertificate);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PUBLIC_CERTIFICATE:
					return "PublicCertificate";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

