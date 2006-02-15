// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision$</version>
// </file>

// This file is automatically generated - any changes will be lost

namespace Debugger.Wrappers.CorSym
{
	using System;
	
	
	public partial class CorSymBinder_deprecatedClass
	{
		
		private Debugger.Interop.CorSym.CorSymBinder_deprecatedClass wrappedObject;
		
		internal Debugger.Interop.CorSym.CorSymBinder_deprecatedClass WrappedObject
		{
			get
			{
				return this.wrappedObject;
			}
		}
		
		public CorSymBinder_deprecatedClass(Debugger.Interop.CorSym.CorSymBinder_deprecatedClass wrappedObject)
		{
			this.wrappedObject = wrappedObject;
			ResourceManager.TrackCOMObject(wrappedObject, typeof(CorSymBinder_deprecatedClass));
		}
		
		public static CorSymBinder_deprecatedClass Wrap(Debugger.Interop.CorSym.CorSymBinder_deprecatedClass objectToWrap)
		{
			return new CorSymBinder_deprecatedClass(objectToWrap);
		}
		
		~CorSymBinder_deprecatedClass()
		{
			object o = wrappedObject;
			wrappedObject = null;
			ResourceManager.ReleaseCOMObject(o, typeof(CorSymBinder_deprecatedClass));
		}
		
		public bool Is<T>() where T: class
		{
			try {
				CastTo<T>();
				return true;
			} catch {
				return false;
			}
		}
		
		public T As<T>() where T: class
		{
			try {
				return CastTo<T>();
			} catch {
				return null;
			}
		}
		
		public T CastTo<T>() where T: class
		{
			return (T)Activator.CreateInstance(typeof(T), this.WrappedObject);
		}
		
		public static bool operator ==(CorSymBinder_deprecatedClass o1, CorSymBinder_deprecatedClass o2)
		{
			return ((object)o1 == null && (object)o2 == null) ||
			       ((object)o1 != null && (object)o2 != null && o1.WrappedObject == o2.WrappedObject);
		}
		
		public static bool operator !=(CorSymBinder_deprecatedClass o1, CorSymBinder_deprecatedClass o2)
		{
			return !(o1 == o2);
		}
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
		
		public override bool Equals(object o)
		{
			CorSymBinder_deprecatedClass casted = o as CorSymBinder_deprecatedClass;
			return (casted != null) && (casted.WrappedObject == wrappedObject);
		}
		
		
		public ISymUnmanagedReader GetReaderForFile(object importer, System.IntPtr filename, System.IntPtr searchPath)
		{
			return ISymUnmanagedReader.Wrap(this.WrappedObject.GetReaderForFile(importer, filename, searchPath));
		}
		
		public ISymUnmanagedReader GetReaderFromStream(object importer, IStream pstream)
		{
			return ISymUnmanagedReader.Wrap(this.WrappedObject.GetReaderFromStream(importer, pstream.WrappedObject));
		}
	}
}
