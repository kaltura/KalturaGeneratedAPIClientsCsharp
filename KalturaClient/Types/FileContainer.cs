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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class FileContainer : ObjectBase
	{
		#region Constants
		public const string FILE_PATH = "filePath";
		public const string ENCRYPTION_KEY = "encryptionKey";
		public const string FILE_SIZE = "fileSize";
		#endregion

		#region Private Fields
		private string _FilePath = null;
		private string _EncryptionKey = null;
		private int _FileSize = Int32.MinValue;
		#endregion

		#region Properties
		public string FilePath
		{
			get { return _FilePath; }
			set 
			{ 
				_FilePath = value;
				OnPropertyChanged("FilePath");
			}
		}
		public string EncryptionKey
		{
			get { return _EncryptionKey; }
			set 
			{ 
				_EncryptionKey = value;
				OnPropertyChanged("EncryptionKey");
			}
		}
		public int FileSize
		{
			get { return _FileSize; }
			set 
			{ 
				_FileSize = value;
				OnPropertyChanged("FileSize");
			}
		}
		#endregion

		#region CTor
		public FileContainer()
		{
		}

		public FileContainer(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "filePath":
						this._FilePath = propertyNode.InnerText;
						continue;
					case "encryptionKey":
						this._EncryptionKey = propertyNode.InnerText;
						continue;
					case "fileSize":
						this._FileSize = ParseInt(propertyNode.InnerText);
						continue;
				}
			}
		}

		public FileContainer(IDictionary<string,object> data) : base(data)
		{
			    this._FilePath = data.TryGetValueSafe<string>("filePath");
			    this._EncryptionKey = data.TryGetValueSafe<string>("encryptionKey");
			    this._FileSize = data.TryGetValueSafe<int>("fileSize");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFileContainer");
			kparams.AddIfNotNull("filePath", this._FilePath);
			kparams.AddIfNotNull("encryptionKey", this._EncryptionKey);
			kparams.AddIfNotNull("fileSize", this._FileSize);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FILE_PATH:
					return "FilePath";
				case ENCRYPTION_KEY:
					return "EncryptionKey";
				case FILE_SIZE:
					return "FileSize";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

