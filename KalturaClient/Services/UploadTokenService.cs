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
// Copyright (C) 2006-2015  Kaltura Inc.
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

	public class KalturaUploadTokenService : KalturaServiceBase
	{
	public KalturaUploadTokenService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaUploadToken Add()
		{
			return this.Add(null);
		}

		public KalturaUploadToken Add(KalturaUploadToken uploadToken)
		{
			KalturaParams kparams = new KalturaParams();
			if (uploadToken != null)
				kparams.Add("uploadToken", uploadToken.ToParams());
			_Client.QueueServiceCall("uploadtoken", "add", "KalturaUploadToken", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUploadToken)KalturaObjectFactory.Create(result, "KalturaUploadToken");
		}

		public KalturaUploadToken Get(string uploadTokenId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("uploadTokenId", uploadTokenId);
			_Client.QueueServiceCall("uploadtoken", "get", "KalturaUploadToken", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUploadToken)KalturaObjectFactory.Create(result, "KalturaUploadToken");
		}

		public KalturaUploadToken Upload(string uploadTokenId, FileStream fileData)
		{
			return this.Upload(uploadTokenId, fileData, false);
		}

		public KalturaUploadToken Upload(string uploadTokenId, FileStream fileData, bool resume)
		{
			return this.Upload(uploadTokenId, fileData, resume, true);
		}

		public KalturaUploadToken Upload(string uploadTokenId, FileStream fileData, bool resume, bool finalChunk)
		{
			return this.Upload(uploadTokenId, fileData, resume, finalChunk, -1);
		}

		public KalturaUploadToken Upload(string uploadTokenId, FileStream fileData, bool resume, bool finalChunk, float resumeAt)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("uploadTokenId", uploadTokenId);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			kparams.AddBoolIfNotNull("resume", resume);
			kparams.AddBoolIfNotNull("finalChunk", finalChunk);
			kparams.AddFloatIfNotNull("resumeAt", resumeAt);
			_Client.QueueServiceCall("uploadtoken", "upload", "KalturaUploadToken", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUploadToken)KalturaObjectFactory.Create(result, "KalturaUploadToken");
		}

		public void Delete(string uploadTokenId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("uploadTokenId", uploadTokenId);
			_Client.QueueServiceCall("uploadtoken", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaUploadTokenListResponse List()
		{
			return this.List(null);
		}

		public KalturaUploadTokenListResponse List(KalturaUploadTokenFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaUploadTokenListResponse List(KalturaUploadTokenFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("uploadtoken", "list", "KalturaUploadTokenListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUploadTokenListResponse)KalturaObjectFactory.Create(result, "KalturaUploadTokenListResponse");
		}
	}
}
