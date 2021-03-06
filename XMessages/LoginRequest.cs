// Generated by ProtoGen, Version=2.4.1.473, Culture=neutral, PublicKeyToken=55f7125234beb589.  DO NOT EDIT!
#pragma warning disable 1591, 0612
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace XReactor {
  
  namespace Proto {
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    public static partial class LoginRequest {
    
      #region Extension registration
      public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
      }
      #endregion
      #region Static variables
      internal static pbd::MessageDescriptor internal__static_XReactor_LoginRequest__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::XReactor.LoginRequest, global::XReactor.LoginRequest.Builder> internal__static_XReactor_LoginRequest__FieldAccessorTable;
      #endregion
      #region Descriptor
      public static pbd::FileDescriptor Descriptor {
        get { return descriptor; }
      }
      private static pbd::FileDescriptor descriptor;
      
      static LoginRequest() {
        byte[] descriptorData = global::System.Convert.FromBase64String(
            "ChJMb2dpblJlcXVlc3QucHJvdG8SCFhSZWFjdG9yIk4KDExvZ2luUmVxdWVz" + 
            "dBIMCgRuYW1lGAEgAigJEg8KB3ZlcnNpb24YAiACKAkSDQoFZW1haWwYAyAB" + 
            "KAkSEAoIcGFzc3dvcmQYBCACKAlCAkgB");
        pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
          descriptor = root;
          internal__static_XReactor_LoginRequest__Descriptor = Descriptor.MessageTypes[0];
          internal__static_XReactor_LoginRequest__FieldAccessorTable = 
              new pb::FieldAccess.FieldAccessorTable<global::XReactor.LoginRequest, global::XReactor.LoginRequest.Builder>(internal__static_XReactor_LoginRequest__Descriptor,
                  new string[] { "Name", "Version", "Email", "Password", });
          return null;
        };
        pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
            new pbd::FileDescriptor[] {
            }, assigner);
      }
      #endregion
      
    }
  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  public sealed partial class LoginRequest : pb::GeneratedMessage<LoginRequest, LoginRequest.Builder> {
    private LoginRequest() { }
    private static readonly LoginRequest defaultInstance = new LoginRequest().MakeReadOnly();
    private static readonly string[] _loginRequestFieldNames = new string[] { "email", "name", "password", "version" };
    private static readonly uint[] _loginRequestFieldTags = new uint[] { 26, 10, 34, 18 };
    public static LoginRequest DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override LoginRequest DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override LoginRequest ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::XReactor.Proto.LoginRequest.internal__static_XReactor_LoginRequest__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<LoginRequest, LoginRequest.Builder> InternalFieldAccessors {
      get { return global::XReactor.Proto.LoginRequest.internal__static_XReactor_LoginRequest__FieldAccessorTable; }
    }
    
    public const int NameFieldNumber = 1;
    private bool hasName;
    private string name_ = "";
    public bool HasName {
      get { return hasName; }
    }
    public string Name {
      get { return name_; }
    }
    
    public const int VersionFieldNumber = 2;
    private bool hasVersion;
    private string version_ = "";
    public bool HasVersion {
      get { return hasVersion; }
    }
    public string Version {
      get { return version_; }
    }
    
    public const int EmailFieldNumber = 3;
    private bool hasEmail;
    private string email_ = "";
    public bool HasEmail {
      get { return hasEmail; }
    }
    public string Email {
      get { return email_; }
    }
    
    public const int PasswordFieldNumber = 4;
    private bool hasPassword;
    private string password_ = "";
    public bool HasPassword {
      get { return hasPassword; }
    }
    public string Password {
      get { return password_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasName) return false;
        if (!hasVersion) return false;
        if (!hasPassword) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _loginRequestFieldNames;
      if (hasName) {
        output.WriteString(1, field_names[1], Name);
      }
      if (hasVersion) {
        output.WriteString(2, field_names[3], Version);
      }
      if (hasEmail) {
        output.WriteString(3, field_names[0], Email);
      }
      if (hasPassword) {
        output.WriteString(4, field_names[2], Password);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasName) {
          size += pb::CodedOutputStream.ComputeStringSize(1, Name);
        }
        if (hasVersion) {
          size += pb::CodedOutputStream.ComputeStringSize(2, Version);
        }
        if (hasEmail) {
          size += pb::CodedOutputStream.ComputeStringSize(3, Email);
        }
        if (hasPassword) {
          size += pb::CodedOutputStream.ComputeStringSize(4, Password);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static LoginRequest ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static LoginRequest ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static LoginRequest ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static LoginRequest ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static LoginRequest ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static LoginRequest ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static LoginRequest ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static LoginRequest ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static LoginRequest ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static LoginRequest ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private LoginRequest MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(LoginRequest prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    public sealed partial class Builder : pb::GeneratedBuilder<LoginRequest, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(LoginRequest cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private LoginRequest result;
      
      private LoginRequest PrepareBuilder() {
        if (resultIsReadOnly) {
          LoginRequest original = result;
          result = new LoginRequest();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override LoginRequest MessageBeingBuilt {
        get { return PrepareBuilder(); }
      }
      
      public override Builder Clear() {
        result = DefaultInstance;
        resultIsReadOnly = true;
        return this;
      }
      
      public override Builder Clone() {
        if (resultIsReadOnly) {
          return new Builder(result);
        } else {
          return new Builder().MergeFrom(result);
        }
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return global::XReactor.LoginRequest.Descriptor; }
      }
      
      public override LoginRequest DefaultInstanceForType {
        get { return global::XReactor.LoginRequest.DefaultInstance; }
      }
      
      public override LoginRequest BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is LoginRequest) {
          return MergeFrom((LoginRequest) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(LoginRequest other) {
        if (other == global::XReactor.LoginRequest.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasName) {
          Name = other.Name;
        }
        if (other.HasVersion) {
          Version = other.Version;
        }
        if (other.HasEmail) {
          Email = other.Email;
        }
        if (other.HasPassword) {
          Password = other.Password;
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        PrepareBuilder();
        pb::UnknownFieldSet.Builder unknownFields = null;
        uint tag;
        string field_name;
        while (input.ReadTag(out tag, out field_name)) {
          if(tag == 0 && field_name != null) {
            int field_ordinal = global::System.Array.BinarySearch(_loginRequestFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _loginRequestFieldTags[field_ordinal];
            else {
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              continue;
            }
          }
          switch (tag) {
            case 0: {
              throw pb::InvalidProtocolBufferException.InvalidTag();
            }
            default: {
              if (pb::WireFormat.IsEndGroupTag(tag)) {
                if (unknownFields != null) {
                  this.UnknownFields = unknownFields.Build();
                }
                return this;
              }
              if (unknownFields == null) {
                unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
              }
              ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
              break;
            }
            case 10: {
              result.hasName = input.ReadString(ref result.name_);
              break;
            }
            case 18: {
              result.hasVersion = input.ReadString(ref result.version_);
              break;
            }
            case 26: {
              result.hasEmail = input.ReadString(ref result.email_);
              break;
            }
            case 34: {
              result.hasPassword = input.ReadString(ref result.password_);
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasName {
        get { return result.hasName; }
      }
      public string Name {
        get { return result.Name; }
        set { SetName(value); }
      }
      public Builder SetName(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasName = true;
        result.name_ = value;
        return this;
      }
      public Builder ClearName() {
        PrepareBuilder();
        result.hasName = false;
        result.name_ = "";
        return this;
      }
      
      public bool HasVersion {
        get { return result.hasVersion; }
      }
      public string Version {
        get { return result.Version; }
        set { SetVersion(value); }
      }
      public Builder SetVersion(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasVersion = true;
        result.version_ = value;
        return this;
      }
      public Builder ClearVersion() {
        PrepareBuilder();
        result.hasVersion = false;
        result.version_ = "";
        return this;
      }
      
      public bool HasEmail {
        get { return result.hasEmail; }
      }
      public string Email {
        get { return result.Email; }
        set { SetEmail(value); }
      }
      public Builder SetEmail(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasEmail = true;
        result.email_ = value;
        return this;
      }
      public Builder ClearEmail() {
        PrepareBuilder();
        result.hasEmail = false;
        result.email_ = "";
        return this;
      }
      
      public bool HasPassword {
        get { return result.hasPassword; }
      }
      public string Password {
        get { return result.Password; }
        set { SetPassword(value); }
      }
      public Builder SetPassword(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasPassword = true;
        result.password_ = value;
        return this;
      }
      public Builder ClearPassword() {
        PrepareBuilder();
        result.hasPassword = false;
        result.password_ = "";
        return this;
      }
    }
    static LoginRequest() {
      object.ReferenceEquals(global::XReactor.Proto.LoginRequest.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
