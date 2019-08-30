module App

open Elmish
open Elmish.React
open Elmish.Debug
open Elmish.HMR

open Fable.Import
open Fable.Import.Electron
open Fable.Helpers.React
open Fable.Helpers.React.Props

type Msg =
  | Yes
  | No

type Model = unit

let init () =
  let m = ()
  m, Cmd.none

let update msg m =
  match msg with
  | Yes -> electron.app.exit 0.
  | No -> electron.app.exit 1.
  m, Cmd.none

let caption = "Title"

let message = "Hello world"

let view model dispatch =
  div [ ]
    [ h1 [ ] [ str caption ]
      p [ ] [ str message ]
      button [ OnClick (fun _ -> dispatch Yes) ] [ str "Yes" ]
      button [ OnClick (fun _ -> dispatch No) ] [ str "No" ] ]

Program.mkProgram init update view
|> Program.withReactUnoptimized "app"
#if DEBUG
|> Program.withDebugger
#endif
|> Program.run
