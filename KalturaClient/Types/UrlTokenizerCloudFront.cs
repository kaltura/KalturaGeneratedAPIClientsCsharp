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
	public class UrlTokenizerCloudFront : UrlTokenizer
	{
		#region Constants
		public const string KEY_PAIR_ID = "keyPairId";
		public const string ROOT_DIR = "rootDir";
		#endregion

		#region Private Fields
		private string _KeyPairId = null;
		private string _RootDir = null;
		#endregion

		#region Properties
		public string KeyPairId
		{
			get { return _KeyPairId; }
			set 
			{ 
				_KeyPairId = value;
				OnPropertyChanged("KeyPairId");
			}
		}
		public string RootDir
		{
			get { return _RootDir; }
			set 
			{ 
				_RootDir = value;
				OnPropertyChanged("RootDir");
			}
		}
		#endregion

		#region CTor
		public UrlTokenizerCloudFront()
		{
		}

		public UrlTokenizerCloudFront(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "keyPairId":
						this._KeyPairId = propertyNode.InnerText;
						continue;
					case "rootDir":
						this._RootDir = propertyNode.InnerText;
						continue;
				}
			}
		}

		public UrlTokenizerCloudFront(IDictionary<string,object> data) : base(data)
		{
			    this._KeyPairId = data.TryGetValueSafe<string>("keyPairId");
			    this._RootDir = data.TryGetValueSafe<string>("rootDir");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUrlTokenizerCloudFront");
			kparams.AddIfNotNull("keyPairId", this._KeyPairId);
			kparams.AddIfNotNull("rootDir", this._RootDir);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case KEY_PAIR_ID:
					return "KeyPairId";
				case ROOT_DIR:
					return "RootDir";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

