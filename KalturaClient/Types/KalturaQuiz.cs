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
	public class KalturaQuiz : KalturaObjectBase
	{
		#region Private Fields
		private int _Version = Int32.MinValue;
		private IList<KalturaKeyValue> _UiAttributes;
		private KalturaNullableBoolean _ShowResultOnAnswer = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaNullableBoolean _ShowCorrectKeyOnAnswer = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaNullableBoolean _AllowAnswerUpdate = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaNullableBoolean _ShowCorrectAfterSubmission = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaNullableBoolean _AllowDownload = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaNullableBoolean _ShowGradeAfterSubmission = (KalturaNullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		public int Version
		{
			get { return _Version; }
		}
		public new IList<KalturaKeyValue> UiAttributes
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
		public KalturaNullableBoolean AllowDownload
		{
			get { return _AllowDownload; }
			set 
			{ 
				_AllowDownload = value;
				OnPropertyChanged("AllowDownload");
			}
		}
		public KalturaNullableBoolean ShowGradeAfterSubmission
		{
			get { return _ShowGradeAfterSubmission; }
			set 
			{ 
				_ShowGradeAfterSubmission = value;
				OnPropertyChanged("ShowGradeAfterSubmission");
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
						this._Version = ParseInt(txt);
						continue;
					case "uiAttributes":
						this._UiAttributes = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._UiAttributes.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode, "KalturaKeyValue"));
						}
						continue;
					case "showResultOnAnswer":
						this._ShowResultOnAnswer = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "showCorrectKeyOnAnswer":
						this._ShowCorrectKeyOnAnswer = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "allowAnswerUpdate":
						this._AllowAnswerUpdate = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "showCorrectAfterSubmission":
						this._ShowCorrectAfterSubmission = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "allowDownload":
						this._AllowDownload = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "showGradeAfterSubmission":
						this._ShowGradeAfterSubmission = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
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
			kparams.AddIfNotNull("version", this._Version);
			kparams.AddIfNotNull("uiAttributes", this._UiAttributes);
			kparams.AddIfNotNull("showResultOnAnswer", this._ShowResultOnAnswer);
			kparams.AddIfNotNull("showCorrectKeyOnAnswer", this._ShowCorrectKeyOnAnswer);
			kparams.AddIfNotNull("allowAnswerUpdate", this._AllowAnswerUpdate);
			kparams.AddIfNotNull("showCorrectAfterSubmission", this._ShowCorrectAfterSubmission);
			kparams.AddIfNotNull("allowDownload", this._AllowDownload);
			kparams.AddIfNotNull("showGradeAfterSubmission", this._ShowGradeAfterSubmission);
			return kparams;
		}
		#endregion
	}
}

