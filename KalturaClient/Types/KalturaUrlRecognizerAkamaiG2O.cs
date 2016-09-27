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
	public class KalturaUrlRecognizerAkamaiG2O : KalturaUrlRecognizer
	{
		#region Private Fields
		private string _HeaderData = null;
		private string _HeaderSign = null;
		private int _Timeout = Int32.MinValue;
		private string _Salt = null;
		#endregion

		#region Properties
		public string HeaderData
		{
			get { return _HeaderData; }
			set 
			{ 
				_HeaderData = value;
				OnPropertyChanged("HeaderData");
			}
		}
		public string HeaderSign
		{
			get { return _HeaderSign; }
			set 
			{ 
				_HeaderSign = value;
				OnPropertyChanged("HeaderSign");
			}
		}
		public int Timeout
		{
			get { return _Timeout; }
			set 
			{ 
				_Timeout = value;
				OnPropertyChanged("Timeout");
			}
		}
		public string Salt
		{
			get { return _Salt; }
			set 
			{ 
				_Salt = value;
				OnPropertyChanged("Salt");
			}
		}
		#endregion

		#region CTor
		public KalturaUrlRecognizerAkamaiG2O()
		{
		}

		public KalturaUrlRecognizerAkamaiG2O(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "headerData":
						this._HeaderData = txt;
						continue;
					case "headerSign":
						this._HeaderSign = txt;
						continue;
					case "timeout":
						this._Timeout = ParseInt(txt);
						continue;
					case "salt":
						this._Salt = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaUrlRecognizerAkamaiG2O");
			kparams.AddIfNotNull("headerData", this._HeaderData);
			kparams.AddIfNotNull("headerSign", this._HeaderSign);
			kparams.AddIfNotNull("timeout", this._Timeout);
			kparams.AddIfNotNull("salt", this._Salt);
			return kparams;
		}
		#endregion
	}
}

