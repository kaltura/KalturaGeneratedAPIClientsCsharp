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
	public class KalturaUiConf : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _Name = null;
		private string _Description = null;
		private int _PartnerId = Int32.MinValue;
		private KalturaUiConfObjType _ObjType = (KalturaUiConfObjType)Int32.MinValue;
		private string _ObjTypeAsString = null;
		private int _Width = Int32.MinValue;
		private int _Height = Int32.MinValue;
		private string _HtmlParams = null;
		private string _SwfUrl = null;
		private string _ConfFilePath = null;
		private string _ConfFile = null;
		private string _ConfFileFeatures = null;
		private string _Config = null;
		private string _ConfVars = null;
		private bool? _UseCdn = null;
		private string _Tags = null;
		private string _SwfUrlVersion = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private KalturaUiConfCreationMode _CreationMode = (KalturaUiConfCreationMode)Int32.MinValue;
		private string _Html5Url = null;
		private string _Version = null;
		private string _PartnerTags = null;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public KalturaUiConfObjType ObjType
		{
			get { return _ObjType; }
			set 
			{ 
				_ObjType = value;
				OnPropertyChanged("ObjType");
			}
		}
		public string ObjTypeAsString
		{
			get { return _ObjTypeAsString; }
		}
		public int Width
		{
			get { return _Width; }
			set 
			{ 
				_Width = value;
				OnPropertyChanged("Width");
			}
		}
		public int Height
		{
			get { return _Height; }
			set 
			{ 
				_Height = value;
				OnPropertyChanged("Height");
			}
		}
		public string HtmlParams
		{
			get { return _HtmlParams; }
			set 
			{ 
				_HtmlParams = value;
				OnPropertyChanged("HtmlParams");
			}
		}
		public string SwfUrl
		{
			get { return _SwfUrl; }
			set 
			{ 
				_SwfUrl = value;
				OnPropertyChanged("SwfUrl");
			}
		}
		public string ConfFilePath
		{
			get { return _ConfFilePath; }
		}
		public string ConfFile
		{
			get { return _ConfFile; }
			set 
			{ 
				_ConfFile = value;
				OnPropertyChanged("ConfFile");
			}
		}
		public string ConfFileFeatures
		{
			get { return _ConfFileFeatures; }
			set 
			{ 
				_ConfFileFeatures = value;
				OnPropertyChanged("ConfFileFeatures");
			}
		}
		public string Config
		{
			get { return _Config; }
			set 
			{ 
				_Config = value;
				OnPropertyChanged("Config");
			}
		}
		public string ConfVars
		{
			get { return _ConfVars; }
			set 
			{ 
				_ConfVars = value;
				OnPropertyChanged("ConfVars");
			}
		}
		public bool? UseCdn
		{
			get { return _UseCdn; }
			set 
			{ 
				_UseCdn = value;
				OnPropertyChanged("UseCdn");
			}
		}
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		public string SwfUrlVersion
		{
			get { return _SwfUrlVersion; }
			set 
			{ 
				_SwfUrlVersion = value;
				OnPropertyChanged("SwfUrlVersion");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public KalturaUiConfCreationMode CreationMode
		{
			get { return _CreationMode; }
			set 
			{ 
				_CreationMode = value;
				OnPropertyChanged("CreationMode");
			}
		}
		public string Html5Url
		{
			get { return _Html5Url; }
			set 
			{ 
				_Html5Url = value;
				OnPropertyChanged("Html5Url");
			}
		}
		public string Version
		{
			get { return _Version; }
		}
		public string PartnerTags
		{
			get { return _PartnerTags; }
			set 
			{ 
				_PartnerTags = value;
				OnPropertyChanged("PartnerTags");
			}
		}
		#endregion

		#region CTor
		public KalturaUiConf()
		{
		}

		public KalturaUiConf(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(txt);
						continue;
					case "name":
						this._Name = txt;
						continue;
					case "description":
						this._Description = txt;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "objType":
						this._ObjType = (KalturaUiConfObjType)ParseEnum(typeof(KalturaUiConfObjType), txt);
						continue;
					case "objTypeAsString":
						this._ObjTypeAsString = txt;
						continue;
					case "width":
						this._Width = ParseInt(txt);
						continue;
					case "height":
						this._Height = ParseInt(txt);
						continue;
					case "htmlParams":
						this._HtmlParams = txt;
						continue;
					case "swfUrl":
						this._SwfUrl = txt;
						continue;
					case "confFilePath":
						this._ConfFilePath = txt;
						continue;
					case "confFile":
						this._ConfFile = txt;
						continue;
					case "confFileFeatures":
						this._ConfFileFeatures = txt;
						continue;
					case "config":
						this._Config = txt;
						continue;
					case "confVars":
						this._ConfVars = txt;
						continue;
					case "useCdn":
						this._UseCdn = ParseBool(txt);
						continue;
					case "tags":
						this._Tags = txt;
						continue;
					case "swfUrlVersion":
						this._SwfUrlVersion = txt;
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
					case "creationMode":
						this._CreationMode = (KalturaUiConfCreationMode)ParseEnum(typeof(KalturaUiConfCreationMode), txt);
						continue;
					case "html5Url":
						this._Html5Url = txt;
						continue;
					case "version":
						this._Version = txt;
						continue;
					case "partnerTags":
						this._PartnerTags = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaUiConf");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("name", this.Name);
			kparams.AddIfNotNull("description", this.Description);
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("objType", this.ObjType);
			kparams.AddIfNotNull("objTypeAsString", this.ObjTypeAsString);
			kparams.AddIfNotNull("width", this.Width);
			kparams.AddIfNotNull("height", this.Height);
			kparams.AddIfNotNull("htmlParams", this.HtmlParams);
			kparams.AddIfNotNull("swfUrl", this.SwfUrl);
			kparams.AddIfNotNull("confFilePath", this.ConfFilePath);
			kparams.AddIfNotNull("confFile", this.ConfFile);
			kparams.AddIfNotNull("confFileFeatures", this.ConfFileFeatures);
			kparams.AddIfNotNull("config", this.Config);
			kparams.AddIfNotNull("confVars", this.ConfVars);
			kparams.AddIfNotNull("useCdn", this.UseCdn);
			kparams.AddIfNotNull("tags", this.Tags);
			kparams.AddIfNotNull("swfUrlVersion", this.SwfUrlVersion);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIfNotNull("creationMode", this.CreationMode);
			kparams.AddIfNotNull("html5Url", this.Html5Url);
			kparams.AddIfNotNull("version", this.Version);
			kparams.AddIfNotNull("partnerTags", this.PartnerTags);
			return kparams;
		}
		#endregion
	}
}

