module App

open Elmish
open Elmish.React
open Elmish.Debug
open Elmish.HMR

open Fable.Helpers.React
open Fable.Helpers.React.Props

type Msg = unit

type Model = unit

let init () =
  let m = ()
  m, Cmd.none

let update msg m =
  m, Cmd.none

let view model dispatch =
  div [ ]
    [ str "Hello world" ]

Program.mkProgram init update view
|> Program.withReactUnoptimized "app"
#if DEBUG
|> Program.withDebugger
#endif
|> Program.run
