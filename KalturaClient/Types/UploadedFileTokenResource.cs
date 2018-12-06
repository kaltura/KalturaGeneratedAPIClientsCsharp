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
	public class UploadedFileTokenResource : GenericDataCenterContentResource
	{
		#region Constants
		public const string TOKEN = "token";
		#endregion

		#region Private Fields
		private string _Token = null;
		#endregion

		#region Properties
		public string Token
		{
			get { return _Token; }
			set 
			{ 
				_Token = value;
				OnPropertyChanged("Token");
			}
		}
		#endregion

		#region CTor
		public UploadedFileTokenResource()
		{
		}

		public UploadedFileTokenResource(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "token":
						this._Token = propertyNode.InnerText;
						continue;
				}
			}
		}

		public UploadedFileTokenResource(IDictionary<string,object> data) : base(data)
		{
			    this._Token = data.TryGetValueSafe<string>("token");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUploadedFileTokenResource");
			kparams.AddIfNotNull("token", this._Token);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TOKEN:
					return "Token";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

