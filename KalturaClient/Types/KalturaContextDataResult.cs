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
	public class KalturaContextDataResult : KalturaObjectBase
	{
		#region Private Fields
		private IList<KalturaString> _Messages;
		private IList<KalturaRuleAction> _Actions;
		#endregion

		#region Properties
		public IList<KalturaString> Messages
		{
			get { return _Messages; }
			set 
			{ 
				_Messages = value;
				OnPropertyChanged("Messages");
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
		#endregion

		#region CTor
		public KalturaContextDataResult()
		{
		}

		public KalturaContextDataResult(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "messages":
						this.Messages = new List<KalturaString>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Messages.Add((KalturaString)KalturaObjectFactory.Create(arrayNode, "KalturaString"));
						}
						continue;
					case "actions":
						this.Actions = new List<KalturaRuleAction>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Actions.Add((KalturaRuleAction)KalturaObjectFactory.Create(arrayNode, "KalturaRuleAction"));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaContextDataResult");
			if (this.Messages != null)
			{
				if (this.Messages.Count == 0)
				{
					kparams.Add("messages:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaString item in this.Messages)
					{
						kparams.Add("messages:" + i, item.ToParams());
						i++;
					}
				}
			}
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
			return kparams;
		}
		#endregion
	}
}

