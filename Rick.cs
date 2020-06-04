namespace Polimorfismo
{
    public class Rick : Powers
    {
        public override void LeituradeMente(){

            base.LeituradeMente();

            System.Console.WriteLine("Leitura mental alterada para 55%");
        }

        public override void Telepatia(){

            base.Telepatia();

        }

        public override void Invisibilidade(){

            base.Invisibilidade();

            System.Console.WriteLine("Durabilidade de Invisibilidade alterado para 1h e 30 minutos");
        }
    }
}