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
	public class ClipConcatJobData : JobData
	{
		#region Constants
		public const string PARTNER_ID = "partnerId";
		public const string PRIORITY = "priority";
		public const string OPERATION_ATTRIBUTES = "operationAttributes";
		#endregion

		#region Private Fields
		private int _PartnerId = Int32.MinValue;
		private int _Priority = Int32.MinValue;
		private IList<ObjectBase> _OperationAttributes;
		#endregion

		#region Properties
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public int Priority
		{
			get { return _Priority; }
			set 
			{ 
				_Priority = value;
				OnPropertyChanged("Priority");
			}
		}
		public IList<ObjectBase> OperationAttributes
		{
			get { return _OperationAttributes; }
			set 
			{ 
				_OperationAttributes = value;
				OnPropertyChanged("OperationAttributes");
			}
		}
		#endregion

		#region CTor
		public ClipConcatJobData()
		{
		}

		public ClipConcatJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "priority":
						this._Priority = ParseInt(propertyNode.InnerText);
						continue;
					case "operationAttributes":
						this._OperationAttributes = new List<ObjectBase>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._OperationAttributes.Add(ObjectFactory.Create<ObjectBase>(arrayNode));
						}
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
				kparams.AddReplace("objectType", "KalturaClipConcatJobData");
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("priority", this._Priority);
			kparams.AddIfNotNull("operationAttributes", this._OperationAttributes);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARTNER_ID:
					return "PartnerId";
				case PRIORITY:
					return "Priority";
				case OPERATION_ATTRIBUTES:
					return "OperationAttributes";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

