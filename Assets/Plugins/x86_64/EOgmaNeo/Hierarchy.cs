//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace eogmaneo {

public class Hierarchy : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Hierarchy(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Hierarchy obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Hierarchy() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          eogmaneoPINVOKE.delete_Hierarchy(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public void create(StdVecPairi inputSizes, StdVeci inputChunkSizes, StdVecb predictInputs, StdVecLayerDesc layerDescs, uint seed) {
    eogmaneoPINVOKE.Hierarchy_create(swigCPtr, StdVecPairi.getCPtr(inputSizes), StdVeci.getCPtr(inputChunkSizes), StdVecb.getCPtr(predictInputs), StdVecLayerDesc.getCPtr(layerDescs), seed);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool load(string fileName) {
    bool ret = eogmaneoPINVOKE.Hierarchy_load(swigCPtr, fileName);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void save(string fileName) {
    eogmaneoPINVOKE.Hierarchy_save(swigCPtr, fileName);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void step(Std2DVeci inputs, ComputeSystem system, bool learn, float reward) {
    eogmaneoPINVOKE.Hierarchy_step__SWIG_0(swigCPtr, Std2DVeci.getCPtr(inputs), ComputeSystem.getCPtr(system), learn, reward);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void step(Std2DVeci inputs, ComputeSystem system, bool learn) {
    eogmaneoPINVOKE.Hierarchy_step__SWIG_1(swigCPtr, Std2DVeci.getCPtr(inputs), ComputeSystem.getCPtr(system), learn);
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void step(Std2DVeci inputs, ComputeSystem system) {
    eogmaneoPINVOKE.Hierarchy_step__SWIG_2(swigCPtr, Std2DVeci.getCPtr(inputs), ComputeSystem.getCPtr(system));
    if (eogmaneoPINVOKE.SWIGPendingException.Pending) throw eogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public int getNumLayers() {
    int ret = eogmaneoPINVOKE.Hierarchy_getNumLayers(swigCPtr);
    return ret;
  }

  public StdVeci getPrediction(int i) {
    StdVeci ret = new StdVeci(eogmaneoPINVOKE.Hierarchy_getPrediction(swigCPtr, i), false);
    return ret;
  }

  public float getAlpha(int l) {
    float ret = eogmaneoPINVOKE.Hierarchy_getAlpha(swigCPtr, l);
    return ret;
  }

  public float getBeta(int l) {
    float ret = eogmaneoPINVOKE.Hierarchy_getBeta(swigCPtr, l);
    return ret;
  }

  public float getDelta(int l) {
    float ret = eogmaneoPINVOKE.Hierarchy_getDelta(swigCPtr, l);
    return ret;
  }

  public float getGamma(int l) {
    float ret = eogmaneoPINVOKE.Hierarchy_getGamma(swigCPtr, l);
    return ret;
  }

  public float getEpsilon(int l) {
    float ret = eogmaneoPINVOKE.Hierarchy_getEpsilon(swigCPtr, l);
    return ret;
  }

  public int getTicks(int l) {
    int ret = eogmaneoPINVOKE.Hierarchy_getTicks(swigCPtr, l);
    return ret;
  }

  public Std2DVeci getHistories(int l) {
    Std2DVeci ret = new Std2DVeci(eogmaneoPINVOKE.Hierarchy_getHistories(swigCPtr, l), true);
    return ret;
  }

  public Layer getLayer(int l) {
    Layer ret = new Layer(eogmaneoPINVOKE.Hierarchy_getLayer(swigCPtr, l), false);
    return ret;
  }

  public Hierarchy() : this(eogmaneoPINVOKE.new_Hierarchy(), true) {
  }

}

}
