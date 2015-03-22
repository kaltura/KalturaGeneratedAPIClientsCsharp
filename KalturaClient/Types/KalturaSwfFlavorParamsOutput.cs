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
	public class KalturaSwfFlavorParamsOutput : KalturaFlavorParamsOutput
	{
		#region Private Fields
		private int _FlashVersion = Int32.MinValue;
		private bool? _Poly2Bitmap = false;
		#endregion

		#region Properties
		public int FlashVersion
		{
			get { return _FlashVersion; }
			set 
			{ 
				_FlashVersion = value;
				OnPropertyChanged("FlashVersion");
			}
		}
		public bool? Poly2Bitmap
		{
			get { return _Poly2Bitmap; }
			set 
			{ 
				_Poly2Bitmap = value;
				OnPropertyChanged("Poly2Bitmap");
			}
		}
		#endregion

		#region CTor
		public KalturaSwfFlavorParamsOutput()
		{
		}

		public KalturaSwfFlavorParamsOutput(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "flashVersion":
						this.FlashVersion = ParseInt(txt);
						continue;
					case "poly2Bitmap":
						this.Poly2Bitmap = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaSwfFlavorParamsOutput");
			kparams.AddIntIfNotNull("flashVersion", this.FlashVersion);
			kparams.AddBoolIfNotNull("poly2Bitmap", this.Poly2Bitmap);
			return kparams;
		}
		#endregion
	}
}

