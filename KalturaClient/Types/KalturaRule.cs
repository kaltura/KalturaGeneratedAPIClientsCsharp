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

namespace Kaltura
{
	public class KalturaRule : KalturaObjectBase
	{
		#region Private Fields
		private string _Description = null;
		private string _RuleData = null;
		private string _Message = null;
		private IList<KalturaRuleAction> _Actions;
		private IList<KalturaCondition> _Conditions;
		private IList<KalturaContextTypeHolder> _Contexts;
		private bool? _StopProcessing = null;
		private KalturaNullableBoolean _ForceAdminValidation = (KalturaNullableBoolean)Int32.MinValue;
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
		public new IList<KalturaRuleAction> Actions
		{
			get { return _Actions; }
			set 
			{ 
				_Actions = value;
				OnPropertyChanged("Actions");
			}
		}
		public new IList<KalturaCondition> Conditions
		{
			get { return _Conditions; }
			set 
			{ 
				_Conditions = value;
				OnPropertyChanged("Conditions");
			}
		}
		public new IList<KalturaContextTypeHolder> Contexts
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
		public KalturaNullableBoolean ForceAdminValidation
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
		public KalturaRule()
		{
		}

		public KalturaRule(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "description":
						this._Description = txt;
						continue;
					case "ruleData":
						this._RuleData = txt;
						continue;
					case "message":
						this._Message = txt;
						continue;
					case "actions":
						this._Actions = new List<KalturaRuleAction>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Actions.Add((KalturaRuleAction)KalturaObjectFactory.Create(arrayNode, "KalturaRuleAction"));
						}
						continue;
					case "conditions":
						this._Conditions = new List<KalturaCondition>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Conditions.Add((KalturaCondition)KalturaObjectFactory.Create(arrayNode, "KalturaCondition"));
						}
						continue;
					case "contexts":
						this._Contexts = new List<KalturaContextTypeHolder>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Contexts.Add((KalturaContextTypeHolder)KalturaObjectFactory.Create(arrayNode, "KalturaContextTypeHolder"));
						}
						continue;
					case "stopProcessing":
						this._StopProcessing = ParseBool(txt);
						continue;
					case "forceAdminValidation":
						this._ForceAdminValidation = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaRule");
			kparams.AddIfNotNull("description", this.Description);
			kparams.AddIfNotNull("ruleData", this.RuleData);
			kparams.AddIfNotNull("message", this.Message);
			kparams.AddIfNotNull("actions", this.Actions);
			kparams.AddIfNotNull("conditions", this.Conditions);
			kparams.AddIfNotNull("contexts", this.Contexts);
			kparams.AddIfNotNull("stopProcessing", this.StopProcessing);
			kparams.AddIfNotNull("forceAdminValidation", this.ForceAdminValidation);
			return kparams;
		}
		#endregion
	}
}

