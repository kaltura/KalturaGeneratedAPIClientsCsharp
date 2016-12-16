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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class CodeCuePoint : CuePoint
	{
		#region Constants
		public const string CODE = "code";
		public const string DESCRIPTION = "description";
		public const string END_TIME = "endTime";
		public const string DURATION = "duration";
		#endregion

		#region Private Fields
		private string _Code = null;
		private string _Description = null;
		private int _EndTime = Int32.MinValue;
		private int _Duration = Int32.MinValue;
		#endregion

		#region Properties
		public string Code
		{
			get { return _Code; }
			set 
			{ 
				_Code = value;
				OnPropertyChanged("Code");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public int EndTime
		{
			get { return _EndTime; }
			set 
			{ 
				_EndTime = value;
				OnPropertyChanged("EndTime");
			}
		}
		public int Duration
		{
			get { return _Duration; }
		}
		#endregion

		#region CTor
		public CodeCuePoint()
		{
		}

		public CodeCuePoint(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "code":
						this._Code = txt;
						continue;
					case "description":
						this._Description = txt;
						continue;
					case "endTime":
						this._EndTime = ParseInt(txt);
						continue;
					case "duration":
						this._Duration = ParseInt(txt);
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
				kparams.AddReplace("objectType", "KalturaCodeCuePoint");
			kparams.AddIfNotNull("code", this._Code);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("endTime", this._EndTime);
			kparams.AddIfNotNull("duration", this._Duration);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CODE:
					return "Code";
				case DESCRIPTION:
					return "Description";
				case END_TIME:
					return "EndTime";
				case DURATION:
					return "Duration";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

