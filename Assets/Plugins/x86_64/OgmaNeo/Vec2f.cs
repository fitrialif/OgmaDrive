//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace ogmaneo {

public class Vec2f : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Vec2f(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Vec2f obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Vec2f() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          csogmaneoPINVOKE.delete_Vec2f(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public float x {
    set {
      csogmaneoPINVOKE.Vec2f_x_set(swigCPtr, value);
    } 
    get {
      float ret = csogmaneoPINVOKE.Vec2f_x_get(swigCPtr);
      return ret;
    } 
  }

  public float y {
    set {
      csogmaneoPINVOKE.Vec2f_y_set(swigCPtr, value);
    } 
    get {
      float ret = csogmaneoPINVOKE.Vec2f_y_get(swigCPtr);
      return ret;
    } 
  }

  public Vec2f() : this(csogmaneoPINVOKE.new_Vec2f__SWIG_0(), true) {
  }

  public Vec2f(float X, float Y) : this(csogmaneoPINVOKE.new_Vec2f__SWIG_1(X, Y), true) {
  }

  public Vec2f(int X, int Y) : this(csogmaneoPINVOKE.new_Vec2f__SWIG_2(X, Y), true) {
  }

}

}