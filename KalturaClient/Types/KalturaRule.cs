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
// Copyright (C) 2006-2015  Kaltura Inc.
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
		private string _Message = null;
		private IList<KalturaRuleAction> _Actions;
		private IList<KalturaCondition> _Conditions;
		private IList<KalturaContextTypeHolder> _Contexts;
		private bool? _StopProcessing = false;
		#endregion

		#region Properties
		public string Message
		{
			get { return _Message; }
			set 
			{ 
				_Message = value;
				OnPropertyChanged("Message");
			}
		}
		public IList<KalturaRuleAction> Actions
		{
			get { return _Actions; }
			set 
			{ 
				_Actions = value;
				OnPropertyChanged("Actions");
			}
		}
		public IList<KalturaCondition> Conditions
		{
			get { return _Conditions; }
			set 
			{ 
				_Conditions = value;
				OnPropertyChanged("Conditions");
			}
		}
		public IList<KalturaContextTypeHolder> Contexts
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
		#endregion

		#region CTor
		public KalturaRule()
		{
		}

		public KalturaRule(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "message":
						this.Message = txt;
						continue;
					case "actions":
						this.Actions = new List<KalturaRuleAction>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Actions.Add((KalturaRuleAction)KalturaObjectFactory.Create(arrayNode, "KalturaRuleAction"));
						}
						continue;
					case "conditions":
						this.Conditions = new List<KalturaCondition>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Conditions.Add((KalturaCondition)KalturaObjectFactory.Create(arrayNode, "KalturaCondition"));
						}
						continue;
					case "contexts":
						this.Contexts = new List<KalturaContextTypeHolder>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Contexts.Add((KalturaContextTypeHolder)KalturaObjectFactory.Create(arrayNode, "KalturaContextTypeHolder"));
						}
						continue;
					case "stopProcessing":
						this.StopProcessing = ParseBool(txt);
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
			kparams.AddStringIfNotNull("message", this.Message);
			if (this.Actions != null)
			{
				if (this.Actions.Count == 0)
				{
					kparams.Add("actions:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaRuleAction item in this.Actions)
					{
						kparams.Add("actions:" + i, item.ToParams());
						i++;
					}
				}
			}
			if (this.Conditions != null)
			{
				if (this.Conditions.Count == 0)
				{
					kparams.Add("conditions:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaCondition item in this.Conditions)
					{
						kparams.Add("conditions:" + i, item.ToParams());
						i++;
					}
				}
			}
			if (this.Contexts != null)
			{
				if (this.Contexts.Count == 0)
				{
					kparams.Add("contexts:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaContextTypeHolder item in this.Contexts)
					{
						kparams.Add("contexts:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddBoolIfNotNull("stopProcessing", this.StopProcessing);
			return kparams;
		}
		#endregion
	}
}

