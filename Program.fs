// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System

[<EntryPoint>]
let main argv = 
  // A very simple program for the purpose of testing the VS2015 installation.
  let today = DateTime.Now 
  printfn "\n\nDate and time now is: %A" today 
  printfn "Press any key to terminate this program..."
  Console.ReadKey(true) |> ignore 

  0 // return an integer exit code
