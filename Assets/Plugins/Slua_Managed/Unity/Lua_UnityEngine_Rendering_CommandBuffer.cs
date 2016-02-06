﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_Rendering_CommandBuffer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer o;
			o=new UnityEngine.Rendering.CommandBuffer();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Dispose(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			self.Dispose();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Release(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			self.Release();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			self.Clear();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DrawMesh(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Mesh a1;
				checkType(l,2,out a1);
				UnityEngine.Matrix4x4 a2;
				checkValueType(l,3,out a2);
				UnityEngine.Material a3;
				checkType(l,4,out a3);
				self.DrawMesh(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Mesh a1;
				checkType(l,2,out a1);
				UnityEngine.Matrix4x4 a2;
				checkValueType(l,3,out a2);
				UnityEngine.Material a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				self.DrawMesh(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(argc==6){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Mesh a1;
				checkType(l,2,out a1);
				UnityEngine.Matrix4x4 a2;
				checkValueType(l,3,out a2);
				UnityEngine.Material a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				System.Int32 a5;
				checkType(l,6,out a5);
				self.DrawMesh(a1,a2,a3,a4,a5);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DrawRenderer(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Renderer a1;
				checkType(l,2,out a1);
				UnityEngine.Material a2;
				checkType(l,3,out a2);
				self.DrawRenderer(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Renderer a1;
				checkType(l,2,out a1);
				UnityEngine.Material a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				self.DrawRenderer(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Renderer a1;
				checkType(l,2,out a1);
				UnityEngine.Material a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				self.DrawRenderer(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetRenderTarget(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==2){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,2,out a1);
				self.SetRenderTarget(a1);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rendering.RenderTargetIdentifier[]),typeof(UnityEngine.Rendering.RenderTargetIdentifier))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier[] a1;
				checkType(l,2,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkValueType(l,3,out a2);
				self.SetRenderTarget(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rendering.RenderTargetIdentifier),typeof(UnityEngine.Rendering.RenderTargetIdentifier))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.RenderTargetIdentifier a1;
				checkValueType(l,2,out a1);
				UnityEngine.Rendering.RenderTargetIdentifier a2;
				checkValueType(l,3,out a2);
				self.SetRenderTarget(a1,a2);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Blit(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.Rendering.BuiltinRenderTextureType),typeof(int))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.BuiltinRenderTextureType a1;
				checkEnum(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.Blit(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rendering.BuiltinRenderTextureType),typeof(UnityEngine.RenderTexture))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.BuiltinRenderTextureType a1;
				checkEnum(l,2,out a1);
				UnityEngine.RenderTexture a2;
				checkType(l,3,out a2);
				self.Blit(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Texture),typeof(UnityEngine.RenderTexture))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Texture a1;
				checkType(l,2,out a1);
				UnityEngine.RenderTexture a2;
				checkType(l,3,out a2);
				self.Blit(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rendering.BuiltinRenderTextureType),typeof(int),typeof(UnityEngine.Material))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.BuiltinRenderTextureType a1;
				checkEnum(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.Material a3;
				checkType(l,4,out a3);
				self.Blit(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rendering.BuiltinRenderTextureType),typeof(UnityEngine.RenderTexture),typeof(UnityEngine.Material))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.BuiltinRenderTextureType a1;
				checkEnum(l,2,out a1);
				UnityEngine.RenderTexture a2;
				checkType(l,3,out a2);
				UnityEngine.Material a3;
				checkType(l,4,out a3);
				self.Blit(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Texture),typeof(UnityEngine.RenderTexture),typeof(UnityEngine.Material))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Texture a1;
				checkType(l,2,out a1);
				UnityEngine.RenderTexture a2;
				checkType(l,3,out a2);
				UnityEngine.Material a3;
				checkType(l,4,out a3);
				self.Blit(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rendering.BuiltinRenderTextureType),typeof(int),typeof(UnityEngine.Material),typeof(int))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.BuiltinRenderTextureType a1;
				checkEnum(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.Material a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				self.Blit(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Rendering.BuiltinRenderTextureType),typeof(UnityEngine.RenderTexture),typeof(UnityEngine.Material),typeof(int))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Rendering.BuiltinRenderTextureType a1;
				checkEnum(l,2,out a1);
				UnityEngine.RenderTexture a2;
				checkType(l,3,out a2);
				UnityEngine.Material a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				self.Blit(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Texture),typeof(UnityEngine.RenderTexture),typeof(UnityEngine.Material),typeof(int))){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				UnityEngine.Texture a1;
				checkType(l,2,out a1);
				UnityEngine.RenderTexture a2;
				checkType(l,3,out a2);
				UnityEngine.Material a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				self.Blit(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetTemporaryRT(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				self.GetTemporaryRT(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				self.GetTemporaryRT(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			else if(argc==6){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				UnityEngine.RenderTextureFormat a5;
				checkEnum(l,6,out a5);
				self.GetTemporaryRT(a1,a2,a3,a4,a5);
				pushValue(l,true);
				return 1;
			}
			else if(argc==7){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				UnityEngine.RenderTextureFormat a5;
				checkEnum(l,6,out a5);
				UnityEngine.RenderTextureReadWrite a6;
				checkEnum(l,7,out a6);
				self.GetTemporaryRT(a1,a2,a3,a4,a5,a6);
				pushValue(l,true);
				return 1;
			}
			else if(argc==8){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				System.Int32 a3;
				checkType(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				UnityEngine.RenderTextureFormat a5;
				checkEnum(l,6,out a5);
				UnityEngine.RenderTextureReadWrite a6;
				checkEnum(l,7,out a6);
				System.Int32 a7;
				checkType(l,8,out a7);
				self.GetTemporaryRT(a1,a2,a3,a4,a5,a6,a7);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ReleaseTemporaryRT(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			self.ReleaseTemporaryRT(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int ClearRenderTarget(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==4){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				UnityEngine.Color a3;
				checkType(l,4,out a3);
				self.ClearRenderTarget(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			else if(argc==5){
				UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
				System.Boolean a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				UnityEngine.Color a3;
				checkType(l,4,out a3);
				System.Single a4;
				checkType(l,5,out a4);
				self.ClearRenderTarget(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_name(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.name);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_name(IntPtr l) {
		try {
			UnityEngine.Rendering.CommandBuffer self=(UnityEngine.Rendering.CommandBuffer)checkSelf(l);
			string v;
			checkType(l,2,out v);
			self.name=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Rendering.CommandBuffer");
		addMember(l,Dispose);
		addMember(l,Release);
		addMember(l,Clear);
		addMember(l,DrawMesh);
		addMember(l,DrawRenderer);
		addMember(l,SetRenderTarget);
		addMember(l,Blit);
		addMember(l,GetTemporaryRT);
		addMember(l,ReleaseTemporaryRT);
		addMember(l,ClearRenderTarget);
		addMember(l,"name",get_name,set_name,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.Rendering.CommandBuffer));
	}
}