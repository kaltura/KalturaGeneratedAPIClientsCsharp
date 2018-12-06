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
		public IList<String> Messages
		{
			get { return _Messages; }
			set 
			{ 
				_Messages = value;
				OnPropertyChanged("Messages");
			}
		}
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

		public ContextDataResult(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "messages":
						this._Messages = new List<String>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Messages.Add(ObjectFactory.Create<String>(arrayNode));
						}
						continue;
					case "actions":
						this._Actions = new List<RuleAction>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Actions.Add(ObjectFactory.Create<RuleAction>(arrayNode));
						}
						continue;
				}
			}
		}

		public ContextDataResult(IDictionary<string,object> data) : base(data)
		{
			    this._Messages = new List<String>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("messages", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._Messages.Add(ObjectFactory.Create<String>((IDictionary<string,object>)dataDictionary));
			    }
			    this._Actions = new List<RuleAction>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("actions", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._Actions.Add(ObjectFactory.Create<RuleAction>((IDictionary<string,object>)dataDictionary));
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

