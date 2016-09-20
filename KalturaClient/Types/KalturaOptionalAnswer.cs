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
	public class KalturaOptionalAnswer : KalturaObjectBase
	{
		#region Private Fields
		private string _Key = null;
		private string _Text = null;
		private float _Weight = Single.MinValue;
		private KalturaNullableBoolean _IsCorrect = (KalturaNullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		public string Key
		{
			get { return _Key; }
			set 
			{ 
				_Key = value;
				OnPropertyChanged("Key");
			}
		}
		public string Text
		{
			get { return _Text; }
			set 
			{ 
				_Text = value;
				OnPropertyChanged("Text");
			}
		}
		public float Weight
		{
			get { return _Weight; }
			set 
			{ 
				_Weight = value;
				OnPropertyChanged("Weight");
			}
		}
		public KalturaNullableBoolean IsCorrect
		{
			get { return _IsCorrect; }
			set 
			{ 
				_IsCorrect = value;
				OnPropertyChanged("IsCorrect");
			}
		}
		#endregion

		#region CTor
		public KalturaOptionalAnswer()
		{
		}

		public KalturaOptionalAnswer(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "key":
						this._Key = txt;
						continue;
					case "text":
						this._Text = txt;
						continue;
					case "weight":
						this._Weight = ParseFloat(txt);
						continue;
					case "isCorrect":
						this._IsCorrect = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaOptionalAnswer");
			kparams.AddIfNotNull("key", this.Key);
			kparams.AddIfNotNull("text", this.Text);
			kparams.AddIfNotNull("weight", this.Weight);
			kparams.AddIfNotNull("isCorrect", this.IsCorrect);
			return kparams;
		}
		#endregion
	}
}

