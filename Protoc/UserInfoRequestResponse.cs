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
    public static partial class UserInfoRequestResponse {
    
      #region Extension registration
      public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
      }
      #endregion
      #region Static variables
      internal static pbd::MessageDescriptor internal__static_XReactor_UserInfoRequestResponse__Descriptor;
      internal static pb::FieldAccess.FieldAccessorTable<global::XReactor.UserInfoRequestResponse, global::XReactor.UserInfoRequestResponse.Builder> internal__static_XReactor_UserInfoRequestResponse__FieldAccessorTable;
      #endregion
      #region Descriptor
      public static pbd::FileDescriptor Descriptor {
        get { return descriptor; }
      }
      private static pbd::FileDescriptor descriptor;
      
      static UserInfoRequestResponse() {
        byte[] descriptorData = global::System.Convert.FromBase64String(
            "Ch1Vc2VySW5mb1JlcXVlc3RSZXNwb25zZS5wcm90bxIIWFJlYWN0b3IimgIK" + 
            "F1VzZXJJbmZvUmVxdWVzdFJlc3BvbnNlEhAKCFVzZXJuYW1lGAEgAigJEgwK" + 
            "BEtpbGwYAiABKAUSDQoFRGVhdGgYAyABKAUSDgoGQ3JlZXBzGAQgASgFEg4K" + 
            "BkFzc2lzdBgFIAEoBRINCgVUb3dlchgGIAEoBRILCgNSYXgYByABKAUSDQoF" + 
            "U2NvcmUYCCABKAUSDAoERGVueRgJIAEoBRIPCgdOZXV0cmFsGAogASgFEhIK" + 
            "ClRvdGFsR2FtZXMYCyABKAUSDgoGTGVhdmVzGAwgASgFEgwKBFdpbnMYDSAB" + 
            "KAUSDAoETG9zdBgOIAEoBRIRCglMb2NrUG9pbnQYDyABKAUSEwoLVG90YWxS" + 
            "ZXBvcnQYECABKAVCAkgB");
        pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
          descriptor = root;
          internal__static_XReactor_UserInfoRequestResponse__Descriptor = Descriptor.MessageTypes[0];
          internal__static_XReactor_UserInfoRequestResponse__FieldAccessorTable = 
              new pb::FieldAccess.FieldAccessorTable<global::XReactor.UserInfoRequestResponse, global::XReactor.UserInfoRequestResponse.Builder>(internal__static_XReactor_UserInfoRequestResponse__Descriptor,
                  new string[] { "Username", "Kill", "Death", "Creeps", "Assist", "Tower", "Rax", "Score", "Deny", "Neutral", "TotalGames", "Leaves", "Wins", "Lost", "LockPoint", "TotalReport", });
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
  public sealed partial class UserInfoRequestResponse : pb::GeneratedMessage<UserInfoRequestResponse, UserInfoRequestResponse.Builder> {
    private UserInfoRequestResponse() { }
    private static readonly UserInfoRequestResponse defaultInstance = new UserInfoRequestResponse().MakeReadOnly();
    private static readonly string[] _userInfoRequestResponseFieldNames = new string[] { "Assist", "Creeps", "Death", "Deny", "Kill", "Leaves", "LockPoint", "Lost", "Neutral", "Rax", "Score", "TotalGames", "TotalReport", "Tower", "Username", "Wins" };
    private static readonly uint[] _userInfoRequestResponseFieldTags = new uint[] { 40, 32, 24, 72, 16, 96, 120, 112, 80, 56, 64, 88, 128, 48, 10, 104 };
    public static UserInfoRequestResponse DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override UserInfoRequestResponse DefaultInstanceForType {
      get { return DefaultInstance; }
    }
    
    protected override UserInfoRequestResponse ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::XReactor.Proto.UserInfoRequestResponse.internal__static_XReactor_UserInfoRequestResponse__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<UserInfoRequestResponse, UserInfoRequestResponse.Builder> InternalFieldAccessors {
      get { return global::XReactor.Proto.UserInfoRequestResponse.internal__static_XReactor_UserInfoRequestResponse__FieldAccessorTable; }
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
    
    public const int KillFieldNumber = 2;
    private bool hasKill;
    private int kill_;
    public bool HasKill {
      get { return hasKill; }
    }
    public int Kill {
      get { return kill_; }
    }
    
    public const int DeathFieldNumber = 3;
    private bool hasDeath;
    private int death_;
    public bool HasDeath {
      get { return hasDeath; }
    }
    public int Death {
      get { return death_; }
    }
    
    public const int CreepsFieldNumber = 4;
    private bool hasCreeps;
    private int creeps_;
    public bool HasCreeps {
      get { return hasCreeps; }
    }
    public int Creeps {
      get { return creeps_; }
    }
    
    public const int AssistFieldNumber = 5;
    private bool hasAssist;
    private int assist_;
    public bool HasAssist {
      get { return hasAssist; }
    }
    public int Assist {
      get { return assist_; }
    }
    
    public const int TowerFieldNumber = 6;
    private bool hasTower;
    private int tower_;
    public bool HasTower {
      get { return hasTower; }
    }
    public int Tower {
      get { return tower_; }
    }
    
    public const int RaxFieldNumber = 7;
    private bool hasRax;
    private int rax_;
    public bool HasRax {
      get { return hasRax; }
    }
    public int Rax {
      get { return rax_; }
    }
    
    public const int ScoreFieldNumber = 8;
    private bool hasScore;
    private int score_;
    public bool HasScore {
      get { return hasScore; }
    }
    public int Score {
      get { return score_; }
    }
    
    public const int DenyFieldNumber = 9;
    private bool hasDeny;
    private int deny_;
    public bool HasDeny {
      get { return hasDeny; }
    }
    public int Deny {
      get { return deny_; }
    }
    
    public const int NeutralFieldNumber = 10;
    private bool hasNeutral;
    private int neutral_;
    public bool HasNeutral {
      get { return hasNeutral; }
    }
    public int Neutral {
      get { return neutral_; }
    }
    
    public const int TotalGamesFieldNumber = 11;
    private bool hasTotalGames;
    private int totalGames_;
    public bool HasTotalGames {
      get { return hasTotalGames; }
    }
    public int TotalGames {
      get { return totalGames_; }
    }
    
    public const int LeavesFieldNumber = 12;
    private bool hasLeaves;
    private int leaves_;
    public bool HasLeaves {
      get { return hasLeaves; }
    }
    public int Leaves {
      get { return leaves_; }
    }
    
    public const int WinsFieldNumber = 13;
    private bool hasWins;
    private int wins_;
    public bool HasWins {
      get { return hasWins; }
    }
    public int Wins {
      get { return wins_; }
    }
    
    public const int LostFieldNumber = 14;
    private bool hasLost;
    private int lost_;
    public bool HasLost {
      get { return hasLost; }
    }
    public int Lost {
      get { return lost_; }
    }
    
    public const int LockPointFieldNumber = 15;
    private bool hasLockPoint;
    private int lockPoint_;
    public bool HasLockPoint {
      get { return hasLockPoint; }
    }
    public int LockPoint {
      get { return lockPoint_; }
    }
    
    public const int TotalReportFieldNumber = 16;
    private bool hasTotalReport;
    private int totalReport_;
    public bool HasTotalReport {
      get { return hasTotalReport; }
    }
    public int TotalReport {
      get { return totalReport_; }
    }
    
    public override bool IsInitialized {
      get {
        if (!hasUsername) return false;
        return true;
      }
    }
    
    public override void WriteTo(pb::ICodedOutputStream output) {
      int size = SerializedSize;
      string[] field_names = _userInfoRequestResponseFieldNames;
      if (hasUsername) {
        output.WriteString(1, field_names[14], Username);
      }
      if (hasKill) {
        output.WriteInt32(2, field_names[4], Kill);
      }
      if (hasDeath) {
        output.WriteInt32(3, field_names[2], Death);
      }
      if (hasCreeps) {
        output.WriteInt32(4, field_names[1], Creeps);
      }
      if (hasAssist) {
        output.WriteInt32(5, field_names[0], Assist);
      }
      if (hasTower) {
        output.WriteInt32(6, field_names[13], Tower);
      }
      if (hasRax) {
        output.WriteInt32(7, field_names[9], Rax);
      }
      if (hasScore) {
        output.WriteInt32(8, field_names[10], Score);
      }
      if (hasDeny) {
        output.WriteInt32(9, field_names[3], Deny);
      }
      if (hasNeutral) {
        output.WriteInt32(10, field_names[8], Neutral);
      }
      if (hasTotalGames) {
        output.WriteInt32(11, field_names[11], TotalGames);
      }
      if (hasLeaves) {
        output.WriteInt32(12, field_names[5], Leaves);
      }
      if (hasWins) {
        output.WriteInt32(13, field_names[15], Wins);
      }
      if (hasLost) {
        output.WriteInt32(14, field_names[7], Lost);
      }
      if (hasLockPoint) {
        output.WriteInt32(15, field_names[6], LockPoint);
      }
      if (hasTotalReport) {
        output.WriteInt32(16, field_names[12], TotalReport);
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
        if (hasKill) {
          size += pb::CodedOutputStream.ComputeInt32Size(2, Kill);
        }
        if (hasDeath) {
          size += pb::CodedOutputStream.ComputeInt32Size(3, Death);
        }
        if (hasCreeps) {
          size += pb::CodedOutputStream.ComputeInt32Size(4, Creeps);
        }
        if (hasAssist) {
          size += pb::CodedOutputStream.ComputeInt32Size(5, Assist);
        }
        if (hasTower) {
          size += pb::CodedOutputStream.ComputeInt32Size(6, Tower);
        }
        if (hasRax) {
          size += pb::CodedOutputStream.ComputeInt32Size(7, Rax);
        }
        if (hasScore) {
          size += pb::CodedOutputStream.ComputeInt32Size(8, Score);
        }
        if (hasDeny) {
          size += pb::CodedOutputStream.ComputeInt32Size(9, Deny);
        }
        if (hasNeutral) {
          size += pb::CodedOutputStream.ComputeInt32Size(10, Neutral);
        }
        if (hasTotalGames) {
          size += pb::CodedOutputStream.ComputeInt32Size(11, TotalGames);
        }
        if (hasLeaves) {
          size += pb::CodedOutputStream.ComputeInt32Size(12, Leaves);
        }
        if (hasWins) {
          size += pb::CodedOutputStream.ComputeInt32Size(13, Wins);
        }
        if (hasLost) {
          size += pb::CodedOutputStream.ComputeInt32Size(14, Lost);
        }
        if (hasLockPoint) {
          size += pb::CodedOutputStream.ComputeInt32Size(15, LockPoint);
        }
        if (hasTotalReport) {
          size += pb::CodedOutputStream.ComputeInt32Size(16, TotalReport);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static UserInfoRequestResponse ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static UserInfoRequestResponse ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static UserInfoRequestResponse ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static UserInfoRequestResponse ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static UserInfoRequestResponse ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static UserInfoRequestResponse ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static UserInfoRequestResponse ParseDelimitedFrom(global::System.IO.Stream input) {
      return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
    }
    public static UserInfoRequestResponse ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
    }
    public static UserInfoRequestResponse ParseFrom(pb::ICodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static UserInfoRequestResponse ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    private UserInfoRequestResponse MakeReadOnly() {
      return this;
    }
    
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(UserInfoRequestResponse prototype) {
      return new Builder(prototype);
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("ProtoGen", "2.4.1.473")]
    public sealed partial class Builder : pb::GeneratedBuilder<UserInfoRequestResponse, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {
        result = DefaultInstance;
        resultIsReadOnly = true;
      }
      internal Builder(UserInfoRequestResponse cloneFrom) {
        result = cloneFrom;
        resultIsReadOnly = true;
      }
      
      private bool resultIsReadOnly;
      private UserInfoRequestResponse result;
      
      private UserInfoRequestResponse PrepareBuilder() {
        if (resultIsReadOnly) {
          UserInfoRequestResponse original = result;
          result = new UserInfoRequestResponse();
          resultIsReadOnly = false;
          MergeFrom(original);
        }
        return result;
      }
      
      public override bool IsInitialized {
        get { return result.IsInitialized; }
      }
      
      protected override UserInfoRequestResponse MessageBeingBuilt {
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
        get { return global::XReactor.UserInfoRequestResponse.Descriptor; }
      }
      
      public override UserInfoRequestResponse DefaultInstanceForType {
        get { return global::XReactor.UserInfoRequestResponse.DefaultInstance; }
      }
      
      public override UserInfoRequestResponse BuildPartial() {
        if (resultIsReadOnly) {
          return result;
        }
        resultIsReadOnly = true;
        return result.MakeReadOnly();
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is UserInfoRequestResponse) {
          return MergeFrom((UserInfoRequestResponse) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(UserInfoRequestResponse other) {
        if (other == global::XReactor.UserInfoRequestResponse.DefaultInstance) return this;
        PrepareBuilder();
        if (other.HasUsername) {
          Username = other.Username;
        }
        if (other.HasKill) {
          Kill = other.Kill;
        }
        if (other.HasDeath) {
          Death = other.Death;
        }
        if (other.HasCreeps) {
          Creeps = other.Creeps;
        }
        if (other.HasAssist) {
          Assist = other.Assist;
        }
        if (other.HasTower) {
          Tower = other.Tower;
        }
        if (other.HasRax) {
          Rax = other.Rax;
        }
        if (other.HasScore) {
          Score = other.Score;
        }
        if (other.HasDeny) {
          Deny = other.Deny;
        }
        if (other.HasNeutral) {
          Neutral = other.Neutral;
        }
        if (other.HasTotalGames) {
          TotalGames = other.TotalGames;
        }
        if (other.HasLeaves) {
          Leaves = other.Leaves;
        }
        if (other.HasWins) {
          Wins = other.Wins;
        }
        if (other.HasLost) {
          Lost = other.Lost;
        }
        if (other.HasLockPoint) {
          LockPoint = other.LockPoint;
        }
        if (other.HasTotalReport) {
          TotalReport = other.TotalReport;
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
            int field_ordinal = global::System.Array.BinarySearch(_userInfoRequestResponseFieldNames, field_name, global::System.StringComparer.Ordinal);
            if(field_ordinal >= 0)
              tag = _userInfoRequestResponseFieldTags[field_ordinal];
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
            case 16: {
              result.hasKill = input.ReadInt32(ref result.kill_);
              break;
            }
            case 24: {
              result.hasDeath = input.ReadInt32(ref result.death_);
              break;
            }
            case 32: {
              result.hasCreeps = input.ReadInt32(ref result.creeps_);
              break;
            }
            case 40: {
              result.hasAssist = input.ReadInt32(ref result.assist_);
              break;
            }
            case 48: {
              result.hasTower = input.ReadInt32(ref result.tower_);
              break;
            }
            case 56: {
              result.hasRax = input.ReadInt32(ref result.rax_);
              break;
            }
            case 64: {
              result.hasScore = input.ReadInt32(ref result.score_);
              break;
            }
            case 72: {
              result.hasDeny = input.ReadInt32(ref result.deny_);
              break;
            }
            case 80: {
              result.hasNeutral = input.ReadInt32(ref result.neutral_);
              break;
            }
            case 88: {
              result.hasTotalGames = input.ReadInt32(ref result.totalGames_);
              break;
            }
            case 96: {
              result.hasLeaves = input.ReadInt32(ref result.leaves_);
              break;
            }
            case 104: {
              result.hasWins = input.ReadInt32(ref result.wins_);
              break;
            }
            case 112: {
              result.hasLost = input.ReadInt32(ref result.lost_);
              break;
            }
            case 120: {
              result.hasLockPoint = input.ReadInt32(ref result.lockPoint_);
              break;
            }
            case 128: {
              result.hasTotalReport = input.ReadInt32(ref result.totalReport_);
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
      
      public bool HasKill {
        get { return result.hasKill; }
      }
      public int Kill {
        get { return result.Kill; }
        set { SetKill(value); }
      }
      public Builder SetKill(int value) {
        PrepareBuilder();
        result.hasKill = true;
        result.kill_ = value;
        return this;
      }
      public Builder ClearKill() {
        PrepareBuilder();
        result.hasKill = false;
        result.kill_ = 0;
        return this;
      }
      
      public bool HasDeath {
        get { return result.hasDeath; }
      }
      public int Death {
        get { return result.Death; }
        set { SetDeath(value); }
      }
      public Builder SetDeath(int value) {
        PrepareBuilder();
        result.hasDeath = true;
        result.death_ = value;
        return this;
      }
      public Builder ClearDeath() {
        PrepareBuilder();
        result.hasDeath = false;
        result.death_ = 0;
        return this;
      }
      
      public bool HasCreeps {
        get { return result.hasCreeps; }
      }
      public int Creeps {
        get { return result.Creeps; }
        set { SetCreeps(value); }
      }
      public Builder SetCreeps(int value) {
        PrepareBuilder();
        result.hasCreeps = true;
        result.creeps_ = value;
        return this;
      }
      public Builder ClearCreeps() {
        PrepareBuilder();
        result.hasCreeps = false;
        result.creeps_ = 0;
        return this;
      }
      
      public bool HasAssist {
        get { return result.hasAssist; }
      }
      public int Assist {
        get { return result.Assist; }
        set { SetAssist(value); }
      }
      public Builder SetAssist(int value) {
        PrepareBuilder();
        result.hasAssist = true;
        result.assist_ = value;
        return this;
      }
      public Builder ClearAssist() {
        PrepareBuilder();
        result.hasAssist = false;
        result.assist_ = 0;
        return this;
      }
      
      public bool HasTower {
        get { return result.hasTower; }
      }
      public int Tower {
        get { return result.Tower; }
        set { SetTower(value); }
      }
      public Builder SetTower(int value) {
        PrepareBuilder();
        result.hasTower = true;
        result.tower_ = value;
        return this;
      }
      public Builder ClearTower() {
        PrepareBuilder();
        result.hasTower = false;
        result.tower_ = 0;
        return this;
      }
      
      public bool HasRax {
        get { return result.hasRax; }
      }
      public int Rax {
        get { return result.Rax; }
        set { SetRax(value); }
      }
      public Builder SetRax(int value) {
        PrepareBuilder();
        result.hasRax = true;
        result.rax_ = value;
        return this;
      }
      public Builder ClearRax() {
        PrepareBuilder();
        result.hasRax = false;
        result.rax_ = 0;
        return this;
      }
      
      public bool HasScore {
        get { return result.hasScore; }
      }
      public int Score {
        get { return result.Score; }
        set { SetScore(value); }
      }
      public Builder SetScore(int value) {
        PrepareBuilder();
        result.hasScore = true;
        result.score_ = value;
        return this;
      }
      public Builder ClearScore() {
        PrepareBuilder();
        result.hasScore = false;
        result.score_ = 0;
        return this;
      }
      
      public bool HasDeny {
        get { return result.hasDeny; }
      }
      public int Deny {
        get { return result.Deny; }
        set { SetDeny(value); }
      }
      public Builder SetDeny(int value) {
        PrepareBuilder();
        result.hasDeny = true;
        result.deny_ = value;
        return this;
      }
      public Builder ClearDeny() {
        PrepareBuilder();
        result.hasDeny = false;
        result.deny_ = 0;
        return this;
      }
      
      public bool HasNeutral {
        get { return result.hasNeutral; }
      }
      public int Neutral {
        get { return result.Neutral; }
        set { SetNeutral(value); }
      }
      public Builder SetNeutral(int value) {
        PrepareBuilder();
        result.hasNeutral = true;
        result.neutral_ = value;
        return this;
      }
      public Builder ClearNeutral() {
        PrepareBuilder();
        result.hasNeutral = false;
        result.neutral_ = 0;
        return this;
      }
      
      public bool HasTotalGames {
        get { return result.hasTotalGames; }
      }
      public int TotalGames {
        get { return result.TotalGames; }
        set { SetTotalGames(value); }
      }
      public Builder SetTotalGames(int value) {
        PrepareBuilder();
        result.hasTotalGames = true;
        result.totalGames_ = value;
        return this;
      }
      public Builder ClearTotalGames() {
        PrepareBuilder();
        result.hasTotalGames = false;
        result.totalGames_ = 0;
        return this;
      }
      
      public bool HasLeaves {
        get { return result.hasLeaves; }
      }
      public int Leaves {
        get { return result.Leaves; }
        set { SetLeaves(value); }
      }
      public Builder SetLeaves(int value) {
        PrepareBuilder();
        result.hasLeaves = true;
        result.leaves_ = value;
        return this;
      }
      public Builder ClearLeaves() {
        PrepareBuilder();
        result.hasLeaves = false;
        result.leaves_ = 0;
        return this;
      }
      
      public bool HasWins {
        get { return result.hasWins; }
      }
      public int Wins {
        get { return result.Wins; }
        set { SetWins(value); }
      }
      public Builder SetWins(int value) {
        PrepareBuilder();
        result.hasWins = true;
        result.wins_ = value;
        return this;
      }
      public Builder ClearWins() {
        PrepareBuilder();
        result.hasWins = false;
        result.wins_ = 0;
        return this;
      }
      
      public bool HasLost {
        get { return result.hasLost; }
      }
      public int Lost {
        get { return result.Lost; }
        set { SetLost(value); }
      }
      public Builder SetLost(int value) {
        PrepareBuilder();
        result.hasLost = true;
        result.lost_ = value;
        return this;
      }
      public Builder ClearLost() {
        PrepareBuilder();
        result.hasLost = false;
        result.lost_ = 0;
        return this;
      }
      
      public bool HasLockPoint {
        get { return result.hasLockPoint; }
      }
      public int LockPoint {
        get { return result.LockPoint; }
        set { SetLockPoint(value); }
      }
      public Builder SetLockPoint(int value) {
        PrepareBuilder();
        result.hasLockPoint = true;
        result.lockPoint_ = value;
        return this;
      }
      public Builder ClearLockPoint() {
        PrepareBuilder();
        result.hasLockPoint = false;
        result.lockPoint_ = 0;
        return this;
      }
      
      public bool HasTotalReport {
        get { return result.hasTotalReport; }
      }
      public int TotalReport {
        get { return result.TotalReport; }
        set { SetTotalReport(value); }
      }
      public Builder SetTotalReport(int value) {
        PrepareBuilder();
        result.hasTotalReport = true;
        result.totalReport_ = value;
        return this;
      }
      public Builder ClearTotalReport() {
        PrepareBuilder();
        result.hasTotalReport = false;
        result.totalReport_ = 0;
        return this;
      }
    }
    static UserInfoRequestResponse() {
      object.ReferenceEquals(global::XReactor.Proto.UserInfoRequestResponse.Descriptor, null);
    }
  }
  
  #endregion
  
}

#endregion Designer generated code
