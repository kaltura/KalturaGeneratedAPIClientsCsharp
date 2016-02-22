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
using System.IO;

namespace Kaltura
{

	public class KalturaDropFolderService : KalturaServiceBase
	{
	public KalturaDropFolderService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaDropFolder Add(KalturaDropFolder dropFolder)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("dropFolder", dropFolder);
			_Client.QueueServiceCall("dropfolder_dropfolder", "add", "KalturaDropFolder", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolder)KalturaObjectFactory.Create(result, "KalturaDropFolder");
		}

		public KalturaDropFolder Get(int dropFolderId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("dropFolderId", dropFolderId);
			_Client.QueueServiceCall("dropfolder_dropfolder", "get", "KalturaDropFolder", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolder)KalturaObjectFactory.Create(result, "KalturaDropFolder");
		}

		public KalturaDropFolder Update(int dropFolderId, KalturaDropFolder dropFolder)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("dropFolderId", dropFolderId);
			kparams.AddIfNotNull("dropFolder", dropFolder);
			_Client.QueueServiceCall("dropfolder_dropfolder", "update", "KalturaDropFolder", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolder)KalturaObjectFactory.Create(result, "KalturaDropFolder");
		}

		public KalturaDropFolder Delete(int dropFolderId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("dropFolderId", dropFolderId);
			_Client.QueueServiceCall("dropfolder_dropfolder", "delete", "KalturaDropFolder", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolder)KalturaObjectFactory.Create(result, "KalturaDropFolder");
		}

		public KalturaDropFolderListResponse List()
		{
			return this.List(null);
		}

		public KalturaDropFolderListResponse List(KalturaDropFolderFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaDropFolderListResponse List(KalturaDropFolderFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("dropfolder_dropfolder", "list", "KalturaDropFolderListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolderListResponse)KalturaObjectFactory.Create(result, "KalturaDropFolderListResponse");
		}
	}
}
