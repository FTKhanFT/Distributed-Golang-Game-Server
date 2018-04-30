// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: message.proto
// </auto-generated>
#pragma warning disable 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Msg {
  public static partial class Rpc
  {
    static readonly string __ServiceName = "msg.Rpc";

    static readonly grpc::Marshaller<global::Msg.Pos> __Marshaller_Pos = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Msg.Pos.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Msg.PosReply> __Marshaller_PosReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Msg.PosReply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Msg.Callin> __Marshaller_Callin = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Msg.Callin.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Msg.Reply> __Marshaller_Reply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Msg.Reply.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Msg.ClientStart> __Marshaller_ClientStart = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Msg.ClientStart.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Msg.User> __Marshaller_User = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Msg.User.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Msg.UserInfo> __Marshaller_UserInfo = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Msg.UserInfo.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Msg.UserRegister> __Marshaller_UserRegister = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Msg.UserRegister.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Msg.UserRegisterInfo> __Marshaller_UserRegisterInfo = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Msg.UserRegisterInfo.Parser.ParseFrom);

    static readonly grpc::Method<global::Msg.Pos, global::Msg.PosReply> __Method_syncPostion = new grpc::Method<global::Msg.Pos, global::Msg.PosReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "syncPostion",
        __Marshaller_Pos,
        __Marshaller_PosReply);

    static readonly grpc::Method<global::Msg.Callin, global::Msg.Reply> __Method_callServer = new grpc::Method<global::Msg.Callin, global::Msg.Reply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "callServer",
        __Marshaller_Callin,
        __Marshaller_Reply);

    static readonly grpc::Method<global::Msg.ClientStart, global::Msg.Reply> __Method_callClient = new grpc::Method<global::Msg.ClientStart, global::Msg.Reply>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "callClient",
        __Marshaller_ClientStart,
        __Marshaller_Reply);

    static readonly grpc::Method<global::Msg.User, global::Msg.UserInfo> __Method_login = new grpc::Method<global::Msg.User, global::Msg.UserInfo>(
        grpc::MethodType.Unary,
        __ServiceName,
        "login",
        __Marshaller_User,
        __Marshaller_UserInfo);

    static readonly grpc::Method<global::Msg.UserRegister, global::Msg.UserRegisterInfo> __Method_createAccount = new grpc::Method<global::Msg.UserRegister, global::Msg.UserRegisterInfo>(
        grpc::MethodType.Unary,
        __ServiceName,
        "createAccount",
        __Marshaller_UserRegister,
        __Marshaller_UserRegisterInfo);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Msg.MessageReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Rpc</summary>
    public abstract partial class RpcBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Msg.PosReply> syncPostion(global::Msg.Pos request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Msg.Reply> callServer(global::Msg.Callin request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task callClient(global::Msg.ClientStart request, grpc::IServerStreamWriter<global::Msg.Reply> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Msg.UserInfo> login(global::Msg.User request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Msg.UserRegisterInfo> createAccount(global::Msg.UserRegister request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Rpc</summary>
    public partial class RpcClient : grpc::ClientBase<RpcClient>
    {
      /// <summary>Creates a new client for Rpc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RpcClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Rpc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RpcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RpcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RpcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Msg.PosReply syncPostion(global::Msg.Pos request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return syncPostion(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Msg.PosReply syncPostion(global::Msg.Pos request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_syncPostion, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Msg.PosReply> syncPostionAsync(global::Msg.Pos request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return syncPostionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Msg.PosReply> syncPostionAsync(global::Msg.Pos request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_syncPostion, null, options, request);
      }
      public virtual global::Msg.Reply callServer(global::Msg.Callin request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return callServer(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Msg.Reply callServer(global::Msg.Callin request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_callServer, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Msg.Reply> callServerAsync(global::Msg.Callin request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return callServerAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Msg.Reply> callServerAsync(global::Msg.Callin request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_callServer, null, options, request);
      }
      public virtual grpc::AsyncServerStreamingCall<global::Msg.Reply> callClient(global::Msg.ClientStart request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return callClient(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Msg.Reply> callClient(global::Msg.ClientStart request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_callClient, null, options, request);
      }
      public virtual global::Msg.UserInfo login(global::Msg.User request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return login(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Msg.UserInfo login(global::Msg.User request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_login, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Msg.UserInfo> loginAsync(global::Msg.User request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return loginAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Msg.UserInfo> loginAsync(global::Msg.User request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_login, null, options, request);
      }
      public virtual global::Msg.UserRegisterInfo createAccount(global::Msg.UserRegister request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return createAccount(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Msg.UserRegisterInfo createAccount(global::Msg.UserRegister request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_createAccount, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Msg.UserRegisterInfo> createAccountAsync(global::Msg.UserRegister request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return createAccountAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Msg.UserRegisterInfo> createAccountAsync(global::Msg.UserRegister request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_createAccount, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override RpcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RpcClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(RpcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_syncPostion, serviceImpl.syncPostion)
          .AddMethod(__Method_callServer, serviceImpl.callServer)
          .AddMethod(__Method_callClient, serviceImpl.callClient)
          .AddMethod(__Method_login, serviceImpl.login)
          .AddMethod(__Method_createAccount, serviceImpl.createAccount).Build();
    }

  }
}
#endregion
