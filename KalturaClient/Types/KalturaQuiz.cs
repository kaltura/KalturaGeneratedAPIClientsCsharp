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
	public class KalturaQuiz : KalturaObjectBase
	{
		#region Private Fields
		private int _Version = Int32.MinValue;
		private IList<KalturaKeyValue> _UiAttributes;
		private KalturaNullableBoolean _ShowResultOnAnswer = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaNullableBoolean _ShowCorrectKeyOnAnswer = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaNullableBoolean _AllowAnswerUpdate = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaNullableBoolean _ShowCorrectAfterSubmission = (KalturaNullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		public int Version
		{
			get { return _Version; }
			set 
			{ 
				_Version = value;
				OnPropertyChanged("Version");
			}
		}
		public IList<KalturaKeyValue> UiAttributes
		{
			get { return _UiAttributes; }
			set 
			{ 
				_UiAttributes = value;
				OnPropertyChanged("UiAttributes");
			}
		}
		public KalturaNullableBoolean ShowResultOnAnswer
		{
			get { return _ShowResultOnAnswer; }
			set 
			{ 
				_ShowResultOnAnswer = value;
				OnPropertyChanged("ShowResultOnAnswer");
			}
		}
		public KalturaNullableBoolean ShowCorrectKeyOnAnswer
		{
			get { return _ShowCorrectKeyOnAnswer; }
			set 
			{ 
				_ShowCorrectKeyOnAnswer = value;
				OnPropertyChanged("ShowCorrectKeyOnAnswer");
			}
		}
		public KalturaNullableBoolean AllowAnswerUpdate
		{
			get { return _AllowAnswerUpdate; }
			set 
			{ 
				_AllowAnswerUpdate = value;
				OnPropertyChanged("AllowAnswerUpdate");
			}
		}
		public KalturaNullableBoolean ShowCorrectAfterSubmission
		{
			get { return _ShowCorrectAfterSubmission; }
			set 
			{ 
				_ShowCorrectAfterSubmission = value;
				OnPropertyChanged("ShowCorrectAfterSubmission");
			}
		}
		#endregion

		#region CTor
		public KalturaQuiz()
		{
		}

		public KalturaQuiz(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "version":
						this.Version = ParseInt(txt);
						continue;
					case "uiAttributes":
						this.UiAttributes = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.UiAttributes.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode, "KalturaKeyValue"));
						}
						continue;
					case "showResultOnAnswer":
						this.ShowResultOnAnswer = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "showCorrectKeyOnAnswer":
						this.ShowCorrectKeyOnAnswer = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "allowAnswerUpdate":
						this.AllowAnswerUpdate = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "showCorrectAfterSubmission":
						this.ShowCorrectAfterSubmission = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaQuiz");
			kparams.AddIfNotNull("version", this.Version);
			kparams.AddIfNotNull("uiAttributes", this.UiAttributes);
			kparams.AddIfNotNull("showResultOnAnswer", this.ShowResultOnAnswer);
			kparams.AddIfNotNull("showCorrectKeyOnAnswer", this.ShowCorrectKeyOnAnswer);
			kparams.AddIfNotNull("allowAnswerUpdate", this.AllowAnswerUpdate);
			kparams.AddIfNotNull("showCorrectAfterSubmission", this.ShowCorrectAfterSubmission);
			return kparams;
		}
		#endregion
	}
}

