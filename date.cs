//Capturar hora
string hora = DateTime.Now.ToShortTimeString();
 

//Capturar data
string data = DateTime.Now.ToShortDateString();

 
//Exibindo modo console
Console.WriteLine("Data: " + data + " Hora: " + hora);
 
//Exibindo Windows Form
MessageBox.Show("Data: " + data + " Hora: " + hora);
