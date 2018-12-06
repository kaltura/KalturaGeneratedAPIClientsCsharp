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
	public class ActivitiBusinessProcessServer : BusinessProcessServer
	{
		#region Constants
		public const string HOST = "host";
		public const string PORT = "port";
		public const string PROTOCOL = "protocol";
		public const string USERNAME = "username";
		public const string PASSWORD = "password";
		#endregion

		#region Private Fields
		private string _Host = null;
		private int _Port = Int32.MinValue;
		private ActivitiBusinessProcessServerProtocol _Protocol = null;
		private string _Username = null;
		private string _Password = null;
		#endregion

		#region Properties
		public string Host
		{
			get { return _Host; }
			set 
			{ 
				_Host = value;
				OnPropertyChanged("Host");
			}
		}
		public int Port
		{
			get { return _Port; }
			set 
			{ 
				_Port = value;
				OnPropertyChanged("Port");
			}
		}
		public ActivitiBusinessProcessServerProtocol Protocol
		{
			get { return _Protocol; }
			set 
			{ 
				_Protocol = value;
				OnPropertyChanged("Protocol");
			}
		}
		public string Username
		{
			get { return _Username; }
			set 
			{ 
				_Username = value;
				OnPropertyChanged("Username");
			}
		}
		public string Password
		{
			get { return _Password; }
			set 
			{ 
				_Password = value;
				OnPropertyChanged("Password");
			}
		}
		#endregion

		#region CTor
		public ActivitiBusinessProcessServer()
		{
		}

		public ActivitiBusinessProcessServer(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "host":
						this._Host = propertyNode.InnerText;
						continue;
					case "port":
						this._Port = ParseInt(propertyNode.InnerText);
						continue;
					case "protocol":
						this._Protocol = (ActivitiBusinessProcessServerProtocol)StringEnum.Parse(typeof(ActivitiBusinessProcessServerProtocol), propertyNode.InnerText);
						continue;
					case "username":
						this._Username = propertyNode.InnerText;
						continue;
					case "password":
						this._Password = propertyNode.InnerText;
						continue;
				}
			}
		}

		public ActivitiBusinessProcessServer(IDictionary<string,object> data) : base(data)
		{
			    this._Host = data.TryGetValueSafe<string>("host");
			    this._Port = data.TryGetValueSafe<int>("port");
			    this._Protocol = (ActivitiBusinessProcessServerProtocol)StringEnum.Parse(typeof(ActivitiBusinessProcessServerProtocol), data.TryGetValueSafe<string>("protocol"));
			    this._Username = data.TryGetValueSafe<string>("username");
			    this._Password = data.TryGetValueSafe<string>("password");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaActivitiBusinessProcessServer");
			kparams.AddIfNotNull("host", this._Host);
			kparams.AddIfNotNull("port", this._Port);
			kparams.AddIfNotNull("protocol", this._Protocol);
			kparams.AddIfNotNull("username", this._Username);
			kparams.AddIfNotNull("password", this._Password);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case HOST:
					return "Host";
				case PORT:
					return "Port";
				case PROTOCOL:
					return "Protocol";
				case USERNAME:
					return "Username";
				case PASSWORD:
					return "Password";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

