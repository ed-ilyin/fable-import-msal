// ts2fable 0.5.2
module rec Fable.Import.Msal.Msal

open Fable.Core


type UserAgentApplication = UserAgentApplication.UserAgentApplication
type User = User.User


[<Import("UserAgentApplication","msal")>]
let userAgentApplication: UserAgentApplication.UserAgentApplicationStatic =
    jsNative

[<Import("Logger","msal")>]
let logger: Logger.LoggerStatic = jsNative

let loggerOptions correlationId level piiLoggingEnabled =
    let o = JsInterop.createEmpty<Logger.LoggerStaticOptions>
    match correlationId with None -> () | Some _ -> o.correlationId <- correlationId
    match level with None -> () | Some _ -> o.level <- level
    match piiLoggingEnabled with None -> () | Some _ -> o.piiLoggingEnabled <- piiLoggingEnabled
    o

let userAgentApplicationStaticOptions cacheLocation loadFrameTimeout logger postLogoutRedirectUri redirectUri validateAuthority =
    let o = JsInterop.createEmpty<UserAgentApplication.UserAgentApplicationStaticOptions>
    match cacheLocation with None -> () | Some _ -> o.cacheLocation <- cacheLocation
    match loadFrameTimeout with None -> () | Some _ -> o.loadFrameTimeout <- loadFrameTimeout
    match logger with None -> () | Some _ -> o.logger <- logger
    match postLogoutRedirectUri with None -> () | Some _ -> o.postLogoutRedirectUri <- postLogoutRedirectUri
    match redirectUri with None -> () | Some _ -> o.redirectUri <- redirectUri
    match validateAuthority with None -> () | Some _ -> o.validateAuthority <- validateAuthority
    o
