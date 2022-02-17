// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2022  Kaltura Inc.
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class DynamicEmailContents : ObjectBase
	{
		#region Constants
		public const string EMAIL_SUBJECT = "emailSubject";
		public const string EMAIL_BODY = "emailBody";
		#endregion

		#region Private Fields
		private string _EmailSubject = null;
		private string _EmailBody = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use EmailSubjectAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EmailSubject
		{
			get { return _EmailSubject; }
			set 
			{ 
				_EmailSubject = value;
				OnPropertyChanged("EmailSubject");
			}
		}
		/// <summary>
		/// Use EmailBodyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EmailBody
		{
			get { return _EmailBody; }
			set 
			{ 
				_EmailBody = value;
				OnPropertyChanged("EmailBody");
			}
		}
		#endregion

		#region CTor
		public DynamicEmailContents()
		{
		}

		public DynamicEmailContents(JToken node) : base(node)
		{
			if(node["emailSubject"] != null)
			{
				this._EmailSubject = node["emailSubject"].Value<string>();
			}
			if(node["emailBody"] != null)
			{
				this._EmailBody = node["emailBody"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDynamicEmailContents");
			kparams.AddIfNotNull("emailSubject", this._EmailSubject);
			kparams.AddIfNotNull("emailBody", this._EmailBody);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case EMAIL_SUBJECT:
					return "EmailSubject";
				case EMAIL_BODY:
					return "EmailBody";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

