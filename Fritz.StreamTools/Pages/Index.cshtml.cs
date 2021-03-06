﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fritz.StreamTools.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fritz.StreamTools.Pages
{
	public class IndexModel : PageModel
	{

		public IndexModel(Models.RundownRepository repo)
		{
			this.Repository = repo;
		}

		public RundownRepository Repository { get; private set; }

		public void OnGet()
		{

		}
	}
}