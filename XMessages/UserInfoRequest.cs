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
    public static partial class UserInfoRequest {
    
      #region Extension registration
      public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
      }
      #endregion
      #region Static variables
      internal static pbd::MessageDescriptor internal__static_XReactor_UserInfoRequest__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::XReactor.UserInfoRequest, global::XReactor.UserInfoRequest.Builder> internal__static_XReactor_UserInfoRequest__FieldAccessorTable;
      #endregion
      #region Descriptor
      public static pbd::FileDescriptor Descriptor {
        get { return descriptor; }
      }
      private static pbd::FileDescriptor descriptor;
      
      static UserInfoRequest() {
        byte[] descriptorData = global::System.Convert.FromBase64String(
            "ChVVc2VySW5mb1JlcXVlc3QucHJvdG8SCFhSZWFjdG9yIm8KD1VzZXJJbmZv" + 
            "UmVxdWVzdBIQCghVc2VybmFtZRgBIAIoCRIkCghHYW1ldHlwZRgCIAMoDjIS" + 
            "LlhSZWFjdG9yLkdhbWVUeXBlEiQKCEluZm90eXBlGAMgASgOMhIuWFJlYWN0" + 
            "b3IuSW5mb1R5cGUqKAoISW5mb1R5cGUSCAoERE9UQRABEgcKA0pGQRACEgkK" + 
            "BVczV1dEEAMqSwoIR2FtZVR5cGUSDwoLV0FSQ1JBRlRJSUkQARIJCgVET1RB" + 
            "MhACEgsKB0NPVU5URVIQAxIHCgNXT1cQBBINCglTVEFSQ1JBRlQQBUICSAE=");
        pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
          descriptor = root;
          internal__static_XReactor_UserInfoRequest__Descriptor = Descriptor.MessageTypes[0];
          internal__static_XReactor_UserInfoRequest__FieldAccessorTable = 
              new pb::FieldAccess.FieldAccessorTable<global::XReactor.UserInfoRequest, global::XReactor.UserInfoRequest.Builder>(internal__static_XReactor_UserInfoRequest__Descriptor,
                  new string[] { "Username", "Gametype", "Infotype", });
          return null;
        };
        pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
            new pbd::FileDescriptor[] {
            }, assigner);
      }
      #endregion
      
    }
  }
  #region Enums
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  public enum InfoType {
    DOTA = 1,
    JFA = 2,
    W3WWD = 3,
  }
  
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  public enum GameType {
    WARCRAFTIII = 1,
    DOTA2 = 2,
    COUNTER = 3,
    WOW = 4,
    STARCRAFT = 5,
  }
  
  #endregion
  
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
  public sealed partial class UserInfoRequest : pb::GeneratedMessage<UserInfoRequest, UserInfoRequest.Builder> {
    private UserInfoRequest() { }
    private static readonly UserInfoRequest defaultInstance = new UserInfoRequest().MakeReadOnly();
    private static readonly string[] _userInfoRequestFieldNames = new string[] { "Gametype", "Infotype", "Username" };
    private static readonly uint[] _userInfoRequestFieldTags = new uint[] { 16, 24, 10 };
    public static UserInfoRequest DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override UserInfoRequest DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override UserInfoRequest ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::XReactor.Proto.UserInfoRequest.internal__static_XReactor_UserInfoRequest__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<UserInfoRequest, UserInfoRequest.Builder> InternalFieldAccessors {
      get { return global::XReactor.Proto.UserInfoRequest.internal__static_XReactor_UserInfoRequest__FieldAccessorTable; }
    }
    
    public const int UsernameFieldNumber = 1;
    private bool hasUsername;
    private string username_ = "";
    public bool HasUsername {
      get { return hasUsername; }
    }
    public string Username {
      get { return username_; }
    }
    
    public const int GametypeFieldNumber = 2;
    private pbc::PopsicleList<global::XReactor.GameType> gametype_ = new pbc::PopsicleList<global::XReactor.GameType>();
    public scg::IList<global::XReactor.GameType> GametypeList {
      get { return pbc::Lists.AsReadOnly(gametype_); }
    }
    public int GametypeCount {
      get { return gametype_.Count; }
    }
    public global::XReactor.GameType GetGametype(int index) {
      return gametype_[index];
    }
    
    public const int InfotypeFieldNumber = 3;
    private bool hasInfotype;
    private global::XReactor.InfoType ınfotype_ = global::XReactor.InfoType.DOTA;
    public bool HasInfotype {
      get { return hasInfotype; }
    }
    public global::XReactor.InfoType Infotype {
      get { return ınfotype_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasUsername) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _userInfoRequestFieldNames;
      if (hasUsername) {
        output.WriteString(1, field_names[2], Username);
      }
      if (gametype_.Count > 0) {
        output.WriteEnumArray(2, field_names[0], gametype_);
      }
      if (hasInfotype) {
        output.WriteEnum(3, field_names[1], (int) Infotype, Infotype);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasUsername) {
          size += pb::CodedOutputStream.ComputeStringSize(1, Username);
        }
        {
          int dataSize = 0;
          if (gametype_.Count > 0) {
            foreach (global::XReactor.GameType element in gametype_) {
              dataSize += pb::CodedOutputStream.ComputeEnumSizeNoTag((int) element);
            }
            size += dataSize;
            size += 1 * gametype_.Count;
          }
        }
        if (hasInfotype) {
          size += pb::CodedOutputStream.ComputeEnumSize(3, (int) Infotype);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static UserInfoRequest ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static UserInfoRequest ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static UserInfoRequest ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static UserInfoRequest ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static UserInfoRequest ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static UserInfoRequest ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static UserInfoRequest ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static UserInfoRequest ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static UserInfoRequest ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static UserInfoRequest ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private UserInfoRequest MakeReadOnly() {
      gametype_.MakeReadOnly();
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(UserInfoRequest prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    public sealed partial class Builder : pb::GeneratedBuilder<UserInfoRequest, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(UserInfoRequest cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private UserInfoRequest result;
      
      private UserInfoRequest PrepareBuilder() {
        if (resultIsReadOnly) {
          UserInfoRequest original = result;
          result = new UserInfoRequest();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override UserInfoRequest MessageBeingBuilt {
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
        get { return global::XReactor.UserInfoRequest.Descriptor; }
      }
      
      public override UserInfoRequest DefaultInstanceForType {
        get { return global::XReactor.UserInfoRequest.DefaultInstance; }
      }
      
      public override UserInfoRequest BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is UserInfoRequest) {
          return MergeFrom((UserInfoRequest) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(UserInfoRequest other) {
        if (other == global::XReactor.UserInfoRequest.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasUsername) {
          Username = other.Username;
        }
        if (other.gametype_.Count != 0) {
          result.gametype_.Add(other.gametype_);
        }
        if (other.HasInfotype) {
          Infotype = other.Infotype;
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
            int field_ordinal = global::System.Array.BinarySearch(_userInfoRequestFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _userInfoRequestFieldTags[field_ordinal];
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
              result.hasUsername = input.ReadString(ref result.username_);
              break;
            }
            case 18:
            case 16: {
              scg::ICollection<object> unknownItems;
              input.ReadEnumArray<global::XReactor.GameType>(tag, field_name, result.gametype_, out unknownItems);
              if (unknownItems != null) {
                if (unknownFields == null) {
                  unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                }
                foreach (object rawValue in unknownItems)
                  if (rawValue is int)
                    unknownFields.MergeVarintField(2, (ulong)(int)rawValue);
              }
              break;
            }
            case 24: {
              object unknown;
              if(input.ReadEnum(ref result.ınfotype_, out unknown)) {
                result.hasInfotype = true;
              } else if(unknown is int) {
                if (unknownFields == null) {
                  unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                }
                unknownFields.MergeVarintField(3, (ulong)(int)unknown);
              }
              break;
            }
          }
        }
        
        if (unknownFields != null) {
          this.UnknownFields = unknownFields.Build();
        }
        return this;
      }
      
      
      public bool HasUsername {
        get { return result.hasUsername; }
      }
      public string Username {
        get { return result.Username; }
        set { SetUsername(value); }
      }
      public Builder SetUsername(string value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        PrepareBuilder();
        result.hasUsername = true;
        result.username_ = value;
        return this;
      }
      public Builder ClearUsername() {
        PrepareBuilder();
        result.hasUsername = false;
        result.username_ = "";
        return this;
      }
      
      public pbc::IPopsicleList<global::XReactor.GameType> GametypeList {
        get { return PrepareBuilder().gametype_; }
      }
      public int GametypeCount {
        get { return result.GametypeCount; }
      }
      public global::XReactor.GameType GetGametype(int index) {
        return result.GetGametype(index);
      }
      public Builder SetGametype(int index, global::XReactor.GameType value) {
        PrepareBuilder();
        result.gametype_[index] = value;
        return this;
      }
      public Builder AddGametype(global::XReactor.GameType value) {
        PrepareBuilder();
        result.gametype_.Add(value);
        return this;
      }
      public Builder AddRangeGametype(scg::IEnumerable<global::XReactor.GameType> values) {
        PrepareBuilder();
        result.gametype_.Add(values);
        return this;
      }
      public Builder ClearGametype() {
        PrepareBuilder();
        result.gametype_.Clear();
        return this;
      }
      
      public bool HasInfotype {
       get { return result.hasInfotype; }
      }
      public global::XReactor.InfoType Infotype {
        get { return result.Infotype; }
        set { SetInfotype(value); }
      }
      public Builder SetInfotype(global::XReactor.InfoType value) {
        PrepareBuilder();
        result.hasInfotype = true;
        result.ınfotype_ = value;
        return this;
      }
      public Builder ClearInfotype() {
        PrepareBuilder();
        result.hasInfotype = false;
        result.ınfotype_ = global::XReactor.InfoType.DOTA;
        return this;
      }
    }
    static UserInfoRequest() {
      object.ReferenceEquals(global::XReactor.Proto.UserInfoRequest.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
