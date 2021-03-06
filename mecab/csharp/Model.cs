/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace MeCab {

using System;
using System.Runtime.InteropServices;

public class Model : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Model(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Model obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Model() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          MeCabPINVOKE.delete_Model(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual DictionaryInfo dictionary_info() {
    IntPtr cPtr = MeCabPINVOKE.Model_dictionary_info(swigCPtr);
    DictionaryInfo ret = (cPtr == IntPtr.Zero) ? null : new DictionaryInfo(cPtr, false);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int transition_cost(ushort rcAttr, ushort lcAttr) {
    int ret = MeCabPINVOKE.Model_transition_cost(swigCPtr, rcAttr, lcAttr);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Node lookup(string begin, string end, Lattice lattice) {
    IntPtr cPtr = MeCabPINVOKE.Model_lookup(swigCPtr, begin, end, Lattice.getCPtr(lattice));
    Node ret = (cPtr == IntPtr.Zero) ? null : new Node(cPtr, false);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Tagger createTagger() {
    IntPtr cPtr = MeCabPINVOKE.Model_createTagger(swigCPtr);
    Tagger ret = (cPtr == IntPtr.Zero) ? null : new Tagger(cPtr, false);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Lattice createLattice() {
    IntPtr cPtr = MeCabPINVOKE.Model_createLattice(swigCPtr);
    Lattice ret = (cPtr == IntPtr.Zero) ? null : new Lattice(cPtr, false);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool swap(Model model) {
    bool ret = MeCabPINVOKE.Model_swap(swigCPtr, Model.getCPtr(model));
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string version() {
    string ret = MeCabPINVOKE.Model_version();
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Model create(int argc, SWIGTYPE_p_p_char argv) {
    IntPtr cPtr = MeCabPINVOKE.Model_create__SWIG_0(argc, SWIGTYPE_p_p_char.getCPtr(argv));
    Model ret = (cPtr == IntPtr.Zero) ? null : new Model(cPtr, false);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Model create(string arg) {
    IntPtr cPtr = MeCabPINVOKE.Model_create__SWIG_1(arg);
    Model ret = (cPtr == IntPtr.Zero) ? null : new Model(cPtr, false);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Model(string argc) : this(MeCabPINVOKE.new_Model__SWIG_0(argc), true) {
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
  }

  public Model() : this(MeCabPINVOKE.new_Model__SWIG_1(), true) {
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
