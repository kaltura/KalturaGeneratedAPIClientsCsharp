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

	public class KalturaDropFolderFileService : KalturaServiceBase
	{
	public KalturaDropFolderFileService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaDropFolderFile Add(KalturaDropFolderFile dropFolderFile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("dropFolderFile", dropFolderFile);
			_Client.QueueServiceCall("dropfolder_dropfolderfile", "add", "KalturaDropFolderFile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolderFile)KalturaObjectFactory.Create(result, "KalturaDropFolderFile");
		}

		public KalturaDropFolderFile Get(int dropFolderFileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("dropFolderFileId", dropFolderFileId);
			_Client.QueueServiceCall("dropfolder_dropfolderfile", "get", "KalturaDropFolderFile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolderFile)KalturaObjectFactory.Create(result, "KalturaDropFolderFile");
		}

		public KalturaDropFolderFile Update(int dropFolderFileId, KalturaDropFolderFile dropFolderFile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("dropFolderFileId", dropFolderFileId);
			kparams.AddIfNotNull("dropFolderFile", dropFolderFile);
			_Client.QueueServiceCall("dropfolder_dropfolderfile", "update", "KalturaDropFolderFile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolderFile)KalturaObjectFactory.Create(result, "KalturaDropFolderFile");
		}

		public KalturaDropFolderFile UpdateStatus(int dropFolderFileId, KalturaDropFolderFileStatus status)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("dropFolderFileId", dropFolderFileId);
			kparams.AddIfNotNull("status", status);
			_Client.QueueServiceCall("dropfolder_dropfolderfile", "updateStatus", "KalturaDropFolderFile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolderFile)KalturaObjectFactory.Create(result, "KalturaDropFolderFile");
		}

		public KalturaDropFolderFile Delete(int dropFolderFileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("dropFolderFileId", dropFolderFileId);
			_Client.QueueServiceCall("dropfolder_dropfolderfile", "delete", "KalturaDropFolderFile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolderFile)KalturaObjectFactory.Create(result, "KalturaDropFolderFile");
		}

		public KalturaDropFolderFileListResponse List()
		{
			return this.List(null);
		}

		public KalturaDropFolderFileListResponse List(KalturaDropFolderFileFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaDropFolderFileListResponse List(KalturaDropFolderFileFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("dropfolder_dropfolderfile", "list", "KalturaDropFolderFileListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolderFileListResponse)KalturaObjectFactory.Create(result, "KalturaDropFolderFileListResponse");
		}

		public KalturaDropFolderFile Ignore(int dropFolderFileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("dropFolderFileId", dropFolderFileId);
			_Client.QueueServiceCall("dropfolder_dropfolderfile", "ignore", "KalturaDropFolderFile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDropFolderFile)KalturaObjectFactory.Create(result, "KalturaDropFolderFile");
		}
	}
}
