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

	public class KalturaMetadataProfileService : KalturaServiceBase
	{
	public KalturaMetadataProfileService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaMetadataProfile Add(KalturaMetadataProfile metadataProfile, string xsdData)
		{
			return this.Add(metadataProfile, xsdData, null);
		}

		public KalturaMetadataProfile Add(KalturaMetadataProfile metadataProfile, string xsdData, string viewsData)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("metadataProfile", metadataProfile);
			kparams.AddIfNotNull("xsdData", xsdData);
			kparams.AddIfNotNull("viewsData", viewsData);
			_Client.QueueServiceCall("metadata_metadataprofile", "add", "KalturaMetadataProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadataProfile)KalturaObjectFactory.Create(result, "KalturaMetadataProfile");
		}

		public KalturaMetadataProfile AddFromFile(KalturaMetadataProfile metadataProfile, FileStream xsdFile)
		{
			return this.AddFromFile(metadataProfile, xsdFile, null);
		}

		public KalturaMetadataProfile AddFromFile(KalturaMetadataProfile metadataProfile, FileStream xsdFile, FileStream viewsFile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("metadataProfile", metadataProfile);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("xsdFile", xsdFile);
			kfiles.Add("viewsFile", viewsFile);
			_Client.QueueServiceCall("metadata_metadataprofile", "addFromFile", "KalturaMetadataProfile", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadataProfile)KalturaObjectFactory.Create(result, "KalturaMetadataProfile");
		}

		public KalturaMetadataProfile Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("metadata_metadataprofile", "get", "KalturaMetadataProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadataProfile)KalturaObjectFactory.Create(result, "KalturaMetadataProfile");
		}

		public KalturaMetadataProfile Update(int id, KalturaMetadataProfile metadataProfile)
		{
			return this.Update(id, metadataProfile, null);
		}

		public KalturaMetadataProfile Update(int id, KalturaMetadataProfile metadataProfile, string xsdData)
		{
			return this.Update(id, metadataProfile, xsdData, null);
		}

		public KalturaMetadataProfile Update(int id, KalturaMetadataProfile metadataProfile, string xsdData, string viewsData)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("metadataProfile", metadataProfile);
			kparams.AddIfNotNull("xsdData", xsdData);
			kparams.AddIfNotNull("viewsData", viewsData);
			_Client.QueueServiceCall("metadata_metadataprofile", "update", "KalturaMetadataProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadataProfile)KalturaObjectFactory.Create(result, "KalturaMetadataProfile");
		}

		public KalturaMetadataProfileListResponse List()
		{
			return this.List(null);
		}

		public KalturaMetadataProfileListResponse List(KalturaMetadataProfileFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaMetadataProfileListResponse List(KalturaMetadataProfileFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("metadata_metadataprofile", "list", "KalturaMetadataProfileListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadataProfileListResponse)KalturaObjectFactory.Create(result, "KalturaMetadataProfileListResponse");
		}

		public KalturaMetadataProfileFieldListResponse ListFields(int metadataProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("metadataProfileId", metadataProfileId);
			_Client.QueueServiceCall("metadata_metadataprofile", "listFields", "KalturaMetadataProfileFieldListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadataProfileFieldListResponse)KalturaObjectFactory.Create(result, "KalturaMetadataProfileFieldListResponse");
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("metadata_metadataprofile", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaMetadataProfile Revert(int id, int toVersion)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("toVersion", toVersion);
			_Client.QueueServiceCall("metadata_metadataprofile", "revert", "KalturaMetadataProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadataProfile)KalturaObjectFactory.Create(result, "KalturaMetadataProfile");
		}

		public KalturaMetadataProfile UpdateDefinitionFromFile(int id, FileStream xsdFile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("xsdFile", xsdFile);
			_Client.QueueServiceCall("metadata_metadataprofile", "updateDefinitionFromFile", "KalturaMetadataProfile", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadataProfile)KalturaObjectFactory.Create(result, "KalturaMetadataProfile");
		}

		public KalturaMetadataProfile UpdateViewsFromFile(int id, FileStream viewsFile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("viewsFile", viewsFile);
			_Client.QueueServiceCall("metadata_metadataprofile", "updateViewsFromFile", "KalturaMetadataProfile", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadataProfile)KalturaObjectFactory.Create(result, "KalturaMetadataProfile");
		}

		public KalturaMetadataProfile UpdateTransformationFromFile(int id, FileStream xsltFile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("xsltFile", xsltFile);
			_Client.QueueServiceCall("metadata_metadataprofile", "updateTransformationFromFile", "KalturaMetadataProfile", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadataProfile)KalturaObjectFactory.Create(result, "KalturaMetadataProfile");
		}
	}
}
