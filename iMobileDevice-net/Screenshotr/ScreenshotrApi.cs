// <copyright file="ScreenshotrApi.cs" company="Quamotion">
// Copyright (c) 2016-2018 Quamotion. All rights reserved.
// </copyright>

namespace iMobileDevice.Screenshotr
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public partial class ScreenshotrApi : IScreenshotrApi
    {
        
        /// <summary>
        /// Backing field for the <see cref="Parent"/> property
        /// </summary>
        private ILibiMobileDevice parent;
        
        /// <summary>
        /// Initializes a new instance of the <see cref"ScreenshotrApi"/> class
        /// </summary>
        /// <param name="parent">
        /// The <see cref="ILibiMobileDeviceApi"/> which owns this <see cref="Screenshotr"/>.
        /// </summary>
        public ScreenshotrApi(ILibiMobileDevice parent)
        {
            this.parent = parent;
        }
        
        /// <inheritdoc/>
        public ILibiMobileDevice Parent
        {
            get
            {
                return this.parent;
            }
        }
        
        /// <summary>
        /// Connects to the screenshotr service on the specified device.
        /// </summary>
        /// <param name="device">
        /// The device to connect to.
        /// </param>
        /// <param name="service">
        /// The service descriptor returned by lockdownd_start_service.
        /// </param>
        /// <param name="client">
        /// Pointer that will be set to a newly allocated
        /// screenshotr_client_t upon successful return.
        /// </param>
        /// <returns>
        /// SCREENSHOTR_E_SUCCESS on success, SCREENSHOTR_E_INVALID ARG if one
        /// or more parameters are invalid, or SCREENSHOTR_E_CONN_FAILED if the
        /// connection to the device could not be established.
        /// </returns>
        /// <remarks>
        /// This service is only available if a developer disk image has been
        /// mounted.
        /// </remarks>
        public virtual ScreenshotrError screenshotr_client_new(iDeviceHandle device, LockdownServiceDescriptorHandle service, out ScreenshotrClientHandle client)
        {
            ScreenshotrError returnValue;
            returnValue = ScreenshotrNativeMethods.screenshotr_client_new(device, service, out client);
            client.Api = this.Parent;
            return returnValue;
        }
        
        /// <summary>
        /// Starts a new screenshotr service on the specified device and connects to it.
        /// </summary>
        /// <param name="device">
        /// The device to connect to.
        /// </param>
        /// <param name="client">
        /// Pointer that will point to a newly allocated
        /// screenshotr_client_t upon successful return. Must be freed using
        /// screenshotr_client_free() after use.
        /// </param>
        /// <param name="label">
        /// The label to use for communication. Usually the program name.
        /// Pass NULL to disable sending the label in requests to lockdownd.
        /// </param>
        /// <returns>
        /// SCREENSHOTR_E_SUCCESS on success, or an SCREENSHOTR_E_* error
        /// code otherwise.
        /// </returns>
        public virtual ScreenshotrError screenshotr_client_start_service(iDeviceHandle device, out ScreenshotrClientHandle client, string label)
        {
            ScreenshotrError returnValue;
            returnValue = ScreenshotrNativeMethods.screenshotr_client_start_service(device, out client, label);
            client.Api = this.Parent;
            return returnValue;
        }
        
        /// <summary>
        /// Disconnects a screenshotr client from the device and frees up the
        /// screenshotr client data.
        /// </summary>
        /// <param name="client">
        /// The screenshotr client to disconnect and free.
        /// </param>
        /// <returns>
        /// SCREENSHOTR_E_SUCCESS on success, or SCREENSHOTR_E_INVALID_ARG
        /// if client is NULL.
        /// </returns>
        public virtual ScreenshotrError screenshotr_client_free(System.IntPtr client)
        {
            return ScreenshotrNativeMethods.screenshotr_client_free(client);
        }
        
        /// <summary>
        /// Get a screen shot from the connected device.
        /// </summary>
        /// <param name="client">
        /// The connection screenshotr service client.
        /// </param>
        /// <param name="imgdata">
        /// Pointer that will point to a newly allocated buffer
        /// containing TIFF image data upon successful return. It is up to the
        /// caller to free the memory.
        /// </param>
        /// <param name="imgsize">
        /// Pointer to a uint64_t that will be set to the size of the
        /// buffer imgdata points to upon successful return.
        /// </param>
        /// <returns>
        /// SCREENSHOTR_E_SUCCESS on success, SCREENSHOTR_E_INVALID_ARG if
        /// one or more parameters are invalid, or another error code if an
        /// error occured.
        /// </returns>
        public virtual ScreenshotrError screenshotr_take_screenshot(ScreenshotrClientHandle client, ref System.IntPtr imgdata, ref ulong imgsize)
        {
            return ScreenshotrNativeMethods.screenshotr_take_screenshot(client, ref imgdata, ref imgsize);
        }
        
        /// <summary>
        /// Frees the memory used by a screen shot
        /// </summary>
        /// <param name="imgdata">
        /// The screenshot
        /// </param>
        /// <returns>
        /// SCREENSHOTR_E_SUCCESS on success
        /// </returns>
        public virtual ScreenshotrError screenshotr_screenshot_free(System.IntPtr imgdata)
        {
            return ScreenshotrNativeMethods.screenshotr_screenshot_free(imgdata);
        }
    }
}
