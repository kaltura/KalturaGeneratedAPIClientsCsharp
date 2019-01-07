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
// Copyright (C) 2006-2019  Kaltura Inc.
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class AuditTrailChangeItem : ObjectBase
	{
		#region Constants
		public const string DESCRIPTOR = "descriptor";
		public const string OLD_VALUE = "oldValue";
		public const string NEW_VALUE = "newValue";
		#endregion

		#region Private Fields
		private string _Descriptor = null;
		private string _OldValue = null;
		private string _NewValue = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string Descriptor
		{
			get { return _Descriptor; }
			set 
			{ 
				_Descriptor = value;
				OnPropertyChanged("Descriptor");
			}
		}
		[JsonProperty]
		public string OldValue
		{
			get { return _OldValue; }
			set 
			{ 
				_OldValue = value;
				OnPropertyChanged("OldValue");
			}
		}
		[JsonProperty]
		public string NewValue
		{
			get { return _NewValue; }
			set 
			{ 
				_NewValue = value;
				OnPropertyChanged("NewValue");
			}
		}
		#endregion

		#region CTor
		public AuditTrailChangeItem()
		{
		}

		public AuditTrailChangeItem(JToken node) : base(node)
		{
			if(node["descriptor"] != null)
			{
				this._Descriptor = node["descriptor"].Value<string>();
			}
			if(node["oldValue"] != null)
			{
				this._OldValue = node["oldValue"].Value<string>();
			}
			if(node["newValue"] != null)
			{
				this._NewValue = node["newValue"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAuditTrailChangeItem");
			kparams.AddIfNotNull("descriptor", this._Descriptor);
			kparams.AddIfNotNull("oldValue", this._OldValue);
			kparams.AddIfNotNull("newValue", this._NewValue);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DESCRIPTOR:
					return "Descriptor";
				case OLD_VALUE:
					return "OldValue";
				case NEW_VALUE:
					return "NewValue";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

