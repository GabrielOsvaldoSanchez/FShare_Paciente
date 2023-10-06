type Paciente =
    | Nombre of string
    | Apellido of string
    | Edad of int
    | Enfermedad of string
     
     
[<EntryPoint>]
let main argv =
    let nombre2 = "Gabriel"
    let nombre = Nombre("Gabri")
    let apellido = Apellido("Ureña")
    let edad = Edad(17)
    let enfermedad = Enfermedad("Artritis")
    
    printfn "Hola %s" nombre2

    match nombre with
    | Nombre(n) -> printfn "El nombre es: %s" n
   
    match apellido with
    | Apellido(a) -> printfn "El apellido es: %s" a
    
    match edad with
    | Edad(e) -> printfn "La edad es: %d" e
     
    match enfermedad with
    | Enfermedad(enf) -> printfn "La enfermedad es: %s" enf
 
    0
