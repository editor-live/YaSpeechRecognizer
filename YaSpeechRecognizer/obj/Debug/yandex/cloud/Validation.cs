// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yandex/cloud/validation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yandex.Cloud {

  /// <summary>Holder for reflection information generated from yandex/cloud/validation.proto</summary>
  public static partial class ValidationReflection {

    #region Descriptor
    /// <summary>File descriptor for yandex/cloud/validation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ValidationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch15YW5kZXgvY2xvdWQvdmFsaWRhdGlvbi5wcm90bxIMeWFuZGV4LmNsb3Vk",
            "GiBnb29nbGUvcHJvdG9idWYvZGVzY3JpcHRvci5wcm90byI8CgpNYXBLZXlT",
            "cGVjEg0KBXZhbHVlGAEgASgJEg8KB3BhdHRlcm4YAiABKAkSDgoGbGVuZ3Ro",
            "GAMgASgJOjQKC2V4YWN0bHlfb25lEh0uZ29vZ2xlLnByb3RvYnVmLk9uZW9m",
            "T3B0aW9ucxiYmAYgASgIOjEKCHJlcXVpcmVkEh0uZ29vZ2xlLnByb3RvYnVm",
            "LkZpZWxkT3B0aW9ucxj9mAYgASgIOjAKB3BhdHRlcm4SHS5nb29nbGUucHJv",
            "dG9idWYuRmllbGRPcHRpb25zGP6YBiABKAk6LgoFdmFsdWUSHS5nb29nbGUu",
            "cHJvdG9idWYuRmllbGRPcHRpb25zGP+YBiABKAk6LQoEc2l6ZRIdLmdvb2ds",
            "ZS5wcm90b2J1Zi5GaWVsZE9wdGlvbnMYgJkGIAEoCTovCgZsZW5ndGgSHS5n",
            "b29nbGUucHJvdG9idWYuRmllbGRPcHRpb25zGIGZBiABKAk6LwoGdW5pcXVl",
            "Eh0uZ29vZ2xlLnByb3RvYnVmLkZpZWxkT3B0aW9ucxiCmQYgASgIOkoKB21h",
            "cF9rZXkSHS5nb29nbGUucHJvdG9idWYuRmllbGRPcHRpb25zGIaZBiABKAsy",
            "GC55YW5kZXguY2xvdWQuTWFwS2V5U3BlYzouCgVieXRlcxIdLmdvb2dsZS5w",
            "cm90b2J1Zi5GaWVsZE9wdGlvbnMYh5kGIAEoCUJKChB5YW5kZXguY2xvdWQu",
            "YXBpWjZnaXRodWIuY29tL3lhbmRleC1jbG91ZC9nby1nZW5wcm90by95YW5k",
            "ZXgvY2xvdWQ7Y2xvdWRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pb::Extension[] { ValidationExtensions.ExactlyOne, ValidationExtensions.Required, ValidationExtensions.Pattern, ValidationExtensions.Value, ValidationExtensions.Size, ValidationExtensions.Length, ValidationExtensions.Unique, ValidationExtensions.MapKey, ValidationExtensions.Bytes }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yandex.Cloud.MapKeySpec), global::Yandex.Cloud.MapKeySpec.Parser, new[]{ "Value", "Pattern", "Length" }, null, null, null, null)
          }));
    }
    #endregion

  }
  /// <summary>Holder for extension identifiers generated from the top level of yandex/cloud/validation.proto</summary>
  public static partial class ValidationExtensions {
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.OneofOptions, bool> ExactlyOne =
      new pb::Extension<global::Google.Protobuf.Reflection.OneofOptions, bool>(101400, pb::FieldCodec.ForBool(811200, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool> Required =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool>(101501, pb::FieldCodec.ForBool(812008, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> Pattern =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(101502, pb::FieldCodec.ForString(812018, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> Value =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(101503, pb::FieldCodec.ForString(812026, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> Size =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(101504, pb::FieldCodec.ForString(812034, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> Length =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(101505, pb::FieldCodec.ForString(812042, ""));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool> Unique =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, bool>(101506, pb::FieldCodec.ForBool(812048, false));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, global::Yandex.Cloud.MapKeySpec> MapKey =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, global::Yandex.Cloud.MapKeySpec>(101510, pb::FieldCodec.ForMessage(812082, global::Yandex.Cloud.MapKeySpec.Parser));
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string> Bytes =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, string>(101511, pb::FieldCodec.ForString(812090, ""));
  }

  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MapKeySpec : pb::IMessage<MapKeySpec>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MapKeySpec> _parser = new pb::MessageParser<MapKeySpec>(() => new MapKeySpec());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MapKeySpec> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yandex.Cloud.ValidationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MapKeySpec() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MapKeySpec(MapKeySpec other) : this() {
      value_ = other.value_;
      pattern_ = other.pattern_;
      length_ = other.length_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MapKeySpec Clone() {
      return new MapKeySpec(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 1;
    private string value_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Value {
      get { return value_; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pattern" field.</summary>
    public const int PatternFieldNumber = 2;
    private string pattern_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Pattern {
      get { return pattern_; }
      set {
        pattern_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "length" field.</summary>
    public const int LengthFieldNumber = 3;
    private string length_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Length {
      get { return length_; }
      set {
        length_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MapKeySpec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MapKeySpec other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      if (Pattern != other.Pattern) return false;
      if (Length != other.Length) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Value.Length != 0) hash ^= Value.GetHashCode();
      if (Pattern.Length != 0) hash ^= Pattern.GetHashCode();
      if (Length.Length != 0) hash ^= Length.GetHashCode();
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
      if (Value.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Value);
      }
      if (Pattern.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Pattern);
      }
      if (Length.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Length);
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
      if (Value.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Value);
      }
      if (Pattern.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Pattern);
      }
      if (Length.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Length);
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
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
      }
      if (Pattern.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Pattern);
      }
      if (Length.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Length);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MapKeySpec other) {
      if (other == null) {
        return;
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
      }
      if (other.Pattern.Length != 0) {
        Pattern = other.Pattern;
      }
      if (other.Length.Length != 0) {
        Length = other.Length;
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
            Value = input.ReadString();
            break;
          }
          case 18: {
            Pattern = input.ReadString();
            break;
          }
          case 26: {
            Length = input.ReadString();
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
            Value = input.ReadString();
            break;
          }
          case 18: {
            Pattern = input.ReadString();
            break;
          }
          case 26: {
            Length = input.ReadString();
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
