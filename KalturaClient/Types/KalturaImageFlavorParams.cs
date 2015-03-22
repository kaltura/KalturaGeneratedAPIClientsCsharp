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
	public class KalturaImageFlavorParams : KalturaFlavorParams
	{
		#region Private Fields
		private int _DensityWidth = Int32.MinValue;
		private int _DensityHeight = Int32.MinValue;
		private int _SizeWidth = Int32.MinValue;
		private int _SizeHeight = Int32.MinValue;
		private int _Depth = Int32.MinValue;
		#endregion

		#region Properties
		public int DensityWidth
		{
			get { return _DensityWidth; }
			set 
			{ 
				_DensityWidth = value;
				OnPropertyChanged("DensityWidth");
			}
		}
		public int DensityHeight
		{
			get { return _DensityHeight; }
			set 
			{ 
				_DensityHeight = value;
				OnPropertyChanged("DensityHeight");
			}
		}
		public int SizeWidth
		{
			get { return _SizeWidth; }
			set 
			{ 
				_SizeWidth = value;
				OnPropertyChanged("SizeWidth");
			}
		}
		public int SizeHeight
		{
			get { return _SizeHeight; }
			set 
			{ 
				_SizeHeight = value;
				OnPropertyChanged("SizeHeight");
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
		#endregion

		#region CTor
		public KalturaImageFlavorParams()
		{
		}

		public KalturaImageFlavorParams(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "densityWidth":
						this.DensityWidth = ParseInt(txt);
						continue;
					case "densityHeight":
						this.DensityHeight = ParseInt(txt);
						continue;
					case "sizeWidth":
						this.SizeWidth = ParseInt(txt);
						continue;
					case "sizeHeight":
						this.SizeHeight = ParseInt(txt);
						continue;
					case "depth":
						this.Depth = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaImageFlavorParams");
			kparams.AddIntIfNotNull("densityWidth", this.DensityWidth);
			kparams.AddIntIfNotNull("densityHeight", this.DensityHeight);
			kparams.AddIntIfNotNull("sizeWidth", this.SizeWidth);
			kparams.AddIntIfNotNull("sizeHeight", this.SizeHeight);
			kparams.AddIntIfNotNull("depth", this.Depth);
			return kparams;
		}
		#endregion
	}
}

