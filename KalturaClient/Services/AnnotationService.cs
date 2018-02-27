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
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;

namespace Kaltura.Services
{
	public class AnnotationAddRequestBuilder : RequestBuilder<Annotation>
	{
		#region Constants
		public const string ANNOTATION = "annotation";
		#endregion

		public CuePoint Annotation
		{
			set;
			get;
		}

		public AnnotationAddRequestBuilder()
			: base("annotation_annotation", "add")
		{
		}

		public AnnotationAddRequestBuilder(CuePoint annotation)
			: this()
		{
			this.Annotation = annotation;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("annotation"))
				kparams.AddIfNotNull("annotation", Annotation);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<Annotation>(result);
		}
	}

	public class AnnotationAddFromBulkRequestBuilder : RequestBuilder<ListResponse<CuePoint>>
	{
		#region Constants
		public const string FILE_DATA = "fileData";
		#endregion

		public Stream FileData
		{
			set;
			get;
		}

		public AnnotationAddFromBulkRequestBuilder()
			: base("annotation_annotation", "addFromBulk")
		{
		}

		public AnnotationAddFromBulkRequestBuilder(Stream fileData)
			: this()
		{
			this.FileData = fileData;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			kfiles.Add("fileData", FileData);
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ListResponse<CuePoint>>(result);
		}
	}

	public class AnnotationCloneRequestBuilder : RequestBuilder<CuePoint>
	{
		#region Constants
		public const string ID = "id";
		public const string ENTRY_ID = "entryId";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public string EntryId
		{
			set;
			get;
		}

		public AnnotationCloneRequestBuilder()
			: base("annotation_annotation", "clone")
		{
		}

		public AnnotationCloneRequestBuilder(string id, string entryId)
			: this()
		{
			this.Id = id;
			this.EntryId = entryId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<CuePoint>(result);
		}
	}

	public class AnnotationCountRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		public const string FILTER = "filter";
		#endregion

		public CuePointFilter Filter
		{
			set;
			get;
		}

		public AnnotationCountRequestBuilder()
			: base("annotation_annotation", "count")
		{
		}

		public AnnotationCountRequestBuilder(CuePointFilter filter)
			: this()
		{
			this.Filter = filter;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return int.Parse(result.InnerText);
		}
	}

	public class AnnotationDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public AnnotationDeleteRequestBuilder()
			: base("annotation_annotation", "delete")
		{
		}

		public AnnotationDeleteRequestBuilder(string id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return null;
		}
	}

	public class AnnotationGetRequestBuilder : RequestBuilder<CuePoint>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public AnnotationGetRequestBuilder()
			: base("annotation_annotation", "get")
		{
		}

		public AnnotationGetRequestBuilder(string id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<CuePoint>(result);
		}
	}

	public class AnnotationListRequestBuilder : RequestBuilder<ListResponse<Annotation>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public CuePointFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public AnnotationListRequestBuilder()
			: base("annotation_annotation", "list")
		{
		}

		public AnnotationListRequestBuilder(CuePointFilter filter, FilterPager pager)
			: this()
		{
			this.Filter = filter;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ListResponse<Annotation>>(result);
		}
	}

	public class AnnotationUpdateRequestBuilder : RequestBuilder<Annotation>
	{
		#region Constants
		public const string ID = "id";
		public const string ANNOTATION = "annotation";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public CuePoint Annotation
		{
			set;
			get;
		}

		public AnnotationUpdateRequestBuilder()
			: base("annotation_annotation", "update")
		{
		}

		public AnnotationUpdateRequestBuilder(string id, CuePoint annotation)
			: this()
		{
			this.Id = id;
			this.Annotation = annotation;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("annotation"))
				kparams.AddIfNotNull("annotation", Annotation);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<Annotation>(result);
		}
	}

	public class AnnotationUpdateStatusRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		public const string STATUS = "status";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public CuePointStatus Status
		{
			set;
			get;
		}

		public AnnotationUpdateStatusRequestBuilder()
			: base("annotation_annotation", "updateStatus")
		{
		}

		public AnnotationUpdateStatusRequestBuilder(string id, CuePointStatus status)
			: this()
		{
			this.Id = id;
			this.Status = status;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("status"))
				kparams.AddIfNotNull("status", Status);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return null;
		}
	}


	public class AnnotationService
	{
		private AnnotationService()
		{
		}

		public static AnnotationAddRequestBuilder Add(CuePoint annotation)
		{
			return new AnnotationAddRequestBuilder(annotation);
		}

		public static AnnotationAddFromBulkRequestBuilder AddFromBulk(Stream fileData)
		{
			return new AnnotationAddFromBulkRequestBuilder(fileData);
		}

		public static AnnotationCloneRequestBuilder Clone(string id, string entryId)
		{
			return new AnnotationCloneRequestBuilder(id, entryId);
		}

		public static AnnotationCountRequestBuilder Count(CuePointFilter filter = null)
		{
			return new AnnotationCountRequestBuilder(filter);
		}

		public static AnnotationDeleteRequestBuilder Delete(string id)
		{
			return new AnnotationDeleteRequestBuilder(id);
		}

		public static AnnotationGetRequestBuilder Get(string id)
		{
			return new AnnotationGetRequestBuilder(id);
		}

		public static AnnotationListRequestBuilder List(CuePointFilter filter = null, FilterPager pager = null)
		{
			return new AnnotationListRequestBuilder(filter, pager);
		}

		public static AnnotationUpdateRequestBuilder Update(string id, CuePoint annotation)
		{
			return new AnnotationUpdateRequestBuilder(id, annotation);
		}

		public static AnnotationUpdateStatusRequestBuilder UpdateStatus(string id, CuePointStatus status)
		{
			return new AnnotationUpdateStatusRequestBuilder(id, status);
		}
	}
}
