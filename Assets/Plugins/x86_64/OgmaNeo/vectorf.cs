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

public class vectorf : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IList<float>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal vectorf(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(vectorf obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~vectorf() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          csogmaneoPINVOKE.delete_vectorf(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public vectorf(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (float element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public float this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(float[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(float[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, float[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  global::System.Collections.Generic.IEnumerator<float> global::System.Collections.Generic.IEnumerable<float>.GetEnumerator() {
    return new vectorfEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new vectorfEnumerator(this);
  }

  public vectorfEnumerator GetEnumerator() {
    return new vectorfEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class vectorfEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<float>
  {
    private vectorf collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public vectorfEnumerator(vectorf collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public float Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (float)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    csogmaneoPINVOKE.vectorf_Clear(swigCPtr);
  }

  public void Add(float x) {
    csogmaneoPINVOKE.vectorf_Add(swigCPtr, x);
  }

  private uint size() {
    uint ret = csogmaneoPINVOKE.vectorf_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = csogmaneoPINVOKE.vectorf_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    csogmaneoPINVOKE.vectorf_reserve(swigCPtr, n);
  }

  public vectorf() : this(csogmaneoPINVOKE.new_vectorf__SWIG_0(), true) {
  }

  public vectorf(vectorf other) : this(csogmaneoPINVOKE.new_vectorf__SWIG_1(vectorf.getCPtr(other)), true) {
    if (csogmaneoPINVOKE.SWIGPendingException.Pending) throw csogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public vectorf(int capacity) : this(csogmaneoPINVOKE.new_vectorf__SWIG_2(capacity), true) {
    if (csogmaneoPINVOKE.SWIGPendingException.Pending) throw csogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  private float getitemcopy(int index) {
    float ret = csogmaneoPINVOKE.vectorf_getitemcopy(swigCPtr, index);
    if (csogmaneoPINVOKE.SWIGPendingException.Pending) throw csogmaneoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private float getitem(int index) {
    float ret = csogmaneoPINVOKE.vectorf_getitem(swigCPtr, index);
    if (csogmaneoPINVOKE.SWIGPendingException.Pending) throw csogmaneoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, float val) {
    csogmaneoPINVOKE.vectorf_setitem(swigCPtr, index, val);
    if (csogmaneoPINVOKE.SWIGPendingException.Pending) throw csogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(vectorf values) {
    csogmaneoPINVOKE.vectorf_AddRange(swigCPtr, vectorf.getCPtr(values));
    if (csogmaneoPINVOKE.SWIGPendingException.Pending) throw csogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public vectorf GetRange(int index, int count) {
    global::System.IntPtr cPtr = csogmaneoPINVOKE.vectorf_GetRange(swigCPtr, index, count);
    vectorf ret = (cPtr == global::System.IntPtr.Zero) ? null : new vectorf(cPtr, true);
    if (csogmaneoPINVOKE.SWIGPendingException.Pending) throw csogmaneoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, float x) {
    csogmaneoPINVOKE.vectorf_Insert(swigCPtr, index, x);
    if (csogmaneoPINVOKE.SWIGPendingException.Pending) throw csogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, vectorf values) {
    csogmaneoPINVOKE.vectorf_InsertRange(swigCPtr, index, vectorf.getCPtr(values));
    if (csogmaneoPINVOKE.SWIGPendingException.Pending) throw csogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    csogmaneoPINVOKE.vectorf_RemoveAt(swigCPtr, index);
    if (csogmaneoPINVOKE.SWIGPendingException.Pending) throw csogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    csogmaneoPINVOKE.vectorf_RemoveRange(swigCPtr, index, count);
    if (csogmaneoPINVOKE.SWIGPendingException.Pending) throw csogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public static vectorf Repeat(float value, int count) {
    global::System.IntPtr cPtr = csogmaneoPINVOKE.vectorf_Repeat(value, count);
    vectorf ret = (cPtr == global::System.IntPtr.Zero) ? null : new vectorf(cPtr, true);
    if (csogmaneoPINVOKE.SWIGPendingException.Pending) throw csogmaneoPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    csogmaneoPINVOKE.vectorf_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    csogmaneoPINVOKE.vectorf_Reverse__SWIG_1(swigCPtr, index, count);
    if (csogmaneoPINVOKE.SWIGPendingException.Pending) throw csogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, vectorf values) {
    csogmaneoPINVOKE.vectorf_SetRange(swigCPtr, index, vectorf.getCPtr(values));
    if (csogmaneoPINVOKE.SWIGPendingException.Pending) throw csogmaneoPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(float value) {
    bool ret = csogmaneoPINVOKE.vectorf_Contains(swigCPtr, value);
    return ret;
  }

  public int IndexOf(float value) {
    int ret = csogmaneoPINVOKE.vectorf_IndexOf(swigCPtr, value);
    return ret;
  }

  public int LastIndexOf(float value) {
    int ret = csogmaneoPINVOKE.vectorf_LastIndexOf(swigCPtr, value);
    return ret;
  }

  public bool Remove(float value) {
    bool ret = csogmaneoPINVOKE.vectorf_Remove(swigCPtr, value);
    return ret;
  }

}

}
