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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class MailNotificationObjectTask : ObjectTask
	{
		#region Constants
		public const string MAIL_ADDRESS = "mailAddress";
		public const string MESSAGE = "message";
		public const string SEND_TO_USERS = "sendToUsers";
		#endregion

		#region Private Fields
		private string _MailAddress = null;
		private string _Message = null;
		private bool? _SendToUsers = null;
		#endregion

		#region Properties
		public string MailAddress
		{
			get { return _MailAddress; }
			set 
			{ 
				_MailAddress = value;
				OnPropertyChanged("MailAddress");
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
		public bool? SendToUsers
		{
			get { return _SendToUsers; }
			set 
			{ 
				_SendToUsers = value;
				OnPropertyChanged("SendToUsers");
			}
		}
		#endregion

		#region CTor
		public MailNotificationObjectTask()
		{
		}

		public MailNotificationObjectTask(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "mailAddress":
						this._MailAddress = propertyNode.InnerText;
						continue;
					case "message":
						this._Message = propertyNode.InnerText;
						continue;
					case "sendToUsers":
						this._SendToUsers = ParseBool(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaMailNotificationObjectTask");
			kparams.AddIfNotNull("mailAddress", this._MailAddress);
			kparams.AddIfNotNull("message", this._Message);
			kparams.AddIfNotNull("sendToUsers", this._SendToUsers);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case MAIL_ADDRESS:
					return "MailAddress";
				case MESSAGE:
					return "Message";
				case SEND_TO_USERS:
					return "SendToUsers";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

