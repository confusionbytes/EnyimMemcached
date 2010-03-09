﻿using System;

namespace Enyim.Caching.Memcached
{
	internal interface IProtocolImplementation : IDisposable
	{
		object Get(string key);
		bool TryGet(string key, out object value);

		bool Store(StoreMode mode, string key, object value, uint expiration);
		bool Delete(string key);
		ulong Mutate(MutationMode mode, string key, ulong startValue, ulong step, uint expiration);
		bool Concatenate(ConcatenationMode mode, string key, ArraySegment<byte> data);

		void FlushAll();
		ServerStats Stats();

		IAuthenticator CreateAuthenticator(ISaslAuthenticationProvider provider);
	}
}

#region [ License information          ]
/* ************************************************************
 *
 * Copyright (c) Attila Kiskó, enyim.com
 *
 * This source code is subject to terms and conditions of 
 * Microsoft Permissive License (Ms-PL).
 * 
 * A copy of the license can be found in the License.html
 * file at the root of this distribution. If you can not 
 * locate the License, please send an email to a@enyim.com
 * 
 * By using this source code in any fashion, you are 
 * agreeing to be bound by the terms of the Microsoft 
 * Permissive License.
 *
 * You must not remove this notice, or any other, from this
 * software.
 *
 * ************************************************************/
#endregion