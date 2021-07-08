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
	public class ContextDataResult : ObjectBase
	{
		#region Constants
		public const string MESSAGES = "messages";
		public const string ACTIONS = "actions";
		#endregion

		#region Private Fields
		private IList<String> _Messages;
		private IList<RuleAction> _Actions;
		#endregion

		#region Properties
		/// <summary>
		/// Use MessagesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<String> Messages
		{
			get { return _Messages; }
			set 
			{ 
				_Messages = value;
				OnPropertyChanged("Messages");
			}
		}
		/// <summary>
		/// Use ActionsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<RuleAction> Actions
		{
			get { return _Actions; }
			set 
			{ 
				_Actions = value;
				OnPropertyChanged("Actions");
			}
		}
		#endregion

		#region CTor
		public ContextDataResult()
		{
		}

		public ContextDataResult(JToken node) : base(node)
		{
			if(node["messages"] != null)
			{
				this._Messages = new List<String>();
				foreach(var arrayNode in node["messages"].Children())
				{
					this._Messages.Add(ObjectFactory.Create<String>(arrayNode));
				}
			}
			if(node["actions"] != null)
			{
				this._Actions = new List<RuleAction>();
				foreach(var arrayNode in node["actions"].Children())
				{
					this._Actions.Add(ObjectFactory.Create<RuleAction>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaContextDataResult");
			kparams.AddIfNotNull("messages", this._Messages);
			kparams.AddIfNotNull("actions", this._Actions);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case MESSAGES:
					return "Messages";
				case ACTIONS:
					return "Actions";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

