namespace Polimorfismo
{
    public class Steve : Powers
    {
        public override void LeituradeMente(){
            base.LeituradeMente();

            System.Console.WriteLine("Nenhuma Alteração");
        }

        public override void Telepatia(){

            base.Telepatia();
            System.Console.WriteLine("Nivel de telepatia alterado - Capacidade de levantar um prédio");
        }

        public override void Invisibilidade(){

            base.Invisibilidade();
            System.Console.WriteLine("Duração de invisibilidade alterada para 3 horas");
        }
    }
}