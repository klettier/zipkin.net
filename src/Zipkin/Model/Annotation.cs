﻿namespace Zipkin
{
	using System;

	public class Annotation
	{
		public Annotation()
		{
			Timestamp = DateTimeOffset.UtcNow;
		}

		/// <summary>
		/// The host that recorded {@link #value}, primarily for query by service name.
		/// </summary>
		public Endpoint Host;

		/// <summary>
		/// Microseconds from epoch.
		/// </summary>
		public DateTimeOffset Timestamp;

		/// <summary>
		/// Usually a short tag indicating an event, like {@link Constants#SERVER_RECV "sr"}. or {@link Constants#ERROR "error"}
		/// </summary>
		public string Value;
	}
}