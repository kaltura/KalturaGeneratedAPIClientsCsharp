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
	public class KalturaPlayReadyCopyRight : KalturaPlayReadyRight
	{
		#region Private Fields
		private int _CopyCount = Int32.MinValue;
		private IList<KalturaPlayReadyCopyEnablerHolder> _CopyEnablers;
		#endregion

		#region Properties
		public int CopyCount
		{
			get { return _CopyCount; }
			set 
			{ 
				_CopyCount = value;
				OnPropertyChanged("CopyCount");
			}
		}
		public IList<KalturaPlayReadyCopyEnablerHolder> CopyEnablers
		{
			get { return _CopyEnablers; }
			set 
			{ 
				_CopyEnablers = value;
				OnPropertyChanged("CopyEnablers");
			}
		}
		#endregion

		#region CTor
		public KalturaPlayReadyCopyRight()
		{
		}

		public KalturaPlayReadyCopyRight(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "copyCount":
						this.CopyCount = ParseInt(txt);
						continue;
					case "copyEnablers":
						this.CopyEnablers = new List<KalturaPlayReadyCopyEnablerHolder>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.CopyEnablers.Add((KalturaPlayReadyCopyEnablerHolder)KalturaObjectFactory.Create(arrayNode, "KalturaPlayReadyCopyEnablerHolder"));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaPlayReadyCopyRight");
			kparams.AddIntIfNotNull("copyCount", this.CopyCount);
			if (this.CopyEnablers != null)
			{
				if (this.CopyEnablers.Count == 0)
				{
					kparams.Add("copyEnablers:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaPlayReadyCopyEnablerHolder item in this.CopyEnablers)
					{
						kparams.Add("copyEnablers:" + i, item.ToParams());
						i++;
					}
				}
			}
			return kparams;
		}
		#endregion
	}
}

