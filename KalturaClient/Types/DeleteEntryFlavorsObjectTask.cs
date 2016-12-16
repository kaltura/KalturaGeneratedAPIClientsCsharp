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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class DeleteEntryFlavorsObjectTask : ObjectTask
	{
		#region Constants
		public const string DELETE_TYPE = "deleteType";
		public const string FLAVOR_PARAMS_IDS = "flavorParamsIds";
		#endregion

		#region Private Fields
		private DeleteFlavorsLogicType _DeleteType = (DeleteFlavorsLogicType)Int32.MinValue;
		private string _FlavorParamsIds = null;
		#endregion

		#region Properties
		public DeleteFlavorsLogicType DeleteType
		{
			get { return _DeleteType; }
			set 
			{ 
				_DeleteType = value;
				OnPropertyChanged("DeleteType");
			}
		}
		public string FlavorParamsIds
		{
			get { return _FlavorParamsIds; }
			set 
			{ 
				_FlavorParamsIds = value;
				OnPropertyChanged("FlavorParamsIds");
			}
		}
		#endregion

		#region CTor
		public DeleteEntryFlavorsObjectTask()
		{
		}

		public DeleteEntryFlavorsObjectTask(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "deleteType":
						this._DeleteType = (DeleteFlavorsLogicType)ParseEnum(typeof(DeleteFlavorsLogicType), txt);
						continue;
					case "flavorParamsIds":
						this._FlavorParamsIds = txt;
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
				kparams.AddReplace("objectType", "KalturaDeleteEntryFlavorsObjectTask");
			kparams.AddIfNotNull("deleteType", this._DeleteType);
			kparams.AddIfNotNull("flavorParamsIds", this._FlavorParamsIds);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DELETE_TYPE:
					return "DeleteType";
				case FLAVOR_PARAMS_IDS:
					return "FlavorParamsIds";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

