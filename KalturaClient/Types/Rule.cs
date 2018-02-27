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
	public class Rule : ObjectBase
	{
		#region Constants
		public const string DESCRIPTION = "description";
		public const string RULE_DATA = "ruleData";
		public const string MESSAGE = "message";
		public const string CODE = "code";
		public const string ACTIONS = "actions";
		public const string CONDITIONS = "conditions";
		public const string CONTEXTS = "contexts";
		public const string STOP_PROCESSING = "stopProcessing";
		public const string FORCE_ADMIN_VALIDATION = "forceAdminValidation";
		#endregion

		#region Private Fields
		private string _Description = null;
		private string _RuleData = null;
		private string _Message = null;
		private string _Code = null;
		private IList<RuleAction> _Actions;
		private IList<Condition> _Conditions;
		private IList<ContextTypeHolder> _Contexts;
		private bool? _StopProcessing = null;
		private NullableBoolean _ForceAdminValidation = (NullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public string RuleData
		{
			get { return _RuleData; }
			set 
			{ 
				_RuleData = value;
				OnPropertyChanged("RuleData");
			}
		}
		public string Message
		{
			get { return _Message; }
			set 
			{ 
				_Message = value;
				OnPropertyChanged("Message");
			}
		}
		public string Code
		{
			get { return _Code; }
			set 
			{ 
				_Code = value;
				OnPropertyChanged("Code");
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
		public IList<Condition> Conditions
		{
			get { return _Conditions; }
			set 
			{ 
				_Conditions = value;
				OnPropertyChanged("Conditions");
			}
		}
		public IList<ContextTypeHolder> Contexts
		{
			get { return _Contexts; }
			set 
			{ 
				_Contexts = value;
				OnPropertyChanged("Contexts");
			}
		}
		public bool? StopProcessing
		{
			get { return _StopProcessing; }
			set 
			{ 
				_StopProcessing = value;
				OnPropertyChanged("StopProcessing");
			}
		}
		public NullableBoolean ForceAdminValidation
		{
			get { return _ForceAdminValidation; }
			set 
			{ 
				_ForceAdminValidation = value;
				OnPropertyChanged("ForceAdminValidation");
			}
		}
		#endregion

		#region CTor
		public Rule()
		{
		}

		public Rule(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "ruleData":
						this._RuleData = propertyNode.InnerText;
						continue;
					case "message":
						this._Message = propertyNode.InnerText;
						continue;
					case "code":
						this._Code = propertyNode.InnerText;
						continue;
					case "actions":
						this._Actions = new List<RuleAction>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Actions.Add(ObjectFactory.Create<RuleAction>(arrayNode));
						}
						continue;
					case "conditions":
						this._Conditions = new List<Condition>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Conditions.Add(ObjectFactory.Create<Condition>(arrayNode));
						}
						continue;
					case "contexts":
						this._Contexts = new List<ContextTypeHolder>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Contexts.Add(ObjectFactory.Create<ContextTypeHolder>(arrayNode));
						}
						continue;
					case "stopProcessing":
						this._StopProcessing = ParseBool(propertyNode.InnerText);
						continue;
					case "forceAdminValidation":
						this._ForceAdminValidation = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaRule");
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("ruleData", this._RuleData);
			kparams.AddIfNotNull("message", this._Message);
			kparams.AddIfNotNull("code", this._Code);
			kparams.AddIfNotNull("actions", this._Actions);
			kparams.AddIfNotNull("conditions", this._Conditions);
			kparams.AddIfNotNull("contexts", this._Contexts);
			kparams.AddIfNotNull("stopProcessing", this._StopProcessing);
			kparams.AddIfNotNull("forceAdminValidation", this._ForceAdminValidation);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DESCRIPTION:
					return "Description";
				case RULE_DATA:
					return "RuleData";
				case MESSAGE:
					return "Message";
				case CODE:
					return "Code";
				case ACTIONS:
					return "Actions";
				case CONDITIONS:
					return "Conditions";
				case CONTEXTS:
					return "Contexts";
				case STOP_PROCESSING:
					return "StopProcessing";
				case FORCE_ADMIN_VALIDATION:
					return "ForceAdminValidation";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

