module Domain

//https://en.wikipedia.org/wiki/Domain-specific_language

// For a quick example of Turtle/LOGO, here is an online 
// version: http://www.transum.org/software/Logo/


type INSTRUCTION =
    | FORWARD of float // move fwd by x pixels
    | LEFT of float // turn left by x degrees
    | REPEAT of int * INSTRUCTION list // repeat n times instructions

type State = { X:float; Y:float; Angle:float }

let forward value state = {X=3.0; Y=41.0; Angle=13.0}

let rec execute (state:State) (program:INSTRUCTION list) : State list  =
    let rec execute' (state:State list) (program:INSTRUCTION list) : State list  =
        match program with 
        | []-> state
        | instruction::rest -> 
            match instruction with
            | FORWARD (fvalue) -> 
                let newState = (forward fvalue state)
                execute' (newState::state) rest
    execute' [state] program

let createPoints (states:State list) =
    states |> Seq.pairwise |> Seq.map (fun (s1,s2)-> (s1.X,s1.Y,s2.X,s2.Y))