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
// Copyright (C) 2006-2021  Kaltura Inc.
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
namespace Kaltura.Enums
{
	public sealed class AuditTrailAction : StringEnum
	{
		public static readonly AuditTrailAction CHANGED = new AuditTrailAction("CHANGED");
		public static readonly AuditTrailAction CONTENT_VIEWED = new AuditTrailAction("CONTENT_VIEWED");
		public static readonly AuditTrailAction COPIED = new AuditTrailAction("COPIED");
		public static readonly AuditTrailAction CREATED = new AuditTrailAction("CREATED");
		public static readonly AuditTrailAction DELETED = new AuditTrailAction("DELETED");
		public static readonly AuditTrailAction FILE_SYNC_CREATED = new AuditTrailAction("FILE_SYNC_CREATED");
		public static readonly AuditTrailAction RELATION_ADDED = new AuditTrailAction("RELATION_ADDED");
		public static readonly AuditTrailAction RELATION_REMOVED = new AuditTrailAction("RELATION_REMOVED");
		public static readonly AuditTrailAction VIEWED = new AuditTrailAction("VIEWED");

		private AuditTrailAction(string name) : base(name) { }
	}
}
