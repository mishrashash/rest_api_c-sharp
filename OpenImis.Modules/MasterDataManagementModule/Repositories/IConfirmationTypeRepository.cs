﻿using OpenImis.Modules.MasterDataManagementModule.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenImis.Modules.MasterDataManagementModule.Repositories
{
	public interface IConfirmationTypeRepository
	{
		Task<ConfirmationTypeModel[]> GetAllConfirmationsTypes();
		Task<ConfirmationTypeModel[]> GetConfirmationTypesByLanguage(string language);
	}
}
