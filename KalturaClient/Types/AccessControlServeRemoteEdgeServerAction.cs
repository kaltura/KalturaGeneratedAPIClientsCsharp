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
	public class AccessControlServeRemoteEdgeServerAction : RuleAction
	{
		#region Constants
		public const string EDGE_SERVER_IDS = "edgeServerIds";
		public const string SEAMLESS_FALLBACK_ENABLED = "seamlessFallbackEnabled";
		#endregion

		#region Private Fields
		private string _EdgeServerIds = null;
		private NullableBoolean _SeamlessFallbackEnabled = (NullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		public string EdgeServerIds
		{
			get { return _EdgeServerIds; }
			set 
			{ 
				_EdgeServerIds = value;
				OnPropertyChanged("EdgeServerIds");
			}
		}
		public NullableBoolean SeamlessFallbackEnabled
		{
			get { return _SeamlessFallbackEnabled; }
			set 
			{ 
				_SeamlessFallbackEnabled = value;
				OnPropertyChanged("SeamlessFallbackEnabled");
			}
		}
		#endregion

		#region CTor
		public AccessControlServeRemoteEdgeServerAction()
		{
		}

		public AccessControlServeRemoteEdgeServerAction(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "edgeServerIds":
						this._EdgeServerIds = propertyNode.InnerText;
						continue;
					case "seamlessFallbackEnabled":
						this._SeamlessFallbackEnabled = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
				}
			}
		}

		public AccessControlServeRemoteEdgeServerAction(IDictionary<string,object> data) : base(data)
		{
			    this._EdgeServerIds = data.TryGetValueSafe<string>("edgeServerIds");
			    this._SeamlessFallbackEnabled = (NullableBoolean)ParseEnum(typeof(NullableBoolean), data.TryGetValueSafe<int>("seamlessFallbackEnabled"));
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAccessControlServeRemoteEdgeServerAction");
			kparams.AddIfNotNull("edgeServerIds", this._EdgeServerIds);
			kparams.AddIfNotNull("seamlessFallbackEnabled", this._SeamlessFallbackEnabled);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case EDGE_SERVER_IDS:
					return "EdgeServerIds";
				case SEAMLESS_FALLBACK_ENABLED:
					return "SeamlessFallbackEnabled";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

