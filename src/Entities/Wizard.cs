namespace GFT_JogoRPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) : base (Name, Level, HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " lançou sua Magia!";
        }


        public string Attack(int Bonus, string Pontos)
        {
            if(Bonus > 6)
            {
                return this.Name + " ajudou Arus e lançou uma Magia super EFETIVA com Bonus de Ataque de " + Bonus;
            }
            else
            {
                return this.Name + " tentou ajudar Arus, mas lançou uma magia MUITO fraca com Bonus de " + Bonus + " " + Pontos;
            }
        }
    }
}