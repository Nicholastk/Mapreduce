namespace MapReduceFilterExample
{
    public class Employee
    {
        public string Nome { get; set; }
        public string Estado { get; set; }
        public decimal Salario { get; set; }
 

      public Employee(string nome, string estado, decimal salario)
        {
            Nome = nome;
            Estado = estado;
            Salario = salario;
            
        }


        public override string ToString()
        {
            return Nome + " " +
                Estado + " " +
                Salario;
                
        }

    }
}