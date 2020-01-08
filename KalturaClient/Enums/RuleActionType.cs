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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public sealed class RuleActionType : StringEnum
	{
		public static readonly RuleActionType DRM_POLICY = new RuleActionType("drm.DRM_POLICY");
		public static readonly RuleActionType ADD_ENTRY_VENDOR_TASK = new RuleActionType("reach.ADD_ENTRY_VENDOR_TASK");
		public static readonly RuleActionType BLOCK = new RuleActionType("1");
		public static readonly RuleActionType PREVIEW = new RuleActionType("2");
		public static readonly RuleActionType LIMIT_FLAVORS = new RuleActionType("3");
		public static readonly RuleActionType ADD_TO_STORAGE = new RuleActionType("4");
		public static readonly RuleActionType LIMIT_DELIVERY_PROFILES = new RuleActionType("5");
		public static readonly RuleActionType SERVE_FROM_REMOTE_SERVER = new RuleActionType("6");
		public static readonly RuleActionType REQUEST_HOST_REGEX = new RuleActionType("7");
		public static readonly RuleActionType LIMIT_THUMBNAIL_CAPTURE = new RuleActionType("8");

		private RuleActionType(string name) : base(name) { }
	}
}
