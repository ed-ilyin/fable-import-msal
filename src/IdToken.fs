// ts2fable 0.5.2
module rec Fable.Import.Msal.IdToken
open System
open Fable.Core
open Fable.Import.JS


type [<AllowNullLiteral>] IExports =
    abstract IdToken: IdTokenStatic

type [<AllowNullLiteral>] IdToken =
    abstract issuer: string with get, set
    abstract objectId: string with get, set
    abstract subject: string with get, set
    abstract tenantId: string with get, set
    abstract version: string with get, set
    abstract preferredName: string with get, set
    abstract name: string with get, set
    abstract homeObjectId: string with get, set
    abstract nonce: string with get, set
    abstract expiration: string with get, set
    abstract rawIdToken: string with get, set
    abstract decodedIdToken: Object with get, set

type [<AllowNullLiteral>] IdTokenStatic =
    [<Emit "new $0($1...)">] abstract Create: rawIdToken: string -> IdToken
