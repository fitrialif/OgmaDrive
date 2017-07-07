//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace eogmaneo {

public class WeightSet : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal WeightSet(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(WeightSet obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~WeightSet() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          eogmaneoPINVOKE.delete_WeightSet(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string _name {
    set {
      eogmaneoPINVOKE.WeightSet__name_set(swigCPtr, value);
      if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = eogmaneoPINVOKE.WeightSet__name_get(swigCPtr);
      if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_sf__Uint16 _radius {
    set {
      eogmaneoPINVOKE.WeightSet__radius_set(swigCPtr, SWIGTYPE_p_sf__Uint16.getCPtr(value));
      if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_sf__Uint16 ret = new SWIGTYPE_p_sf__Uint16(eogmaneoPINVOKE.WeightSet__radius_get(swigCPtr), true);
      if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public StdVecf _weights {
    set {
      eogmaneoPINVOKE.WeightSet__weights_set(swigCPtr, StdVecf.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = eogmaneoPINVOKE.WeightSet__weights_get(swigCPtr);
      StdVecf ret = (cPtr == global::System.IntPtr.Zero) ? null : new StdVecf(cPtr, false);
      return ret;
    } 
  }

  public WeightSet() : this(eogmaneoPINVOKE.new_WeightSet(), true) {
  }

}

}