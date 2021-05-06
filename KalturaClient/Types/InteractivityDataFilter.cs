// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class InteractivityDataFilter : ObjectBase
	{
		#region Constants
		public const string ROOT_FILTER = "rootFilter";
		public const string NODE_FILTER = "nodeFilter";
		public const string INTERACTION_FILTER = "interactionFilter";
		#endregion

		#region Private Fields
		private InteractivityRootFilter _RootFilter;
		private InteractivityNodeFilter _NodeFilter;
		private InteractivityInteractionFilter _InteractionFilter;
		#endregion

		#region Properties
		[JsonProperty]
		public InteractivityRootFilter RootFilter
		{
			get { return _RootFilter; }
			set 
			{ 
				_RootFilter = value;
				OnPropertyChanged("RootFilter");
			}
		}
		[JsonProperty]
		public InteractivityNodeFilter NodeFilter
		{
			get { return _NodeFilter; }
			set 
			{ 
				_NodeFilter = value;
				OnPropertyChanged("NodeFilter");
			}
		}
		[JsonProperty]
		public InteractivityInteractionFilter InteractionFilter
		{
			get { return _InteractionFilter; }
			set 
			{ 
				_InteractionFilter = value;
				OnPropertyChanged("InteractionFilter");
			}
		}
		#endregion

		#region CTor
		public InteractivityDataFilter()
		{
		}

		public InteractivityDataFilter(JToken node) : base(node)
		{
			if(node["rootFilter"] != null)
			{
				this._RootFilter = ObjectFactory.Create<InteractivityRootFilter>(node["rootFilter"]);
			}
			if(node["nodeFilter"] != null)
			{
				this._NodeFilter = ObjectFactory.Create<InteractivityNodeFilter>(node["nodeFilter"]);
			}
			if(node["interactionFilter"] != null)
			{
				this._InteractionFilter = ObjectFactory.Create<InteractivityInteractionFilter>(node["interactionFilter"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaInteractivityDataFilter");
			kparams.AddIfNotNull("rootFilter", this._RootFilter);
			kparams.AddIfNotNull("nodeFilter", this._NodeFilter);
			kparams.AddIfNotNull("interactionFilter", this._InteractionFilter);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ROOT_FILTER:
					return "RootFilter";
				case NODE_FILTER:
					return "NodeFilter";
				case INTERACTION_FILTER:
					return "InteractionFilter";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

