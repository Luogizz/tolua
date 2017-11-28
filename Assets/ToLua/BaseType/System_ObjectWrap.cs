﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using System.Runtime.InteropServices;
using LuaInterface;

public class System_ObjectWrap
{
	public static void Register(LuaState L)
	{
		IntPtr lazyWrapFunc = Marshal.GetFunctionPointerForDelegate((LuaCSFunction)LazyWrap);
		IntPtr lazyVarWrapFunc = Marshal.GetFunctionPointerForDelegate((LuaCSFunction)LazyVarWrap);
		L.BeginClass(typeof(System.Object), null);
		L.RegLazyFunction("Equals", lazyWrapFunc);
		L.RegLazyFunction("GetHashCode", lazyWrapFunc);
		L.RegLazyFunction("GetType", lazyWrapFunc);
		L.RegLazyFunction("ToString", lazyWrapFunc);
		L.RegLazyFunction("ReferenceEquals", lazyWrapFunc);
		L.RegLazyFunction("Destroy", lazyWrapFunc);
		L.RegLazyFunction("New", lazyWrapFunc);
		L.RegFunction("__eq", op_Equality);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSystem_Object(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				System.Object obj = new System.Object();
				ToLua.Push(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: System.Object.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Equals(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			object obj = ToLua.CheckObject(L, 1);
			object arg0 = ToLua.ToVarObject(L, 2);
			bool o = obj != null ? obj.Equals(arg0) : arg0 == null;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHashCode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			object obj = ToLua.CheckObject(L, 1);
			int o = obj.GetHashCode();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			object obj = ToLua.CheckObject(L, 1);
			System.Type o = obj.GetType();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ToString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			object obj = ToLua.CheckObject(L, 1);
			string o = obj.ToString();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReferenceEquals(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			object arg0 = ToLua.ToVarObject(L, 1);
			object arg1 = ToLua.ToVarObject(L, 2);
			bool o = System.Object.ReferenceEquals(arg0, arg1);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			object arg0 = ToLua.ToVarObject(L, 1);
			object arg1 = ToLua.ToVarObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Destroy(IntPtr L)
	{
		return ToLua.Destroy(L);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LazyWrap(IntPtr L)
	{
		try
		{
			int stackTop = LuaDLL.lua_gettop(L);
			bool lazy = LuaDLL.luaL_checkboolean(L, stackTop);
			string key = LuaDLL.lua_tostring(L, stackTop - 1);
			LuaDLL.lua_pop(L, 2);

			switch (key)
			{
				case "New":
					return ToLua.LazyRegisterFunc(lazy, "New", _CreateSystem_Object, ref L);
				case "Equals":
					return ToLua.LazyRegisterFunc(lazy, "Equals", Equals, ref L);
				case "GetHashCode":
					return ToLua.LazyRegisterFunc(lazy, "GetHashCode", GetHashCode, ref L);
				case "GetType":
					return ToLua.LazyRegisterFunc(lazy, "GetType", GetType, ref L);
				case "ToString":
					return ToLua.LazyRegisterFunc(lazy, "ToString", ToString, ref L);
				case "ReferenceEquals":
					return ToLua.LazyRegisterFunc(lazy, "ReferenceEquals", ReferenceEquals, ref L);
				case "op_Equality":
					return ToLua.LazyRegisterFunc(lazy, "op_Equality", op_Equality, ref L);
				case "Destroy":
					return ToLua.LazyRegisterFunc(lazy, "Destroy", Destroy, ref L);
			}
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LazyVarWrap(IntPtr L)
	{
		try
		{
			int stackTop = LuaDLL.lua_gettop(L);
			bool getStatus = LuaDLL.luaL_checkboolean(L, stackTop);
			bool lazy = LuaDLL.luaL_checkboolean(L, stackTop - 1);
			string key = LuaDLL.lua_tostring(L, stackTop - 2);
			LuaDLL.lua_pop(L, 3);

			switch (key)
			{
			}
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

