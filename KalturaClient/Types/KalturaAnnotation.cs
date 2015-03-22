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
	public class KalturaAnnotation : KalturaCuePoint
	{
		#region Private Fields
		private string _ParentId = null;
		private string _Text = null;
		private int _EndTime = Int32.MinValue;
		private int _Duration = Int32.MinValue;
		private int _Depth = Int32.MinValue;
		private int _ChildrenCount = Int32.MinValue;
		private int _DirectChildrenCount = Int32.MinValue;
		#endregion

		#region Properties
		public string ParentId
		{
			get { return _ParentId; }
			set 
			{ 
				_ParentId = value;
				OnPropertyChanged("ParentId");
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
			set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		public int Depth
		{
			get { return _Depth; }
			set 
			{ 
				_Depth = value;
				OnPropertyChanged("Depth");
			}
		}
		public int ChildrenCount
		{
			get { return _ChildrenCount; }
			set 
			{ 
				_ChildrenCount = value;
				OnPropertyChanged("ChildrenCount");
			}
		}
		public int DirectChildrenCount
		{
			get { return _DirectChildrenCount; }
			set 
			{ 
				_DirectChildrenCount = value;
				OnPropertyChanged("DirectChildrenCount");
			}
		}
		#endregion

		#region CTor
		public KalturaAnnotation()
		{
		}

		public KalturaAnnotation(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "parentId":
						this.ParentId = txt;
						continue;
					case "text":
						this.Text = txt;
						continue;
					case "endTime":
						this.EndTime = ParseInt(txt);
						continue;
					case "duration":
						this.Duration = ParseInt(txt);
						continue;
					case "depth":
						this.Depth = ParseInt(txt);
						continue;
					case "childrenCount":
						this.ChildrenCount = ParseInt(txt);
						continue;
					case "directChildrenCount":
						this.DirectChildrenCount = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAnnotation");
			kparams.AddStringIfNotNull("parentId", this.ParentId);
			kparams.AddStringIfNotNull("text", this.Text);
			kparams.AddIntIfNotNull("endTime", this.EndTime);
			kparams.AddIntIfNotNull("duration", this.Duration);
			kparams.AddIntIfNotNull("depth", this.Depth);
			kparams.AddIntIfNotNull("childrenCount", this.ChildrenCount);
			kparams.AddIntIfNotNull("directChildrenCount", this.DirectChildrenCount);
			return kparams;
		}
		#endregion
	}
}

