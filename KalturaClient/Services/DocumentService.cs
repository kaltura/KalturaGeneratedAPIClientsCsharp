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

	public class KalturaDocumentService : KalturaServiceBase
	{
	public KalturaDocumentService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaDocumentEntry AddFromUploadedFile(KalturaDocumentEntry documentEntry, string uploadTokenId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("documentEntry", documentEntry);
			kparams.AddIfNotNull("uploadTokenId", uploadTokenId);
			_Client.QueueServiceCall("document", "addFromUploadedFile", "KalturaDocumentEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDocumentEntry)KalturaObjectFactory.Create(result, "KalturaDocumentEntry");
		}

		public KalturaDocumentEntry AddFromEntry(string sourceEntryId)
		{
			return this.AddFromEntry(sourceEntryId, null);
		}

		public KalturaDocumentEntry AddFromEntry(string sourceEntryId, KalturaDocumentEntry documentEntry)
		{
			return this.AddFromEntry(sourceEntryId, documentEntry, Int32.MinValue);
		}

		public KalturaDocumentEntry AddFromEntry(string sourceEntryId, KalturaDocumentEntry documentEntry, int sourceFlavorParamsId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("sourceEntryId", sourceEntryId);
			kparams.AddIfNotNull("documentEntry", documentEntry);
			kparams.AddIfNotNull("sourceFlavorParamsId", sourceFlavorParamsId);
			_Client.QueueServiceCall("document", "addFromEntry", "KalturaDocumentEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDocumentEntry)KalturaObjectFactory.Create(result, "KalturaDocumentEntry");
		}

		public KalturaDocumentEntry AddFromFlavorAsset(string sourceFlavorAssetId)
		{
			return this.AddFromFlavorAsset(sourceFlavorAssetId, null);
		}

		public KalturaDocumentEntry AddFromFlavorAsset(string sourceFlavorAssetId, KalturaDocumentEntry documentEntry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("sourceFlavorAssetId", sourceFlavorAssetId);
			kparams.AddIfNotNull("documentEntry", documentEntry);
			_Client.QueueServiceCall("document", "addFromFlavorAsset", "KalturaDocumentEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDocumentEntry)KalturaObjectFactory.Create(result, "KalturaDocumentEntry");
		}

		public long Convert(string entryId)
		{
			return this.Convert(entryId, Int32.MinValue);
		}

		public long Convert(string entryId, int conversionProfileId)
		{
			return this.Convert(entryId, conversionProfileId, null);
		}

		public long Convert(string entryId, int conversionProfileId, IList<KalturaConversionAttribute> dynamicConversionAttributes)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("conversionProfileId", conversionProfileId);
			kparams.AddIfNotNull("dynamicConversionAttributes", dynamicConversionAttributes);
			_Client.QueueServiceCall("document", "convert", null, kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return long.Parse(result.InnerText);
		}

		public KalturaDocumentEntry Get(string entryId)
		{
			return this.Get(entryId, -1);
		}

		public KalturaDocumentEntry Get(string entryId, int version)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("version", version);
			_Client.QueueServiceCall("document", "get", "KalturaDocumentEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDocumentEntry)KalturaObjectFactory.Create(result, "KalturaDocumentEntry");
		}

		public KalturaDocumentEntry Update(string entryId, KalturaDocumentEntry documentEntry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("documentEntry", documentEntry);
			_Client.QueueServiceCall("document", "update", "KalturaDocumentEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDocumentEntry)KalturaObjectFactory.Create(result, "KalturaDocumentEntry");
		}

		public void Delete(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("document", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaDocumentListResponse List()
		{
			return this.List(null);
		}

		public KalturaDocumentListResponse List(KalturaDocumentEntryFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaDocumentListResponse List(KalturaDocumentEntryFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("document", "list", "KalturaDocumentListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDocumentListResponse)KalturaObjectFactory.Create(result, "KalturaDocumentListResponse");
		}

		public string Upload(FileStream fileData)
		{
			KalturaParams kparams = new KalturaParams();
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			_Client.QueueServiceCall("document", "upload", null, kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public string ConvertPptToSwf(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("document", "convertPptToSwf", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public KalturaDocumentEntry UpdateContent(string entryId, KalturaResource resource)
		{
			return this.UpdateContent(entryId, resource, Int32.MinValue);
		}

		public KalturaDocumentEntry UpdateContent(string entryId, KalturaResource resource, int conversionProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("resource", resource);
			kparams.AddIfNotNull("conversionProfileId", conversionProfileId);
			_Client.QueueServiceCall("document", "updateContent", "KalturaDocumentEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDocumentEntry)KalturaObjectFactory.Create(result, "KalturaDocumentEntry");
		}

		public KalturaDocumentEntry ApproveReplace(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("document", "approveReplace", "KalturaDocumentEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDocumentEntry)KalturaObjectFactory.Create(result, "KalturaDocumentEntry");
		}

		public KalturaDocumentEntry CancelReplace(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("document", "cancelReplace", "KalturaDocumentEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDocumentEntry)KalturaObjectFactory.Create(result, "KalturaDocumentEntry");
		}
	}
}
