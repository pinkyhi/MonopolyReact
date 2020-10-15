﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Monopoly.Core.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Monopoly.Core.Resources.ErrorMessages", typeof(ErrorMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wrong model data.
        /// </summary>
        public static string BadModelData {
            get {
                return ResourceManager.GetString("BadModelData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This email is already occupied.
        /// </summary>
        public static string EmailOccupiedException {
            get {
                return ResourceManager.GetString("EmailOccupiedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Something went wrong on server.
        /// </summary>
        public static string GuessNumberException {
            get {
                return ResourceManager.GetString("GuessNumberException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid password.
        /// </summary>
        public static string InvalidPasswordException {
            get {
                return ResourceManager.GetString("InvalidPasswordException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid refresh token.
        /// </summary>
        public static string InvalidRefreshTokenException {
            get {
                return ResourceManager.GetString("InvalidRefreshTokenException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Refresh token is expired.
        /// </summary>
        public static string RefreshTokenIsExpiredException {
            get {
                return ResourceManager.GetString("RefreshTokenIsExpiredException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Refresh token is invalidated.
        /// </summary>
        public static string RefreshTokenIsInvalidatedException {
            get {
                return ResourceManager.GetString("RefreshTokenIsInvalidatedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Refresh token is used.
        /// </summary>
        public static string RefreshTokenIsUsedException {
            get {
                return ResourceManager.GetString("RefreshTokenIsUsedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Refresh token not found.
        /// </summary>
        public static string RefreshTokenNotFoundException {
            get {
                return ResourceManager.GetString("RefreshTokenNotFoundException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Refresh token is wrong cause wrong jti.
        /// </summary>
        public static string RefreshTokenWrongJtiException {
            get {
                return ResourceManager.GetString("RefreshTokenWrongJtiException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Token isn&apos;t expired.
        /// </summary>
        public static string TokenIsNotExpiredExeption {
            get {
                return ResourceManager.GetString("TokenIsNotExpiredExeption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Token refreshing error, access token may be invalid.
        /// </summary>
        public static string TokenRefreshingException {
            get {
                return ResourceManager.GetString("TokenRefreshingException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown error :(.
        /// </summary>
        public static string Unknown {
            get {
                return ResourceManager.GetString("Unknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This username is already occupied.
        /// </summary>
        public static string UsernameOccupiedException {
            get {
                return ResourceManager.GetString("UsernameOccupiedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown user.
        /// </summary>
        public static string UserUnknownException {
            get {
                return ResourceManager.GetString("UserUnknownException", resourceCulture);
            }
        }
    }
}
