//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#nullable restore
using System;
using System.Collections.Generic;
using Java.Interop;

namespace Test.ME {

	// Metadata.xml XPath class reference: path="/api/package[@name='test.me']/class[@name='GenericStringImplementation']"
	[global::Java.Interop.JniTypeSignature ("test/me/GenericStringImplementation", GenerateJavaPeer=false)]
	public partial class GenericStringImplementation : global::Java.Lang.Object, global::Test.ME.IGenericInterface {
		static readonly JniPeerMembers _members = new JniPeerMembers ("test/me/GenericStringImplementation", typeof (GenericStringImplementation));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected GenericStringImplementation (ref JniObjectReference reference, JniObjectReferenceOptions options) : base (ref reference, options)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='test.me']/class[@name='GenericStringImplementation']/constructor[@name='GenericStringImplementation' and count(parameter)=0]"
		[global::Java.Interop.JniConstructorSignature ("()V")]
		public unsafe GenericStringImplementation () : base (ref *InvalidJniObjectReference, JniObjectReferenceOptions.None)
		{
			const string __id = "()V";

			if (PeerReference.IsValid)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				Construct (ref __r, JniObjectReferenceOptions.CopyAndDispose);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='test.me']/class[@name='GenericStringImplementation']/method[@name='SetObject' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[global::Java.Interop.JniMethodSignature ("SetObject", "([Ljava/lang/String;)V")]
		public virtual unsafe void SetObject (global::Java.Interop.JavaObjectArray<string> value)
		{
			const string __id = "SetObject.([Ljava/lang/String;)V";
			var native_value = global::Java.Interop.JniEnvironment.Arrays.CreateMarshalObjectArray<string> (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (native_value != null) {
					native_value.DisposeUnlessReferenced ();
				}
				global::System.GC.KeepAlive (value);
			}
		}

		// This method is explicitly implemented as a member of an instantiated Test.ME.IGenericInterface
		void global::Test.ME.IGenericInterface.SetObject (global::Java.Lang.Object value)
		{
			SetObject (global::Java.Interop.JniEnvironment.Runtime.ValueManager.GetValue<global::Java.Interop.JavaObjectArray<string>>((value?.PeerReference ?? default).Handle));
		}

	}
}
