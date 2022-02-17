// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public sealed class PartnerOrderBy : StringEnum
	{
		public static readonly PartnerOrderBy ADMIN_EMAIL_ASC = new PartnerOrderBy("+adminEmail");
		public static readonly PartnerOrderBy ADMIN_NAME_ASC = new PartnerOrderBy("+adminName");
		public static readonly PartnerOrderBy CREATED_AT_ASC = new PartnerOrderBy("+createdAt");
		public static readonly PartnerOrderBy ID_ASC = new PartnerOrderBy("+id");
		public static readonly PartnerOrderBy NAME_ASC = new PartnerOrderBy("+name");
		public static readonly PartnerOrderBy STATUS_ASC = new PartnerOrderBy("+status");
		public static readonly PartnerOrderBy WEBSITE_ASC = new PartnerOrderBy("+website");
		public static readonly PartnerOrderBy ADMIN_EMAIL_DESC = new PartnerOrderBy("-adminEmail");
		public static readonly PartnerOrderBy ADMIN_NAME_DESC = new PartnerOrderBy("-adminName");
		public static readonly PartnerOrderBy CREATED_AT_DESC = new PartnerOrderBy("-createdAt");
		public static readonly PartnerOrderBy ID_DESC = new PartnerOrderBy("-id");
		public static readonly PartnerOrderBy NAME_DESC = new PartnerOrderBy("-name");
		public static readonly PartnerOrderBy STATUS_DESC = new PartnerOrderBy("-status");
		public static readonly PartnerOrderBy WEBSITE_DESC = new PartnerOrderBy("-website");

		private PartnerOrderBy(string name) : base(name) { }
	}
}
