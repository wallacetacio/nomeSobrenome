Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

    string nomeCompleto, primeiroNome, sobrenome;
    int pos1, pos2;

    Console.Write("Digite seu nome completo: ");
    nomeCompleto = Console.ReadLine()
    .Replace("das","").Replace("dos","")
    .Replace("da","").Replace("do","")
    .Replace("'","").Replace("de","")
    .Replace("á","a").Replace("â","a")
    .Replace("é","e").Replace("ê","e")
    .Replace("í","i").Replace("î","i")
    .Replace("ó","o").Replace("ô","o")
    .Replace("ú","u").Replace("û","u");
    
pos1 = nomeCompleto.IndexOf(" ");

pos2 = nomeCompleto.LastIndexOf(" ");

primeiroNome = nomeCompleto.Substring(0,pos1);

sobrenome = nomeCompleto.Substring(pos2);

Console.WriteLine("Primeiro Nome: " + char.ToUpper(primeiroNome[0]) + primeiroNome.Substring(1) + "\n"+
"Sobrenome: "+ char.ToUpper(sobrenome[1]) + sobrenome.Substring(2) + "\n"+
"Do 5 ao 10: " + nomeCompleto.Substring(5,10) + "\n"+
"Trocando 'a' por 'o': " + nomeCompleto.Replace("a","o").Replace("A","O"));