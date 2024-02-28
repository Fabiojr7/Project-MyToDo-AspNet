namespace MeuTodo1.Models
{
    public class Todo
    {
        public int Id { get; set;}
        public string Title {get; set;}
        public bool Done { get; set;}
        public DateTime Date { get; set;}

        public Todo()
        {
            Date = DateTime.Now; // Inicializa a propriedade Date com a data e hora atuais
        } 
    }
}