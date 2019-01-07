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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public enum DropFolderFileStatus
	{
		UPLOADING = 1,
		PENDING = 2,
		WAITING = 3,
		HANDLED = 4,
		IGNORE = 5,
		DELETED = 6,
		PURGED = 7,
		NO_MATCH = 8,
		ERROR_HANDLING = 9,
		ERROR_DELETING = 10,
		DOWNLOADING = 11,
		ERROR_DOWNLOADING = 12,
		PROCESSING = 13,
		PARSED = 14,
		DETECTED = 15,
	}
}
