﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASC.Mail.Resources {
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
    internal class MailCoreResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MailCoreResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ASC.Mail.Resources.MailCoreResource", typeof(MailCoreResource).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File &apos;{0}&apos; not found.
        /// </summary>
        internal static string FileNotFoundOrDamaged {
            get {
                return ResourceManager.GetString("FileNotFoundOrDamaged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} files not found.
        /// </summary>
        internal static string FilesNotFound {
            get {
                return ResourceManager.GetString("FilesNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Search in mail messages content.
        /// </summary>
        internal static string IndexTitle {
            get {
                return ResourceManager.GetString("IndexTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No attachments in message.
        /// </summary>
        internal static string NoAttachmentsInMessage {
            get {
                return ResourceManager.GetString("NoAttachmentsInMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating link.
        /// </summary>
        internal static string OperationCreatingLink {
            get {
                return ResourceManager.GetString("OperationCreatingLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Finished.
        /// </summary>
        internal static string OperationFinished {
            get {
                return ResourceManager.GetString("OperationFinished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Get attachments.
        /// </summary>
        internal static string OperationGetAttachments {
            get {
                return ResourceManager.GetString("OperationGetAttachments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Preparation archive.
        /// </summary>
        internal static string OperationPreparationArchive {
            get {
                return ResourceManager.GetString("OperationPreparationArchive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setup tenant and user.
        /// </summary>
        internal static string OperationSetupTenantAndUser {
            get {
                return ResourceManager.GetString("OperationSetupTenantAndUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Zipping attachments.
        /// </summary>
        internal static string OperationZippingAttachments {
            get {
                return ResourceManager.GetString("OperationZippingAttachments", resourceCulture);
            }
        }
    }
}
