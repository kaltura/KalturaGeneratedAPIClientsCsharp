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
	public class TvinciDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string INGEST_URL = "ingestUrl";
		public const string USERNAME = "username";
		public const string PASSWORD = "password";
		public const string TAGS = "tags";
		public const string XSLT_FILE = "xsltFile";
		#endregion

		#region Private Fields
		private string _IngestUrl = null;
		private string _Username = null;
		private string _Password = null;
		private IList<TvinciDistributionTag> _Tags;
		private string _XsltFile = null;
		#endregion

		#region Properties
		public string IngestUrl
		{
			get { return _IngestUrl; }
			set 
			{ 
				_IngestUrl = value;
				OnPropertyChanged("IngestUrl");
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
		public IList<TvinciDistributionTag> Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		public string XsltFile
		{
			get { return _XsltFile; }
			set 
			{ 
				_XsltFile = value;
				OnPropertyChanged("XsltFile");
			}
		}
		#endregion

		#region CTor
		public TvinciDistributionProfile()
		{
		}

		public TvinciDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "ingestUrl":
						this._IngestUrl = propertyNode.InnerText;
						continue;
					case "username":
						this._Username = propertyNode.InnerText;
						continue;
					case "password":
						this._Password = propertyNode.InnerText;
						continue;
					case "tags":
						this._Tags = new List<TvinciDistributionTag>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Tags.Add(ObjectFactory.Create<TvinciDistributionTag>(arrayNode));
						}
						continue;
					case "xsltFile":
						this._XsltFile = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaTvinciDistributionProfile");
			kparams.AddIfNotNull("ingestUrl", this._IngestUrl);
			kparams.AddIfNotNull("username", this._Username);
			kparams.AddIfNotNull("password", this._Password);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("xsltFile", this._XsltFile);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case INGEST_URL:
					return "IngestUrl";
				case USERNAME:
					return "Username";
				case PASSWORD:
					return "Password";
				case TAGS:
					return "Tags";
				case XSLT_FILE:
					return "XsltFile";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

