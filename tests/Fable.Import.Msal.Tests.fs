module Fable.Import.Msal.Tests

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import.Msal
open Fable.Core.Testing

[<Global>]
let it (msg: string) (f: unit->unit): unit = jsNative

it "Adding works" <| fun () ->
    let expected = 3
    let actual = 3
    Assert.AreEqual(expected,actual)
