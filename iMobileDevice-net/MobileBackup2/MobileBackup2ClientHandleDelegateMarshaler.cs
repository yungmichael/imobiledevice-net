﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="MobileBackup2ClientHandleDelegateMarshaler.cs" company="Quamotion">
// Copyright (c) 2016-2019 Quamotion. All rights reserved.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.MobileBackup2
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public partial class MobileBackup2ClientHandleDelegateMarshaler : System.Runtime.InteropServices.ICustomMarshaler
    {
        
        public static System.Runtime.InteropServices.ICustomMarshaler GetInstance(string cookie)
        {
            return new MobileBackup2ClientHandleDelegateMarshaler();
        }
        
        public void CleanUpManagedData(object managedObject)
        {
        }
        
        public void CleanUpNativeData(System.IntPtr nativeData)
        {
        }
        
        public int GetNativeDataSize()
        {
            return -1;
        }
        
        public System.IntPtr MarshalManagedToNative(object managedObject)
        {
            return System.IntPtr.Zero;
        }
        
        public object MarshalNativeToManaged(System.IntPtr nativeData)
        {
            return MobileBackup2ClientHandle.DangerousCreate(nativeData, false);
        }
    }
}
