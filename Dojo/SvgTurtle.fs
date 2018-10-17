module SvgTurtle

let path = __SOURCE_DIRECTORY__ + "/turtles.html"


let svgLine (x1,y1,x2,y2) =
    sprintf
        """<line x1="%.1f" y1="%.1f" x2="%.1f" y2="%.1f" stroke="black" />"""
        x1 y1 x2 y2
        
let inTemplate points =
    let inTemplate' content =
        sprintf """
<html>
<body>
    <h1>Turtles & F#!</h1>
    <svg width="500" height="500">
%s
    </svg>
</body>
</html>""" content
    inTemplate' (points|> Seq.map svgLine |> String.concat "\n")



let save (content:string) = 
    System.IO.File.WriteAllText(path,content)