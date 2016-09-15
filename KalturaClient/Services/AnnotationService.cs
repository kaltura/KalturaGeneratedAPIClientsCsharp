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

	public class KalturaAnnotationService : KalturaServiceBase
	{
	public KalturaAnnotationService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaAnnotation Add(KalturaCuePoint annotation)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("annotation", annotation);
			_Client.QueueServiceCall("annotation_annotation", "add", "KalturaAnnotation", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAnnotation)KalturaObjectFactory.Create(result, "KalturaAnnotation");
		}

		public KalturaAnnotation Update(string id, KalturaCuePoint annotation)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("annotation", annotation);
			_Client.QueueServiceCall("annotation_annotation", "update", "KalturaAnnotation", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAnnotation)KalturaObjectFactory.Create(result, "KalturaAnnotation");
		}

		public KalturaAnnotationListResponse List()
		{
			return this.List(null);
		}

		public KalturaAnnotationListResponse List(KalturaCuePointFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaAnnotationListResponse List(KalturaCuePointFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("annotation_annotation", "list", "KalturaAnnotationListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAnnotationListResponse)KalturaObjectFactory.Create(result, "KalturaAnnotationListResponse");
		}

		public KalturaCuePointListResponse AddFromBulk(Stream fileData)
		{
			KalturaParams kparams = new KalturaParams();
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			_Client.QueueServiceCall("annotation_annotation", "addFromBulk", "KalturaCuePointListResponse", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCuePointListResponse)KalturaObjectFactory.Create(result, "KalturaCuePointListResponse");
		}

		public KalturaCuePoint Get(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("annotation_annotation", "get", "KalturaCuePoint", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCuePoint)KalturaObjectFactory.Create(result, "KalturaCuePoint");
		}

		public int Count()
		{
			return this.Count(null);
		}

		public int Count(KalturaCuePointFilter filter)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			_Client.QueueServiceCall("annotation_annotation", "count", null, kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}

		public void Delete(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("annotation_annotation", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void UpdateStatus(string id, KalturaCuePointStatus status)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("status", status);
			_Client.QueueServiceCall("annotation_annotation", "updateStatus", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaCuePoint Clone(string id, string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("annotation_annotation", "clone", "KalturaCuePoint", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCuePoint)KalturaObjectFactory.Create(result, "KalturaCuePoint");
		}
	}
}
