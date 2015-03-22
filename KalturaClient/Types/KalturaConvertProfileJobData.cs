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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public class KalturaConvertProfileJobData : KalturaJobData
	{
		#region Private Fields
		private string _InputFileSyncLocalPath = null;
		private int _ThumbHeight = Int32.MinValue;
		private int _ThumbBitrate = Int32.MinValue;
		#endregion

		#region Properties
		public string InputFileSyncLocalPath
		{
			get { return _InputFileSyncLocalPath; }
			set 
			{ 
				_InputFileSyncLocalPath = value;
				OnPropertyChanged("InputFileSyncLocalPath");
			}
		}
		public int ThumbHeight
		{
			get { return _ThumbHeight; }
			set 
			{ 
				_ThumbHeight = value;
				OnPropertyChanged("ThumbHeight");
			}
		}
		public int ThumbBitrate
		{
			get { return _ThumbBitrate; }
			set 
			{ 
				_ThumbBitrate = value;
				OnPropertyChanged("ThumbBitrate");
			}
		}
		#endregion

		#region CTor
		public KalturaConvertProfileJobData()
		{
		}

		public KalturaConvertProfileJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "inputFileSyncLocalPath":
						this.InputFileSyncLocalPath = txt;
						continue;
					case "thumbHeight":
						this.ThumbHeight = ParseInt(txt);
						continue;
					case "thumbBitrate":
						this.ThumbBitrate = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaConvertProfileJobData");
			kparams.AddStringIfNotNull("inputFileSyncLocalPath", this.InputFileSyncLocalPath);
			kparams.AddIntIfNotNull("thumbHeight", this.ThumbHeight);
			kparams.AddIntIfNotNull("thumbBitrate", this.ThumbBitrate);
			return kparams;
		}
		#endregion
	}
}

