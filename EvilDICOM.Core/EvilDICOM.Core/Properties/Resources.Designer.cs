﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EvilDICOM.Core.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EvilDICOM.Core.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;dictionary tagclass=&quot;org.dcm4che2.data.Tag&quot;&gt;
        ///  &lt;element tag=&quot;00000000&quot; keyword=&quot;CommandGroupLength&quot; vr=&quot;UL&quot; vm=&quot;1&quot; ret=&quot;&quot;&gt;Command Group Length&lt;/element&gt;
        ///  &lt;element tag=&quot;00000001&quot; keyword=&quot;CommandLengthToEnd&quot; vr=&quot;UL&quot; vm=&quot;1&quot; ret=&quot;RET&quot;&gt;Length to End&lt;/element&gt;
        ///  &lt;element tag=&quot;00000002&quot; keyword=&quot;AffectedSOPClassUID&quot; vr=&quot;UI&quot; vm=&quot;1&quot; ret=&quot;&quot;&gt;Affected SOP Class UID&lt;/element&gt;
        ///  &lt;element tag=&quot;00000003&quot; keyword=&quot;RequestedSOPClassUID&quot; vr=&quot;UI&quot; vm=&quot;1&quot; ret=&quot;&quot;&gt;Requested SOP Class UID&lt;/ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string DICOMDictionary {
            get {
                return ResourceManager.GetString("DICOMDictionary", resourceCulture);
            }
        }
    }
}
