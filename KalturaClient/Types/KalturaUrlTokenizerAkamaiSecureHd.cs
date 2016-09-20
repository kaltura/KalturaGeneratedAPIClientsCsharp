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
	public class KalturaUrlTokenizerAkamaiSecureHd : KalturaUrlTokenizer
	{
		#region Private Fields
		private string _ParamName = null;
		private string _AclPostfix = null;
		private string _CustomPostfixes = null;
		private string _UseCookieHosts = null;
		private string _RootDir = null;
		#endregion

		#region Properties
		public string ParamName
		{
			get { return _ParamName; }
			set 
			{ 
				_ParamName = value;
				OnPropertyChanged("ParamName");
			}
		}
		public string AclPostfix
		{
			get { return _AclPostfix; }
			set 
			{ 
				_AclPostfix = value;
				OnPropertyChanged("AclPostfix");
			}
		}
		public string CustomPostfixes
		{
			get { return _CustomPostfixes; }
			set 
			{ 
				_CustomPostfixes = value;
				OnPropertyChanged("CustomPostfixes");
			}
		}
		public string UseCookieHosts
		{
			get { return _UseCookieHosts; }
			set 
			{ 
				_UseCookieHosts = value;
				OnPropertyChanged("UseCookieHosts");
			}
		}
		public string RootDir
		{
			get { return _RootDir; }
			set 
			{ 
				_RootDir = value;
				OnPropertyChanged("RootDir");
			}
		}
		#endregion

		#region CTor
		public KalturaUrlTokenizerAkamaiSecureHd()
		{
		}

		public KalturaUrlTokenizerAkamaiSecureHd(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "paramName":
						this._ParamName = txt;
						continue;
					case "aclPostfix":
						this._AclPostfix = txt;
						continue;
					case "customPostfixes":
						this._CustomPostfixes = txt;
						continue;
					case "useCookieHosts":
						this._UseCookieHosts = txt;
						continue;
					case "rootDir":
						this._RootDir = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaUrlTokenizerAkamaiSecureHd");
			kparams.AddIfNotNull("paramName", this.ParamName);
			kparams.AddIfNotNull("aclPostfix", this.AclPostfix);
			kparams.AddIfNotNull("customPostfixes", this.CustomPostfixes);
			kparams.AddIfNotNull("useCookieHosts", this.UseCookieHosts);
			kparams.AddIfNotNull("rootDir", this.RootDir);
			return kparams;
		}
		#endregion
	}
}

