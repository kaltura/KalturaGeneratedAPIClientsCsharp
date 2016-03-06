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

	public class KalturaBaseEntryService : KalturaServiceBase
	{
	public KalturaBaseEntryService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaBaseEntry Add(KalturaBaseEntry entry)
		{
			return this.Add(entry, null);
		}

		public KalturaBaseEntry Add(KalturaBaseEntry entry, KalturaEntryType type)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entry", entry);
			kparams.AddIfNotNull("type", type);
			_Client.QueueServiceCall("baseentry", "add", "KalturaBaseEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result, "KalturaBaseEntry");
		}

		public KalturaBaseEntry AddContent(string entryId, KalturaResource resource)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("resource", resource);
			_Client.QueueServiceCall("baseentry", "addContent", "KalturaBaseEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result, "KalturaBaseEntry");
		}

		public KalturaBaseEntry AddFromUploadedFile(KalturaBaseEntry entry, string uploadTokenId)
		{
			return this.AddFromUploadedFile(entry, uploadTokenId, null);
		}

		public KalturaBaseEntry AddFromUploadedFile(KalturaBaseEntry entry, string uploadTokenId, KalturaEntryType type)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entry", entry);
			kparams.AddIfNotNull("uploadTokenId", uploadTokenId);
			kparams.AddIfNotNull("type", type);
			_Client.QueueServiceCall("baseentry", "addFromUploadedFile", "KalturaBaseEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result, "KalturaBaseEntry");
		}

		public KalturaBaseEntry Get(string entryId)
		{
			return this.Get(entryId, -1);
		}

		public KalturaBaseEntry Get(string entryId, int version)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("version", version);
			_Client.QueueServiceCall("baseentry", "get", "KalturaBaseEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result, "KalturaBaseEntry");
		}

		public KalturaRemotePathListResponse GetRemotePaths(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("baseentry", "getRemotePaths", "KalturaRemotePathListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaRemotePathListResponse)KalturaObjectFactory.Create(result, "KalturaRemotePathListResponse");
		}

		public KalturaBaseEntry Update(string entryId, KalturaBaseEntry baseEntry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("baseEntry", baseEntry);
			_Client.QueueServiceCall("baseentry", "update", "KalturaBaseEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result, "KalturaBaseEntry");
		}

		public KalturaBaseEntry UpdateContent(string entryId, KalturaResource resource)
		{
			return this.UpdateContent(entryId, resource, Int32.MinValue);
		}

		public KalturaBaseEntry UpdateContent(string entryId, KalturaResource resource, int conversionProfileId)
		{
			return this.UpdateContent(entryId, resource, conversionProfileId, null);
		}

		public KalturaBaseEntry UpdateContent(string entryId, KalturaResource resource, int conversionProfileId, KalturaEntryReplacementOptions advancedOptions)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("resource", resource);
			kparams.AddIfNotNull("conversionProfileId", conversionProfileId);
			kparams.AddIfNotNull("advancedOptions", advancedOptions);
			_Client.QueueServiceCall("baseentry", "updateContent", "KalturaBaseEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result, "KalturaBaseEntry");
		}

		public IList<KalturaBaseEntry> GetByIds(string entryIds)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryIds", entryIds);
			_Client.QueueServiceCall("baseentry", "getByIds", "KalturaBaseEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaBaseEntry> list = new List<KalturaBaseEntry>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaBaseEntry)KalturaObjectFactory.Create(node, "KalturaBaseEntry"));
			}
			return list;
		}

		public void Delete(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("baseentry", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaBaseEntryListResponse List()
		{
			return this.List(null);
		}

		public KalturaBaseEntryListResponse List(KalturaBaseEntryFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaBaseEntryListResponse List(KalturaBaseEntryFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("baseentry", "list", "KalturaBaseEntryListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntryListResponse)KalturaObjectFactory.Create(result, "KalturaBaseEntryListResponse");
		}

		public KalturaBaseEntryListResponse ListByReferenceId(string refId)
		{
			return this.ListByReferenceId(refId, null);
		}

		public KalturaBaseEntryListResponse ListByReferenceId(string refId, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("refId", refId);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("baseentry", "listByReferenceId", "KalturaBaseEntryListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntryListResponse)KalturaObjectFactory.Create(result, "KalturaBaseEntryListResponse");
		}

		public int Count()
		{
			return this.Count(null);
		}

		public int Count(KalturaBaseEntryFilter filter)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			_Client.QueueServiceCall("baseentry", "count", null, kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}

		public string Upload(Stream fileData)
		{
			KalturaParams kparams = new KalturaParams();
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			_Client.QueueServiceCall("baseentry", "upload", null, kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public KalturaBaseEntry UpdateThumbnailJpeg(string entryId, Stream fileData)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			_Client.QueueServiceCall("baseentry", "updateThumbnailJpeg", "KalturaBaseEntry", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result, "KalturaBaseEntry");
		}

		public KalturaBaseEntry UpdateThumbnailFromUrl(string entryId, string url)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("url", url);
			_Client.QueueServiceCall("baseentry", "updateThumbnailFromUrl", "KalturaBaseEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result, "KalturaBaseEntry");
		}

		public KalturaBaseEntry UpdateThumbnailFromSourceEntry(string entryId, string sourceEntryId, int timeOffset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("sourceEntryId", sourceEntryId);
			kparams.AddIfNotNull("timeOffset", timeOffset);
			_Client.QueueServiceCall("baseentry", "updateThumbnailFromSourceEntry", "KalturaBaseEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result, "KalturaBaseEntry");
		}

		public void Flag(KalturaModerationFlag moderationFlag)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("moderationFlag", moderationFlag);
			_Client.QueueServiceCall("baseentry", "flag", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void Reject(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("baseentry", "reject", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void Approve(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("baseentry", "approve", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaModerationFlagListResponse ListFlags(string entryId)
		{
			return this.ListFlags(entryId, null);
		}

		public KalturaModerationFlagListResponse ListFlags(string entryId, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("baseentry", "listFlags", "KalturaModerationFlagListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaModerationFlagListResponse)KalturaObjectFactory.Create(result, "KalturaModerationFlagListResponse");
		}

		public void AnonymousRank(string entryId, int rank)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("rank", rank);
			_Client.QueueServiceCall("baseentry", "anonymousRank", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaEntryContextDataResult GetContextData(string entryId, KalturaEntryContextDataParams contextDataParams)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("contextDataParams", contextDataParams);
			_Client.QueueServiceCall("baseentry", "getContextData", "KalturaEntryContextDataResult", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryContextDataResult)KalturaObjectFactory.Create(result, "KalturaEntryContextDataResult");
		}

		public KalturaBaseEntry Export(string entryId, int storageProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("storageProfileId", storageProfileId);
			_Client.QueueServiceCall("baseentry", "export", "KalturaBaseEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result, "KalturaBaseEntry");
		}

		public int Index(string id)
		{
			return this.Index(id, true);
		}

		public int Index(string id, bool shouldUpdate)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("shouldUpdate", shouldUpdate);
			_Client.QueueServiceCall("baseentry", "index", null, kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}

		public KalturaBaseEntry Clone(string entryId)
		{
			return this.Clone(entryId, null);
		}

		public KalturaBaseEntry Clone(string entryId, IList<KalturaBaseEntryCloneOptionItem> cloneOptions)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("cloneOptions", cloneOptions);
			_Client.QueueServiceCall("baseentry", "clone", "KalturaBaseEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result, "KalturaBaseEntry");
		}
	}
}
