// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/ai/stt/v3/stt_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Speechkit.Stt.V3 {

  /// <summary>Holder for reflection information generated from yandex/cloud/ai/stt/v3/stt_service.proto</summary>
  public static partial class SttServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/ai/stt/v3/stt_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SttServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cih5YW5kZXgvY2xvdWQvYWkvc3R0L3YzL3N0dF9zZXJ2aWNlLnByb3RvEhBz",
            "cGVlY2hraXQuc3R0LnYzGiB5YW5kZXgvY2xvdWQvYWkvc3R0L3YzL3N0dC5w",
            "cm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90bxodeWFuZGV4L2Ns",
            "b3VkL3ZhbGlkYXRpb24ucHJvdG8aIHlhbmRleC9jbG91ZC9hcGkvb3BlcmF0",
            "aW9uLnByb3RvGiZ5YW5kZXgvY2xvdWQvb3BlcmF0aW9uL29wZXJhdGlvbi5w",
            "cm90byI7ChVHZXRSZWNvZ25pdGlvblJlcXVlc3QSIgoMb3BlcmF0aW9uX2lk",
            "GAEgASgJQgzoxzEBisgxBDw9NTAycQoKUmVjb2duaXplchJjChJSZWNvZ25p",
            "emVTdHJlYW1pbmcSIi5zcGVlY2hraXQuc3R0LnYzLlN0cmVhbWluZ1JlcXVl",
            "c3QaIy5zcGVlY2hraXQuc3R0LnYzLlN0cmVhbWluZ1Jlc3BvbnNlIgAoATAB",
            "MrMCCg9Bc3luY1JlY29nbml6ZXISnAEKDVJlY29nbml6ZUZpbGUSJi5zcGVl",
            "Y2hraXQuc3R0LnYzLlJlY29nbml6ZUZpbGVSZXF1ZXN0GiEueWFuZGV4LmNs",
            "b3VkLm9wZXJhdGlvbi5PcGVyYXRpb24iQLLSKhcSFWdvb2dsZS5wcm90b2J1",
            "Zi5FbXB0eYLT5JMCHyIaL3N0dC92My9yZWNvZ25pemVGaWxlQXN5bmM6ASoS",
            "gAEKDkdldFJlY29nbml0aW9uEicuc3BlZWNoa2l0LnN0dC52My5HZXRSZWNv",
            "Z25pdGlvblJlcXVlc3QaIy5zcGVlY2hraXQuc3R0LnYzLlN0cmVhbWluZ1Jl",
            "c3BvbnNlIh6C0+STAhgSFi9zdHQvdjMvZ2V0UmVjb2duaXRpb24wAUJcChp5",
            "YW5kZXguY2xvdWQuYXBpLmFpLnN0dC52M1o+Z2l0aHViLmNvbS95YW5kZXgt",
            "Y2xvdWQvZ28tZ2VucHJvdG8veWFuZGV4L2Nsb3VkL2FpL3N0dC92MztzdHRi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Speechkit.Stt.V3.SttReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Yandex.Cloud.ValidationReflection.Descriptor, global::Yandex.Cloud.Api.OperationReflection.Descriptor, global::Yandex.Cloud.Operation.OperationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Speechkit.Stt.V3.GetRecognitionRequest), global::Speechkit.Stt.V3.GetRecognitionRequest.Parser, new[]{ "OperationId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetRecognitionRequest : pb::IMessage<GetRecognitionRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetRecognitionRequest> _parser = new pb::MessageParser<GetRecognitionRequest>(() => new GetRecognitionRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetRecognitionRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Speechkit.Stt.V3.SttServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetRecognitionRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetRecognitionRequest(GetRecognitionRequest other) : this() {
      operationId_ = other.operationId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetRecognitionRequest Clone() {
      return new GetRecognitionRequest(this);
    }

    /// <summary>Field number for the "operation_id" field.</summary>
    public const int OperationIdFieldNumber = 1;
    private string operationId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OperationId {
      get { return operationId_; }
      set {
        operationId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetRecognitionRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetRecognitionRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OperationId != other.OperationId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (OperationId.Length != 0) hash ^= OperationId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (OperationId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(OperationId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (OperationId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(OperationId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (OperationId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OperationId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetRecognitionRequest other) {
      if (other == null) {
        return;
      }
      if (other.OperationId.Length != 0) {
        OperationId = other.OperationId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            OperationId = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            OperationId = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
