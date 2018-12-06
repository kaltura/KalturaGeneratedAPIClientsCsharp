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
	public class AccessControlDrmPolicyAction : RuleAction
	{
		#region Constants
		public const string POLICY_ID = "policyId";
		#endregion

		#region Private Fields
		private int _PolicyId = Int32.MinValue;
		#endregion

		#region Properties
		public int PolicyId
		{
			get { return _PolicyId; }
			set 
			{ 
				_PolicyId = value;
				OnPropertyChanged("PolicyId");
			}
		}
		#endregion

		#region CTor
		public AccessControlDrmPolicyAction()
		{
		}

		public AccessControlDrmPolicyAction(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "policyId":
						this._PolicyId = ParseInt(propertyNode.InnerText);
						continue;
				}
			}
		}

		public AccessControlDrmPolicyAction(IDictionary<string,object> data) : base(data)
		{
			    this._PolicyId = data.TryGetValueSafe<int>("policyId");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAccessControlDrmPolicyAction");
			kparams.AddIfNotNull("policyId", this._PolicyId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case POLICY_ID:
					return "PolicyId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

