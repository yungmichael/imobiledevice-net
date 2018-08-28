//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="LockdownPairRecordHandle.cs" company="Quamotion">
// Copyright (c) 2016-2018 Quamotion. All rights reserved.
// </copyright>

using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;

namespace iMobileDevice.Lockdown
{
    /// <summary>
    /// Represents a wrapper class for Lockdown handles.
    /// </summary>
    [SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode=true)]
    [SecurityPermission(SecurityAction.Demand, UnmanagedCode=true)]
    public partial class LockdownPairRecordHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        private string creationStackTrace;

        private ILibiMobileDevice api;

        /// <summary>
        /// Initializes a new instance of the <see cref="LockdownPairRecordHandle"/> class.
        /// </summary>
        protected LockdownPairRecordHandle() :
                base(true)
        {
            this.creationStackTrace = Environment.StackTrace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LockdownPairRecordHandle"/> class, specifying whether the handle is to be reliably released.
        /// </summary>
        /// <param name="ownsHandle">
        /// <see langword="true"/> to reliably release the handle during the finalization phase; <see langword="false"/> to prevent reliable release (not recommended).
        /// </param>
        protected LockdownPairRecordHandle(bool ownsHandle) :
                base(ownsHandle)
        {
            this.creationStackTrace = Environment.StackTrace;
        }

        /// <summary>
        /// Gets or sets the API to use
        /// </summary>
        public ILibiMobileDevice Api
        {
            get
            {
                return this.api;
            }
            set
            {
                this.api = value;
            }
        }

        /// <summary>
        /// Gets a value which represents a pointer or handle that has been initialized to zero.
        /// </summary>
        public static LockdownPairRecordHandle Zero
        {
            get
            {
                return LockdownPairRecordHandle.DangerousCreate(System.IntPtr.Zero);
            }
        }

        /// <inheritdoc/>
        [ReliabilityContractAttribute(Consistency.WillNotCorruptState, Cer.MayFail)]
        protected override bool ReleaseHandle()
        {
            return true;
        }
        
        /// <summary>
        /// Creates a new <see cref="LockdownPairRecordHandle"/> from a <see cref="IntPtr"/>.
        /// </summary>
        /// <param name="unsafeHandle">
        /// The underlying <see cref="IntPtr"/>
        /// </param>
        /// <param name="ownsHandle">
        /// <see langword="true"/> to reliably release the handle during the finalization phase; <see langword="false"/> to prevent reliable release (not recommended).
        /// </param>
        /// <returns>
        /// </returns>
        public static LockdownPairRecordHandle DangerousCreate(System.IntPtr unsafeHandle, bool ownsHandle)
        {
            LockdownPairRecordHandle safeHandle = new LockdownPairRecordHandle(ownsHandle);
            safeHandle.SetHandle(unsafeHandle);
            return safeHandle;
        }
        
        /// <summary>
        /// Creates a new <see cref="LockdownPairRecordHandle"/> from a <see cref="IntPtr"/>.
        /// </summary>
        /// <param name="unsafeHandle">
        /// The underlying <see cref="IntPtr"/>
        /// </param>
        /// <returns>
        /// </returns>
        public static LockdownPairRecordHandle DangerousCreate(System.IntPtr unsafeHandle)
        {
            return LockdownPairRecordHandle.DangerousCreate(unsafeHandle, true);
        }
        
        /// <inheritdoc/>
        public override string ToString()
        {
            return string.Format("{0} ({1})", this.handle, "LockdownPairRecordHandle");
        }
        
        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj != null && obj.GetType() == typeof(LockdownPairRecordHandle))
            {
                return ((LockdownPairRecordHandle)obj).handle.Equals(this.handle);
            }
            else
            {
                return false;
            }
        }
        
        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return this.handle.GetHashCode();
        }
        
        /// <summary>
        /// Determines whether two specified instances of <see cref="LockdownPairRecordHandle"/> are equal.
        /// </summary>
        /// <param name="value1">
        /// The first pointer or handle to compare.
        /// </param>
        /// <param name="value2">
        /// The second pointer or handle to compare.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if <paramref name="value1"/> equals <paramref name="value2"/>; otherwise, <see langword="false"/>.
        /// </returns>
        public static bool operator == (LockdownPairRecordHandle value1, LockdownPairRecordHandle value2) 
        {
            if (object.Equals(value1, null) && object.Equals(value2, null))
            {
                return true;
            }
        
            if (object.Equals(value1, null) || object.Equals(value2, null))
            {
                return false;
            }
        
            return value1.handle == value2.handle;
        }
        
        /// <summary>
        /// Determines whether two specified instances of <see cref="LockdownPairRecordHandle"/> are not equal.
        /// </summary>
        /// <param name="value1">
        /// The first pointer or handle to compare.
        /// </param>
        /// <param name="value2">
        /// The second pointer or handle to compare.
        /// </param>
        /// <returns>
        /// <see langword="true"/> if <paramref name="value1"/> does not equal <paramref name="value2"/>; otherwise, <see langword="false"/>.
        /// </returns>
        public static bool operator != (LockdownPairRecordHandle value1, LockdownPairRecordHandle value2) 
        {
            if (object.Equals(value1, null) && object.Equals(value2, null))
            {
                return false;
            }
        
            if (object.Equals(value1, null) || object.Equals(value2, null))
            {
                return true;
            }
        
            return value1.handle != value2.handle;
        }
    }
}
