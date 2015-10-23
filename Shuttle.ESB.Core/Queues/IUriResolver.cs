﻿using System;

namespace Shuttle.ESB.Core
{
	public interface IUriResolver
	{
		Uri Get(string forUri);
		void Add(string sourceUri, string targetUri);
		void Add(string sourceUri, Uri targetUri);
	}
}