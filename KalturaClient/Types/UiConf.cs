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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class UiConf : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string NAME = "name";
		public const string DESCRIPTION = "description";
		public const string PARTNER_ID = "partnerId";
		public const string OBJ_TYPE = "objType";
		public const string OBJ_TYPE_AS_STRING = "objTypeAsString";
		public const string WIDTH = "width";
		public const string HEIGHT = "height";
		public const string HTML_PARAMS = "htmlParams";
		public const string SWF_URL = "swfUrl";
		public const string CONF_FILE_PATH = "confFilePath";
		public const string CONF_FILE = "confFile";
		public const string CONF_FILE_FEATURES = "confFileFeatures";
		public const string CONFIG = "config";
		public const string CONF_VARS = "confVars";
		public const string USE_CDN = "useCdn";
		public const string TAGS = "tags";
		public const string SWF_URL_VERSION = "swfUrlVersion";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string CREATION_MODE = "creationMode";
		public const string HTML5URL = "html5Url";
		public const string VERSION = "version";
		public const string PARTNER_TAGS = "partnerTags";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _Name = null;
		private string _Description = null;
		private int _PartnerId = Int32.MinValue;
		private UiConfObjType _ObjType = (UiConfObjType)Int32.MinValue;
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
		private UiConfCreationMode _CreationMode = (UiConfCreationMode)Int32.MinValue;
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
		public UiConfObjType ObjType
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
		public UiConfCreationMode CreationMode
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
		public UiConf()
		{
		}

		public UiConf(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "objType":
						this._ObjType = (UiConfObjType)ParseEnum(typeof(UiConfObjType), propertyNode.InnerText);
						continue;
					case "objTypeAsString":
						this._ObjTypeAsString = propertyNode.InnerText;
						continue;
					case "width":
						this._Width = ParseInt(propertyNode.InnerText);
						continue;
					case "height":
						this._Height = ParseInt(propertyNode.InnerText);
						continue;
					case "htmlParams":
						this._HtmlParams = propertyNode.InnerText;
						continue;
					case "swfUrl":
						this._SwfUrl = propertyNode.InnerText;
						continue;
					case "confFilePath":
						this._ConfFilePath = propertyNode.InnerText;
						continue;
					case "confFile":
						this._ConfFile = propertyNode.InnerText;
						continue;
					case "confFileFeatures":
						this._ConfFileFeatures = propertyNode.InnerText;
						continue;
					case "config":
						this._Config = propertyNode.InnerText;
						continue;
					case "confVars":
						this._ConfVars = propertyNode.InnerText;
						continue;
					case "useCdn":
						this._UseCdn = ParseBool(propertyNode.InnerText);
						continue;
					case "tags":
						this._Tags = propertyNode.InnerText;
						continue;
					case "swfUrlVersion":
						this._SwfUrlVersion = propertyNode.InnerText;
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "creationMode":
						this._CreationMode = (UiConfCreationMode)ParseEnum(typeof(UiConfCreationMode), propertyNode.InnerText);
						continue;
					case "html5Url":
						this._Html5Url = propertyNode.InnerText;
						continue;
					case "version":
						this._Version = propertyNode.InnerText;
						continue;
					case "partnerTags":
						this._PartnerTags = propertyNode.InnerText;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUiConf");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("objType", this._ObjType);
			kparams.AddIfNotNull("objTypeAsString", this._ObjTypeAsString);
			kparams.AddIfNotNull("width", this._Width);
			kparams.AddIfNotNull("height", this._Height);
			kparams.AddIfNotNull("htmlParams", this._HtmlParams);
			kparams.AddIfNotNull("swfUrl", this._SwfUrl);
			kparams.AddIfNotNull("confFilePath", this._ConfFilePath);
			kparams.AddIfNotNull("confFile", this._ConfFile);
			kparams.AddIfNotNull("confFileFeatures", this._ConfFileFeatures);
			kparams.AddIfNotNull("config", this._Config);
			kparams.AddIfNotNull("confVars", this._ConfVars);
			kparams.AddIfNotNull("useCdn", this._UseCdn);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("swfUrlVersion", this._SwfUrlVersion);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("creationMode", this._CreationMode);
			kparams.AddIfNotNull("html5Url", this._Html5Url);
			kparams.AddIfNotNull("version", this._Version);
			kparams.AddIfNotNull("partnerTags", this._PartnerTags);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case NAME:
					return "Name";
				case DESCRIPTION:
					return "Description";
				case PARTNER_ID:
					return "PartnerId";
				case OBJ_TYPE:
					return "ObjType";
				case OBJ_TYPE_AS_STRING:
					return "ObjTypeAsString";
				case WIDTH:
					return "Width";
				case HEIGHT:
					return "Height";
				case HTML_PARAMS:
					return "HtmlParams";
				case SWF_URL:
					return "SwfUrl";
				case CONF_FILE_PATH:
					return "ConfFilePath";
				case CONF_FILE:
					return "ConfFile";
				case CONF_FILE_FEATURES:
					return "ConfFileFeatures";
				case CONFIG:
					return "Config";
				case CONF_VARS:
					return "ConfVars";
				case USE_CDN:
					return "UseCdn";
				case TAGS:
					return "Tags";
				case SWF_URL_VERSION:
					return "SwfUrlVersion";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case CREATION_MODE:
					return "CreationMode";
				case HTML5URL:
					return "Html5Url";
				case VERSION:
					return "Version";
				case PARTNER_TAGS:
					return "PartnerTags";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

