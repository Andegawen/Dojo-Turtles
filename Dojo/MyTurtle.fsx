#load "SvgTurtle.fs"
#load "Domain.fs"

open SvgTurtle
open Domain



let points = 
    [{X=0.0;Y=0.0;Angle=0.0};{X=50.0;Y=50.0;Angle=0.0}] 
    |> createPoints 
    

save (points |> inTemplate)
let simpleProgram = [ FORWARD 50.0; LEFT (90.0); FORWARD 50.0 ]