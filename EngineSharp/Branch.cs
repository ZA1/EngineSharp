﻿using System;
using System.Collections.Generic;

namespace EngineSample
{
	public class Branch : EngineResource
	{
    private const string path = "branches";

		public string name { get; set; }
		public string description { get; set; }
		public string source_reference { get; set; }

    public Branch Update() {
      return Branch.Update (this);
    }

		public static List<Branch> All() {
      return EngineResource.All<Branch> (path);
		}

    public static Branch Create(Branch branch) {
      return EngineResource.Create<Branch> (branch, path);
    }

    public static Branch Update(Branch branch) {
      return EngineResource.Update<Branch> (branch, path);
    }

	}
}
