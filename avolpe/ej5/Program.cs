//ej5
Console.WriteLine("Ingrese el nombre de un día de la semana:");
        string input = Console.ReadLine();

        // Normalizamos el texto: quitamos espacios y pasamos a minúsculas
        string dia = input.Trim().ToLower();
        

        switch (dia)
        {
            case "lunes":
            case "martes":
            case "miércoles":
            case "miercoles": 
            case "jueves":
            case "viernes":
                Console.WriteLine("No es fin de semana.");
                break;

            case "sábado":
            case "sabado": 
            case "domingo":
                Console.WriteLine("Es fin de semana.");
                break;

            default:
                Console.WriteLine("Error: día invlido.");
                break;
        }
