﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCacheSharp.Tests
{
	[TestClass]
	public class CacheFactoryTests
	{
		[TestMethod]
		public void ConstructCreatesCacheConstructor()
		{
			// Act
			var config = CacheFactory.Configure();

			// Assert
			Assert.IsNotNull( config );
			Assert.IsInstanceOfType( config, typeof(CacheConfiguration) );
		}
	}
}