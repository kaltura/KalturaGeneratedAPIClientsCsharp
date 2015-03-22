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
// Copyright (C) 2006-2011  Kaltura Inc.
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
namespace Kaltura
{
	public sealed class KalturaAuditTrailAction : KalturaStringEnum
	{
		public static readonly KalturaAuditTrailAction CHANGED = new KalturaAuditTrailAction("CHANGED");
		public static readonly KalturaAuditTrailAction CONTENT_VIEWED = new KalturaAuditTrailAction("CONTENT_VIEWED");
		public static readonly KalturaAuditTrailAction COPIED = new KalturaAuditTrailAction("COPIED");
		public static readonly KalturaAuditTrailAction CREATED = new KalturaAuditTrailAction("CREATED");
		public static readonly KalturaAuditTrailAction DELETED = new KalturaAuditTrailAction("DELETED");
		public static readonly KalturaAuditTrailAction FILE_SYNC_CREATED = new KalturaAuditTrailAction("FILE_SYNC_CREATED");
		public static readonly KalturaAuditTrailAction RELATION_ADDED = new KalturaAuditTrailAction("RELATION_ADDED");
		public static readonly KalturaAuditTrailAction RELATION_REMOVED = new KalturaAuditTrailAction("RELATION_REMOVED");
		public static readonly KalturaAuditTrailAction VIEWED = new KalturaAuditTrailAction("VIEWED");

		private KalturaAuditTrailAction(string name) : base(name) { }
	}
}
